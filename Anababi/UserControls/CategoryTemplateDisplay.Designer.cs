namespace Anababi.UserControls
{
    partial class CategoryTemplateDisplay
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
            this.PanelCategoryHeader = new System.Windows.Forms.Panel();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.PanelCategoryHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCategoryHeader
            // 
            this.PanelCategoryHeader.Controls.Add(this.LblCategoryName);
            this.PanelCategoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCategoryHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelCategoryHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCategoryHeader.Name = "PanelCategoryHeader";
            this.PanelCategoryHeader.Padding = new System.Windows.Forms.Padding(0, 15, 18, 15);
            this.PanelCategoryHeader.Size = new System.Drawing.Size(700, 56);
            this.PanelCategoryHeader.TabIndex = 3;
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.LblCategoryName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCategoryName.Location = new System.Drawing.Point(0, 15);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(201, 29);
            this.LblCategoryName.TabIndex = 1;
            this.LblCategoryName.Text = "Category_Name";
            // 
            // CategoryTemplateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelCategoryHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(700, 225);
            this.Name = "CategoryTemplateDisplay";
            this.Size = new System.Drawing.Size(700, 225);
            this.PanelCategoryHeader.ResumeLayout(false);
            this.PanelCategoryHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelCategoryHeader;
        private Label LblCategoryName;
    }
}

