using Anababi.ModelClasses;
namespace Anababi
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            //Create a user authentication UserControl object and add it to the control of the form.
            //...

            //This is dummy data and will be replaced by the verified User object from the Login page.
            User user = new User();
            user.id = 1;
            user.firstName = "Yelielew";
            user.lastName = "Aymertim";
            user.username = "yelielew";
            user.profilePic = UserExperience.ImageToByteArray(Properties.Resources.Afewerk_Tekle);

            //This will be inside the button-click event of the user authentication UserControl.
            //Create a UserExperience object and add it to the control.
            UserExperience userExperience = new UserExperience(user);
            userExperience.Dock = DockStyle.Fill;
            //Remember to replace `this` with `this.FindForm()` in the user authentication class.
            this.Controls.Add(userExperience);

        }
    }
}