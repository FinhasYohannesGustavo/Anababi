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
        }

      
        private void CreatorCenterDisplay_Load(object sender, EventArgs e)
        {
            LblFirstName.Text = creator.FirstName;
            lblLastName.Text = creator.LastName;
            List<Reference> referencesOfCreator = creator.GetReferencesCreated();
            int count = referencesOfCreator.Count();
            for(int i = 0; i<count - 1; i++) 
            {
                textBoxWorks.Text += referencesOfCreator[i].Title;
                textBoxWorks.Text += ", ";
                
            }
            textBoxWorks.Text += referencesOfCreator[count - 1].Title;
            textBoxWorks.ReadOnly = true;

            pictureBoxCoverImage.Image = UserExperience.ByteArrayToImage(creator.ProfilePic);
        }

    }
}
