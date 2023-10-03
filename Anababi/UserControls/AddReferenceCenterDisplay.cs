using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anababi.UserControls
{
    public partial class AddReferenceCenterDisplay : UserControl
    {
        public AddReferenceCenterDisplay()
        {
            InitializeComponent();
        }

        private void ComboBoxDiscriminator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBoxDiscriminator!= null&&ComboBoxDiscriminator.SelectedItem=="Digital Reference") { 
                this.textBoxFloor.Visible= false;
                this.textBoxShelf.Visible= false;
                this.textBoxSection.Visible= false;
                this.textBoxNumOfCopies.Visible= false;

                this.LblAvailable.Visible= false;
                this.LblFloor.Visible= false;
                this.LblShelf.Visible= false;
                this.LblSection.Visible= false;
                this.LblAvailable.Visible= false;
                this.LblNumOfCopies.Visible= false;

                this.checkBoxAvailable.Visible= false;
            }
            else
            {
                if (ComboBoxDiscriminator != null)
                {
                    this.textBoxFloor.Visible = true;
                    this.textBoxShelf.Visible = true;
                    this.textBoxSection.Visible = true;
                    this.textBoxNumOfCopies.Visible = true;

                    this.LblAvailable.Visible = true;
                    this.LblFloor.Visible = true;
                    this.LblShelf.Visible = true;
                    this.LblSection.Visible = true;
                    this.LblAvailable.Visible = true;
                    this.LblNumOfCopies.Visible = true;

                    this.checkBoxAvailable.Visible = true;

                }
            }
        }
    }
}
