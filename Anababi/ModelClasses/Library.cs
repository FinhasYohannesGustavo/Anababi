
using Microsoft.EntityFrameworkCore;

namespace Anababi.ModelClasses
{
    [Keyless]
    public class Library
    {
        public string Name { get; set; } = null!;
        List<User> Members { get; set; } = null!;
        List<User> Administrators { get; set; } = null!;
        public List<Reference> References { get; set; } = null!;

        public Library() { }

        public Library(List<User> members, List<User> administrators, List<Reference> references)
        {
            Members = members;
            Administrators = administrators;
            References = references;
        }

    }
}
