using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        private string _password { get; set; } = null!;
        public byte[]? ProfilePic { get; set; }
        public bool IsAdmin { get; set; } = false;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
            }
        }

        public void Login() { }
        public void Logout() { }
        public void Search(string searchKey, Reference[] references) { }
        public void Sort(Reference[] referenes) { }

        // User privileges
        public string AddReference(Reference reference)
        {
            string confirmationMessage;
            if(this.IsAdmin)
            {
                // Code for adding a Reference.
                confirmationMessage = "Reference added.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        public string ModifyReference(Reference reference)
        {
            string confirmationMessage;
            if(this.IsAdmin)
            {
                // Code for adding a Reference.
                confirmationMessage = "Reference modified.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        public string RemoveReference(Reference reference)
        {
            string confirmationMessage;
            if(this.IsAdmin)
            {
                // Code for adding a Reference.
                confirmationMessage = "Reference removed.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        
    }
}