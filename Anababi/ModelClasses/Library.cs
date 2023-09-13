
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<User> Members { get; set; } = null!;
        public List<Reference> References { get; set; } = null!;

        public Library() { }

        public Library(List<User> members, List<Reference> references)
        {
            Members = members;
            References = references;
        }

    }
}
