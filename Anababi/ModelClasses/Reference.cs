using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal int id {  get; set; }
        internal string title { get; set; }
        internal SqlDateTime publishedOn { get; set; }
        internal ISBN ISBNValue { get; set; }
        internal ReferenceType referenceType { get; set; }
        internal ReferenceGenre referenceGenre { get; set; }
        internal Creator creator { get; set; }
        internal byte[]? coverImage { get; set; }
        internal string description { get; set; }
    }
}