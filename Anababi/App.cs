using Anababi.ModelClasses;
using Anababi.Data;
using Microsoft.IdentityModel.Tokens;
using Anababi.Properties;

namespace Anababi
{
    public partial class App : Form
    {
        static Library Library { get; set; } = null!;
        User user;
        public App(User ekele)
        {
            InitializeComponent();
            this.user= ekele;
        }

        private void App_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.font_symbol_of_letter_a;

            //Maximize the window
            this.WindowState = FormWindowState.Maximized;
            //Prevent resizing
            this.MaximizeBox = false;

            //Create as UserExperience object and add it to the control.
            UserExperience userExperience = new UserExperience(this.user);
            userExperience.Dock = DockStyle.Fill;
            this.Controls.Add(userExperience);

        }
    }
}