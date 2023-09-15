using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Anababi.ModelClasses
{

    public class Reference
    {
        public enum ReferenceType
        {
            Book,
            Article
        }
        public enum ReferenceGenre
        {
            Fiction,
            NonFiction,
            ScienceFiction,
            Thriller,
            Fantasy,
            Romance
        }

        public class ISBN
        {
            [Key]
            public int Id { get; set; }
            public int Prefix { get; set; }
            public int RegistrationGroup { get; set; }
            public int Registrant { get; set; }
            public int Publication { get; set; }
            public int CheckDigit { get; set; }

            ISBN() { }
            ISBN(int prefix, int registrationGroup, int registrant, int publication, int checkDigit)
            {
                Prefix = prefix;
                RegistrationGroup = registrationGroup;
                Registrant = registrant;
                Publication = publication;
                CheckDigit = checkDigit;
            }

            public int GetISBN()
            {
                string fullISBN = $"{Prefix}{RegistrationGroup}{Registrant}{Publication}{CheckDigit}";
                
                return int.Parse(fullISBN);
            }
        }

        [Key]
        public int Id {  get; set; }
        public string Title { get; set; } = null!;
        public DateTime PublishedOn { get; set; }
        public ISBN ISBNValue { get; set; } = null!;
        public ReferenceType Type { get; set; }
        public ReferenceGenre Genre { get; set; }
        public Creator Creator { get; set; } = null!;
        public byte[]? CoverImage { get; set; }
        public string Description { get; set; } = null!;

        public Reference() { }

        public Reference(Reference reference)
        {
            Id = reference.Id;
            Title = reference.Title;
            PublishedOn = reference.PublishedOn;
            Creator = reference.Creator;
            ISBNValue = reference.ISBNValue;
            Type = reference.Type;
            Genre = reference.Genre;
            CoverImage = reference.CoverImage;
            Description = reference.Description;
        }
    }
}