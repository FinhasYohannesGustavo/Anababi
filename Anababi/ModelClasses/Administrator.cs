
namespace Anababi.ModelClasses
{
    internal class Administrator : User
    {
        public Administrator() { }
        void AddReference(Reference reference) {
            // Code for adding a reference.
            Console.WriteLine("Reference added.");
        }
        void ModifyReference(Reference reference) { 
            // Code for modifying a reference.
            Console.WriteLine("Reference modified."); 
        }
        void RemoveReference(Reference reference) {
            // Code for removing a reference.
            Console.WriteLine("Reference removed");
        }
    }
}
