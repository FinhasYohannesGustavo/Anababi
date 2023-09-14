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

namespace Anababi.UserControls
{
    internal partial class TopCreatorsPage : UserControl
    {
        public TopCreatorsPage()
        {
            InitializeComponent();
        }

        private void TopArtistsPage_Load(object sender, EventArgs e)
        {
            //Will be replaced by a databse fetch of the top writers
            List<Creator> writers = UserExperience.GetCreators();

            //Create results grid of the top writers
            ResultsGrid resultsGrid = new ResultsGrid(writers);

            //Add the results grid to the content panel
            UserExperience.AddToPanel(resultsGrid, PanelContentTopArtists);
        }
    }
}
