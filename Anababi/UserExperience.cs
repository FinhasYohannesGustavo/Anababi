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

namespace Anababi
{
    public partial class UserExperience : UserControl
    {
        public static User currentUser;

        public UserExperience(User ekele)
        {
            InitializeComponent();
            currentUser = ekele;
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

        private void LoadUserExperience()
        {
            //Set the text property of the labels for  FullName and Username and center them horizontally.
            
            LblFullName.Text = currentUser.firstName + " " + currentUser.lastName;
            
            LblUsername.Text = $"@{currentUser.username}";
            //LblUsername.CenterHorizontally();

            //Set the image of the profile picture from the currentUser.
            Image ProfileImage = byteArrayToImage(currentUser.profilePic);


            guna2CirclePictureBoxProfilePic.Image = ProfileImage;

           
                //Create a new ConsumerExperienceNavButtons object and add it to the navigation panel.
                AddToPanel(new ConsumerNavigationPanel(), SplitContainerAll.Panel1);

              
            }
        private void UserExperience_Load(object sender, EventArgs e)
        {
            LoadUserExperience();
        }

    }



    }

