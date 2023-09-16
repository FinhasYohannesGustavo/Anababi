namespace Anababi.UserControls
{
    partial class SearchDisplay
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.PanelSearchBar = new System.Windows.Forms.Panel();
            this.PanelSearchResults = new System.Windows.Forms.Panel();
            this.TableLayoutPanelSearchResults = new System.Windows.Forms.TableLayoutPanel();
            this.PanelArtistsSection = new System.Windows.Forms.Panel();
            this.PanelHeaderArtistsSection = new System.Windows.Forms.Panel();
            this.LblArtists = new System.Windows.Forms.Label();
            this.PanelArtworksSection = new System.Windows.Forms.Panel();
            this.PanelHeaderArtworksSection = new System.Windows.Forms.Panel();
            this.LblArtworks = new System.Windows.Forms.Label();
            this.PanelSearchTypeToggle = new System.Windows.Forms.Panel();
            this.ToggleSearchType = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.PanelLabelsForSearch = new System.Windows.Forms.Panel();
            this.LabelBinarySearch = new System.Windows.Forms.Label();
            this.LabelLinearSearch = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanelArtistResults = new System.Windows.Forms.TableLayoutPanel();
            this.PanelSearchBar.SuspendLayout();
            this.PanelSearchResults.SuspendLayout();
            this.TableLayoutPanelSearchResults.SuspendLayout();
            this.PanelArtistsSection.SuspendLayout();
            this.PanelHeaderArtistsSection.SuspendLayout();
            this.PanelArtworksSection.SuspendLayout();
            this.PanelHeaderArtworksSection.SuspendLayout();
            this.PanelSearchTypeToggle.SuspendLayout();
            this.PanelLabelsForSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.AcceptsReturn = true;
            this.TextBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearchBar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSearchBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxSearchBar.Location = new System.Drawing.Point(35, 30);
            this.TextBoxSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 18, 2);
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.PlaceholderText = "Interested in...";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(280, 29);
            this.TextBoxSearchBar.TabIndex = 0;
            this.TextBoxSearchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchBar_KeyUp);
            // 
            // PanelSearchBar
            // 
            this.PanelSearchBar.Controls.Add(this.TextBoxSearchBar);
            this.PanelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelSearchBar.Name = "PanelSearchBar";
            this.PanelSearchBar.Padding = new System.Windows.Forms.Padding(35, 30, 35, 30);
            this.PanelSearchBar.Size = new System.Drawing.Size(350, 84);
            this.PanelSearchBar.TabIndex = 1;
            // 
            // PanelSearchResults
            // 
            this.PanelSearchResults.AutoScroll = true;
            this.PanelSearchResults.AutoSize = true;
            this.PanelSearchResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelSearchResults.Controls.Add(this.TableLayoutPanelSearchResults);
            this.PanelSearchResults.Controls.Add(this.PanelSearchTypeToggle);
            this.PanelSearchResults.Controls.Add(this.PanelLabelsForSearch);
            this.PanelSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearchResults.Location = new System.Drawing.Point(0, 84);
            this.PanelSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelSearchResults.MinimumSize = new System.Drawing.Size(350, 300);
            this.PanelSearchResults.Name = "PanelSearchResults";
            this.PanelSearchResults.Padding = new System.Windows.Forms.Padding(35, 0, 35, 30);
            this.PanelSearchResults.Size = new System.Drawing.Size(350, 300);
            this.PanelSearchResults.TabIndex = 2;
            // 
            // TableLayoutPanelSearchResults
            // 
            this.TableLayoutPanelSearchResults.AutoSize = true;
            this.TableLayoutPanelSearchResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelSearchResults.ColumnCount = 1;
            this.TableLayoutPanelSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelSearchResults.Controls.Add(this.PanelArtistsSection, 0, 0);
            this.TableLayoutPanelSearchResults.Controls.Add(this.PanelArtworksSection, 0, 1);
            this.TableLayoutPanelSearchResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelSearchResults.Location = new System.Drawing.Point(35, 51);
            this.TableLayoutPanelSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanelSearchResults.Name = "TableLayoutPanelSearchResults";
            this.TableLayoutPanelSearchResults.RowCount = 3;
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanelSearchResults.Size = new System.Drawing.Size(280, 135);
            this.TableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // PanelArtistsSection
            // 
            this.PanelArtistsSection.AutoScroll = true;
            this.PanelArtistsSection.AutoSize = true;
            this.PanelArtistsSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelArtistsSection.BackColor = System.Drawing.Color.Transparent;
            this.PanelArtistsSection.Controls.Add(this.PanelHeaderArtistsSection);
            this.PanelArtistsSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArtistsSection.Location = new System.Drawing.Point(3, 2);
            this.PanelArtistsSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelArtistsSection.Name = "PanelArtistsSection";
            this.PanelArtistsSection.Size = new System.Drawing.Size(274, 56);
            this.PanelArtistsSection.TabIndex = 0;
            // 
            // PanelHeaderArtistsSection
            // 
            this.PanelHeaderArtistsSection.AutoScroll = true;
            this.PanelHeaderArtistsSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelHeaderArtistsSection.Controls.Add(this.LblArtists);
            this.PanelHeaderArtistsSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderArtistsSection.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderArtistsSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelHeaderArtistsSection.Name = "PanelHeaderArtistsSection";
            this.PanelHeaderArtistsSection.Padding = new System.Windows.Forms.Padding(0, 15, 18, 15);
            this.PanelHeaderArtistsSection.Size = new System.Drawing.Size(274, 56);
            this.PanelHeaderArtistsSection.TabIndex = 1;
            // 
            // LblArtists
            // 
            this.LblArtists.AutoSize = true;
            this.LblArtists.BackColor = System.Drawing.Color.Transparent;
            this.LblArtists.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblArtists.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblArtists.Location = new System.Drawing.Point(0, 15);
            this.LblArtists.Name = "LblArtists";
            this.LblArtists.Size = new System.Drawing.Size(80, 28);
            this.LblArtists.TabIndex = 1;
            this.LblArtists.Text = "Artists";
            // 
            // PanelArtworksSection
            // 
            this.PanelArtworksSection.AutoScroll = true;
            this.PanelArtworksSection.AutoSize = true;
            this.PanelArtworksSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelArtworksSection.Controls.Add(this.PanelHeaderArtworksSection);
            this.PanelArtworksSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArtworksSection.Location = new System.Drawing.Point(3, 62);
            this.PanelArtworksSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelArtworksSection.Name = "PanelArtworksSection";
            this.PanelArtworksSection.Size = new System.Drawing.Size(274, 56);
            this.PanelArtworksSection.TabIndex = 1;
            // 
            // PanelHeaderArtworksSection
            // 
            this.PanelHeaderArtworksSection.AutoScroll = true;
            this.PanelHeaderArtworksSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelHeaderArtworksSection.Controls.Add(this.LblArtworks);
            this.PanelHeaderArtworksSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderArtworksSection.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderArtworksSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelHeaderArtworksSection.Name = "PanelHeaderArtworksSection";
            this.PanelHeaderArtworksSection.Padding = new System.Windows.Forms.Padding(0, 15, 18, 15);
            this.PanelHeaderArtworksSection.Size = new System.Drawing.Size(274, 56);
            this.PanelHeaderArtworksSection.TabIndex = 1;
            // 
            // LblArtworks
            // 
            this.LblArtworks.AutoSize = true;
            this.LblArtworks.BackColor = System.Drawing.Color.Transparent;
            this.LblArtworks.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblArtworks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblArtworks.Location = new System.Drawing.Point(0, 15);
            this.LblArtworks.Name = "LblArtworks";
            this.LblArtworks.Size = new System.Drawing.Size(112, 28);
            this.LblArtworks.TabIndex = 1;
            this.LblArtworks.Text = "Artworks";
            // 
            // PanelSearchTypeToggle
            // 
            this.PanelSearchTypeToggle.Controls.Add(this.ToggleSearchType);
            this.PanelSearchTypeToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchTypeToggle.Location = new System.Drawing.Point(35, 30);
            this.PanelSearchTypeToggle.Name = "PanelSearchTypeToggle";
            this.PanelSearchTypeToggle.Size = new System.Drawing.Size(280, 21);
            this.PanelSearchTypeToggle.TabIndex = 1;
            // 
            // ToggleSearchType
            // 
            this.ToggleSearchType.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSearchType.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSearchType.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSearchType.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSearchType.CustomizableEdges = customizableEdges1;
            this.ToggleSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggleSearchType.Location = new System.Drawing.Point(0, 0);
            this.ToggleSearchType.Name = "ToggleSearchType";
            this.ToggleSearchType.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ToggleSearchType.Size = new System.Drawing.Size(280, 21);
            this.ToggleSearchType.TabIndex = 0;
            this.ToggleSearchType.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSearchType.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSearchType.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSearchType.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // PanelLabelsForSearch
            // 
            this.PanelLabelsForSearch.Controls.Add(this.LabelBinarySearch);
            this.PanelLabelsForSearch.Controls.Add(this.LabelLinearSearch);
            this.PanelLabelsForSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLabelsForSearch.Location = new System.Drawing.Point(35, 0);
            this.PanelLabelsForSearch.Name = "PanelLabelsForSearch";
            this.PanelLabelsForSearch.Size = new System.Drawing.Size(280, 30);
            this.PanelLabelsForSearch.TabIndex = 2;
            // 
            // LabelBinarySearch
            // 
            this.LabelBinarySearch.AutoSize = true;
            this.LabelBinarySearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelBinarySearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelBinarySearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelBinarySearch.Location = new System.Drawing.Point(165, 0);
            this.LabelBinarySearch.Name = "LabelBinarySearch";
            this.LabelBinarySearch.Size = new System.Drawing.Size(115, 19);
            this.LabelBinarySearch.TabIndex = 1;
            this.LabelBinarySearch.Text = "Binary Search";
            // 
            // LabelLinearSearch
            // 
            this.LabelLinearSearch.AutoSize = true;
            this.LabelLinearSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelLinearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelLinearSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLinearSearch.Location = new System.Drawing.Point(0, 0);
            this.LabelLinearSearch.Name = "LabelLinearSearch";
            this.LabelLinearSearch.Size = new System.Drawing.Size(114, 19);
            this.LabelLinearSearch.TabIndex = 0;
            this.LabelLinearSearch.Text = "Linear Search";
            // 
            // PanelContent
            // 
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(200, 100);
            this.PanelContent.TabIndex = 0;
            // 
            // tableLayoutPanelArtistResults
            // 
            this.tableLayoutPanelArtistResults.AutoScroll = true;
            this.tableLayoutPanelArtistResults.ColumnCount = 3;
            this.tableLayoutPanelArtistResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelArtistResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelArtistResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelArtistResults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelArtistResults.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelArtistResults.MinimumSize = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelArtistResults.Name = "tableLayoutPanelArtistResults";
            this.tableLayoutPanelArtistResults.RowCount = 3;
            this.tableLayoutPanelArtistResults.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelArtistResults.TabIndex = 0;
            // 
            // SearchDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelSearchResults);
            this.Controls.Add(this.PanelSearchBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchDisplay";
            this.Size = new System.Drawing.Size(350, 384);
            this.Load += new System.EventHandler(this.SearchDisplay_Load);
            this.PanelSearchBar.ResumeLayout(false);
            this.PanelSearchBar.PerformLayout();
            this.PanelSearchResults.ResumeLayout(false);
            this.PanelSearchResults.PerformLayout();
            this.TableLayoutPanelSearchResults.ResumeLayout(false);
            this.TableLayoutPanelSearchResults.PerformLayout();
            this.PanelArtistsSection.ResumeLayout(false);
            this.PanelHeaderArtistsSection.ResumeLayout(false);
            this.PanelHeaderArtistsSection.PerformLayout();
            this.PanelArtworksSection.ResumeLayout(false);
            this.PanelHeaderArtworksSection.ResumeLayout(false);
            this.PanelHeaderArtworksSection.PerformLayout();
            this.PanelSearchTypeToggle.ResumeLayout(false);
            this.PanelLabelsForSearch.ResumeLayout(false);
            this.PanelLabelsForSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxSearchBar;
        private Panel PanelSearchBar;
        private Panel PanelSearchResults;
        private TableLayoutPanel TableLayoutPanelSearchResults;
        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanelArtistResults;
        private Panel PanelArtworksSection;
        private Panel PanelArtistsSection;
        private Panel PanelHeaderArtworksSection;
        private Label LblArtworks;
        private Panel PanelHeaderArtistsSection;
        private Label LblArtists;
        private Panel PanelSearchTypeToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSearchType;
        private Panel PanelLabelsForSearch;
        private Label LabelBinarySearch;
        private Label LabelLinearSearch;
    }
}
