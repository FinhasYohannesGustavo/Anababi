
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    internal class Creator
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Reference> ReferencesCreated { get; set; } = null!;
        public byte[]? ProfilePic { get; set; } = null!;

    }
}
