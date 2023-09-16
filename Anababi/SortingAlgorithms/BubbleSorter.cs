using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anababi.ModelClasses;

namespace Anababi.SortingAlgorithms
{
    internal class BubbleSorter
    {
        public static List<Reference> BubbleSort(List<Reference> referenceToBeSorted)
        {
            int len = referenceToBeSorted.Count;

            for (int i = 0; i < len - 1; i++)
            {
                // Inner loop for each pass
                for (int j = 0; j < len - i - 1; j++)
                {
                    int titleComparison = String.Compare(referenceToBeSorted[j].Title, referenceToBeSorted[j + 1].Title);

                    // Compare and swap if necessary
                    if (titleComparison > 0 )
                    {
                        // Swap the objects
                        Reference temp = referenceToBeSorted[j];
                        referenceToBeSorted[j] = referenceToBeSorted[j + 1];
                        referenceToBeSorted[j + 1] = temp;
                    }
                }
            }

            return referenceToBeSorted;
        }
    }
}
