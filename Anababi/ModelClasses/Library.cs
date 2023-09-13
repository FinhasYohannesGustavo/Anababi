
namespace Anababi.ModelClasses
{
    internal class Library
    {
        internal string Name { get; set; } = null!;
        List<User> Members { get; set; }
        List<User> Administrators { get; set; }
        internal List<Reference> References { get; set; }

        public Library(List<User> members, List<User> administrators, List<Reference> references)
        {
            Members = members;
            Administrators = administrators;
            References = references;
        }

    }
}
