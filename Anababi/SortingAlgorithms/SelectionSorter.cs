using Anababi.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anababi.ModelClasses;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Anababi.SortingAlgorithms
{
    internal class SelectionSorter
    {
        public static List<Reference> SelectionSort(List<Reference> referenceToBeSorted)
        {

            //Variable for holding the size of the array referenceToBeSorted.
            int len = referenceToBeSorted.Count();
            //Variable for holding the index of the current minimum portion.
            int index_of_min = 0;

            for (int i = 0; i < len - 1; i++)
            {
                index_of_min = i;

                //Look for the index of the minimum number in the unsorted part of the data set.
                for (int j = i + 1; j < len; j++)
                {
                    if (String.Compare(referenceToBeSorted[j].Creator.FirstName, referenceToBeSorted[index_of_min].Creator.FirstName) < 0)
                    {
                        index_of_min = j;
                    }
                    else if (String.Compare(referenceToBeSorted[j].Creator.FirstName, referenceToBeSorted[index_of_min].Creator.FirstName) == 0)
                    {
                        if (String.Compare(referenceToBeSorted[j].Creator.LastName, referenceToBeSorted[index_of_min].Creator.LastName) < 0)
                        {
                            index_of_min = j;
                        }
                    }
                }

                //Only switch if the minimum index has changed.
                if (index_of_min != i)
                {
                    // Swap the objects
                    Reference temp = referenceToBeSorted[index_of_min];
                    referenceToBeSorted[index_of_min] = referenceToBeSorted[i];
                    referenceToBeSorted[i] = temp;
                }

            }
            return referenceToBeSorted;
        }
    }
}
