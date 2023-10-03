namespace Anababi.UserControls
{
    partial class LinkedReferencesPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panelCoverImageHolder = new Panel();
            pictureBoxCoverImage = new PictureBox();
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
            LblFile = new Label();
            PanelSearchResults = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxCreator = new TextBox();
            textBoxType = new TextBox();
            textBoxGenre = new TextBox();
            textBoxISBN = new TextBox();
            textBoxDescription = new TextBox();
            textBoxDiscriminator = new TextBox();
            textBoxFloor = new TextBox();
            textBoxSection = new TextBox();
            textBoxShelf = new TextBox();
            textBoxNumOfCopies = new TextBox();
            pdfViewerFile = new PdfiumViewer.PdfViewer();
            buttonSave = new Button();
            textBoxPublishedOn = new TextBox();
            checkBoxAvailable = new CheckBox();
            panelNextPreviousHolder = new Panel();
            buttonNext = new Button();
            buttonPrevious = new Button();
            LblReferenceTitle = new Label();
            PanelSearchBar = new Panel();
            buttonRemove = new Button();
            panelCoverImageHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            PanelSearchResults.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelNextPreviousHolder.SuspendLayout();
            PanelSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelCoverImageHolder
            // 
            panelCoverImageHolder.Controls.Add(pictureBoxCoverImage);
            panelCoverImageHolder.Dock = DockStyle.Left;
            panelCoverImageHolder.Location = new Point(40, 40);
            panelCoverImageHolder.Name = "panelCoverImageHolder";
            panelCoverImageHolder.Padding = new Padding(0, 20, 20, 20);
            panelCoverImageHolder.Size = new Size(350, 702);
            panelCoverImageHolder.TabIndex = 1;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCoverImage.Dock = DockStyle.Fill;
            pictureBoxCoverImage.Location = new Point(0, 20);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(330, 662);
            pictureBoxCoverImage.TabIndex = 34;
            pictureBoxCoverImage.TabStop = false;
            // 
            // LblCreator
            // 
            LblCreator.AutoSize = true;
            LblCreator.Dock = DockStyle.Right;
            LblCreator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCreator.Location = new Point(104, 0);
            LblCreator.Name = "LblCreator";
            LblCreator.Size = new Size(82, 31);
            LblCreator.TabIndex = 2;
            LblCreator.Text = "Creator";
            // 
            // LblType
            // 
            LblType.AutoSize = true;
            LblType.Dock = DockStyle.Right;
            LblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblType.Location = new Point(129, 31);
            LblType.Name = "LblType";
            LblType.Size = new Size(57, 31);
            LblType.TabIndex = 1;
            LblType.Text = "Type";
            // 
            // LblGenre
            // 
            LblGenre.AutoSize = true;
            LblGenre.Dock = DockStyle.Right;
            LblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblGenre.Location = new Point(118, 62);
            LblGenre.Name = "LblGenre";
            LblGenre.Size = new Size(68, 31);
            LblGenre.TabIndex = 3;
            LblGenre.Text = "Genre";
            // 
            // LblPublishedOn
            // 
            LblPublishedOn.AutoSize = true;
            LblPublishedOn.Dock = DockStyle.Right;
            LblPublishedOn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPublishedOn.Location = new Point(49, 93);
            LblPublishedOn.Name = "LblPublishedOn";
            LblPublishedOn.Size = new Size(137, 31);
            LblPublishedOn.TabIndex = 4;
            LblPublishedOn.Text = "Published On";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Dock = DockStyle.Right;
            LblISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblISBN.Location = new Point(45, 124);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(141, 31);
            LblISBN.TabIndex = 5;
            LblISBN.Text = "ISBN Number";
            // 
            // LblDescription
            // 
            LblDescription.AutoSize = true;
            LblDescription.Dock = DockStyle.Right;
            LblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblDescription.Location = new Point(65, 155);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(121, 66);
            LblDescription.TabIndex = 6;
            LblDescription.Text = "Description";
            // 
            // LblDiscriminator
            // 
            LblDiscriminator.AutoSize = true;
            LblDiscriminator.Dock = DockStyle.Right;
            LblDiscriminator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscriminator.Location = new Point(45, 221);
            LblDiscriminator.Name = "LblDiscriminator";
            LblDiscriminator.Size = new Size(141, 31);
            LblDiscriminator.TabIndex = 8;
            LblDiscriminator.Text = "Discriminator";
            // 
            // LblFloor
            // 
            LblFloor.AutoSize = true;
            LblFloor.Dock = DockStyle.Right;
            LblFloor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFloor.Location = new Point(126, 252);
            LblFloor.Name = "LblFloor";
            LblFloor.Size = new Size(60, 31);
            LblFloor.TabIndex = 10;
            LblFloor.Text = "Floor";
            // 
            // LblSection
            // 
            LblSection.AutoSize = true;
            LblSection.Dock = DockStyle.Right;
            LblSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSection.Location = new Point(104, 283);
            LblSection.Name = "LblSection";
            LblSection.Size = new Size(82, 31);
            LblSection.TabIndex = 11;
            LblSection.Text = "Section";
            // 
            // LblShelf
            // 
            LblShelf.AutoSize = true;
            LblShelf.Dock = DockStyle.Right;
            LblShelf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblShelf.Location = new Point(126, 314);
            LblShelf.Name = "LblShelf";
            LblShelf.Size = new Size(60, 31);
            LblShelf.TabIndex = 9;
            LblShelf.Text = "Shelf";
            // 
            // LblAvailable
            // 
            LblAvailable.AutoSize = true;
            LblAvailable.Dock = DockStyle.Right;
            LblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAvailable.Location = new Point(86, 345);
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
            LblNumOfCopies.Location = new Point(3, 373);
            LblNumOfCopies.Name = "LblNumOfCopies";
            LblNumOfCopies.Size = new Size(183, 33);
            LblNumOfCopies.TabIndex = 16;
            LblNumOfCopies.Text = "Number of Copies";
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Dock = DockStyle.Right;
            LblFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFile.Location = new Point(141, 406);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(45, 255);
            LblFile.TabIndex = 17;
            LblFile.Text = "File";
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchResults.Controls.Add(tableLayoutPanel2);
            PanelSearchResults.Controls.Add(panelCoverImageHolder);
            PanelSearchResults.Controls.Add(panelNextPreviousHolder);
            PanelSearchResults.Dock = DockStyle.Fill;
            PanelSearchResults.Location = new Point(10, 153);
            PanelSearchResults.Margin = new Padding(10);
            PanelSearchResults.MinimumSize = new Size(1000, 300);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40);
            PanelSearchResults.Size = new Size(1080, 846);
            PanelSearchResults.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
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
            tableLayoutPanel2.Controls.Add(LblFile, 0, 13);
            tableLayoutPanel2.Controls.Add(textBoxCreator, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxType, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxGenre, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxISBN, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxDescription, 1, 5);
            tableLayoutPanel2.Controls.Add(textBoxDiscriminator, 1, 7);
            tableLayoutPanel2.Controls.Add(textBoxFloor, 1, 8);
            tableLayoutPanel2.Controls.Add(textBoxSection, 1, 9);
            tableLayoutPanel2.Controls.Add(textBoxShelf, 1, 10);
            tableLayoutPanel2.Controls.Add(textBoxNumOfCopies, 1, 12);
            tableLayoutPanel2.Controls.Add(pdfViewerFile, 1, 13);
            tableLayoutPanel2.Controls.Add(buttonSave, 1, 14);
            tableLayoutPanel2.Controls.Add(textBoxPublishedOn, 1, 3);
            tableLayoutPanel2.Controls.Add(checkBoxAvailable, 1, 11);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(390, 40);
            tableLayoutPanel2.MinimumSize = new Size(600, 300);
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
            tableLayoutPanel2.Size = new Size(648, 702);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxCreator
            // 
            textBoxCreator.Dock = DockStyle.Fill;
            textBoxCreator.Location = new Point(192, 2);
            textBoxCreator.Margin = new Padding(3, 2, 3, 2);
            textBoxCreator.Name = "textBoxCreator";
            textBoxCreator.Size = new Size(453, 27);
            textBoxCreator.TabIndex = 19;
            // 
            // textBoxType
            // 
            textBoxType.Dock = DockStyle.Fill;
            textBoxType.Location = new Point(192, 33);
            textBoxType.Margin = new Padding(3, 2, 3, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(453, 27);
            textBoxType.TabIndex = 20;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Dock = DockStyle.Fill;
            textBoxGenre.Location = new Point(192, 64);
            textBoxGenre.Margin = new Padding(3, 2, 3, 2);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(453, 27);
            textBoxGenre.TabIndex = 21;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Dock = DockStyle.Fill;
            textBoxISBN.Location = new Point(192, 126);
            textBoxISBN.Margin = new Padding(3, 2, 3, 2);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(453, 27);
            textBoxISBN.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(192, 157);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(453, 62);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // textBoxDiscriminator
            // 
            textBoxDiscriminator.Dock = DockStyle.Fill;
            textBoxDiscriminator.Location = new Point(192, 223);
            textBoxDiscriminator.Margin = new Padding(3, 2, 3, 2);
            textBoxDiscriminator.Name = "textBoxDiscriminator";
            textBoxDiscriminator.Size = new Size(453, 27);
            textBoxDiscriminator.TabIndex = 25;
            // 
            // textBoxFloor
            // 
            textBoxFloor.Dock = DockStyle.Fill;
            textBoxFloor.Location = new Point(192, 254);
            textBoxFloor.Margin = new Padding(3, 2, 3, 2);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new Size(453, 27);
            textBoxFloor.TabIndex = 26;
            // 
            // textBoxSection
            // 
            textBoxSection.Dock = DockStyle.Fill;
            textBoxSection.Location = new Point(192, 285);
            textBoxSection.Margin = new Padding(3, 2, 3, 2);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(453, 27);
            textBoxSection.TabIndex = 27;
            // 
            // textBoxShelf
            // 
            textBoxShelf.Dock = DockStyle.Fill;
            textBoxShelf.Location = new Point(192, 316);
            textBoxShelf.Margin = new Padding(3, 2, 3, 2);
            textBoxShelf.Name = "textBoxShelf";
            textBoxShelf.Size = new Size(453, 27);
            textBoxShelf.TabIndex = 28;
            // 
            // textBoxNumOfCopies
            // 
            textBoxNumOfCopies.Dock = DockStyle.Fill;
            textBoxNumOfCopies.Location = new Point(192, 376);
            textBoxNumOfCopies.Name = "textBoxNumOfCopies";
            textBoxNumOfCopies.Size = new Size(453, 27);
            textBoxNumOfCopies.TabIndex = 30;
            // 
            // pdfViewerFile
            // 
            pdfViewerFile.Dock = DockStyle.Fill;
            pdfViewerFile.Location = new Point(193, 411);
            pdfViewerFile.Margin = new Padding(4, 5, 4, 5);
            pdfViewerFile.Name = "pdfViewerFile";
            pdfViewerFile.ShowToolbar = false;
            pdfViewerFile.Size = new Size(451, 245);
            pdfViewerFile.TabIndex = 35;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Right;
            buttonSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(476, 664);
            buttonSave.MaximumSize = new Size(169, 35);
            buttonSave.MinimumSize = new Size(169, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(169, 35);
            buttonSave.TabIndex = 36;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxPublishedOn
            // 
            textBoxPublishedOn.Dock = DockStyle.Fill;
            textBoxPublishedOn.Location = new Point(192, 95);
            textBoxPublishedOn.Margin = new Padding(3, 2, 3, 2);
            textBoxPublishedOn.Name = "textBoxPublishedOn";
            textBoxPublishedOn.Size = new Size(453, 27);
            textBoxPublishedOn.TabIndex = 37;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Dock = DockStyle.Fill;
            checkBoxAvailable.Location = new Point(192, 348);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(453, 22);
            checkBoxAvailable.TabIndex = 38;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // panelNextPreviousHolder
            // 
            panelNextPreviousHolder.Controls.Add(buttonNext);
            panelNextPreviousHolder.Controls.Add(buttonPrevious);
            panelNextPreviousHolder.Dock = DockStyle.Bottom;
            panelNextPreviousHolder.Location = new Point(40, 742);
            panelNextPreviousHolder.Margin = new Padding(10);
            panelNextPreviousHolder.Name = "panelNextPreviousHolder";
            panelNextPreviousHolder.Padding = new Padding(0, 20, 0, 0);
            panelNextPreviousHolder.Size = new Size(998, 62);
            panelNextPreviousHolder.TabIndex = 35;
            // 
            // buttonNext
            // 
            buttonNext.Dock = DockStyle.Right;
            buttonNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.Location = new Point(826, 20);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(172, 42);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Dock = DockStyle.Left;
            buttonPrevious.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrevious.Location = new Point(0, 20);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(172, 42);
            buttonPrevious.TabIndex = 0;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // LblReferenceTitle
            // 
            LblReferenceTitle.Dock = DockStyle.Fill;
            LblReferenceTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblReferenceTitle.Location = new Point(40, 40);
            LblReferenceTitle.Name = "LblReferenceTitle";
            LblReferenceTitle.Size = new Size(998, 61);
            LblReferenceTitle.TabIndex = 0;
            LblReferenceTitle.Text = "Title";
            LblReferenceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.BackColor = SystemColors.Control;
            PanelSearchBar.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchBar.Controls.Add(buttonRemove);
            PanelSearchBar.Controls.Add(LblReferenceTitle);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(10, 10);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(1080, 143);
            PanelSearchBar.TabIndex = 7;
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Right;
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.Brown;
            buttonRemove.Location = new Point(922, 40);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(116, 61);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // LinkedReferencesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            MinimumSize = new Size(1000, 509);
            Name = "LinkedReferencesPage";
            Padding = new Padding(10);
            Size = new Size(1100, 1009);
            Load += LinkedReferencesPage_Load;
            panelCoverImageHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelNextPreviousHolder.ResumeLayout(false);
            PanelSearchBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCoverImageHolder;
        private PictureBox pictureBoxCoverImage;
        private Label LblCreator;
        private Label LblType;
        private Label LblGenre;
        private Label LblPublishedOn;
        private Label LblISBN;
        private Label LblDescription;
        private Label LblDiscriminator;
        private Label LblFloor;
        private Label LblSection;
        private Label LblShelf;
        private Label LblAvailable;
        private Label LblNumOfCopies;
        private Label LblFile;
        private Panel PanelSearchResults;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxCreator;
        private TextBox textBoxType;
        private TextBox textBoxGenre;
        private TextBox textBoxISBN;
        private TextBox textBoxDescription;
        private TextBox textBoxDiscriminator;
        private TextBox textBoxFloor;
        private TextBox textBoxSection;
        private TextBox textBoxShelf;
        private TextBox textBoxNumOfCopies;
        private PdfiumViewer.PdfViewer pdfViewerFile;
        private Button buttonSave;
        private TextBox textBoxPublishedOn;
        private CheckBox checkBoxAvailable;
        private Label LblReferenceTitle;
        private Panel PanelSearchBar;
        private Panel panelNextPreviousHolder;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonRemove;
    }
}
