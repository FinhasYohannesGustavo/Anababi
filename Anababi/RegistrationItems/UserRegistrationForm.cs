using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anababi.RegistrationItems
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void year_Click(object sender, EventArgs e)
        {
        }

        private void month_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" && confirmPwdTextBox.Text == "" && pwdTextBox.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Sign up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (confirmPwdTextBox.Text == pwdTextBox.Text)
            {
                con.Open();
                string register = "Insert into tbl_users values ('" + userNameTextBox.Text + "','" + confirmPwdTextBox.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                userNameTextBox.Text = "";
                confirmPwdTextBox.Text = "";
                pwdTextBox.Text = "";
                MessageBox.Show("Your account has been created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect Password, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OPATlabel_Click(object sender, EventArgs e)
        {

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

        private void phoneNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
            eailTextBox.Text = "";
            genderComboBox1.Text = "";
            countryComboBox.Text = "";
            phoneNumComboBox.Text = "";
            phoneNumTextBox.Text = "";
            confirmPwdTextBox.Text = "";
            //UserRegistrationForm.Text = "";
        }
    }
}
