
namespace Anababi.ModelClasses
{
    public class PhysicalReference : Reference
    {
        public class ReferenceLocation
        {
            int Floor;
            int Section;
            int Shelf;

            ReferenceLocation(int floor, int section, int shelf)
            {
                Floor = floor;
                Section = section;
                Shelf = shelf;
            }
        }

        ReferenceLocation Location { get; set; } = null!;
        int NumOfCopies { get; set; }
        bool Available { get; set; }

    }
}
