using Anababi.UserControls;
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
using Anababi.UserControls;
using Bunifu.Framework.UI;

namespace Anababi
{
    public partial class CenterDisplayForm : Form
    {
        Reference currentReference;
        Form blurForm;
        public CenterDisplayForm(Reference currentReference)
        {

            InitializeComponent();

            this.currentReference = currentReference;

            

            // Set the form as a top-level window
            this.TopLevel = true;
            this.TopMost = true;

            // Make the form semi-transparent
            //this.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Opacity = 1;
            

            // Create a new form for blurring the background
            blurForm = new BunifuForm
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Opacity = 0.75,
                BackColor = Color.Black,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                Size = this.Size
            };

            // Attach an event handler to close the popup form when the blur form is clicked
            blurForm.Click += (sender, e) =>
            {
                blurForm.Close();
                this.Close();
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Show the blur form
            blurForm.Show();

            // Bring the popup form to the front
            this.BringToFront();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Close the blur form when the popup form is closed
            blurForm.Close();
        }

        public void LoadRefrenceCenterDisplay()
        {
            ReferenceCenterDisplay referenceCenterDisplay = new ReferenceCenterDisplay(this.currentReference);

            UserExperience.AddToPanel(referenceCenterDisplay, contentPanel);
            
        }

        private void CenterDisplayForm_Load(object sender, EventArgs e)
        {
            LoadRefrenceCenterDisplay();
        }
    }
}
