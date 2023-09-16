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
using Anababi.Properties;
using Anababi.UserControls;
using Anababi.Data;
using Anababi.UserControls.AdminControls;
using static Anababi.ModelClasses.PhysicalReference;
using Anababi.ModelClasses;
using Anababi.SortingAlgorithms;

namespace Anababi
{
    public partial class UserExperience : UserControl
    {
        public static User currentUser = null!;
        public String SortBy;

        public UserExperience(User ekele)
        {
            InitializeComponent();
            currentUser = ekele;
        }

        #region Custom Methods

        internal void LoadUserExperience(String sortBy)
        {
            //Set the text property of the labels for  FullName and Username and center them horizontally.

            LblFullName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.Username}";
            LblUsername.CenterHorizontally();
            this.SortBy = sortBy;

            //Set the image of the profile picture from the currentUser.
            Image ProfileImage = ByteArrayToImage(currentUser.ProfilePic);

            guna2CirclePictureBoxProfilePic.Image = ProfileImage;
            
            
            //Create a new navigation panel depending on whether or not the user is an admin.
            if (currentUser.IsAdmin)
            {
                AddToPanel(new ConsumerNavigationPanel(), SplitContainerAll.Panel1);

                AddToPanelContent(new MyFeedPage(Reference.GetAllReferencesFromDB(),sortBy));

            }
            else
            {
                AddToPanel(new ConsumerNavigationPanel(), SplitContainerAll.Panel1);

                AddToPanelContent(new MyFeedPage(Reference.GetAllReferencesFromDB(),sortBy));

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
            if (references != null&& references[0]==null)
                return buttonList;
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

        public static List<CategoryTemplateDisplay> GetCategoriesFromReferences(List<Reference> references,String SortBy)
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
                foreach(Reference reference in visualsOfGenre)
                {
                    reference.Creator = Reference.GetCreator(reference);

                }

                //sort each category using the sorter that was given in the combo box
                if (SortBy.Equals("Title"))
                {
                    visualsOfGenre = BubbleSorter.BubbleSort(visualsOfGenre);
                }
                else if (SortBy.Equals("Author")){
                    visualsOfGenre = SelectionSorter.SelectionSort(visualsOfGenre);
                }
                else
                {
                    visualsOfGenre = InsertionSorter.InsertionSort(visualsOfGenre);
                }
                

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

        public static void PopulateDatabaseWithDummyData()
        {
            using (var context = new AnababiContext())
            {
                // Insert creators
                var creators = new List<Creator>
                {
                    new Creator { 
                        FirstName = "William", 
                        LastName = "Shakespeare",
                        ProfilePic = ImageToByteArray(Resources.William_Shakespeare_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Jane", 
                        LastName = "Austen",
                        ProfilePic = ImageToByteArray(Resources.Jane_Austen_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Charles", 
                        LastName = "Dickens",
                        ProfilePic = ImageToByteArray(Resources.Charles_Dickens_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Leo", 
                        LastName = "Tolstoy",
                        ProfilePic = ImageToByteArray(Resources.Leo_Tolstoy_HD_pic)
                    },
                    new Creator { 
                        FirstName = "George", 
                        LastName = "Orwell",
                        ProfilePic = ImageToByteArray(Resources.George_Orwell_HD_pic)
                    },
                    new Creator { 
                        FirstName = "J.K.", 
                        LastName = "Rowling",
                        ProfilePic = ImageToByteArray(Resources.J_K__Rowling_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Mark", 
                        LastName = "Twain",
                        ProfilePic = ImageToByteArray(Resources.Mark_Twain_HD_pic)
                    },
                    new Creator { 
                        FirstName = "F. Scott", 
                        LastName = "Fitzgerald",
                        ProfilePic = ImageToByteArray(Resources.F__Scott_Fitzgerald_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Gabriel García", 
                        LastName = "Márquez",
                        ProfilePic = ImageToByteArray(Resources.Gabriel_García_Márquez_HD_pic)
                    },
                    new Creator { 
                        FirstName = "Harper", 
                        LastName = "Lee",
                        ProfilePic = ImageToByteArray(Resources.Harper_Lee_HD_pic)
                    }
                };
                context.Creators.AddRange(creators);

                // Insert digital references
                var digitalReferences = new List<DigitalReference>
                {
                    new DigitalReference
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        PublishedOn = DateTime.Parse("1997-01-01"),
                        ISBN = "978-0590353427",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Fantasy,
                        Creator = creators[5],
                        CoverImage = ImageToByteArray(Resources.Harry_Potter_and_the_Sorcerer_s_Stone_book_cover_HD),
                        Description = "The first book in the beloved wizarding world saga by J.K. Rowling. Follow the journey of a young wizard, Harry Potter, as he discovers his magical abilities and uncovers the mysteries of his past."
                    },
                    new DigitalReference
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        PublishedOn = DateTime.Parse("2007-01-01"),
                        ISBN = "978-0545139700",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Fantasy,
                        Creator = creators[5],
                        CoverImage = ImageToByteArray(Resources.Harry_Potter_and_the_Deathly_Hallows_book_cover_HD),
                        Description = "The thrilling and epic conclusion to the Harry Potter series. Join Harry, Ron, and Hermione as they face their ultimate challenge: defeating the dark wizard, Voldemort."
                    },
                    new DigitalReference
                    {
                        Title = "The Adventures of Huckleberry Finn",
                        PublishedOn = DateTime.Parse("1884-01-01"),
                        ISBN = "978-0142437179",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Adventure,
                        Creator = creators[6],
                        CoverImage = ImageToByteArray(Resources.The_Adventures_of_Huckleberry_Finn_book_cover_HD),
                        Description = "Mark Twain's timeless American novel that follows the adventures of a young boy, Huckleberry Finn, as he travels down the Mississippi River with his friend Jim, an escaped slave, and explores themes of freedom and morality."
                    },
                    new DigitalReference
                    {
                        Title = "The Adventures of Tom Sawyer",
                        PublishedOn = DateTime.Parse("1876-01-01"),
                        ISBN = "978-0486400778",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Adventure,
                        Creator = creators[6],
                        CoverImage = ImageToByteArray(Resources.The_Adventures_of_Tom_Sawyer_book_cover_HD),
                        Description = "A classic coming-of-age story by Mark Twain, featuring the mischievous Tom Sawyer and his adventures in a small American town along the Mississippi River."
                    },
                    new DigitalReference
                    {
                        Title = "The Great Gatsby",
                        PublishedOn = DateTime.Parse("1925-01-01"),
                        ISBN = "978-0743273565",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[7],
                        CoverImage = ImageToByteArray(Resources.The_Great_Gatsby_book_cover_HD),
                        Description = "F. Scott Fitzgerald's iconic Jazz Age novel that delves into the world of wealth, excess, and the American Dream. Follow the enigmatic Jay Gatsby and his obsession with the elusive Daisy Buchanan."
                    },
                    new DigitalReference
                    {
                        Title = "Tender Is the Night",
                        PublishedOn = DateTime.Parse("1934-01-01"),
                        ISBN = "978-0684801544",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[7],
                        CoverImage = ImageToByteArray(Resources.Tender_Is_the_Night_book_cover_HD),
                        Description = "A novel of decadence and romance by F. Scott Fitzgerald. Explore the lives of the wealthy and glamorous as they grapple with love, ambition, and the consequences of their choices."
                    },
                    new DigitalReference
                    {
                        Title = "One Hundred Years of Solitude",
                        PublishedOn = DateTime.Parse("1967-01-01"),
                        ISBN = "978-0060883287",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Fantasy,
                        Creator = creators[8],
                        CoverImage = ImageToByteArray(Resources.One_Hundred_Years_of_Solitude_book_cover_HD),
                        Description = "Gabriel García Márquez's magical realist masterpiece that tells the multi-generational story of the Buendía family in the fictional town of Macondo. Experience a world where reality and fantasy intertwine."
                    },
                    new DigitalReference
                    {
                        Title = "Love in the Time of Cholera",
                        PublishedOn = DateTime.Parse("1985-01-01"),
                        ISBN = "978-0307389732",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[8],
                        CoverImage = ImageToByteArray(Resources.Love_in_the_Time_of_Cholera_book_cover_HD),
                        Description = "A tale of enduring love by Gabriel García Márquez. Follow the lifelong romance between Florentino Ariza and Fermina Daza amidst the backdrop of Colombia's changing society."
                    },
                    new DigitalReference
                    {
                        Title = "To Kill a Mockingbird",
                        PublishedOn = DateTime.Parse("1960-01-01"),
                        ISBN = "978-0061120084",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Drama,
                        Creator = creators[9],
                        CoverImage = ImageToByteArray(Resources.toKillAMockingBird),
                        Description = "Harper Lee's classic of American literature that explores themes of racial injustice, morality, and compassion in the racially divided town of Maycomb, Alabama."
                    },
                    new DigitalReference
                    {
                        Title = "Go Set a Watchman",
                        PublishedOn = DateTime.Parse("2015-01-01"),
                        ISBN = "978-0062409850",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Drama,
                        Creator = creators[9],
                        CoverImage = ImageToByteArray(Resources.Go_Set_a_Watchman_book_cover_HD),
                        Description = "A follow-up to 'To Kill a Mockingbird' by Harper Lee. Discover the later life of Scout Finch as she returns to her hometown and confronts the complexities of her past and present."
                    }

                };
                context.References.AddRange(digitalReferences);

                // Insert physical reference locations
                var referenceLocations = new List<ReferenceLocation>
                {
                    new ReferenceLocation { Floor = 1, Section = 2, Shelf = 3 },
                    new ReferenceLocation { Floor = 2, Section = 3, Shelf = 4 },
                    new ReferenceLocation { Floor = 2, Section = 4, Shelf = 4 },
                    new ReferenceLocation { Floor = 1, Section = 1, Shelf = 2 },
                    new ReferenceLocation { Floor = 3, Section = 1, Shelf = 2 },
                    new ReferenceLocation { Floor = 2, Section = 2, Shelf = 3 },
                    new ReferenceLocation { Floor = 1, Section = 5, Shelf = 3 },
                    new ReferenceLocation { Floor = 3, Section = 1, Shelf = 1 },
                    new ReferenceLocation { Floor = 4, Section = 2, Shelf = 1 },
                    new ReferenceLocation { Floor = 2, Section = 4, Shelf = 1 }
                };
                context.ReferenceLocations.AddRange(referenceLocations);

                // Insert physical references
                var physicalReferences = new List<PhysicalReference>
                {
                    new PhysicalReference
                    {
                        Title = "Romeo and Juliet",
                        PublishedOn = DateTime.Parse("1597-01-01"),
                        ISBN = "978-0743477116",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[0],
                        CoverImage = ImageToByteArray(Resources.Romeo_and_Juliet_book_cover_HD),
                        Description = "A tragic love story that tells the tale of two young lovers, Romeo and Juliet, whose love defies the feuding families of Verona.",
                        Location = referenceLocations[0],
                        NumOfCopies = 3,
                        Available = true
                    },
                    new PhysicalReference
                    {
                        Title = "Hamlet",
                        PublishedOn = DateTime.Parse("1603-01-01"),
                        ISBN = "978-0743477123",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Drama,
                        Creator = creators[0],
                        CoverImage = ImageToByteArray(Resources.Hamlet_book_cover_HD),
                        Description = "A tragedy about a Danish prince, Hamlet, who seeks revenge against his uncle for murdering his father. It explores themes of madness, revenge, and mortality.",
                        Location = referenceLocations[1],
                        NumOfCopies = 2,
                        Available = true
                    },
                    new PhysicalReference
                    {
                        Title = "Pride and Prejudice",
                        PublishedOn = DateTime.Parse("1813-01-01"),
                        ISBN = "978-1503290567",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[1],
                        CoverImage = ImageToByteArray(Resources.Pride_and_Prejudice_book_cover_HD),
                        Description = "A classic romance novel by Jane Austen that follows the life and love of Elizabeth Bennet and Mr. Darcy amidst societal expectations and prejudices.",
                        Location = referenceLocations[2],
                        NumOfCopies = 5,
                        Available = true
                    },
                    new PhysicalReference
                    {
                        Title = "Sense and Sensibility",
                        PublishedOn = DateTime.Parse("1811-01-01"),
                        ISBN = "978-1503290567",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[1],
                        CoverImage = ImageToByteArray(Resources.Sense_and_Sensibility_book_cover_HD),
                        Description = "Jane Austen's novel about the Dashwood sisters, Elinor and Marianne, as they navigate love and heartbreak in early 19th-century England.",
                        Location = referenceLocations[3],
                        NumOfCopies = 4,
                        Available = false
                    },
                    new PhysicalReference
                    {
                        Title = "Great Expectations",
                        PublishedOn = DateTime.Parse("1861-01-01"),
                        ISBN = "978-1503290567",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Drama,
                        Creator = creators[2],
                        CoverImage = ImageToByteArray(Resources.Great_Expectations_book_cover_HD),
                        Description = "Charles Dickens's coming-of-age novel follows the life of Pip, an orphan who rises through society while facing personal challenges and moral dilemmas.",
                        Location = referenceLocations[4],
                        NumOfCopies = 6,
                        Available = false
                    },
                    new PhysicalReference
                    {
                        Title = "A Tale of Two Cities",
                        PublishedOn = DateTime.Parse("1859-01-01"),
                        ISBN = "978-0486406510",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[3],
                        CoverImage = ImageToByteArray(Resources.A_Tale_of_Two_Cities_book_cover_HD),
                        Description = "Charles Dickens's historical novel set during the tumultuous times of the French Revolution, weaving the stories of characters in London and Paris.",
                        Location = referenceLocations[5],
                        NumOfCopies = 3,
                        Available = true
                    },
                    new PhysicalReference
                    {
                        Title = "War and Peace",
                        PublishedOn = DateTime.Parse("1869-01-01"),
                        ISBN = "978-1400041801",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Historical,
                        Creator = creators[4],
                        CoverImage = ImageToByteArray(Resources.War_and_Peace_book_cover_HD),
                        Description = "Leo Tolstoy's epic Russian novel explores the lives of five aristocratic families during the Napoleonic era, delving into themes of history, love, and destiny.",
                        Location = referenceLocations[6],
                        NumOfCopies = 2,
                        Available = true
                    },
                    new PhysicalReference
                    {
                        Title = "Anna Karenina",
                        PublishedOn = DateTime.Parse("1877-01-01"),
                        ISBN = "978-1853262715",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Romance,
                        Creator = creators[4],
                        CoverImage = ImageToByteArray(Resources.Anna_Karenina_book_cover_HD),
                        Description = "A tragic tale of love and society in Imperial Russia, where Anna Karenina enters a forbidden love affair that leads to personal and societal consequences.",
                        Location = referenceLocations[7],
                        NumOfCopies = 5,
                        Available = false
                    },
                    new PhysicalReference
                    {
                        Title = "1984",
                        PublishedOn = DateTime.Parse("1949-01-01"),
                        ISBN = "978-0451524935",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Dystopian,
                        Creator = creators[5],
                        CoverImage = ImageToByteArray(Resources._1984_book_cover_HD),
                        Description = "George Orwell's dystopian classic set in a totalitarian society where individuality is suppressed, and the government exerts control over every aspect of life.",
                        Location = referenceLocations[8],
                        NumOfCopies = 4,
                        Available = false
                    },
                    new PhysicalReference
                    {
                        Title = "Animal Farm",
                        PublishedOn = DateTime.Parse("1945-01-01"),
                        ISBN = "978-0451526342",
                        Type = Reference.ReferenceType.Book,
                        Genre = Reference.ReferenceGenre.Satire,
                        Creator = creators[5],
                        CoverImage = ImageToByteArray(Resources.Animal_Farm_book_cover_HD),
                        Description = "George Orwell's allegorical novella that satirizes the events leading up to the Russian Revolution of 1917 and the early years of the Soviet Union.",
                        Location = referenceLocations[9],
                        NumOfCopies = 6,
                        Available = true
                    }
                };
                context.References.AddRange(physicalReferences);

                // Insert users
                var users = new List<User>
                {
                    new User
                    {
                        FirstName = "Abebe",
                        LastName = "Kebede",
                        Email = "abebe123@email.com",
                        Username = "abebe123",
                        Password = "password123",
                        IsAdmin = true
                    },
                    new User
                    {
                        FirstName = "Mulu",
                        LastName = "Tadesse",
                        Email = "mulu123@email.com",
                        Username = "mulu123",
                        Password = "mypassword",
                        IsAdmin = true
                    },
                    new User
                    {
                        FirstName = "Sara",
                        LastName = "Girma",
                        Email = "sara123@email.com",
                        Username = "sara123",
                        Password = "letmein",
                        IsAdmin = false
                    },
                    new User
                    {
                        FirstName = "Daniel",
                        LastName = "Alemu",
                        Email = "daniel123@email.com",
                        Username = "daniel123",
                        Password = "12345",
                        IsAdmin = false
                    },
                };
                context.Users.AddRange(users);

                //Add all the references to a single list.
                List<Reference> allReferences = new List<Reference>();
                allReferences.AddRange(physicalReferences);
                allReferences.AddRange(digitalReferences);

                // Insert the library
                var library = new Library { 
                    Name = "Anababi",
                    Members = users,
                    References = allReferences
                };
                context.Libraries.Add(library);
                
                context.SaveChanges();
            }



        }
        public static List<Reference> GetReferences()
        {
            List<Reference> references= new List<Reference>();

            //creating the context object to get a session with the database.
            AnababiContext AnababiContext = new AnababiContext();

            List<Reference> contextReferences = (from reference in AnababiContext.References
                                           select reference).ToList();


            return contextReferences;

        }
        public static List<Creator> GetCreators()
        {
  
            //creating the context object to get a session with the database.
            AnababiContext AnababiContext = new AnababiContext();

            List<Creator> creators = (from creator in AnababiContext.Creators
                                                 select creator).ToList();
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
            LoadUserExperience(this.cmbSort.Text);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            AddToPanelContent(new SearchDisplay());
        }

        #endregion

    }



    }

