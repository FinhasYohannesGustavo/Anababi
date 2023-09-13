using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        private string _password { get; set; } = null!;
        public byte[]? ProfilePic { get; set; }
        internal bool IsAdmin { get; set; } = false;

        public void Login() { }
        public void Logout() { }
        public void Search(string searchKey, Reference[] references) { }
        public void Sort(Reference[] referenes) { }

        // User privileges
        internal string AddReference(Reference reference)
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
        internal string ModifyReference(Reference reference)
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
        internal string RemoveReference(Reference reference)
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