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
            this.PanelContentTopCreators = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContentTopCreators
            // 
            this.PanelContentTopCreators.AutoScroll = true;
            this.PanelContentTopCreators.AutoSize = true;
            this.PanelContentTopCreators.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelContentTopCreators.Location = new System.Drawing.Point(0, 56);
            this.PanelContentTopCreators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContentTopCreators.Name = "PanelContentTopCreators";
            this.PanelContentTopCreators.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.PanelContentTopCreators.Size = new System.Drawing.Size(915, 30);
            this.PanelContentTopCreators.TabIndex = 4;
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
            this.Controls.Add(this.PanelContentTopCreators);
            this.Controls.Add(this.PanelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TopWritersPage";
            this.Size = new System.Drawing.Size(915, 462);
            this.Load += new System.EventHandler(this.TopCreatorsPage_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelContentTopCreators;
        private Panel PanelHeader;
        private Label LblPageTitle;
    }
}
