using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anababi.ModelClasses;

namespace Anababi.SortingAlgorithms
{
    internal class InsertionSorter
    {
        public static List<Reference> InsertionSort(List<Reference> referenceToBeSorted)
        {
            int len = referenceToBeSorted.Count;

            for (int i = 1; i < len; i++)
            {
                Reference key = referenceToBeSorted[i]; // Store the current element
                int j = i - 1;

                // Compare the key element with the elements before it
                while (j >= 0 && CompareReferences(referenceToBeSorted[j], key) > 0)
                {
                    referenceToBeSorted[j + 1] = referenceToBeSorted[j]; // Shift larger element to the right
                    j--;
                }

                referenceToBeSorted[j + 1] = key; // Place the key element in its correct position
            }

            return referenceToBeSorted;
        }

        // Compare two Reference objects based on FirstName and LastName properties
        private static int CompareReferences(Reference reference1, Reference reference2)
        {
            int publicationComparision = String.Compare(reference1.PublishedOn.ToString(), reference2.PublishedOn.ToString());

            return publicationComparision;
     
        }
    }
}
