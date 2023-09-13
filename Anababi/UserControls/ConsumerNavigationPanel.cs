using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.ModelClasses;

namespace Anababi.UserControls
{
    public partial class ConsumerNavigationPanel : UserControl
    {
        UserExperience currentExperience = null!;
        public ConsumerNavigationPanel()
        {
            InitializeComponent();
        }
        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            //database fetch for the specific feed of this user
            List<Reference> arts = UserExperience.GetDummyReferences();

            currentExperience.AddToPanelContent(new MyFeedPage(arts));
        }
        //private void BtnTopArtists_Click(object sender, EventArgs e)
        //{
        //    currentExperience.AddToPanelContent(new TopArtistsPage());
        //}
        private void BtnTopArtworks_Click(object sender, EventArgs e)
        {
            currentExperience.AddToPanelContent(new TopBooksPage());
        }
     
        //private void BtnSettings_Click(object sender, EventArgs e)
        //{
        //    currentExperience.AddToPanelContent(new SettingsPage());
        //}
        private void ConsumerExperienceNavButtons_Load(object sender, EventArgs e)
        {
            //Get the current UserExperience.
            currentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
        }
    
    }
}
