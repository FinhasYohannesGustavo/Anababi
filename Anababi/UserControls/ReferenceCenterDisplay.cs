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
    internal partial class ReferenceCenterDisplay : UserControl
    {
        Reference Reference;
        public ReferenceCenterDisplay(Reference reference)

        {
            InitializeComponent();
            this.Reference = reference;
        }

    private void CenterDisplay_Load(object sender, EventArgs e)
    {
        //Set the label representing the Title of the artwork.
        //LblArtworkTitle.Text = Art.Title;


        //Set the background image of the artPage (tab in the TabControl) to the image of the VisualArt.
        Image artPageImage = UserExperience.byteArrayToImage(Reference.CoverImage);
        //artPage.BackgroundImage = artPageImage;
        //Set the layout of the background image of the artPage.
        //artPage.BackgroundImageLayout = ImageLayout.Zoom;
        //Set the text of the TextBox representing the Description of the art.
        //textBoxDescription.Text = Reference.Description;

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
