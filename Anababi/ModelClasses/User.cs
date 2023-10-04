using Anababi.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
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

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static List<User> GetAllUsersFromDB()
        {
            using AnababiContext context = new AnababiContext();
            List<User> users = context.Users.ToList();
            return users;
        }

        // Admin privileges
        public string AddReference(Reference reference)
        {
            string confirmationMessage;
            if(this.IsAdmin)
            {
                // Code for adding a Reference.
                using AnababiContext context = new AnababiContext();

                context.References.Add(reference);
                context.SaveChanges();

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
                using AnababiContext context = new AnababiContext();
                var toBeModified = context.References
                        .Where(r => r.Id == reference.Id)
                        .First();

                if (toBeModified is Reference)
                {
                    if(toBeModified is DigitalReference)
                        toBeModified = new DigitalReference(reference as DigitalReference);
                    else
                        toBeModified = new PhysicalReference(reference as PhysicalReference);
                } 
                context.SaveChanges();

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
                using AnababiContext context = new AnababiContext();

                var toBeRemoved = context.References
                            .Where(r => r.Id == reference.Id) 
                            .First();

                if(toBeRemoved is Reference)
                {
                    context.Remove(toBeRemoved);
                }

                confirmationMessage = "Reference removed.";
            }
            else
                confirmationMessage = "This feature is only for admins.";
            
            return confirmationMessage;
        }
        
    }
}