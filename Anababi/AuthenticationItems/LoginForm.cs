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
using Anababi.Data;
using Anababi.RegistrationItems;
using Anababi.Properties;
using Microsoft.IdentityModel.Tokens;

namespace Anababi.AuthenticationItems
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Icon = Resources.font_symbol_of_letter_a;
        }

        private void loginPwdTextBox_TextChanged(object sender, EventArgs e)
        {
            loginPwdTextBox.PasswordChar = '*';
        }

        private void loginShowPwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loginShowPwdCheckBox.Checked)
            {
                loginPwdTextBox.PasswordChar = '\0';
            }
            else
            {
                loginPwdTextBox.PasswordChar = '*';
            }
        }

    

        private void loginClearBtn_Click(object sender, EventArgs e)
        {
            loginPwdTextBox.Text = "";
            loginUserNameTextBox.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User userToBeLoggedIn = new User();
            using (var context = new AnababiContext())
            {
                //Populate the database with dummy objects only if it is empty
                if (context.Libraries.IsNullOrEmpty())
                {
                    UserExperience.PopulateDatabaseWithDummyData();
                }

                userToBeLoggedIn = context.Users.FirstOrDefault(c => c.Username.Equals(loginUserNameTextBox.Text));
            }

            if (userToBeLoggedIn.ProfilePic == null)
            {
                userToBeLoggedIn.ProfilePic = UserExperience.ImageToByteArray(Resources.user);
            }

            if (userToBeLoggedIn != null && userToBeLoggedIn.Password.Equals(loginPwdTextBox.Text)){
                App app = new App(userToBeLoggedIn);
                this.Hide();
                app.FormClosed += NewForm_FormClosed;
                app.Show();
                  
            }
            else if (userToBeLoggedIn == null)
            {
                MessageBox.Show("There is no user with the user name '"+ loginUserNameTextBox.Text+"'");
            }
            else
            {
                MessageBox.Show("You have entered the wrong password for the user");
            }

        }
        
        //this function simply closes the login form when the app is closed
        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the old form (LoginForm) when the new form (App) is closed
            this.Close();
        }

        private void LabelDonthaveAccLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
            this.Hide();
            userRegistrationForm.FormClosed += NewForm_FormClosed;
            userRegistrationForm.Show();
        }

        private void loginPwdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the new line from being inserted
                loginBtn.PerformClick(); // Programmatically click the button
            }
        }

        private void loginUserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the new line from being inserted
                loginBtn.PerformClick(); // Programmatically click the button
            }
        }
    }
}
