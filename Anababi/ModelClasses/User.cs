using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    internal class User
    {
        public int id { get; set; }
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string username { get; set; } = null!;
        private string _password { get; set; } = null!;
        public byte[]? profilePic { get; set; }

        public void Login() { }
        public void Logout() { }
        public void Search(string searchKey, Reference[] references) { }
        public void Sort(Reference[] referenes) { }
    }
}