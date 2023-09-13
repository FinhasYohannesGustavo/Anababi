
using System.ComponentModel.DataAnnotations;

namespace Anababi.ModelClasses
{
    public class PhysicalReference : Reference
    {
        public class ReferenceLocation
        {
            [Key]
            public int Id { get; set; }
            public int Floor { get; set; }
            public int Section { get; set; }
            public int Shelf { get; set; }

            ReferenceLocation(int floor, int section, int shelf)
            {
                Floor = floor;
                Section = section;
                Shelf = shelf;
            }
        }

        public ReferenceLocation Location { get; set; } = null!;
        public int NumOfCopies { get; set; }
        public bool Available { get; set; }

    }
}
