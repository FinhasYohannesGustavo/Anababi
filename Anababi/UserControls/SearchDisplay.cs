using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.ModelClasses;
using Anababi.Data;
using Anababi.SortingAlgorithms;
using Anababi.SearchingAlgorithms;

namespace Anababi.UserControls
{
    public partial class SearchDisplay : UserControl
    {
        ResultsGrid? resultsGridArtists;
        ResultsGrid? resultsGridArtworks;
        public SearchDisplay()
        {
            InitializeComponent();
        }

        private void SearchDisplay_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<Creator> creators = Creator.GetAllCreatorsFromDB();
            //Create a ResultsGrid object from the list of Users.
            resultsGridArtists = new ResultsGrid(creators);
            //Add the ResultsGrid object to PanelArtistsSection.
            UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

           
            List<Reference> references = UserExperience.GetReferences();
            UserExperience CurrentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
            if (CurrentExperience.SortBy == "Title")
            {
                references = SortingAlgorithms.BubbleSorter.BubbleSort(references);
            }
            else if (CurrentExperience.SortBy == "Author")
            {
               
                references = SortingAlgorithms.SelectionSorter.SelectionSort(references);

            }
            else
            {
                references = SortingAlgorithms.InsertionSorter.InsertionSort(references);
            }
            //Create a ResultsGrid object from the list of VisualArts.
            resultsGridArtworks = new ResultsGrid(references);
            //Add the ResultsGrid object to PanelArtworksSection.
            UserExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);

        }
        //Event for hitting "Enter" after typing in a few characters in the text box.
        private void TextBoxSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Call the search algorithm with the user's input here...
                string searchText = TextBoxSearchBar.Text.ToString();
                AnababiContext searchedReferencesContext = new AnababiContext();
                List<Reference> searchedReferences = (from references in searchedReferencesContext.References
                                                where references.Description.Contains(TextBoxSearchBar.Text.ToString())
                                                || references.Title.Contains(TextBoxSearchBar.Text.ToString())
                                                select references).ToList();
                UserExperience CurrentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
                if (CurrentExperience.SortBy == "Title")
                {
                    searchedReferences = SortingAlgorithms.BubbleSorter.BubbleSort(searchedReferences);
                }
                else if(CurrentExperience.SortBy == "Author")
                {
                    foreach (Reference reference in searchedReferences)
                    {
                      
                      
                        searchedReferences = SortingAlgorithms.SelectionSorter.SelectionSort(searchedReferences);
                        foundReference.Add(BinarySearcher.BinarySearch(searchedReferences, searchText, CurrentExperience.SortBy));

                        

                    }
                    
                    else
                    {
                        searchedReferences = SortingAlgorithms.InsertionSorter.InsertionSort(searchedReferences);
                        foundReference.Add(BinarySearcher.BinarySearch(searchedReferences, searchText, CurrentExperience.SortBy));
                    }

                }
                else
                {
                    //Do linear Searching only search for what the user has chosen to sort with, no sorting is required here
                  
                  

                        foreach (Reference reference in searchedReferences)
                        {
                            reference.Creator = Reference.GetCreator(reference);

                        }
                        foundReference.Add(LinearSearcher.LinearSearch(searchedReferences, searchText, CurrentExperience.SortBy));

                List<Creator> searchedArtists = (from creators in searchedReferencesContext.Creators
                                              where creators.FirstName.Contains(TextBoxSearchBar.Text.ToString())
                                              || creators.LastName.Contains(TextBoxSearchBar.Text.ToString())
                                              select creators).ToList();

                //Clear the contents of the default search display
                PanelArtistsSection.Controls.Remove(resultsGridArtists);
                PanelArtworksSection.Controls.Remove(resultsGridArtworks);

                //Create a ResultsGrid object from the list of Users.
                resultsGridArtists = new ResultsGrid(searchedCreators);
                //Add the ResultsGrid object to PanelArtistsSection.
                UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

                //Create a ResultsGrid object from the list of VisualArts.
                resultsGridArtworks = new ResultsGrid(foundReference);
                //Add the ResultsGrid object to PanelArtworksSection.
                UserExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);



            }
        }
    }
}
