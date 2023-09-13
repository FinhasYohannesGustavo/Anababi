using Microsoft.Data.SqlTypes;

namespace Anababi.ModelClasses
{
    internal class DigitalReference : Reference
    {
        SqlFileStream File { get; set; } = null!;
        public string getFileType()
        {
            string fileType = "";
            //Code for extracting the file type from the file.
            return fileType;
        }

    }
}
