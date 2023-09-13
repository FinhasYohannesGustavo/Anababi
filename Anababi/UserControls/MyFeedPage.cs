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
    internal partial class MyFeedPage : UserControl
    {
        List<Reference> references;
        public MyFeedPage(List<Reference> references)
        {
            InitializeComponent();
            this.references = references;
        }

        private void MyFeedPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the references that are specific to the user
            references = UserExperience.GetDummyReferences();


            //Get a list of categories based on the visual references sent
            List<CategoryTemplateDisplay> categories = UserExperience.GetCategoriesFromReferences(references);

            //Add each category to the table layout panel
            foreach (CategoryTemplateDisplay c in categories)
            {
                UserExperience.AddToPanel(c, tableLayoutPanelAllArtworks);
            }

        }
    }
}
