using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anababi.ModelClasses;
using Anababi.Properties;
using Anababi.UserControls;

namespace Anababi
{
    internal partial class UserExperience : UserControl
    {
        public static User currentUser = null!;

        public UserExperience(User ekele)
        {
            InitializeComponent();
            currentUser = ekele;
        }

        #region Custom Methods

        private void LoadUserExperience()
        {
            //Set the text property of the labels for  FullName and Username and center them horizontally.

            LblFullName.Text = currentUser.firstName + " " + currentUser.lastName;
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.username}";
            LblUsername.CenterHorizontally();

            //Set the image of the profile picture from the currentUser.
            Image ProfileImage = byteArrayToImage(currentUser.profilePic);

            guna2CirclePictureBoxProfilePic.Image = ProfileImage;

            //Create a new ConsumerExperienceNavButtons object and add it to the navigation panel.
            AddToPanel(new ConsumerNavigationPanel(), SplitContainerAll.Panel1);

            AddToPanelContent(new MyFeedPage(GetDummyReferences()));


        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void AddToPanel(Control c, Panel panel)
        {
            //Add control to panel.
            panel.Controls.Add(c);
            //Set Dock property of control to Fill.
            c.Dock = DockStyle.Fill;
            //Set AutoSize of control property to true.
            c.AutoSize = true;
            //Set backcolor of control to transparent.
            c.BackColor = System.Drawing.Color.Transparent;
            //Bring the control to the front.
            c.BringToFront();
        }

        public static void CreateCenterDisplayForArt(Reference reference, Panel panelContent)
        {
            //Create CenterDisplay object.
            ReferenceCenterDisplay centerDisplay = new ReferenceCenterDisplay(reference);

            //Set the paddding to 10 % of the panel's dimensions (x and y)
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            //Set the Dock property to Fill.
            centerDisplay.Dock = DockStyle.Fill;

            //Add the CenterDisplay to the panel and bring it to the front.
            panelContent.Controls.Add(centerDisplay);   
            centerDisplay.BringToFront();
        }

        //Create a center display for an Artist.
        public static void CreateCenterDisplayForWriter(Creator writer, Panel panelContent)
        {
            //Create CenterDisplay object.
            WriterCenterDisplay centerDisplay = new WriterCenterDisplay(writer);

            //Set the padding to 10% of the panel's dimensions
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            //Set the Dock property to Fill.
            centerDisplay.Dock = DockStyle.Fill;

            //Add the CenterDisplay to the panel and bring it to the front.
            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();

        }

