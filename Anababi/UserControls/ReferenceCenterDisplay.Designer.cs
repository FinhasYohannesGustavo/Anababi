namespace Anababi.UserControls
{
    partial class ReferenceCenterDisplay
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
            LblCoverImage = new Label();
            LblDiscriminator = new Label();
            LblFloor = new Label();
            LblSection = new Label();
            LblShelf = new Label();
            LblAvailable = new Label();
            LblNumOfCopies = new Label();
            LblFile = new Label();
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
            dateTimePickerPublishedOn = new DateTimePicker();
            comboBoxAvailable = new ComboBox();
            pictureBoxCoverImage = new PictureBox();
            pdfViewerFile = new PdfiumViewer.PdfViewer();
            PanelSearchResults = new Panel();
            PanelSearchBar = new Panel();
            LblReferenceTitle = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            PanelSearchResults.SuspendLayout();
            PanelSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.Controls.Add(LblCreator, 0, 0);
            tableLayoutPanel2.Controls.Add(LblType, 0, 1);
            tableLayoutPanel2.Controls.Add(LblGenre, 0, 2);
            tableLayoutPanel2.Controls.Add(LblPublishedOn, 0, 3);
            tableLayoutPanel2.Controls.Add(LblISBN, 0, 4);
            tableLayoutPanel2.Controls.Add(LblDescription, 0, 5);
            tableLayoutPanel2.Controls.Add(LblCoverImage, 0, 6);
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
            tableLayoutPanel2.Controls.Add(dateTimePickerPublishedOn, 1, 3);
            tableLayoutPanel2.Controls.Add(comboBoxAvailable, 1, 11);
            tableLayoutPanel2.Controls.Add(pictureBoxCoverImage, 1, 6);
            tableLayoutPanel2.Controls.Add(pdfViewerFile, 1, 13);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(40, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
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
            tableLayoutPanel2.Size = new Size(942, 1516);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LblCreator
            // 
            LblCreator.AutoSize = true;
            LblCreator.Dock = DockStyle.Right;
            LblCreator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCreator.Location = new Point(268, 0);
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
            LblType.Location = new Point(293, 33);
            LblType.Name = "LblType";
            LblType.Size = new Size(57, 33);
            LblType.TabIndex = 1;
            LblType.Text = "Type";
            // 
            // LblGenre
            // 
            LblGenre.AutoSize = true;
            LblGenre.Dock = DockStyle.Right;
            LblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblGenre.Location = new Point(282, 66);
            LblGenre.Name = "LblGenre";
            LblGenre.Size = new Size(68, 33);
            LblGenre.TabIndex = 3;
            LblGenre.Text = "Genre";
            // 
            // LblPublishedOn
            // 
            LblPublishedOn.AutoSize = true;
            LblPublishedOn.Dock = DockStyle.Right;
            LblPublishedOn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPublishedOn.Location = new Point(213, 99);
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
            LblISBN.Location = new Point(209, 132);
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
            LblDescription.Location = new Point(229, 165);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(121, 33);
            LblDescription.TabIndex = 6;
            LblDescription.Text = "Description";
            // 
            // LblCoverImage
            // 
            LblCoverImage.AutoSize = true;
            LblCoverImage.Dock = DockStyle.Right;
            LblCoverImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCoverImage.Location = new Point(220, 198);
            LblCoverImage.Name = "LblCoverImage";
            LblCoverImage.Size = new Size(130, 267);
            LblCoverImage.TabIndex = 7;
            LblCoverImage.Text = "Cover Image";
            // 
            // LblDiscriminator
            // 
            LblDiscriminator.AutoSize = true;
            LblDiscriminator.Dock = DockStyle.Right;
            LblDiscriminator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscriminator.Location = new Point(209, 465);
            LblDiscriminator.Name = "LblDiscriminator";
            LblDiscriminator.Size = new Size(141, 33);
            LblDiscriminator.TabIndex = 8;
            LblDiscriminator.Text = "Discriminator";
            // 
            // LblFloor
            // 
            LblFloor.AutoSize = true;
            LblFloor.Dock = DockStyle.Right;
            LblFloor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFloor.Location = new Point(290, 498);
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
            LblSection.Location = new Point(268, 531);
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
            LblShelf.Location = new Point(290, 564);
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
            LblAvailable.Location = new Point(250, 597);
            LblAvailable.Name = "LblAvailable";
            LblAvailable.Size = new Size(100, 34);
            LblAvailable.TabIndex = 18;
            LblAvailable.Text = "Available";
            // 
            // LblNumOfCopies
            // 
            LblNumOfCopies.AutoSize = true;
            LblNumOfCopies.Dock = DockStyle.Right;
            LblNumOfCopies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNumOfCopies.Location = new Point(167, 631);
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
            LblFile.Location = new Point(305, 664);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(45, 852);
            LblFile.TabIndex = 17;
            LblFile.Text = "File";
            // 
            // textBoxCreator
            // 
            textBoxCreator.Dock = DockStyle.Fill;
            textBoxCreator.Location = new Point(356, 3);
            textBoxCreator.Name = "textBoxCreator";
            textBoxCreator.Size = new Size(583, 27);
            textBoxCreator.TabIndex = 19;
            // 
            // textBoxType
            // 
            textBoxType.Dock = DockStyle.Fill;
            textBoxType.Location = new Point(356, 36);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(583, 27);
            textBoxType.TabIndex = 20;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Dock = DockStyle.Fill;
            textBoxGenre.Location = new Point(356, 69);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(583, 27);
            textBoxGenre.TabIndex = 21;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Dock = DockStyle.Fill;
            textBoxISBN.Location = new Point(356, 135);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(583, 27);
            textBoxISBN.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(356, 168);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(583, 27);
            textBoxDescription.TabIndex = 23;
            // 
            // textBoxDiscriminator
            // 
            textBoxDiscriminator.Dock = DockStyle.Fill;
            textBoxDiscriminator.Location = new Point(356, 468);
            textBoxDiscriminator.Name = "textBoxDiscriminator";
            textBoxDiscriminator.Size = new Size(583, 27);
            textBoxDiscriminator.TabIndex = 25;
            // 
            // textBoxFloor
            // 
            textBoxFloor.Dock = DockStyle.Fill;
            textBoxFloor.Location = new Point(356, 501);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new Size(583, 27);
            textBoxFloor.TabIndex = 26;
            // 
            // textBoxSection
            // 
            textBoxSection.Dock = DockStyle.Fill;
            textBoxSection.Location = new Point(356, 534);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(583, 27);
            textBoxSection.TabIndex = 27;
            // 
            // textBoxShelf
            // 
            textBoxShelf.Dock = DockStyle.Fill;
            textBoxShelf.Location = new Point(356, 567);
            textBoxShelf.Name = "textBoxShelf";
            textBoxShelf.Size = new Size(583, 27);
            textBoxShelf.TabIndex = 28;
            // 
            // textBoxNumOfCopies
            // 
            textBoxNumOfCopies.Dock = DockStyle.Fill;
            textBoxNumOfCopies.Location = new Point(356, 634);
            textBoxNumOfCopies.Name = "textBoxNumOfCopies";
            textBoxNumOfCopies.Size = new Size(583, 27);
            textBoxNumOfCopies.TabIndex = 30;
            // 
            // dateTimePickerPublishedOn
            // 
            dateTimePickerPublishedOn.Dock = DockStyle.Fill;
            dateTimePickerPublishedOn.Location = new Point(356, 102);
            dateTimePickerPublishedOn.Name = "dateTimePickerPublishedOn";
            dateTimePickerPublishedOn.Size = new Size(583, 27);
            dateTimePickerPublishedOn.TabIndex = 32;
            // 
            // comboBoxAvailable
            // 
            comboBoxAvailable.Dock = DockStyle.Fill;
            comboBoxAvailable.FormattingEnabled = true;
            comboBoxAvailable.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxAvailable.Location = new Point(356, 600);
            comboBoxAvailable.Name = "comboBoxAvailable";
            comboBoxAvailable.Size = new Size(583, 28);
            comboBoxAvailable.TabIndex = 33;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.Dock = DockStyle.Fill;
            pictureBoxCoverImage.Location = new Point(356, 201);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(583, 261);
            pictureBoxCoverImage.TabIndex = 34;
            pictureBoxCoverImage.TabStop = false;
            // 
            // pdfViewerFile
            // 
            pdfViewerFile.Location = new Point(357, 669);
            pdfViewerFile.Margin = new Padding(4, 5, 4, 5);
            pdfViewerFile.Name = "pdfViewerFile";
            pdfViewerFile.Size = new Size(580, 842);
            pdfViewerFile.TabIndex = 35;
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.Controls.Add(tableLayoutPanel2);
            PanelSearchResults.Dock = DockStyle.Fill;
            PanelSearchResults.Location = new Point(10, 122);
            PanelSearchResults.MinimumSize = new Size(400, 400);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40, 0, 40, 40);
            PanelSearchResults.Size = new Size(1022, 1556);
            PanelSearchResults.TabIndex = 6;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.BackColor = SystemColors.ButtonShadow;
            PanelSearchBar.Controls.Add(LblReferenceTitle);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(10, 10);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(1022, 112);
            PanelSearchBar.TabIndex = 5;
            // 
            // LblReferenceTitle
            // 
            LblReferenceTitle.AutoSize = true;
            LblReferenceTitle.Dock = DockStyle.Fill;
            LblReferenceTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblReferenceTitle.Location = new Point(40, 40);
            LblReferenceTitle.Name = "LblReferenceTitle";
            LblReferenceTitle.Size = new Size(91, 46);
            LblReferenceTitle.TabIndex = 0;
            LblReferenceTitle.Text = "Title";
            LblReferenceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReferenceCenterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReferenceCenterDisplay";
            Padding = new Padding(10);
            Size = new Size(1042, 1688);
            Load += CenterDisplay_Load;
            Click += CenterDisplay_Click;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            PanelSearchBar.ResumeLayout(false);
            PanelSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel PanelSearchResults;
        private Panel PanelSearchBar;
        private Label LblReferenceTitle;
        private Label LblCreator;
        private Label LblType;
        private Label LblGenre;
        private Label LblPublishedOn;
        private Label LblISBN;
        private Label LblDescription;
        private Label LblCoverImage;
        private Label LblDiscriminator;
        private Label LblShelf;
        private Label LblFloor;
        private Label LblSection;
        private Label LblAvailable;
        private Label LblNumOfCopies;
        private Label LblFile;
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
        private DateTimePicker dateTimePickerPublishedOn;
        private ComboBox comboBoxAvailable;
        private PictureBox pictureBoxCoverImage;
        private PdfiumViewer.PdfViewer pdfViewerFile;
    }
}
