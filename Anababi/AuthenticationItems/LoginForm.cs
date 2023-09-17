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

namespace Anababi.AuthenticationItems
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginPwdTextBox_Enter(object sender, EventArgs e)
        {
            if (loginPwdTextBox.Text == "Password")
            {
                loginPwdTextBox.Text = "";
            }
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("yay!");
            loginPwdTextBox.Text = "";
            loginUserNameTextBox.Text = "";
        }

        private void clearBtn_Click1(object sender, EventArgs e)
        {
            loginPwdTextBox.Text = "";
            loginUserNameTextBox.Text = "";
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
               userToBeLoggedIn = context.Users.FirstOrDefault(c => c.Username.Equals(loginUserNameTextBox.Text));
            }

            if (userToBeLoggedIn!=null&&userToBeLoggedIn.Password.Equals(loginPwdTextBox.Text)){
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
    }
}
