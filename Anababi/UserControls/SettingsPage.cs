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
using System.Drawing.Design;

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
                        MessageBox.Show("Make sure the passwords you have entered match.");
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
                    currentUser.ProfilePic = UserExperience.ImageToByteArray(guna2PictureBox1.Image);
                    AnababiContext.SaveChanges();
                    UserExperience CurrentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
                    CurrentExperience.LoadUserExperience(CurrentExperience.SortBy);
                    
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
                    if (UserNames.Contains(txtUserName.Text))
                    {
                        MessageBox.Show("Username has been taken please choose another username");
                    }
                    else if (txtUserName.Text!="")
                    {
                        userToBeUpdated.Username = txtUserName.Text;

                        AnababiContext.SaveChanges();
                        //update the current user and reload the experience
                        currentUser.Username = txtUserName.Text;
                        currentUser.FirstName= txtFirstName.Text;
                        currentUser.LastName = txtLastName.Text;
                        UserExperience CurrentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
                        CurrentExperience.LoadUserExperience(CurrentExperience.SortBy);

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

                    this.FindForm().Close();
                }

            }

        }

       
    }
}
