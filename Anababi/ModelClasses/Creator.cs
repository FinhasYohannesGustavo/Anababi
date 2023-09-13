using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.ModelClasses
{
    internal class Creator
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Reference> referencesCreated { get; set; }

        public byte[]? profilePic { get; set; }

        Creator(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
