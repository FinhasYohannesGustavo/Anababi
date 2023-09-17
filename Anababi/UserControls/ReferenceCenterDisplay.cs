using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.ModelClasses;
using PdfiumViewer;

namespace Anababi.UserControls
{
    public partial class ReferenceCenterDisplay : UserControl
    {
        Reference Reference { get; set; }
        public ReferenceCenterDisplay(Reference reference)

        {
            InitializeComponent();
            Reference = reference;
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
            LblReferenceTitle.CenterHorizontally();
            //Set the text box representing the creator of the reference.
            textBoxCreator.Text = Reference.Creator.GetFullName();
            textBoxType.Text = Reference.Type.ToString();
            textBoxGenre.Text = Reference.Genre.ToString();
            dateTimePickerPublishedOn.Value = Reference.PublishedOn;
            textBoxISBN.Text = Reference.ISBN;
            textBoxDescription.Text = Reference.Description;
            textBoxDescription.WordWrap = true;
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
                    comboBoxAvailable.SelectedIndex = 0;
                else
                    comboBoxAvailable.SelectedIndex = 1;

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
                comboBoxAvailable.Visible = false;

            }

        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artwork to be viewed.
            this.Hide();
        }


    }
}
