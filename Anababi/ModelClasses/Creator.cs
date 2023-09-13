using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.ModelClasses
{
    internal class Creator
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public List<Reference> referencesCreated { get; set; } = null!;
        public byte[]? profilePic { get; set; } = null!

    }
}
