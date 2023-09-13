using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    internal class User
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string username { get; set; } = null!;
        private string _password { get; set; } = null!;
        public byte[]? profilePic { get; set; }
        internal bool isAdmin { get; set; } = false;

        public void Login() { }
        public void Logout() { }
        public void Search(string searchKey, Reference[] references) { }
        public void Sort(Reference[] referenes) { }

        // User privileges
        internal string AddReference(Reference reference)
        {
            string confirmationMessage;
            if(this.isAdmin)
            {
                // Code for adding a reference.
                confirmationMessage = "Reference added.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        internal string ModifyReference(Reference reference)
        {
            string confirmationMessage;
            if(this.isAdmin)
            {
                // Code for adding a reference.
                confirmationMessage = "Reference modified.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        internal string RemoveReference(Reference reference)
        {
            string confirmationMessage;
            if(this.isAdmin)
            {
                // Code for adding a reference.
                confirmationMessage = "Reference removed.";

            }
            else
                confirmationMessage = "This feature is only for admins.";
            return confirmationMessage;
            
        }
        
    }
}