        //Get a list of Buttons from a list of VisualArts.
        public static List<Button> CreateButtonsFromVisualArtworks(List<Reference> references)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < references.Count(); i++)
            {
                Button button = new Button();
                Image buttonImage = byteArrayToImage(references[i].coverImage);
                button.BackgroundImage = buttonImage;
                button.BackgroundImageLayout = ImageLayout.Tile;
                button.Text = "";
                button.Tag = references[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        //Get a list of Buttons from a list of Users(Artists).
        public static List<Button> CreateButtonsFromCreators(List<Creator> wirter)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < wirter.Count(); i++)
            {
                Button button = new Button();

                Image buttonImage = byteArrayToImage(wirter[i].profilePic);
                button.BackgroundImage = buttonImage;
                button.BackgroundImageLayout = ImageLayout.Tile;
                button.Text = "";
                button.Tag = wirter[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        public static List<CategoryTemplateDisplay> GetCategoriesFromReferences(List<Reference> books)
        {
            //Create a empty list of CategoryTemplateDisplay objects.
            List<CategoryTemplateDisplay> categories = new List<CategoryTemplateDisplay>();

            //Create a list of objects to store the genres found in the VisualArts sent.
            List<String> genres = new List<String>();

            //Identify all the genres in the list
            foreach (Reference r in books)
            {
                //Add each genre to the genres list.
                genres.Add(r.referenceGenre.ToString());
            }
            //Remove duplicate genres.
            genres = genres.Distinct().ToList();

            //Create one CategoryTemplateDisplay for each genre
            foreach (String genre in genres)
            {
                //Create a list of References that are of the specific genre.
                List<Reference> visualsOfGenre = books.FindAll(book => book.referenceGenre.ToString() == genre);
                //Create a CategoryTemplateDisplay object for this genre based on the selected visuals.
                CategoryTemplateDisplay categoryTemplateDisplay = new CategoryTemplateDisplay(genre.ToString(), visualsOfGenre);
                //Add the CategoryTemplateDisplay object to the categories list.
                categories.Add(categoryTemplateDisplay);
            }

            return categories;
        }
        
        private void BtnNavigation_Click(object sender, EventArgs e)
        {
            if (SplitContainerAll.Panel1.Visible == true)
            {
                SplitContainerAll.Panel1.Hide();
                SplitContainerAll.Panel2.Dock = DockStyle.Fill;
            }
            else
            {
                SplitContainerAll.Panel1.Show();
                SplitContainerAll.Panel2.Dock = DockStyle.None;
            }
        }

        public static List<Reference> GetDummyReferences()
        {
            List<Reference> references= new List<Reference>();
            Reference book1 = new Reference
            {
                id = 1,
                title = "1984",
                referenceGenre = Reference.ReferenceGenre.Fiction,
                description = "\"1984\" is a classic dystopian novel written by George Orwell. Set in a totalitarian society, it follows the story of Winston Smith as he rebels against the oppressive regime ruled by Big Brother.",
                publishedOn = new SqlDateTime(1949, 6, 8),
                coverImage = ImageToByteArray(Resources._1984)
            };
            

            Reference book2 = new Reference
            {
                id = 2,
                title = "Pride and Prejudice",
                referenceGenre = Reference.ReferenceGenre.Romance,
                description = "\"Pride and Prejudice\" is a beloved romance novel by Jane Austen. Set in 19th-century England, it revolves around the spirited Elizabeth Bennet and her complex relationship with the proud Mr. Darcy.",
                publishedOn = new SqlDateTime(1813, 1, 28),
                coverImage = ImageToByteArray(Resources.prideAndPrejudice)
            };

            Reference book3 = new Reference
            {
                id = 3,
                title = "The Hobbit",
                referenceGenre = Reference.ReferenceGenre.Fantasy,
                description = "\"The Hobbit\" is a fantasy adventure novel by J.R.R. Tolkien. It follows the journey of Bilbo Baggins, a hobbit who is swept into an epic quest to reclaim the dwarves' homeland from the dragon Smaug.",
                publishedOn = new SqlDateTime(1937, 9, 21),
                coverImage = ImageToByteArray(Resources.theHobbit)
            };

            // Creating objects for the remaining books in a similar manner

            Reference book4 = new Reference
            {
                id = 4,
                title = "To Kill a Mockingbird",
                referenceGenre = Reference.ReferenceGenre.Romance,
                description = "\"To Kill a Mockingbird\" is a poignant coming-of-age novel by Harper Lee. Set in the racially charged atmosphere of 1930s Alabama, it explores themes of racial injustice, morality, and the loss of innocence through the eyes of Scout Finch.",
                publishedOn = new SqlDateTime(1960, 7, 11),
                coverImage = ImageToByteArray(Resources.toKillAMockingBird)
            };

            Reference book5 = new Reference
            {
                id = 5,
                title = "The Da Vinci Code",
                referenceGenre = Reference.ReferenceGenre.Thriller,
                description = "\"The Da Vinci Code\" is a gripping thriller by Dan Brown. The story follows symbologist Robert Langdon as he unravels a mystery involving religious symbolism, secret societies, and hidden codes.",
                publishedOn = new SqlDateTime(2003, 3, 18),
                coverImage = ImageToByteArray(Resources.theDavinciCode)
            };

            Reference book6 = new Reference
            {
                id = 6,
                title = "The Great Gatsby",
                referenceGenre = Reference.ReferenceGenre.Fiction,
                description = "\"The Great Gatsby\" is a literary masterpiece by F. Scott Fitzgerald. Set in the Roaring Twenties, it explores the glamorous and decadent lifestyle of the wealthy elite, as seen through the eyes of the enigmatic Jay Gatsby.",
                publishedOn = new SqlDateTime(1925, 4, 10),
                coverImage = ImageToByteArray(Resources.theGreatGatsby)
            };

            Reference book7 = new Reference
            {
                id = 7,
                title = "The Hunger Games",
                referenceGenre = Reference.ReferenceGenre.ScienceFiction,
                description = "\"The Hunger Games\" is a thrilling young adult science fiction novel by Suzanne Collins. Set in a dystopian future, it follows the story of Katniss Everdeen as she participates in a brutal televised competition where teenagers fight to the death.",
                publishedOn = new SqlDateTime(2008, 9, 14),
                coverImage = ImageToByteArray(Resources.theHungerGames)
            };

            Reference book8 = new Reference
            {
                id = 8,
                title = "Gone Girl",
                referenceGenre = Reference.ReferenceGenre.Thriller,
                description = "\"Gone Girl\" is a gripping psychological thriller by Gillian Flynn. It revolves around the disappearance of Amy Dunne and the suspicion that falls on her husband, Nick.",
                publishedOn = new SqlDateTime(2012, 6, 5),
                coverImage = ImageToByteArray(Resources.goneGirl)
            };

            Reference book9 = new Reference
            {
                id = 9,
                title = "Sapiens: A Brief History of Humankind",
                referenceGenre = Reference.ReferenceGenre.NonFiction,
                description = "\"Sapiens: A Brief History of Humankind\" is a thought-provoking non-fiction book by Yuval Noah Harari. It provides an overview of human history, from the emergence of Homo sapiMy apologies, it seems the code got cut off. Here's the continuation:",
                publishedOn = new SqlDateTime(2011, 2, 10),
                coverImage = ImageToByteArray(Resources.sapiens)
            };
            references.Add(book9);
            references.Add(book8);
            references.Add(book7);
            references.Add(book6);
            references.Add(book5);
            references.Add(book4);
            references.Add(book3);
            references.Add(book2);
            references.Add(book1);

            return references;
        }
        public void AddToPanelContent(UserControl userControl)
        {
            //Remove all the controls from PanelContent.
            PanelContent.Controls.Clear();
            //Add the UserControl object to the panel.
            PanelContent.Controls.Add(userControl);
            //Set the Dock property to Fill.
            userControl.Dock = DockStyle.Fill;
            //Bring the UserControl to the front.
            userControl.BringToFront();
        }

        #endregion

        #region Events
        private void UserExperience_Load(object sender, EventArgs e)
        {
            LoadUserExperience();
        }

        #endregion

    }



    }

