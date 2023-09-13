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
    internal partial class CategoryTemplateDisplay : UserControl
    {
        public CategoryTemplateDisplay(string categoryName, List<Reference> refrences)
        {
            InitializeComponent();

            //Set the text of the label representing the category Name.
            LblCategoryName.Text = categoryName;

            //Create a new ResultsGrid object from the list of VisualArt objects.
            ResultsGrid resultsGridCategoryResults = new ResultsGrid(refrences);
            //Set the Dock property of the ResultsGrid object.
            resultsGridCategoryResults.Dock = DockStyle.Fill;
            //Set the AutoSize property of the ResultsGrid object.
            resultsGridCategoryResults.AutoSize = true;
            //Add the ResultsGrid object to this UserControl.
            this.Controls.Add(resultsGridCategoryResults);
            //Bring the ResultsGrid object to the front.
            resultsGridCategoryResults.BringToFront();

        }
    }
}
