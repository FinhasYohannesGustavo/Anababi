namespace Anababi.UserControls
{
    partial class TopCreatorsPage
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
            this.PanelContentTopArtists = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContentTopArtists
            // 
            this.PanelContentTopArtists.AutoScroll = true;
            this.PanelContentTopArtists.AutoSize = true;
            this.PanelContentTopArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelContentTopArtists.Location = new System.Drawing.Point(0, 56);
            this.PanelContentTopArtists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContentTopArtists.Name = "PanelContentTopArtists";
            this.PanelContentTopArtists.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.PanelContentTopArtists.Size = new System.Drawing.Size(915, 30);
            this.PanelContentTopArtists.TabIndex = 4;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.LblPageTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.PanelHeader.Size = new System.Drawing.Size(915, 56);
            this.PanelHeader.TabIndex = 3;
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.AutoSize = true;
            this.LblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(18, 15);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(150, 29);
            this.LblPageTitle.TabIndex = 1;
            this.LblPageTitle.Text = "Top Creators";
            // 
            // TopWritersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelContentTopArtists);
            this.Controls.Add(this.PanelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TopWritersPage";
            this.Size = new System.Drawing.Size(915, 462);
            this.Load += new System.EventHandler(this.TopArtistsPage_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelContentTopArtists;
        private Panel PanelHeader;
        private Label LblPageTitle;
    }
}
