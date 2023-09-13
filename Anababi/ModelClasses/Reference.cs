using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Anababi.ModelClasses
{

    internal class Reference
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
        internal class ISBN
        {
            int Prefix;
            int RegistrationGroup;
            int Registrant;
            int Publication;
            int CheckDigit;

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
        internal int Id {  get; set; }
        internal string Title { get; set; } = null!;
        internal SqlDateTime PublishedOn { get; set; }
        internal ISBN ISBNValue { get; set; } = null!;
        internal ReferenceType Type { get; set; }
        internal ReferenceGenre Genre { get; set; }
        internal Creator Creator { get; set; } = null!;
        internal byte[]? CoverImage { get; set; }
        internal string Description { get; set; } = null!;
    }
}