
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    internal class Creator
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public List<Reference> referencesCreated { get; set; } = null!;
        public byte[]? profilePic { get; set; } = null!

    }
}
