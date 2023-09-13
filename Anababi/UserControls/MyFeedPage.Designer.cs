namespace Anababi.UserControls
{
    partial class MyFeedPage
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
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAllArtworks = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPageTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Size = new System.Drawing.Size(175, 44);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "My Feed";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Controls.Add(this.LblPageTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.PanelHeader.Size = new System.Drawing.Size(1129, 84);
            this.PanelHeader.TabIndex = 2;
            // 
            // tableLayoutPanelAllArtworks
            // 
            this.tableLayoutPanelAllArtworks.AutoScroll = true;
            this.tableLayoutPanelAllArtworks.AutoSize = true;
            this.tableLayoutPanelAllArtworks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAllArtworks.ColumnCount = 1;
            this.tableLayoutPanelAllArtworks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAllArtworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAllArtworks.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanelAllArtworks.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelAllArtworks.MinimumSize = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelAllArtworks.Name = "tableLayoutPanelAllArtworks";
            this.tableLayoutPanelAllArtworks.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanelAllArtworks.RowCount = 3;
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAllArtworks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAllArtworks.Size = new System.Drawing.Size(1129, 2200);
            this.tableLayoutPanelAllArtworks.TabIndex = 2;
            // 
            // MyFeedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelAllArtworks);
            this.Controls.Add(this.PanelHeader);
            this.Name = "MyFeedPage";
            this.Size = new System.Drawing.Size(1129, 2284);
            this.Load += new System.EventHandler(this.MyFeedPage_Load);
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblPageTitle;
        private Panel PanelHeader;
        private TableLayoutPanel tableLayoutPanelAllArtworks;
    }
}
