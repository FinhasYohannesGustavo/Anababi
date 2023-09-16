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

namespace Anababi.UserControls.AdminControls
{
    internal partial class AdminNavigationalPanel : UserControl
    {
        UserExperience CurrentExperience = null!;
        public AdminNavigationalPanel()
        {
            InitializeComponent();
        }
        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            //database fetch for the specific feed of this user
            List<Reference> arts = Reference.GetAllReferencesFromDB();

            CurrentExperience.AddToPanelContent(new MyFeedPage(arts, CurrentExperience.SortBy));
        }
        private void BtnTopCreators_Click(object sender, EventArgs e)
        {
            CurrentExperience.AddToPanelContent(new TopCreatorsPage());
        }
        private void BtnTopReferences_Click(object sender, EventArgs e)
        {
            CurrentExperience.AddToPanelContent(new TopReferencesPage(CurrentExperience.SortBy));
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            CurrentExperience.AddToPanelContent(new SettingsPage());
        }
        private void ConsumerExperienceNavButtons_Load(object sender, EventArgs e)
        {
            //Get the current UserExperience.
            CurrentExperience = (this.FindForm().Controls.Find("UserExperience", true)[0]) as UserExperience;
        }

    }
}
