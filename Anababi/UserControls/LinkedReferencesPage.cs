using System.Data;
using Anababi.Data;
using Anababi.ModelClasses;
using Microsoft.EntityFrameworkCore;

namespace Anababi.UserControls
{
    public partial class LinkedReferencesPage : UserControl
    {
        LinkedList<Reference> LinkedReferences;
        LinkedListNode<Reference> CurrentReferenceNode;

        public LinkedReferencesPage(LinkedList<Reference> references)
        {
            InitializeComponent();
            LinkedReferences = references;
            CurrentReferenceNode = new LinkedListNode<Reference>(new Reference());
            CurrentReferenceNode = LinkedReferences.First;

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

                //Remove button
                buttonRemove.Enabled = false;
            }

            // The physical or digital nature of a reference is not editable.
            textBoxDiscriminator.Enabled = false;
        }

        private void LinkedReferencesPage_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void LoadPage()
        {
            //Set the label representing the title of the reference.
            LblReferenceTitle.Text = CurrentReferenceNode.Value.Title;
            LblReferenceTitle.TextAlign = ContentAlignment.MiddleCenter;
            //Set the text box representing the creator of the reference.
            textBoxCreator.Text = CurrentReferenceNode.Value.Creator.GetFullName();
            //Set the text box representing the type of the reference.
            textBoxType.Text = CurrentReferenceNode.Value.Type.ToString();
            //Set the text box representing the genre of the reference.
            textBoxGenre.Text = CurrentReferenceNode.Value.Genre.ToString();
            //Set the text box representing the publishing date of the reference.
            textBoxPublishedOn.Text = CurrentReferenceNode.Value.PublishedOn.ToShortDateString();
            //Set the text box representing the ISBN of the reference.
            textBoxISBN.Text = CurrentReferenceNode.Value.ISBN;
            //Set the text box representing the description of the reference.
            textBoxDescription.Text = CurrentReferenceNode.Value.Description;
            textBoxDescription.WordWrap = true;
            //textBoxDescription.AutoSize = true;
            //Set the picture box representing the coverimage of the reference.
            pictureBoxCoverImage.BackgroundImage = UserExperience.ByteArrayToImage(CurrentReferenceNode.Value.CoverImage);
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;

            if (CurrentReferenceNode.Value is PhysicalReference)
            {
                PhysicalReference physicalReference = (PhysicalReference)CurrentReferenceNode.Value;
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

                // Make all digital components invisible.
                LblFile.Visible = false;
                pdfViewerFile.Visible = false;

                // Make all physical components visisble.
                LblFloor.Visible = true;
                textBoxFloor.Visible = true;
                LblSection.Visible = true;
                textBoxSection.Visible = true;
                LblShelf.Visible = true;
                textBoxShelf.Visible = true;
                LblNumOfCopies.Visible = true;
                textBoxNumOfCopies.Visible = true;
                LblAvailable.Visible = true;
                checkBoxAvailable.Visible = true;

            }
            else if (CurrentReferenceNode.Value is DigitalReference)
            {
                DigitalReference digitalReference = (DigitalReference)CurrentReferenceNode.Value;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UserExperience.currentUser.IsAdmin)
            {
                try
                {
                    // Get the database object from the context class
                    using AnababiContext context = new AnababiContext();
                    Reference referenceToBeUpdated = context.References.Where(r => r.Id == CurrentReferenceNode.Value.Id)
                        .Include(r => r.Creator)
                        .Include(r => (r as PhysicalReference).Location)
                        .First();

                    referenceToBeUpdated.Title = LblReferenceTitle.Text;
                    referenceToBeUpdated.PublishedOn = DateTime.Parse(textBoxPublishedOn.Text);
                    referenceToBeUpdated.ISBN = textBoxISBN.Text;
                    referenceToBeUpdated.Type = Enum.Parse<Reference.ReferenceType>(textBoxType.Text);
                    referenceToBeUpdated.Genre = Enum.Parse<Reference.ReferenceGenre>(textBoxGenre.Text);
                    referenceToBeUpdated.CoverImage = UserExperience.ImageToByteArray(pictureBoxCoverImage.BackgroundImage);
                    referenceToBeUpdated.Description = textBoxDescription.Text;

                    // Check if the reference is digital or physical
                    if (referenceToBeUpdated is PhysicalReference)
                    {
                        PhysicalReference physicalReference = (referenceToBeUpdated as PhysicalReference);
                        physicalReference.Location.Floor = int.Parse(textBoxFloor.Text);
                        physicalReference.Location.Section = int.Parse(textBoxSection.Text);
                        physicalReference.Location.Shelf = int.Parse(textBoxShelf.Text);
                        physicalReference.Available = checkBoxAvailable.Checked;
                        physicalReference.NumOfCopies = int.Parse(textBoxNumOfCopies.Text);
                    }
                    else
                    {
                        referenceToBeUpdated = new DigitalReference(CurrentReferenceNode.Value as DigitalReference);
                    }

                    // Save changes
                    context.SaveChanges();

                    //Refresh the user experience
                    ((this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience).LoadUserExperience("Title");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentReferenceNode.Previous != null)
            {
                CurrentReferenceNode = CurrentReferenceNode.Previous;
                LoadPage();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (CurrentReferenceNode.Next != null)
            {
                CurrentReferenceNode = CurrentReferenceNode.Next;
                LoadPage();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (UserExperience.currentUser.IsAdmin)
            {
                using AnababiContext context = new AnababiContext();
                Reference toBeRemoved = context.References.Where(r => r.Id == CurrentReferenceNode.Value.Id).First();

                context.Remove(toBeRemoved);
                context.SaveChanges();

                // Reload page with the first reference in the list
                CurrentReferenceNode = LinkedReferences.First;
                LoadPage();

            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            // Calculate the preferred height based on the content
            int preferredHeight = TextRenderer.MeasureText(textBoxDescription.Text, textBoxDescription.Font, textBoxDescription.ClientSize, TextFormatFlags.WordBreak).Height;

            // Set the TextBox's height to the preferred height
            textBoxDescription.Height = preferredHeight + 8;
        }
    }
}
