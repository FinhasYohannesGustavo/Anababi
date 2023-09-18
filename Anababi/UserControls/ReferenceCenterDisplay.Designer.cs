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
            pdfViewerFile = new PdfiumViewer.PdfViewer();
            buttonSave = new Button();
            textBoxPublishedOn = new TextBox();
            checkBoxAvailable = new CheckBox();
            pictureBoxCoverImage = new PictureBox();
            PanelSearchResults = new Panel();
            panelCoverImageHolder = new Panel();
            PanelSearchBar = new Panel();
            LblReferenceTitle = new Label();
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
            tableLayoutPanel2.Location = new Point(390, 0);
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
            tableLayoutPanel2.Size = new Size(600, 707);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LblCreator
            // 
            this.LblCreator.AutoSize = true;
            this.LblCreator.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblCreator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCreator.Location = new System.Drawing.Point(85, 0);
            this.LblCreator.Name = "LblCreator";
            this.LblCreator.Size = new System.Drawing.Size(66, 27);
            this.LblCreator.TabIndex = 2;
            this.LblCreator.Text = "Creator";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblType.Location = new System.Drawing.Point(105, 27);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(46, 27);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "Type";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGenre.Location = new System.Drawing.Point(96, 54);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(55, 27);
            this.LblGenre.TabIndex = 3;
            this.LblGenre.Text = "Genre";
            // 
            // LblPublishedOn
            // 
            this.LblPublishedOn.AutoSize = true;
            this.LblPublishedOn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblPublishedOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPublishedOn.Location = new System.Drawing.Point(39, 81);
            this.LblPublishedOn.Name = "LblPublishedOn";
            this.LblPublishedOn.Size = new System.Drawing.Size(112, 27);
            this.LblPublishedOn.TabIndex = 4;
            this.LblPublishedOn.Text = "Published On";
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblISBN.Location = new System.Drawing.Point(37, 108);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(114, 27);
            this.LblISBN.TabIndex = 5;
            this.LblISBN.Text = "ISBN Number";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDescription.Location = new System.Drawing.Point(53, 135);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(98, 25);
            this.LblDescription.TabIndex = 6;
            this.LblDescription.Text = "Description";
            // 
            // LblDiscriminator
            // 
            this.LblDiscriminator.AutoSize = true;
            this.LblDiscriminator.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblDiscriminator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDiscriminator.Location = new System.Drawing.Point(37, 160);
            this.LblDiscriminator.Name = "LblDiscriminator";
            this.LblDiscriminator.Size = new System.Drawing.Size(114, 27);
            this.LblDiscriminator.TabIndex = 8;
            this.LblDiscriminator.Text = "Discriminator";
            // 
            // LblFloor
            // 
            this.LblFloor.AutoSize = true;
            this.LblFloor.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFloor.Location = new System.Drawing.Point(102, 187);
            this.LblFloor.Name = "LblFloor";
            this.LblFloor.Size = new System.Drawing.Size(49, 27);
            this.LblFloor.TabIndex = 10;
            this.LblFloor.Text = "Floor";
            // 
            // LblSection
            // 
            this.LblSection.AutoSize = true;
            this.LblSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSection.Location = new System.Drawing.Point(84, 214);
            this.LblSection.Name = "LblSection";
            this.LblSection.Size = new System.Drawing.Size(67, 27);
            this.LblSection.TabIndex = 11;
            this.LblSection.Text = "Section";
            // 
            // LblShelf
            // 
            this.LblShelf.AutoSize = true;
            this.LblShelf.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblShelf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblShelf.Location = new System.Drawing.Point(102, 241);
            this.LblShelf.Name = "LblShelf";
            this.LblShelf.Size = new System.Drawing.Size(49, 27);
            this.LblShelf.TabIndex = 9;
            this.LblShelf.Text = "Shelf";
            // 
            // LblAvailable
            // 
            LblAvailable.AutoSize = true;
            LblAvailable.Dock = DockStyle.Right;
            LblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAvailable.Location = new Point(86, 330);
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
            LblNumOfCopies.Location = new Point(3, 358);
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
            LblFile.Location = new Point(141, 391);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(45, 255);
            LblFile.TabIndex = 17;
            LblFile.Text = "File";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCreator.Location = new System.Drawing.Point(157, 2);
            this.textBoxCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.Size = new System.Drawing.Size(386, 23);
            this.textBoxCreator.TabIndex = 19;
            // 
            // textBoxType
            // 
            this.textBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxType.Location = new System.Drawing.Point(157, 29);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(386, 23);
            this.textBoxType.TabIndex = 20;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGenre.Location = new System.Drawing.Point(157, 56);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(386, 23);
            this.textBoxGenre.TabIndex = 21;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxISBN.Location = new System.Drawing.Point(157, 110);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(386, 23);
            this.textBoxISBN.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(157, 137);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(386, 21);
            this.textBoxDescription.TabIndex = 23;
            // 
            // textBoxDiscriminator
            // 
            this.textBoxDiscriminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscriminator.Location = new System.Drawing.Point(157, 162);
            this.textBoxDiscriminator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiscriminator.Name = "textBoxDiscriminator";
            this.textBoxDiscriminator.Size = new System.Drawing.Size(386, 23);
            this.textBoxDiscriminator.TabIndex = 25;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFloor.Location = new System.Drawing.Point(157, 189);
            this.textBoxFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(386, 23);
            this.textBoxFloor.TabIndex = 26;
            // 
            // textBoxSection
            // 
            this.textBoxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSection.Location = new System.Drawing.Point(157, 216);
            this.textBoxSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(386, 23);
            this.textBoxSection.TabIndex = 27;
            // 
            // textBoxShelf
            // 
            this.textBoxShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxShelf.Location = new System.Drawing.Point(157, 243);
            this.textBoxShelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShelf.Name = "textBoxShelf";
            this.textBoxShelf.Size = new System.Drawing.Size(386, 23);
            this.textBoxShelf.TabIndex = 28;
            // 
            // textBoxNumOfCopies
            // 
            textBoxNumOfCopies.Dock = DockStyle.Fill;
            textBoxNumOfCopies.Location = new Point(192, 361);
            textBoxNumOfCopies.Name = "textBoxNumOfCopies";
            textBoxNumOfCopies.Size = new Size(405, 27);
            textBoxNumOfCopies.TabIndex = 30;
            // 
            // pdfViewerFile
            // 
            pdfViewerFile.Location = new Point(193, 396);
            pdfViewerFile.Margin = new Padding(4, 5, 4, 5);
            pdfViewerFile.Name = "pdfViewerFile";
            pdfViewerFile.ShowToolbar = false;
            pdfViewerFile.Size = new Size(353, 245);
            pdfViewerFile.TabIndex = 35;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Right;
            buttonSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(463, 649);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(134, 55);
            buttonSave.TabIndex = 36;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxPublishedOn
            // 
            this.textBoxPublishedOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPublishedOn.Location = new System.Drawing.Point(157, 83);
            this.textBoxPublishedOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPublishedOn.Name = "textBoxPublishedOn";
            this.textBoxPublishedOn.Size = new System.Drawing.Size(386, 23);
            this.textBoxPublishedOn.TabIndex = 37;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Dock = DockStyle.Fill;
            checkBoxAvailable.Location = new Point(192, 333);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(405, 22);
            checkBoxAvailable.TabIndex = 38;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCoverImage.Dock = DockStyle.Fill;
            pictureBoxCoverImage.Location = new Point(0, 0);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(350, 707);
            pictureBoxCoverImage.TabIndex = 34;
            pictureBoxCoverImage.TabStop = false;
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
            PanelSearchResults.Location = new Point(10, 153);
            PanelSearchResults.MinimumSize = new Size(900, 300);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40, 0, 40, 40);
            PanelSearchResults.Size = new Size(980, 749);
            PanelSearchResults.TabIndex = 6;
            // 
            // panelCoverImageHolder
            // 
            panelCoverImageHolder.Controls.Add(pictureBoxCoverImage);
            panelCoverImageHolder.Dock = DockStyle.Left;
            panelCoverImageHolder.Location = new Point(40, 0);
            panelCoverImageHolder.Name = "panelCoverImageHolder";
            panelCoverImageHolder.Size = new Size(350, 707);
            panelCoverImageHolder.TabIndex = 1;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.BackColor = SystemColors.Control;
            PanelSearchBar.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchBar.Controls.Add(LblReferenceTitle);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(10, 10);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(980, 143);
            PanelSearchBar.TabIndex = 5;
            // 
            // LblReferenceTitle
            // 
            LblReferenceTitle.Dock = DockStyle.Fill;
            LblReferenceTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblReferenceTitle.Location = new Point(40, 40);
            LblReferenceTitle.Name = "LblReferenceTitle";
            LblReferenceTitle.Size = new Size(898, 61);
            LblReferenceTitle.TabIndex = 0;
            LblReferenceTitle.Text = "Title";
            LblReferenceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReferenceCenterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 400);
            Name = "ReferenceCenterDisplay";
            Padding = new Padding(10);
            Size = new Size(1000, 912);
            Load += CenterDisplay_Load;
            Click += CenterDisplay_Click;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            panelCoverImageHolder.ResumeLayout(false);
            PanelSearchBar.ResumeLayout(false);
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
        private PictureBox pictureBoxCoverImage;
        private PdfiumViewer.PdfViewer pdfViewerFile;
        private Button buttonSave;
        private Panel panelCoverImageHolder;
        private TextBox textBoxPublishedOn;
        private CheckBox checkBoxAvailable;
    }
}
