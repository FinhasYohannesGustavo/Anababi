using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.ModelClasses
{
    internal class Library
    {
        List<User> users { get; set; }
        List<Administrator> administrators { get; set; }
        internal List<Reference> references { get; set; }

        public Library(List<User> users, List<Administrator> administrators, List<Reference> references)
        {
            this.users = users;
            this.administrators = administrators;
            this.references = references;
        }

    }
}
