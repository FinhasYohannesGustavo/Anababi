using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using Anababi.ModelClasses;
using Anababi.Data;

namespace Anababi.UserControls
{
    internal partial class SettingsPage : UserControl
    {
        User currentUser = UserExperience.currentUser;
        public SettingsPage()
        {
            InitializeComponent();

        }

        private void updatePictureClick(object sender, EventArgs e)
        {
            string imagelocation;

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| all files(*.*)|*.*";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = op.FileName;
                //guna2PictureBox1.ImageLocation = imagelocation;
                guna2PictureBox1.Image = new Bitmap(op.FileName);


            }
        }

        private void saveChangedPassword(object sender, EventArgs e)
        {

            //update db
            using (AnababiContext AnababiContext = new AnababiContext())
            {
                User userToBeUpdated = AnababiContext.Users.SingleOrDefault
                    (username => username.Username == UserExperience.currentUser.Username);
                if (userToBeUpdated != null)
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {

                        if (userToBeUpdated.Password == txtCurrentPassword.Text)
                        {
                            userToBeUpdated.Password = txtNewPassword.Text;
                            AnababiContext.SaveChanges();
                            MessageBox.Show("Password change confirmed.");
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct current Password!");

                        }

                    }

                    else
                    {
                        MessageBox.Show("Make sure the passwords you have entered match and try again.");
                    }
                }

            }



        }

        private void saveChangedProfilePicture(object sender, EventArgs e)
        {
            using (AnababiContext AnababiContext = new AnababiContext())
            {
                User userToBeUpdated = AnababiContext.Users.SingleOrDefault
                    (username => username.Username == UserExperience.currentUser.Username);
                if (userToBeUpdated != null)
                {
                    userToBeUpdated.ProfilePic = UserExperience.ImageToByteArray(guna2PictureBox1.Image);
                    AnababiContext.SaveChanges();

                }

            }

        }

        private void btnEditProfileDetails_Click(object sender, EventArgs e)
        {
            using (AnababiContext AnababiContext = new AnababiContext())
            {
                User userToBeUpdated = AnababiContext.Users.SingleOrDefault
                    (username => username.Username == UserExperience.currentUser.Username);
                if (userToBeUpdated != null)
                {
                    userToBeUpdated.FirstName = txtFirstName.Text;
                    userToBeUpdated.LastName = txtLastName.Text;
                    AnababiContext checkUsernameContext = new AnababiContext();
                    List<String> UserNames = (from usernames in checkUsernameContext.Users
                                              select usernames.Username.ToString()).ToList();
                    if (UserNames.Count > 0)
                    {
                        MessageBox.Show("Username has been taken please choose another username");
                    }
                    else if (txtUserName != null && UserNames.Count == 0)
                    {
                        userToBeUpdated.Username = txtUserName.Text;

                        AnababiContext.SaveChanges();

                    }
                    else
                    {

                        AnababiContext.SaveChanges();
                    }


                }

            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            using (AnababiContext AnababiContext = new AnababiContext())
            {
                User userToBeDeleted = AnababiContext.Users.SingleOrDefault
                    (username => username.Username == UserExperience.currentUser.Username);
                if (userToBeDeleted != null && userToBeDeleted.Password == txtPasswordToDelete.Text)
                {
                    AnababiContext.Users.Remove(userToBeDeleted);

                    AnababiContext.SaveChanges();

                }

            }

        }
    }
}
