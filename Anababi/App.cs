using Anababi.ModelClasses;
namespace Anababi
{
    public partial class App : Form
    {
        static Library Library { get; set; } = null!;
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
            user.Id = 1;
            user.FirstName = "Yelielew";
            user.LastName = "Aymertim";
            user.Username = "yelielew";
            user.ProfilePic = UserExperience.ImageToByteArray(Properties.Resources.Afewerk_Tekle);

            User administrator = new User();
            administrator.Id = 2;
            administrator.FirstName = "Aytal";
            administrator.LastName = "Esuga";
            administrator.Username = "aytal_esuga";
            administrator.IsAdmin = true;
            administrator.ProfilePic = UserExperience.ImageToByteArray(Properties.Resources.goneGirl);

            //Create a library object with all users, Administrators and References.
            List<User> users = new List<User> { user};
            List<Reference> references = UserExperience.GetDummyReferences();
            List<User> administrators = new List<User> { administrator};
            Library = new Library(users, administrators, references);
            

            //Everything below will be inside the button-click event of the user authentication UserControl.
            //Create a UserExperience object and add it to the control.
            UserExperience userExperience = new UserExperience(user);
            userExperience.Dock = DockStyle.Fill;
            //Remember to replace `this` with `this.FindForm()` in the user authentication class.
            this.Controls.Add(userExperience);

        }
    }
}