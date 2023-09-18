using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.Data;
using Anababi.ModelClasses;
using Microsoft.EntityFrameworkCore;
using PdfiumViewer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anababi.UserControls
{
    public partial class ReferenceCenterDisplay : UserControl
    {
        Reference Reference { get; set; }
        public ReferenceCenterDisplay(Reference reference)

        {
            InitializeComponent();
            Reference = reference;

            if (!UserExperience.currentUser.IsAdmin)
            {
                textBoxCreator.Enabled = false;
                textBoxType.Enabled = false;
                textBoxGenre.Enabled = false;
                textBoxPublishedOn.Enabled = false;
                textBoxDescription.Enabled = false;
                textBoxISBN.Enabled = false;

                //Physical reference fields
                textBoxFloor.Enabled = false;
                textBoxSection.Enabled = false;
                textBoxShelf.Enabled = false;
                checkBoxAvailable.Enabled = false;
                textBoxNumOfCopies.Enabled = false;

                //Digital reference fields
                pdfViewerFile.Enabled = false;

                //Save button
                buttonSave.Enabled = false;
            }

            // The physical or digital nature of a reference is not editable.
            textBoxDiscriminator.Enabled = false;
        }

        #region Custom Methods
        public static PdfDocument? ByteArrayToPDFDocument(byte[] data)
        {
            PdfDocument pdfDocument = null;
            using (MemoryStream stream = new MemoryStream(data))
            {
                try
                {
                    pdfDocument = PdfDocument.Load(stream);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    Console.WriteLine("Error loading PDF from byte array: " + ex.Message);
                }
            }
            return pdfDocument;
        }
        public static byte[] PDFDocumentToByteArray(PdfDocument pdfDocument)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                pdfDocument.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }
        #endregion

        private void CenterDisplay_Load(object sender, EventArgs e)
        {
            //Set the label representing the title of the reference.
            LblReferenceTitle.Text = Reference.Title;
            LblReferenceTitle.TextAlign = ContentAlignment.MiddleCenter;
            //Set the text box representing the creator of the reference.
            textBoxCreator.Text = Reference.Creator.GetFullName();
            //Set the text box representing the type of the reference.
            textBoxType.Text = Reference.Type.ToString();
            //Set the text box representing the genre of the reference.
            textBoxGenre.Text = Reference.Genre.ToString();
            //Set the text box representing the publishing date of the reference.
            textBoxPublishedOn.Text = Reference.PublishedOn.ToShortDateString();
            //Set the text box representing the ISBN of the reference.
            textBoxISBN.Text = Reference.ISBN;
            //Set the text box representing the description of the reference.
            textBoxDescription.Text = Reference.Description;
            textBoxDescription.WordWrap = true;
            //Set the picture box representing the coverimage of the reference.
            pictureBoxCoverImage.BackgroundImage = UserExperience.ByteArrayToImage(Reference.CoverImage);
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;

            if (Reference is PhysicalReference)
            {
                PhysicalReference physicalReference = (PhysicalReference)Reference;
                // Set the discriminator, location and num of copies values.
                textBoxDiscriminator.Text = "Physical Reference";
                textBoxFloor.Text = physicalReference.Location.Floor.ToString();
                textBoxSection.Text = physicalReference.Location.Section.ToString();
                textBoxShelf.Text = physicalReference.Location.Shelf.ToString();
                textBoxNumOfCopies.Text = physicalReference.NumOfCopies.ToString();

                // Fill the combo box representing the availability of the reference
                if (physicalReference.Available)
                    checkBoxAvailable.Checked = true;
                else
                    checkBoxAvailable.Checked = false;

                this.ActiveControl = null;

                // Make all digital components invisible.
                LblFile.Visible = false;
                pdfViewerFile.Visible = false;

            }
            else if (Reference is DigitalReference)
            {
                DigitalReference digitalReference = (DigitalReference)Reference;

                textBoxDiscriminator.Text = "Digital Reference";
                //PdfDocument? pdfDocument = ByteArrayToPDFDocument(digitalReference.File);
                //pdfViewerFile.Load(pdfDocument);
                pdfViewerFile.Visible = false;
                LblFile.Visible = false;

                // Make all physical components invisible.
                LblFloor.Visible = false;
                textBoxFloor.Visible = false;
                LblSection.Visible = false;
                textBoxSection.Visible = false;
                LblShelf.Visible = false;
                textBoxShelf.Visible = false;
                LblNumOfCopies.Visible = false;
                textBoxNumOfCopies.Visible = false;
                LblAvailable.Visible = false;
                checkBoxAvailable.Visible = false;

            }

        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artwork to be viewed.
            this.Hide();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            // Calculate the preferred height based on the content
            int preferredHeight = TextRenderer.MeasureText(textBoxDescription.Text, textBoxDescription.Font, textBoxDescription.ClientSize, TextFormatFlags.WordBreak).Height;

            // Set the TextBox's height to the preferred height
            textBoxDescription.Height = preferredHeight;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UserExperience.currentUser.IsAdmin)
            {
                try
                {
                    // Get the database object from the context class
                    using AnababiContext context = new AnababiContext();
                    Reference referenceToBeUpdated = context.References.Where(r => r.Id == Reference.Id)
                        .Include(r => r.Creator)
                        .Include(r => (r as PhysicalReference).Location)
                        .FirstOrDefault();

                    referenceToBeUpdated.Id = Reference.Id;
                    referenceToBeUpdated.Title = Reference.Title;
                    referenceToBeUpdated.PublishedOn = DateTime.Parse(textBoxPublishedOn.Text);
                    referenceToBeUpdated.ISBN = textBoxISBN.Text;
                    referenceToBeUpdated.Type = Enum.Parse<Reference.ReferenceType>(textBoxType.Text);
                    referenceToBeUpdated.Genre = Enum.Parse<Reference.ReferenceGenre>(textBoxGenre.Text);
                    referenceToBeUpdated.CoverImage = UserExperience.ImageToByteArray(pictureBoxCoverImage.BackgroundImage);
                    referenceToBeUpdated.Description = textBoxDescription.Text;

                    // Check if the reference is digital or physical
                    if (referenceToBeUpdated is PhysicalReference)
                    {
                        (referenceToBeUpdated as PhysicalReference).Location.Floor = int.Parse(textBoxFloor.Text);
                        (referenceToBeUpdated as PhysicalReference).Location.Section = int.Parse(textBoxSection.Text);
                        (referenceToBeUpdated as PhysicalReference).Location.Shelf = int.Parse(textBoxShelf.Text);
                        (referenceToBeUpdated as PhysicalReference).Available = checkBoxAvailable.Checked;
                        (referenceToBeUpdated as PhysicalReference).NumOfCopies = int.Parse(textBoxNumOfCopies.Text);
                    }
                    else
                    {
                        // referenceToBeUpdated = new DigitalReference(Reference as DigitalReference);
                    }

                    // Save changes
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

    }
}
