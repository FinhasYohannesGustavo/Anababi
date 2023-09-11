using System;
using System.Collections.Generic;
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
            NonFiction
        }
        internal class ISBN
        {
            int prefixElement;
            int registrationGroupElement;
            int registrantElement;
            int publicationElement;
            int checkDigit;

            ISBN(int prefixElement, int registrationGroupElement, int registrantElement, int publicationElement, int checkDigit)
            {
                this.prefixElement = prefixElement;
                this.registrationGroupElement = registrationGroupElement;
                this.registrantElement = registrantElement;
                this.publicationElement = publicationElement;
                this.checkDigit = checkDigit;
            }

            public string getISBN()
            {
                string fullISBN = $"{prefixElement}-{registrationGroupElement}-{registrantElement}-{publicationElement}-{checkDigit}";
                return fullISBN;
            }
        }

        int id {  get; set; }
        string title { get; set; }
        SqlDateTime publishedOn { get; set; }
        ISBN ISBNValue { get; set; }
        ReferenceType referenceType { get; set; }
        ReferenceGenre referenceGenre { get; set; }
        Creator creator { get; set; }
    }
}