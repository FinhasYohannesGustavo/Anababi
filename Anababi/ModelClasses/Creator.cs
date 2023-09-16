
using Anababi.Data;
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    public class Creator
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public byte[]? ProfilePic { get; set; } = null!;

        public List<Reference> GetReferencesCreated()
        {
            using AnababiContext context = new AnababiContext();
            return context.References.Where(r => r.Creator == this).ToList();
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static List<Creator> GetAllCreatorsFromDB()
        {
            using AnababiContext context = new AnababiContext();
            List<Creator> creators = context.Creators.ToList();
            return creators;
        }

    }
}
