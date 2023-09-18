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
    public partial class CreatorCenterDisplay : UserControl
    {
        Creator creator;
        public CreatorCenterDisplay(Creator creator)
        {
            InitializeComponent();
            this.creator = creator;

            textBoxWorks.Enabled = false;
        }


        private void CreatorCenterDisplay_Load(object sender, EventArgs e)
        {
            LblCreatorName.Text = creator.GetFullName();
            LblCreatorName.TextAlign = ContentAlignment.MiddleCenter;
            List<Reference> referencesOfCreator = creator.GetReferencesCreated();
            int count = referencesOfCreator.Count();
            for (int i = 0; i < count - 1; i++)
            {
                textBoxWorks.Text += referencesOfCreator[i].Title;
                textBoxWorks.Text += ", ";

            }
            textBoxWorks.Text += referencesOfCreator[count - 1].Title;
            textBoxWorks.ReadOnly = true;

            pictureBoxCoverImage.BackgroundImage = UserExperience.ByteArrayToImage(creator.ProfilePic);
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artwork to be viewed.
            this.Hide();
        }

    }
}
