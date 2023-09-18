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
            using AnababiContext context = new AnababiContext();
            
            //Populate the database with dummy objects only if it is empty
            if(context.Libraries.IsNullOrEmpty())
            {
                UserExperience.PopulateDatabaseWithDummyData();
            }

            if(this.user.ProfilePic==null) {
                this.user.ProfilePic = UserExperience.ImageToByteArray(Resources.user);
            }

            Library = context.Libraries.FirstOrDefault() as Library;

            //Maximize the window
            this.WindowState = FormWindowState.Maximized;
            //Prevent resizing
            this.MaximizeBox = false;

            //Create as UserExperience object and add it to the control.
            UserExperience userExperience = new UserExperience(this.user);
            userExperience.Dock = DockStyle.Fill;
            //Remember to replace `this` with `this.FindForm()` in the user authentication class.
            this.Controls.Add(userExperience);

        }
    }
}