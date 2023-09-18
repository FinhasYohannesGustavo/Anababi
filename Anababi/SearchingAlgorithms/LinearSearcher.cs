using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anababi.ModelClasses;

namespace Anababi.SearchingAlgorithms
    {
        internal class LinearSearcher
        {
            public static Reference LinearSearch(List<Reference> referenceList, string searchKey, string compareBy)
            {
                foreach (var reference in referenceList)
                {
                    if (compareBy.Equals("Author"))
                    {
                        if (CompareReferencesAuthor(reference, searchKey) == 0)
                            return reference;
                    }
                    else if (compareBy.Equals("Title"))
                    {
                        if (CompareReferencesTitle(reference, searchKey) == 0)
                            return reference;
                    }
                    else if (compareBy.Equals("Published Date"))
                    {
                        if (CompareReferencesPublishedOn(reference, searchKey) == 0)
                            return reference;
                    }
                }

                // Search key was not found
                return null;
            }

            // Compare two Reference objects based on FirstName and LastName properties
            private static int CompareReferencesAuthor(Reference reference, string searchKey)
            {
                int firstNameComparison = string.Compare(reference.Creator.FirstName, searchKey);
                int lastNameComparison = string.Compare(reference.Creator.LastName, searchKey);

                if (firstNameComparison == 0)
                    return firstNameComparison;
                else
                    return lastNameComparison;
            }

            private static int CompareReferencesTitle(Reference reference, string searchKey)
            {
                return string.Compare(reference.Title, searchKey);
            }

            private static int CompareReferencesPublishedOn(Reference reference, string searchKey)
            {
                return string.Compare(reference.PublishedOn.ToShortDateString(), searchKey);
            }
        }

}


