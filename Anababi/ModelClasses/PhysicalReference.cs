
namespace Anababi.ModelClasses
{
    internal class PhysicalReference : Reference
    {
        internal class ReferenceLocation
        {
            int floor;
            int section;
            int shelf;

            ReferenceLocation(int floor, int section, int shelf)
            {
                this.floor = floor;
                this.section = section;
                this.shelf = shelf;
            }
        }

        ReferenceLocation location { get; set; } = null!;
        int numOfCopies { get; set; }
        bool available { get; set; }

    }
}
