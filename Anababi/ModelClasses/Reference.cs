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
            public int Prefix;
            public int RegistrationGroup;
            public int Registrant;
            public int Publication;
            public int CheckDigit;

            ISBN() { }
            ISBN(int prefix, int registrationGroup, int registrant, int publication, int checkDigit)
            {
                Prefix = prefix;
                RegistrationGroup = registrationGroup;
                Registrant = registrant;
                Publication = publication;
                CheckDigit = checkDigit;
            }

            public string GetISBN()
            {
                string fullISBN = $"{Prefix}-{RegistrationGroup}-{Registrant}-{Publication}-{CheckDigit}";
                return fullISBN;
            }
        }

        [Key]
        public int Id {  get; set; }
        public string Title { get; set; } = null!;
        public SqlDateTime PublishedOn { get; set; }
        public ISBN ISBNValue { get; set; } = null!;
        public ReferenceType Type { get; set; }
        public ReferenceGenre Genre { get; set; }
        public Creator Creator { get; set; } = null!;
        public byte[]? CoverImage { get; set; }
        public string Description { get; set; } = null!;
    }
}