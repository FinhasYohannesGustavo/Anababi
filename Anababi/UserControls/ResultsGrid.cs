using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Anababi.ModelClasses;

namespace Anababi.UserControls
{
    //An enumeration for holding the type of data to be displayed by the ResultsGrid.
    enum TypeOfDataToBeDisplayed
    {
        Reference,
        Creator
    }
    public partial class ResultsGrid : UserControl
    {
        private List<Button>? buttonList;
        private List<Creator>? writers;
        private List<Reference>? visuals;
        private TypeOfDataToBeDisplayed typeOfDataToBeDisplayed;
        public ResultsGrid(List<Creator> toBeDisplayed)
        {
            InitializeComponent();
            writers = toBeDisplayed;
            //Set the typeOfDataToBeDisplayed property to Creator.
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.Creator;
        }
        public ResultsGrid(List<Reference> toBeDisplayed)
        {
            InitializeComponent();
            visuals = toBeDisplayed;
            //Set the typeOfDataToBeDisplayed property to Reference.
            typeOfDataToBeDisplayed = TypeOfDataToBeDisplayed.Reference;
        }

        private void ResultsGrid_Load(object sender, EventArgs e)
        {
            PopulateResultsGrid();
        }
        private void PopulateResultsGrid()
        {
            //If the object created was not empty
            if (visuals != null || writers != null)
            {
                //Check which constructor was used to create the object
                if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.Reference)
                {
                    //VisualArts were sent
                    //Use the ConsumerExperience.CreateButtonsFromReferences() function to create Buttons from Reference objects.
                    buttonList = UserExperience.CreateButtonsFromReferences(visuals);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific visual art with the button to make the Artist accessible in the event
                        buttonList[i].Tag = visuals[i];
                    }
                }
                else
                {
                    //Users were sent
                    //Use the ConsumerExperience.CreateButtonsFromReferences() function to create Buttons from Creator objects.
                    buttonList = UserExperience.CreateButtonsFromCreators(writers);
                    for (int i = 0; i < buttonList.Count(); i++)
                    {
                        //Associate the specific Artist with the button to make the Artist accessible in the event
                        buttonList[i].Tag = writers[i];
                    }
                }

                for (int i = 0; i < buttonList.Count(); i++)
                {
                    //Adding the buttonResult_Click event to the button's list of events
                    buttonList[i].Click += new System.EventHandler(buttonResult_Click);
                    //Defining the minimum size of the button to avoid unnecessary shrinking
                    buttonList[i].MinimumSize = new Size(250, 200);
                    //Adding the button to the table layout panel
                    tableLayoutPanelResults.Controls.Add(buttonList[i]);
                    //Setting the button's Dock property to Fill (so that it can occupy all the space in the cell)
                    buttonList[i].Dock = DockStyle.Fill;
                    //Adding space between each button by defining its margin
                    buttonList[i].Margin = new Padding(5, 5, 5, 5);
                }

            }

        }
        //Event that is associated with all artwork or writer buttons.
        //It displays the writer or the artwork in the center of the screen.
        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Get the PanelContent that is found in ConsumerExperience
            Panel requiredPanel = (Panel)(this.FindForm().Controls.Find("PanelContent", true)[0]);

            Button btn = (Button)sender;
            if (typeOfDataToBeDisplayed == TypeOfDataToBeDisplayed.Reference)
            {
                //VisualArts were sent
                //Code for extracting a Reference object from a button
                Reference reference = (Reference)btn.Tag;

                //Create a center display for the visual art
                //UserExperience.CreateCenterDisplayForArt(Reference, requiredPanel);
                CenterDisplayForm popup = new CenterDisplayForm(reference);
                popup.Show();
            }
            else
            {
                //Users were sent
                //Code for extracting a Creator object from a button
                Creator writer = (Creator)btn.Tag;

                //Create a center display for the writer
                UserExperience.CreateCenterDisplayForCreator(writer, requiredPanel);
            }

        }
    }
}
