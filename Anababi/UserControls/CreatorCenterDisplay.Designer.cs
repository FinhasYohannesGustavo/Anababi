namespace Anababi.UserControls
{
    partial class CreatorCenterDisplay
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
            pictureBoxCoverImage = new PictureBox();
            PanelSearchResults = new Panel();
            tableLayoutPanelCreatorData = new TableLayoutPanel();
            LblWorks = new Label();
            textBoxWorks = new TextBox();
            panelCoverImageHolder = new Panel();
            PanelSearchBar = new Panel();
            LblCreatorName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            PanelSearchResults.SuspendLayout();
            tableLayoutPanelCreatorData.SuspendLayout();
            panelCoverImageHolder.SuspendLayout();
            PanelSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCoverImage.Dock = DockStyle.Fill;
            pictureBoxCoverImage.Location = new Point(0, 0);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(350, 400);
            pictureBoxCoverImage.TabIndex = 34;
            pictureBoxCoverImage.TabStop = false;
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchResults.Controls.Add(tableLayoutPanelCreatorData);
            PanelSearchResults.Controls.Add(panelCoverImageHolder);
            PanelSearchResults.Dock = DockStyle.Top;
            PanelSearchResults.Location = new Point(10, 156);
            PanelSearchResults.MinimumSize = new Size(900, 301);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40);
            PanelSearchResults.Size = new Size(980, 482);
            PanelSearchResults.TabIndex = 6;
            // 
            // tableLayoutPanelCreatorData
            // 
            tableLayoutPanelCreatorData.AutoSize = true;
            tableLayoutPanelCreatorData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelCreatorData.ColumnCount = 2;
            tableLayoutPanelCreatorData.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelCreatorData.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelCreatorData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanelCreatorData.Controls.Add(LblWorks, 0, 7);
            tableLayoutPanelCreatorData.Controls.Add(textBoxWorks, 1, 7);
            tableLayoutPanelCreatorData.Dock = DockStyle.Fill;
            tableLayoutPanelCreatorData.Location = new Point(390, 40);
            tableLayoutPanelCreatorData.MinimumSize = new Size(500, 400);
            tableLayoutPanelCreatorData.Name = "tableLayoutPanelCreatorData";
            tableLayoutPanelCreatorData.RowCount = 15;
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.RowStyles.Add(new RowStyle());
            tableLayoutPanelCreatorData.Size = new Size(548, 400);
            tableLayoutPanelCreatorData.TabIndex = 0;
            // 
            // LblWorks
            // 
            LblWorks.AutoSize = true;
            LblWorks.Dock = DockStyle.Right;
            LblWorks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblWorks.Location = new Point(3, 0);
            LblWorks.Name = "LblWorks";
            LblWorks.Size = new Size(71, 33);
            LblWorks.TabIndex = 8;
            LblWorks.Text = "Works";
            // 
            // textBoxWorks
            // 
            textBoxWorks.Dock = DockStyle.Fill;
            textBoxWorks.Location = new Point(80, 3);
            textBoxWorks.Name = "textBoxWorks";
            textBoxWorks.Size = new Size(465, 27);
            textBoxWorks.TabIndex = 25;
            // 
            // panelCoverImageHolder
            // 
            panelCoverImageHolder.Controls.Add(pictureBoxCoverImage);
            panelCoverImageHolder.Dock = DockStyle.Left;
            panelCoverImageHolder.Location = new Point(40, 40);
            panelCoverImageHolder.Name = "panelCoverImageHolder";
            panelCoverImageHolder.Size = new Size(350, 400);
            panelCoverImageHolder.TabIndex = 1;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.BackColor = SystemColors.Control;
            PanelSearchBar.BorderStyle = BorderStyle.FixedSingle;
            PanelSearchBar.Controls.Add(LblCreatorName);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(10, 11);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(980, 145);
            PanelSearchBar.TabIndex = 5;
            // 
            // LblCreatorName
            // 
            LblCreatorName.Dock = DockStyle.Fill;
            LblCreatorName.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblCreatorName.Location = new Point(40, 40);
            LblCreatorName.Name = "LblCreatorName";
            LblCreatorName.Size = new Size(898, 63);
            LblCreatorName.TabIndex = 0;
            LblCreatorName.Text = "Full Name";
            LblCreatorName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreatorCenterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 400);
            Name = "CreatorCenterDisplay";
            Padding = new Padding(10, 11, 10, 11);
            Size = new Size(1000, 649);
            Load += CreatorCenterDisplay_Load;
            Click += CenterDisplay_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            tableLayoutPanelCreatorData.ResumeLayout(false);
            tableLayoutPanelCreatorData.PerformLayout();
            panelCoverImageHolder.ResumeLayout(false);
            PanelSearchBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void CreatorCenterDisplay_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }









        #endregion
        private Panel PanelSearchResults;
        private Panel PanelSearchBar;
        private Label LblCreatorName;
        private PictureBox pictureBoxCoverImage;
        private Panel panelCoverImageHolder;
        private TableLayoutPanel tableLayoutPanelCreatorData;
        private Label LblWorks;
        private TextBox textBoxWorks;
    }
}
