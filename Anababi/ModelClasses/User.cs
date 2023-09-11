using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.ModelClasses
{
    internal class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        private string _password { get; set; }

        public User()
        {
        }

        public void Login() { }
        public void Logout() { }
        public void Search(string searchKey, Reference[] references) { }
        public void Sort(Reference[] referenes) { }
    }
}