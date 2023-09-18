using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.AuthenticationItems;
using Anababi.Data;
using Anababi.ModelClasses;

namespace Anababi.RegistrationItems
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }


        private void year_Click(object sender, EventArgs e)
        {
        }

        private void month_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || confirmPwdTextBox.Text == "" || pwdTextBox.Text == "" || TextBoxEmail.Text == "")
            {
                MessageBox.Show("You have left some fields empty", "Sign up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (confirmPwdTextBox.Text == pwdTextBox.Text)
            {

                User userToBeCreated = new User();
                userToBeCreated.FirstName = fnameTextBox.Text;
                userToBeCreated.LastName = lnameTextBox.Text;
                userToBeCreated.Username = userNameTextBox.Text;
                userToBeCreated.Password = pwdTextBox.Text;
                userToBeCreated.Email = pwdTextBox.Text;
                using (AnababiContext anababiContext = new AnababiContext())
                {
                    User userDuplicateUsername = anababiContext.Users.FirstOrDefault(u => u.Username == userNameTextBox.Text);
                    if (userDuplicateUsername == null)
                    {
                        anababiContext.Users.Add(userToBeCreated);
                        anababiContext.SaveChanges();
                        App app = new App(userToBeCreated);
                        this.Hide();
                        app.FormClosed += NewForm_FormClosed;
                        app.Show();
                    }
                    else
                    {
                        MessageBox.Show("There is already a user with the username '"+userNameTextBox.Text+"' please choose a differnt one");
                    }

                }


            }
            else
            {
                MessageBox.Show("Passwords do not match, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmPwdTextBox.Text = "";
                pwdTextBox.Text = "";
                confirmPwdTextBox.Focus();
            }
        }

        private void pwdcfcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwdCheckBox.Checked)
            {
                pwdTextBox.PasswordChar = '\0';
            }
            else
            {
                pwdTextBox.PasswordChar = '*';

            }
        }


        private void fnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void pwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pwdTextBox.Text))
            {
                confirmPwdTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                pwdTextBox.UseSystemPasswordChar = false;
            }
        }

        private void connfirmPwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmPwdCheckBox.Checked)
            {
                confirmPwdTextBox.PasswordChar = '\0';
            }

            else
            {
                confirmPwdTextBox.PasswordChar = '*';
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pwdTextBox.Text = "";
            userNameTextBox.Text = "";
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            TextBoxEmail.Text = "";
           
            //countryComboBox.Text = "";
            //phoneNumComboBox.Text = "";
            //phoneNumTextBox.Text = "";
            confirmPwdTextBox.Text = "";
            //UserRegistrationForm.Text = "";
        }
        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the old form (LoginForm) when the new form (App) is closed
            this.Close();
        }

        private void fnameTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the new line from being inserted
                signUpBtn.PerformClick(); // Programmatically click the button
            }
        }

        private void haveAccLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.FormClosed += NewForm_FormClosed;
            loginform.Show();
        }
    }
}
