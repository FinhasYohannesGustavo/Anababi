using Anababi.Data;
using Anababi.ModelClasses;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anababi.UserControls
{
    public partial class AddReferenceCenterDisplay : UserControl
    {
        public AddReferenceCenterDisplay()
        {
            InitializeComponent();
        }

        private void ComboBoxDiscriminator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBoxDiscriminator!= null&&ComboBoxDiscriminator.SelectedItem=="Digital Reference") { 
                this.textBoxFloor.Visible= false;
                this.textBoxShelf.Visible= false;
                this.textBoxSection.Visible= false;
                this.textBoxNumOfCopies.Visible= false;

                this.LblAvailable.Visible= false;
                this.LblFloor.Visible= false;
                this.LblShelf.Visible= false;
                this.LblSection.Visible= false;
                this.LblAvailable.Visible= false;
                this.LblNumOfCopies.Visible= false;

                this.checkBoxAvailable.Visible= false;
            }
            else
            {
                if (ComboBoxDiscriminator != null)
                {
                    this.textBoxFloor.Visible = true;
                    this.textBoxShelf.Visible = true;
                    this.textBoxSection.Visible = true;
                    this.textBoxNumOfCopies.Visible = true;

                    this.LblAvailable.Visible = true;
                    this.LblFloor.Visible = true;
                    this.LblShelf.Visible = true;
                    this.LblSection.Visible = true;
                    this.LblAvailable.Visible = true;
                    this.LblNumOfCopies.Visible = true;

                    this.checkBoxAvailable.Visible = true;

                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the database object from the context class
                using (AnababiContext context = new AnababiContext())
                {
                    Reference referenceToBeAdded = new Reference();
                    
                    referenceToBeAdded.Creator = context.Creators.FirstOrDefault(u => u.FirstName.Equals(textBoxCreator.Text));

                    if (referenceToBeAdded.Creator == null)
                    {
                        referenceToBeAdded.Creator = context.Creators.FirstOrDefault(u => u.LastName.Equals(textBoxCreator.Text));
                    }

                    if (referenceToBeAdded.Creator == null)
                    {
                        MessageBox.Show("There is no creator with that first name or lastname");
                    }
                    else
                    {
                        // Check if the reference is digital or physical
                        Creator creatorOfReference = referenceToBeAdded.Creator;
                        if (ComboBoxDiscriminator.SelectedItem == "Physical Reference")
                        {
                            referenceToBeAdded.Title = txtTitle.Text;
                            referenceToBeAdded.PublishedOn = DateTime.Parse(textBoxPublishedOn.Text);
                            referenceToBeAdded.ISBN = textBoxISBN.Text;
                            referenceToBeAdded.Type = Enum.Parse<Reference.ReferenceType>(textBoxType.Text);
                            referenceToBeAdded.Genre = Enum.Parse<Reference.ReferenceGenre>(textBoxGenre.Text);
                            referenceToBeAdded.CoverImage = UserExperience.ImageToByteArray(pictureBoxCoverImage.Image);
                            referenceToBeAdded.Description = textBoxDescription.Text;
                            referenceToBeAdded.Creator = creatorOfReference;
                            PhysicalReference physicalReference = new PhysicalReference();
   
                            physicalReference.Location.Floor = int.Parse(textBoxFloor.Text);
                            physicalReference.Location.Section = int.Parse(textBoxSection.Text);
                            physicalReference.Location.Shelf = int.Parse(textBoxShelf.Text);
                            physicalReference.Available = checkBoxAvailable.Checked;
                            physicalReference.NumOfCopies = int.Parse(textBoxNumOfCopies.Text);
                            referenceToBeAdded = physicalReference;
                        }
                        else
                        {
                            DigitalReference digitalReferenceToBeAdded = new DigitalReference();
                            
                            referenceToBeAdded = digitalReferenceToBeAdded;
                        }
                        referenceToBeAdded.Title = txtTitle.Text;
                        referenceToBeAdded.PublishedOn = DateTime.Parse(textBoxPublishedOn.Text);
                        referenceToBeAdded.ISBN = textBoxISBN.Text;
                        referenceToBeAdded.Type = Enum.Parse<Reference.ReferenceType>(textBoxType.Text);
                        referenceToBeAdded.Genre = Enum.Parse<Reference.ReferenceGenre>(textBoxGenre.Text);
                        referenceToBeAdded.CoverImage = UserExperience.ImageToByteArray(pictureBoxCoverImage.Image);
                        referenceToBeAdded.Description = textBoxDescription.Text;
                        referenceToBeAdded.Creator = creatorOfReference;

                        context.Add(referenceToBeAdded);

                        // Save changes
                        context.SaveChanges();
                    }
                }

     // Refresh the user experience
     ((this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience).LoadUserExperience("Title");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBoxCoverImage_Click(object sender, EventArgs e)
        {
            string imagelocation;

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| all files(*.*)|*.*";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = op.FileName;
                //guna2PictureBox1.ImageLocation = imagelocation;
                pictureBoxCoverImage.Image = new Bitmap(op.FileName);


            }
        }
    }
}
