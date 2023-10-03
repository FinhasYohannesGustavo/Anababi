using Anababi.Properties;

namespace Anababi.UserControls
{
    partial class AddReferenceCenterDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            LblCreator = new Label();
            LblType = new Label();
            LblGenre = new Label();
            LblPublishedOn = new Label();
            LblISBN = new Label();
            LblDescription = new Label();
            LblDiscriminator = new Label();
            LblFloor = new Label();
            LblSection = new Label();
            LblShelf = new Label();
            LblAvailable = new Label();
            LblNumOfCopies = new Label();
            textBoxCreator = new TextBox();
            comboBoxType = new ComboBox();
            comboBoxGenre = new ComboBox();
            textBoxISBN = new TextBox();
            textBoxDescription = new TextBox();
            ComboBoxDiscriminator = new ComboBox();
            textBoxFloor = new TextBox();
            textBoxSection = new TextBox();
            textBoxShelf = new TextBox();
            textBoxNumOfCopies = new TextBox();
            buttonAdd = new Button();
            textBoxPublishedOn = new TextBox();
            checkBoxAvailable = new CheckBox();
            pictureBoxCoverImage = new PictureBox();
            PanelSearchResults = new Panel();
            panelCoverImageHolder = new Panel();
            PanelSearchBar = new Panel();
            txtTitle = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            PanelSearchResults.SuspendLayout();
            panelCoverImageHolder.SuspendLayout();
            PanelSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel2.Controls.Add(LblCreator, 0, 0);
            tableLayoutPanel2.Controls.Add(LblType, 0, 1);
            tableLayoutPanel2.Controls.Add(LblGenre, 0, 2);
            tableLayoutPanel2.Controls.Add(LblPublishedOn, 0, 3);
            tableLayoutPanel2.Controls.Add(LblISBN, 0, 4);
            tableLayoutPanel2.Controls.Add(LblDescription, 0, 5);
            tableLayoutPanel2.Controls.Add(LblDiscriminator, 0, 7);
            tableLayoutPanel2.Controls.Add(LblFloor, 0, 8);
            tableLayoutPanel2.Controls.Add(LblSection, 0, 9);
            tableLayoutPanel2.Controls.Add(LblShelf, 0, 10);
            tableLayoutPanel2.Controls.Add(LblAvailable, 0, 11);
            tableLayoutPanel2.Controls.Add(LblNumOfCopies, 0, 12);
            tableLayoutPanel2.Controls.Add(textBoxCreator, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBoxType, 1, 1);
            tableLayoutPanel2.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxISBN, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxDescription, 1, 5);
            tableLayoutPanel2.Controls.Add(ComboBoxDiscriminator, 1, 7);
            tableLayoutPanel2.Controls.Add(textBoxFloor, 1, 8);
            tableLayoutPanel2.Controls.Add(textBoxSection, 1, 9);
            tableLayoutPanel2.Controls.Add(textBoxShelf, 1, 10);
            tableLayoutPanel2.Controls.Add(textBoxNumOfCopies, 1, 12);
            tableLayoutPanel2.Controls.Add(buttonAdd, 1, 14);
            tableLayoutPanel2.Controls.Add(textBoxPublishedOn, 1, 3);
            tableLayoutPanel2.Controls.Add(checkBoxAvailable, 1, 11);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(390, 40);
            tableLayoutPanel2.MinimumSize = new Size(600, 400);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 15;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(600, 439);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LblCreator
            // 
            LblCreator.AutoSize = true;
            LblCreator.Dock = DockStyle.Right;
            LblCreator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCreator.Location = new Point(104, 0);
            LblCreator.Name = "LblCreator";
            LblCreator.Size = new Size(82, 33);
            LblCreator.TabIndex = 2;
            LblCreator.Text = "Creator";
            // 
            // LblType
            // 
            LblType.AutoSize = true;
            LblType.Dock = DockStyle.Right;
            LblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblType.Location = new Point(129, 33);
            LblType.Name = "LblType";
            LblType.Size = new Size(57, 34);
            LblType.TabIndex = 1;
            LblType.Text = "Type";
            // 
            // LblGenre
            // 
            LblGenre.AutoSize = true;
            LblGenre.Dock = DockStyle.Right;
            LblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblGenre.Location = new Point(118, 67);
            LblGenre.Name = "LblGenre";
            LblGenre.Size = new Size(68, 34);
            LblGenre.TabIndex = 3;
            LblGenre.Text = "Genre";
            // 
            // LblPublishedOn
            // 
            LblPublishedOn.AutoSize = true;
            LblPublishedOn.Dock = DockStyle.Right;
            LblPublishedOn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPublishedOn.Location = new Point(49, 101);
            LblPublishedOn.Name = "LblPublishedOn";
            LblPublishedOn.Size = new Size(137, 33);
            LblPublishedOn.TabIndex = 4;
            LblPublishedOn.Text = "Published On";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Dock = DockStyle.Right;
            LblISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblISBN.Location = new Point(45, 134);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(141, 33);
            LblISBN.TabIndex = 5;
            LblISBN.Text = "ISBN Number";
            // 
            // LblDescription
            // 
            LblDescription.AutoSize = true;
            LblDescription.Dock = DockStyle.Right;
            LblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblDescription.Location = new Point(65, 167);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(121, 37);
            LblDescription.TabIndex = 6;
            LblDescription.Text = "Description";
            // 
            // LblDiscriminator
            // 
            LblDiscriminator.AutoSize = true;
            LblDiscriminator.Dock = DockStyle.Right;
            LblDiscriminator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscriminator.Location = new Point(45, 204);
            LblDiscriminator.Name = "LblDiscriminator";
            LblDiscriminator.Size = new Size(141, 34);
            LblDiscriminator.TabIndex = 8;
            LblDiscriminator.Text = "Discriminator";
            // 
            // LblFloor
            // 
            LblFloor.AutoSize = true;
            LblFloor.Dock = DockStyle.Right;
            LblFloor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFloor.Location = new Point(126, 238);
            LblFloor.Name = "LblFloor";
            LblFloor.Size = new Size(60, 33);
            LblFloor.TabIndex = 10;
            LblFloor.Text = "Floor";
            // 
            // LblSection
            // 
            LblSection.AutoSize = true;
            LblSection.Dock = DockStyle.Right;
            LblSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSection.Location = new Point(104, 271);
            LblSection.Name = "LblSection";
            LblSection.Size = new Size(82, 33);
            LblSection.TabIndex = 11;
            LblSection.Text = "Section";
            // 
            // LblShelf
            // 
            LblShelf.AutoSize = true;
            LblShelf.Dock = DockStyle.Right;
            LblShelf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblShelf.Location = new Point(126, 304);
            LblShelf.Name = "LblShelf";
            LblShelf.Size = new Size(60, 33);
            LblShelf.TabIndex = 9;
            LblShelf.Text = "Shelf";
            // 
            // LblAvailable
            // 
            LblAvailable.AutoSize = true;
            LblAvailable.Dock = DockStyle.Right;
            LblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAvailable.Location = new Point(86, 337);
            LblAvailable.Name = "LblAvailable";
            LblAvailable.Size = new Size(100, 28);
            LblAvailable.TabIndex = 18;
            LblAvailable.Text = "Available";
            // 
            // LblNumOfCopies
            // 
            LblNumOfCopies.AutoSize = true;
            LblNumOfCopies.Dock = DockStyle.Right;
            LblNumOfCopies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNumOfCopies.Location = new Point(3, 365);
            LblNumOfCopies.Name = "LblNumOfCopies";
            LblNumOfCopies.Size = new Size(183, 33);
            LblNumOfCopies.TabIndex = 16;
            LblNumOfCopies.Text = "Number of Copies";
            // 
            // textBoxCreator
            // 
            textBoxCreator.Dock = DockStyle.Fill;
            textBoxCreator.Location = new Point(192, 3);
            textBoxCreator.Name = "textBoxCreator";
            textBoxCreator.Size = new Size(441, 27);
            textBoxCreator.TabIndex = 19;
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Fill;
            comboBoxType.Items.AddRange(new object[] { "Book", "Article" });
            comboBoxType.Location = new Point(192, 36);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(441, 28);
            comboBoxType.TabIndex = 20;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Dock = DockStyle.Fill;
            comboBoxGenre.Items.AddRange(new object[] { "Fiction", "NonFiction", "ScienceFiction", "Thriller", "Fantasy", "Romance", "Adventure", "Drama", "Historical", "Dystopian", "Satire" });
            comboBoxGenre.Location = new Point(192, 70);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(441, 28);
            comboBoxGenre.TabIndex = 21;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Dock = DockStyle.Fill;
            textBoxISBN.Location = new Point(192, 137);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(441, 27);
            textBoxISBN.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(192, 170);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(441, 31);
            textBoxDescription.TabIndex = 23;
            // 
            // ComboBoxDiscriminator
            // 
            ComboBoxDiscriminator.Dock = DockStyle.Fill;
            ComboBoxDiscriminator.Items.AddRange(new object[] { "Physical Reference", "Digital Reference" });
            ComboBoxDiscriminator.Location = new Point(192, 207);
            ComboBoxDiscriminator.Name = "ComboBoxDiscriminator";
            ComboBoxDiscriminator.Size = new Size(441, 28);
            ComboBoxDiscriminator.TabIndex = 25;
            ComboBoxDiscriminator.SelectedIndexChanged += ComboBoxDiscriminator_SelectedIndexChanged;
            // 
            // textBoxFloor
            // 
            textBoxFloor.Dock = DockStyle.Fill;
            textBoxFloor.Location = new Point(192, 241);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new Size(441, 27);
            textBoxFloor.TabIndex = 26;
            // 
            // textBoxSection
            // 
            textBoxSection.Dock = DockStyle.Fill;
            textBoxSection.Location = new Point(192, 274);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(441, 27);
            textBoxSection.TabIndex = 27;
            // 
            // textBoxShelf
            // 
            textBoxShelf.Dock = DockStyle.Fill;
            textBoxShelf.Location = new Point(192, 307);
            textBoxShelf.Name = "textBoxShelf";
            textBoxShelf.Size = new Size(441, 27);
            textBoxShelf.TabIndex = 28;
            // 
            // textBoxNumOfCopies
            // 
            textBoxNumOfCopies.Dock = DockStyle.Fill;
            textBoxNumOfCopies.Location = new Point(192, 368);
            textBoxNumOfCopies.Name = "textBoxNumOfCopies";
            textBoxNumOfCopies.Size = new Size(441, 27);
            textBoxNumOfCopies.TabIndex = 30;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Right;
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(464, 401);
            buttonAdd.MaximumSize = new Size(169, 35);
            buttonAdd.MinimumSize = new Size(169, 35);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(169, 35);
            buttonAdd.TabIndex = 36;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPublishedOn
            // 
            textBoxPublishedOn.Dock = DockStyle.Fill;
            textBoxPublishedOn.Location = new Point(192, 104);
            textBoxPublishedOn.Name = "textBoxPublishedOn";
            textBoxPublishedOn.Size = new Size(441, 27);
            textBoxPublishedOn.TabIndex = 37;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Dock = DockStyle.Fill;
            checkBoxAvailable.Location = new Point(192, 340);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(441, 22);
            checkBoxAvailable.TabIndex = 38;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCoverImage.Dock = DockStyle.Fill;
            pictureBoxCoverImage.Image = Resources.DefaultCoverImage;
            pictureBoxCoverImage.Location = new Point(0, 20);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(330, 399);
            pictureBoxCoverImage.TabIndex = 34;
            pictureBoxCoverImage.TabStop = false;
            pictureBoxCoverImage.Click += pictureBoxCoverImage_Click;
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchResults.Controls.Add(tableLayoutPanel2);
            PanelSearchResults.Controls.Add(panelCoverImageHolder);
            PanelSearchResults.Dock = DockStyle.Top;
            PanelSearchResults.Location = new Point(10, 154);
            PanelSearchResults.MinimumSize = new Size(900, 301);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40);
            PanelSearchResults.Size = new Size(980, 521);
            PanelSearchResults.TabIndex = 6;
            // 
            // panelCoverImageHolder
            // 
            panelCoverImageHolder.Controls.Add(pictureBoxCoverImage);
            panelCoverImageHolder.Dock = DockStyle.Left;
            panelCoverImageHolder.Location = new Point(40, 40);
            panelCoverImageHolder.Name = "panelCoverImageHolder";
            panelCoverImageHolder.Padding = new Padding(0, 20, 20, 20);
            panelCoverImageHolder.Size = new Size(350, 439);
            panelCoverImageHolder.TabIndex = 1;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.BackColor = SystemColors.Control;
            PanelSearchBar.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchBar.Controls.Add(txtTitle);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(10, 11);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(980, 143);
            PanelSearchBar.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(40, 40);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(898, 42);
            txtTitle.TabIndex = 0;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // AddReferenceCenterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 400);
            Name = "AddReferenceCenterDisplay";
            Padding = new Padding(10, 11, 10, 11);
            Size = new Size(1000, 686);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            panelCoverImageHolder.ResumeLayout(false);
            PanelSearchBar.ResumeLayout(false);
            PanelSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel PanelSearchResults;
        private Panel PanelSearchBar;
        private Label LblCreator;
        private Label LblType;
        private Label LblGenre;
        private Label LblPublishedOn;
        private Label LblISBN;
        private Label LblDescription;
        private Label LblDiscriminator;
        private Label LblShelf;
        private Label LblFloor;
        private Label LblSection;
        private Label LblAvailable;
        private Label LblNumOfCopies;
        private TextBox textBoxCreator;
        private ComboBox comboBoxType;
        private ComboBox comboBoxGenre;
        private TextBox textBoxISBN;
        private TextBox textBoxDescription;
        internal ComboBox ComboBoxDiscriminator;
        private TextBox textBoxFloor;
        private TextBox textBoxSection;
        private TextBox textBoxShelf;
        private TextBox textBoxNumOfCopies;
        private PictureBox pictureBoxCoverImage;
        private Button buttonAdd;
        private Panel panelCoverImageHolder;
        private TextBox textBoxPublishedOn;
        private CheckBox checkBoxAvailable;
        private TextBox txtTitle;
    }
}
