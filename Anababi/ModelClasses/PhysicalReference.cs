
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

            public ReferenceLocation() { }

            public ReferenceLocation(int floor, int section, int shelf)
            {
                Floor = floor;
                Section = section;
                Shelf = shelf;
            }
        }

        public ReferenceLocation Location { get; set; } = null!;
        public int NumOfCopies { get; set; }
        public bool Available { get; set; }

        public PhysicalReference() { }

        public PhysicalReference(PhysicalReference physicalReference)
            :base(physicalReference)
        {
            Location = physicalReference.Location;
            NumOfCopies = physicalReference.NumOfCopies;
            Available = physicalReference.Available;
        }

    }
}
