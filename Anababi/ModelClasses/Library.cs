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
        Reference[] references { get; set; }

        public Library()
        {
            users = new User[] { };
            administrators = new Administrator[] { };
            references = new Reference[] { };
        }

    }
}
