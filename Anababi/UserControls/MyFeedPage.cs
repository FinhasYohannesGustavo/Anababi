using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.ModelClasses;

namespace Anababi.UserControls
{
    public partial class MyFeedPage : UserControl
    {
        List<Reference> References;
        String SortBy;
        public MyFeedPage(List<Reference> references,String SortBy)
        {
            InitializeComponent();
            this.References = references;
            this.SortBy = SortBy;

        }

        private void MyFeedPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the References that are specific to the user
            References = Reference.GetAllReferencesFromDB();

           
            //Get a list of categories based on the visual References sent
            List<CategoryTemplateDisplay> categories = UserExperience.GetCategoriesFromReferences(References,this.SortBy);

            //Add each category to the table layout panel
            foreach (CategoryTemplateDisplay c in categories)
            {
                UserExperience.AddToPanel(c, tableLayoutPanelAllReferences);
            }

        }
    }
}
