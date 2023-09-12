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

            //This will be replaced by the verified User object from the Login page.

            //this is dummy data.
            User user = new User();
            user.id = 1;
            user.firstName = "yelelew";
            user.lastName = "aymertim";
            user.username = "user";
            user.profilePic = UserExperience.ImageToByteArray(Properties.Resources.Afewerk_Tekle);
            //Display user experience
            UserExperience userExperience = new UserExperience(user);
            userExperience.Dock = DockStyle.Fill;
            this.Controls.Add(userExperience);
        }
    }
}