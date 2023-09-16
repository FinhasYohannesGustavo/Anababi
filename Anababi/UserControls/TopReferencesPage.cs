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
    public partial class TopReferencesPage : UserControl
    {
    String SortBy;
    List<Reference>? References;
    public TopReferencesPage(String SortBy)
    {
        this.SortBy = SortBy;
        InitializeComponent();
    }

    private void TopBooksPage_Load(object sender, EventArgs e)
    {
        //This will be replaced by a database fetch for the books that are considered the top books.
        References = UserExperience.GetDummyReferences();


        //Possible algorithm for picking the top ranking artworks
        //ConsumerExperience.GetDummyArts().FindAll(top => top.Analytics[0] > 500);

        //Get a list of categories based on the visual arts sent
        List<CategoryTemplateDisplay> categories = UserExperience.GetCategoriesFromReferences(References,SortBy);

        //Add each category to the table layout panel
        foreach (CategoryTemplateDisplay c in categories)
        {
            UserExperience.AddToPanel(c, tableLayoutPanelAllArtworks);
        }
    }
}
}
