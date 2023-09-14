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
            List<Creator> creators = UserExperience.GetCreators();
            //Create a ResultsGrid object from the list of Users.
            resultsGridArtists = new ResultsGrid(creators);
            //Add the ResultsGrid object to PanelArtistsSection.
            UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

            //This will be replaced by a database fetch of a list of the recent searches the user made.
            List<Reference> references = UserExperience.GetDummyReferences();
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

                AnababiContext searchedReferencesContext = new AnababiContext();
                List<Reference> searchedArts = (from references in searchedReferencesContext.References
                                                where references.Description.Contains(TextBoxSearchBar.Text.ToString())
                                                || references.Title.Contains(TextBoxSearchBar.Text.ToString())
                                                select references).ToList();

                List<Creator> searchedArtists = (from creators in searchedReferencesContext.Creators
                                              where creators.FirstName.Contains(TextBoxSearchBar.Text.ToString())
                                              || creators.LastName.Contains(TextBoxSearchBar.Text.ToString())
                                              select creators).ToList();

                //Clear the contents of the default search display
                PanelArtistsSection.Controls.Remove(resultsGridArtists);
                PanelArtworksSection.Controls.Remove(resultsGridArtworks);

                //Create a ResultsGrid object from the list of Users.
                resultsGridArtists = new ResultsGrid(searchedArtists);
                //Add the ResultsGrid object to PanelArtistsSection.
                //UserExperience.AddToPanel(resultsGridArtists, PanelArtistsSection);

                //Create a ResultsGrid object from the list of VisualArts.
                resultsGridArtworks = new ResultsGrid(searchedArts);
                //Add the ResultsGrid object to PanelArtworksSection.
                UserExperience.AddToPanel(resultsGridArtworks, PanelArtworksSection);



            }
        }
    }
}
