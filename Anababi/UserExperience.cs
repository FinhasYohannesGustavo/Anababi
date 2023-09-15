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
using Anababi.Data;
using Anababi.UserControls.AdminControls;

namespace Anababi
{
    public partial class UserExperience : UserControl
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

            LblFullName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.Username}";
            LblUsername.CenterHorizontally();

            //Set the image of the profile picture from the currentUser.
            Image ProfileImage = ByteArrayToImage(currentUser.ProfilePic);

            guna2CirclePictureBoxProfilePic.Image = ProfileImage;

            currentUser.IsAdmin= true;
            //Create a new navigation panel depending on whether or not the use is an admin.
            if (currentUser.IsAdmin)
            {
                AddToPanel(new AdminNavigationalPanel(), SplitContainerAll.Panel1);

                AddToPanelContent(new MyFeedPage(GetDummyReferences()));

            }
            else
            {
                AddToPanel(new ConsumerNavigationPanel(), SplitContainerAll.Panel1);

                AddToPanelContent(new MyFeedPage(GetDummyReferences()));

            }
            


        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static User GetUserByUserName(string username) 
        {
            AnababiContext anababiContext = new AnababiContext();
            return anababiContext.Users.SingleOrDefault(user => user.Username == username);
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

        public static void CreateCenterDisplayForReference(Reference reference, Panel panelContent)
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
        public static void CreateCenterDisplayForCreator(Creator creator, Panel panelContent)
        {
            //Create CenterDisplay object.
            PhysicalReferenceCenterDisplay centerDisplay = new PhysicalReferenceCenterDisplay(creator);

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
        public static List<Button> CreateButtonsFromReferences(List<Reference> references)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < references.Count(); i++)
            {
                Button button = new Button();
                Image buttonImage = ByteArrayToImage(references[i].CoverImage);
                button.BackgroundImage = buttonImage;
                button.BackgroundImageLayout = ImageLayout.Tile;
                button.Text = "";
                button.Tag = references[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        //Get a list of Buttons from a list of Users(Artists).
        public static List<Button> CreateButtonsFromCreators(List<Creator> creators)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < creators.Count(); i++)
            {
                Button button = new Button();

                Image buttonImage = ByteArrayToImage(creators[i].ProfilePic);
                button.BackgroundImage = buttonImage;
                button.BackgroundImageLayout = ImageLayout.Tile;
                button.Text = "";
                button.Tag = creators[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        public static List<CategoryTemplateDisplay> GetCategoriesFromReferences(List<Reference> references)
        {
            //Create a empty list of CategoryTemplateDisplay objects.
            List<CategoryTemplateDisplay> categories = new List<CategoryTemplateDisplay>();

            //Create a list of objects to store the genres found in the VisualArts sent.
            List<String> genres = new List<String>();

            //Identify all the genres in the list
            foreach (Reference r in references)
            {
                //Add each genre to the genres list.
                genres.Add(r.Genre.ToString());
            }
            //Remove duplicate genres.
            genres = genres.Distinct().ToList();

            //Create one CategoryTemplateDisplay for each genre
            foreach (String genre in genres)
            {
                //Create a list of References that are of the specific genre.
                List<Reference> visualsOfGenre = references.FindAll(book => book.Genre.ToString() == genre);
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
                Id = 1,
                Title = "1984",
                Genre = Reference.ReferenceGenre.Fiction,
                Description = "\"1984\" is a classic dystopian novel written by George Orwell. Set in a totalitarian society, it follows the story of Winston Smith as he rebels against the oppressive regime ruled by Big Brother.",
                PublishedOn = new DateTime(1949, 6, 8),
                CoverImage = ImageToByteArray(Resources._1984)
            };
            

            Reference book2 = new Reference
            {
                Id = 2,
                Title = "Pride and Prejudice",
                Genre = Reference.ReferenceGenre.Romance,
                Description = "\"Pride and Prejudice\" is a beloved romance novel by Jane Austen. Set in 19th-century England, it revolves around the spirited Elizabeth Bennet and her complex relationship with the proud Mr. Darcy.",
                PublishedOn = new DateTime(1813, 1, 28),
                CoverImage = ImageToByteArray(Resources.prideAndPrejudice)
            };

            Reference book3 = new Reference
            {
                Id = 3,
                Title = "The Hobbit",
                Genre = Reference.ReferenceGenre.Fantasy,
                Description = "\"The Hobbit\" is a fantasy adventure novel by J.R.R. Tolkien. It follows the journey of Bilbo Baggins, a hobbit who is swept into an epic quest to reclaim the dwarves' homeland from the dragon Smaug.",
                PublishedOn = new DateTime(1937, 9, 21),
                CoverImage = ImageToByteArray(Resources.theHobbit)
            };

            // Creating objects for the remaining references in a similar manner

            Reference book4 = new Reference
            {
                Id = 4,
                Title = "To Kill a Mockingbird",
                Genre = Reference.ReferenceGenre.Romance,
                Description = "\"To Kill a Mockingbird\" is a poignant coming-of-age novel by Harper Lee. Set in the racially charged atmosphere of 1930s Alabama, it explores themes of racial injustice, morality, and the loss of innocence through the eyes of Scout Finch.",
                PublishedOn = new DateTime(1960, 7, 11),
                CoverImage = ImageToByteArray(Resources.toKillAMockingBird)
            };

            Reference book5 = new Reference
            {
                Id = 5,
                Title = "The Da Vinci Code",
                Genre = Reference.ReferenceGenre.Thriller,
                Description = "\"The Da Vinci Code\" is a gripping thriller by Dan Brown. The story follows symbologist Robert Langdon as he unravels a mystery involving religious symbolism, secret societies, and hidden codes.",
                PublishedOn = new DateTime(2003, 3, 18),
                CoverImage = ImageToByteArray(Resources.theDavinciCode)
            };

            Reference book6 = new Reference
            {
                Id = 6,
                Title = "The Great Gatsby",
                Genre = Reference.ReferenceGenre.Fiction,
                Description = "\"The Great Gatsby\" is a literary masterpiece by F. Scott Fitzgerald. Set in the Roaring Twenties, it explores the glamorous and decadent lifestyle of the wealthy elite, as seen through the eyes of the enigmatic Jay Gatsby.",
                PublishedOn = new DateTime(1925, 4, 10),
                CoverImage = ImageToByteArray(Resources.theGreatGatsby)
            };

            Reference book7 = new Reference
            {
                Id = 7,
                Title = "The Hunger Games",
                Genre = Reference.ReferenceGenre.ScienceFiction,
                Description = "\"The Hunger Games\" is a thrilling young adult science fiction novel by Suzanne Collins. Set in a dystopian future, it follows the story of Katniss Everdeen as she participates in a brutal televised competition where teenagers fight to the death.",
                PublishedOn = new DateTime(2008, 9, 14),
                CoverImage = ImageToByteArray(Resources.theHungerGames)
            };

            Reference book8 = new Reference
            {
                Id = 8,
                Title = "Gone Girl",
                Genre = Reference.ReferenceGenre.Thriller,
                Description = "\"Gone Girl\" is a gripping psychological thriller by Gillian Flynn. It revolves around the disappearance of Amy Dunne and the suspicion that falls on her husband, Nick.",
                PublishedOn = new DateTime(2012, 6, 5),
                CoverImage = ImageToByteArray(Resources.goneGirl)
            };

            Reference book9 = new Reference
            {
                Id = 9,
                Title = "Sapiens: A Brief History of Humankind",
                Genre = Reference.ReferenceGenre.NonFiction,
                Description = "\"Sapiens: A Brief History of Humankind\" is a thought-provoking non-fiction book by Yuval Noah Harari. It provides an overview of human history, from the emergence of Homo sapiMy apologies, it seems the code got cut off. Here's the continuation:",
                PublishedOn = new DateTime(2011, 2, 10),
                CoverImage = ImageToByteArray(Resources.sapiens)
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
        public static List<Creator> GetCreators()
        {
            List<Creator> creators = new List<Creator>();
            //populate the creators list from database fetch using Anababi Context
            return creators;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            AddToPanelContent(new SearchDisplay());
        }

        #endregion

    }



    }

