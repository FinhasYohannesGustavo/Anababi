
namespace Anababi.ModelClasses
{
    internal class Library
    {
        internal string name { get; set; } = null!;
        List<User> members { get; set; }
        List<User> administrators { get; set; }
        internal List<Reference> references { get; set; }

        public Library(List<User> members, List<User> administrators, List<Reference> references)
        {
            this.members = members;
            this.administrators = administrators;
            this.references = references;
        }

    }
}
