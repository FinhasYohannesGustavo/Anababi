using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anababi.ModelClasses;

namespace Anababi.SearchingAlgorithms
{
    internal class BinarySearcher
    {
        public static Reference  BinarySearch(List<Reference> sortedList, String searchKey,String compareBy)
        {
            int low = 0;
            int high = sortedList.Count - 1;
            int comparisonResult = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (compareBy.Equals("Author")){
                    comparisonResult = CompareReferencesAuthor(sortedList[mid], searchKey);

                }
                else if (compareBy.Equals("Title"))
                {
                    comparisonResult = CompareReferencesTitle(sortedList[mid], searchKey);

                }
                else
                {
                    comparisonResult = CompareReferencesPublishedOn(sortedList[mid], searchKey);
                }


                if (comparisonResult == 0)
                {
                    // Found the search key at index mid
                    return sortedList[mid];
                }
                else if (comparisonResult < 0)
                {
                    // Search in the right half of the remaining list
                    low = mid + 1;
                }
                else
                {
                    // Search in the left half of the remaining list
                    high = mid - 1;
                }
            }

            // Search key was not found
            return null;
        }

        // Compare two Reference objects based on FirstName and LastName properties
        private static int CompareReferencesAuthor(Reference reference1, String searchKey)
        {
            int firstNameComparison = String.Compare(reference1.Creator.FirstName, searchKey);
            int lastNameComparison = String.Compare(reference1.Creator.LastName, searchKey);

            if (firstNameComparison == 0)
                return firstNameComparison;
            else
                return lastNameComparison;
        }

        private static int CompareReferencesTitle(Reference reference1, String searchKey)
        {
          
            int titleComparison= String.Compare(reference1.Title, searchKey);

           
            return titleComparison;
        }

        private static int CompareReferencesPublishedOn(Reference reference1, String searchKey)
        {

            int ISBN_Comparison = String.Compare(reference1.PublishedOn.ToString(), searchKey);


            return ISBN_Comparison;
        }
    }
}
