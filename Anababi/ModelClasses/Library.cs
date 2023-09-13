using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.ModelClasses
{
    internal class Library
    {
        User[] users { get; set; }
        Administrator[] administrators { get; set; }
        internal Reference[] references { get; set; }

        public Library(User[] users, Administrator[] administrators, Reference[] references)
        {
            this.users = users;
            this.administrators = administrators;
            this.references = references;
        }

    }
}
