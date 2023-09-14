using Microsoft.Data.SqlTypes;
using System.Transactions;

namespace Anababi.ModelClasses
{
    public class DigitalReference : Reference
    {
        public byte[] File { get; set; } = null!;

        public DigitalReference() { }

        public DigitalReference(DigitalReference digitalReference)
            :base(digitalReference)
        {
            File = digitalReference.File;
        }
        public string getFileType()
        {
            string fileType = "";
            //Code for extracting the file type from the file.
            return fileType;
        }

    }
}
