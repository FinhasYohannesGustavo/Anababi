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
            //Create a user authentication UserControl object and add it to the control of the form.
            //...

            using AnababiContext context = new AnababiContext();
            
            //Populate the database with dummy objects only if it is empty
            if(context.Libraries.IsNullOrEmpty())
            {
                UserExperience.PopulateDatabaseWithDummyData();
            }

            //var user = context.Users.Where(u => !u.IsAdmin).FirstOrDefault() as User;
            if(this.user.ProfilePic==null) {

                this.user.ProfilePic = UserExperience.ImageToByteArray(Resources.user);
            }
            //var administrator = context.Users.Where(u => u.IsAdmin).FirstOrDefault() as User;

            Library = context.Libraries.FirstOrDefault() as Library;
            

            //Everything below will be inside the button-click event of the user authentication UserControl.
            //Create a UserExperience object and add it to the control.
            UserExperience userExperience = new UserExperience(this.user);
            userExperience.Dock = DockStyle.Fill;
            //Remember to replace `this` with `this.FindForm()` in the user authentication class.
            this.Controls.Add(userExperience);

        }
    }
}