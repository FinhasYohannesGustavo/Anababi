using Anababi.AuthenticationItems;
using Anababi.Data;
using Anababi.ModelClasses;
using Anababi.Properties;

namespace Anababi
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            //For testing only
            //User trial = new AnababiContext().Users.FirstOrDefault(u => u.Username.Equals("gustavo"));
            //User trial = new AnababiContext().Users.Where(u => (!u.IsAdmin)).First();
            //Application.Run(new App(trial));
        }
    }
}