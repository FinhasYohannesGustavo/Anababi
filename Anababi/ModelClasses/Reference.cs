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
            int prefix;
            int registrationGroup;
            int registrant;
            int publication;
            int checkDigit;

            ISBN(int prefix, int registrationGroup, int registrant, int publication, int checkDigit)
            {
                this.prefix = prefix;
                this.registrationGroup = registrationGroup;
                this.registrant = registrant;
                this.publication = publication;
                this.checkDigit = checkDigit;
            }

            public string getISBN()
            {
                string fullISBN = $"{prefix}-{registrationGroup}-{registrant}-{publication}-{checkDigit}";
                return fullISBN;
            }
        }

        [Key]
        internal int id {  get; set; }
        internal string title { get; set; } = null!;
        internal SqlDateTime publishedOn { get; set; }
        internal ISBN ISBNValue { get; set; } = null!;
        internal ReferenceType referenceType { get; set; }
        internal ReferenceGenre referenceGenre { get; set; }
        internal Creator creator { get; set; } = null!;
        internal byte[]? coverImage { get; set; }
        internal string description { get; set; } = null!;
    }
}