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
            TextBoxSearchBar = new TextBox();
            PanelSearchBar = new Panel();
            PanelSearchResults = new Panel();
            TableLayoutPanelSearchResults = new TableLayoutPanel();
            PanelCreatorsSection = new Panel();
            PanelHeaderCreatorsSection = new Panel();
            LblCreators = new Label();
            PanelReferencesSection = new Panel();
            PanelHeaderReferencesSection = new Panel();
            LblReferences = new Label();
            PanelSearchTypeToggle = new Panel();
            ToggleSearchType = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            PanelLabelsForSearch = new Panel();
            LabelBinarySearch = new Label();
            LabelLinearSearch = new Label();
            PanelContent = new Panel();
            tableLayoutPanelArtistResults = new TableLayoutPanel();
            PanelSearchBar.SuspendLayout();
            PanelSearchResults.SuspendLayout();
            TableLayoutPanelSearchResults.SuspendLayout();
            PanelCreatorsSection.SuspendLayout();
            PanelHeaderCreatorsSection.SuspendLayout();
            PanelReferencesSection.SuspendLayout();
            PanelHeaderReferencesSection.SuspendLayout();
            PanelSearchTypeToggle.SuspendLayout();
            PanelLabelsForSearch.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxSearchBar
            // 
            TextBoxSearchBar.AcceptsReturn = true;
            TextBoxSearchBar.BorderStyle = BorderStyle.None;
            TextBoxSearchBar.Dock = DockStyle.Fill;
            TextBoxSearchBar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxSearchBar.ForeColor = SystemColors.ActiveCaptionText;
            TextBoxSearchBar.Location = new Point(40, 40);
            TextBoxSearchBar.Margin = new Padding(3, 3, 21, 3);
            TextBoxSearchBar.Name = "TextBoxSearchBar";
            TextBoxSearchBar.PlaceholderText = "Interested in...";
            TextBoxSearchBar.Size = new Size(320, 36);
            TextBoxSearchBar.TabIndex = 0;
            TextBoxSearchBar.KeyUp += TextBoxSearchBar_KeyUp;
            // 
            // PanelSearchBar
            // 
            PanelSearchBar.Controls.Add(TextBoxSearchBar);
            PanelSearchBar.Dock = DockStyle.Top;
            PanelSearchBar.Location = new Point(0, 0);
            PanelSearchBar.Name = "PanelSearchBar";
            PanelSearchBar.Padding = new Padding(40);
            PanelSearchBar.Size = new Size(400, 112);
            PanelSearchBar.TabIndex = 1;
            // 
            // PanelSearchResults
            // 
            PanelSearchResults.AutoScroll = true;
            PanelSearchResults.AutoSize = true;
            PanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSearchResults.Controls.Add(TableLayoutPanelSearchResults);
            PanelSearchResults.Controls.Add(PanelSearchTypeToggle);
            PanelSearchResults.Controls.Add(PanelLabelsForSearch);
            PanelSearchResults.Dock = DockStyle.Fill;
            PanelSearchResults.Location = new Point(0, 112);
            PanelSearchResults.MinimumSize = new Size(400, 400);
            PanelSearchResults.Name = "PanelSearchResults";
            PanelSearchResults.Padding = new Padding(40, 0, 40, 40);
            PanelSearchResults.Size = new Size(400, 400);
            PanelSearchResults.TabIndex = 2;
            // 
            // TableLayoutPanelSearchResults
            // 
            TableLayoutPanelSearchResults.AutoSize = true;
            TableLayoutPanelSearchResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelSearchResults.ColumnCount = 1;
            TableLayoutPanelSearchResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelSearchResults.Controls.Add(PanelCreatorsSection, 0, 0);
            TableLayoutPanelSearchResults.Controls.Add(PanelReferencesSection, 0, 1);
            TableLayoutPanelSearchResults.Dock = DockStyle.Top;
            TableLayoutPanelSearchResults.Location = new Point(40, 68);
            TableLayoutPanelSearchResults.Name = "TableLayoutPanelSearchResults";
            TableLayoutPanelSearchResults.RowCount = 3;
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle());
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle());
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSearchResults.Size = new Size(320, 182);
            TableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // PanelCreatorsSection
            // 
            PanelCreatorsSection.AutoScroll = true;
            PanelCreatorsSection.AutoSize = true;
            PanelCreatorsSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelCreatorsSection.BackColor = Color.Transparent;
            PanelCreatorsSection.Controls.Add(PanelHeaderCreatorsSection);
            PanelCreatorsSection.Dock = DockStyle.Top;
            PanelCreatorsSection.Location = new Point(3, 3);
            PanelCreatorsSection.Name = "PanelCreatorsSection";
            PanelCreatorsSection.Size = new Size(314, 75);
            PanelCreatorsSection.TabIndex = 0;
            // 
            // PanelHeaderCreatorsSection
            // 
            PanelHeaderCreatorsSection.AutoScroll = true;
            PanelHeaderCreatorsSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelHeaderCreatorsSection.Controls.Add(LblCreators);
            PanelHeaderCreatorsSection.Dock = DockStyle.Top;
            PanelHeaderCreatorsSection.Location = new Point(0, 0);
            PanelHeaderCreatorsSection.Name = "PanelHeaderCreatorsSection";
            PanelHeaderCreatorsSection.Padding = new Padding(0, 20, 21, 20);
            PanelHeaderCreatorsSection.Size = new Size(314, 75);
            PanelHeaderCreatorsSection.TabIndex = 1;
            // 
            // LblCreators
            // 
            LblCreators.AutoSize = true;
            LblCreators.BackColor = Color.Transparent;
            LblCreators.Dock = DockStyle.Left;
            LblCreators.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblCreators.Location = new Point(0, 20);
            LblCreators.Name = "LblCreators";
            LblCreators.Size = new Size(100, 37);
            LblCreators.TabIndex = 1;
            LblCreators.Text = "Creators";
            // 
            // PanelReferencesSection
            // 
            PanelReferencesSection.AutoScroll = true;
            PanelReferencesSection.AutoSize = true;
            PanelReferencesSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelReferencesSection.Controls.Add(PanelHeaderReferencesSection);
            PanelReferencesSection.Dock = DockStyle.Top;
            PanelReferencesSection.Location = new Point(3, 84);
            PanelReferencesSection.Name = "PanelReferencesSection";
            PanelReferencesSection.Size = new Size(314, 75);
            PanelReferencesSection.TabIndex = 1;
            // 
            // PanelHeaderReferencesSection
            // 
            PanelHeaderReferencesSection.AutoScroll = true;
            PanelHeaderReferencesSection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelHeaderReferencesSection.Controls.Add(LblReferences);
            PanelHeaderReferencesSection.Dock = DockStyle.Top;
            PanelHeaderReferencesSection.Location = new Point(0, 0);
            PanelHeaderReferencesSection.Name = "PanelHeaderReferencesSection";
            PanelHeaderReferencesSection.Padding = new Padding(0, 20, 21, 20);
            PanelHeaderReferencesSection.Size = new Size(314, 75);
            PanelHeaderReferencesSection.TabIndex = 1;
            // 
            // LblReferences
            // 
            LblReferences.AutoSize = true;
            LblReferences.BackColor = Color.Transparent;
            LblReferences.Dock = DockStyle.Left;
            LblReferences.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblReferences.Location = new Point(0, 20);
            LblReferences.Name = "LblReferences";
            LblReferences.Size = new Size(141, 37);
            LblReferences.TabIndex = 1;
            LblReferences.Text = "References";
            // 
            // PanelSearchTypeToggle
            // 
            PanelSearchTypeToggle.Controls.Add(ToggleSearchType);
            PanelSearchTypeToggle.Dock = DockStyle.Top;
            PanelSearchTypeToggle.Location = new Point(40, 40);
            PanelSearchTypeToggle.Margin = new Padding(3, 4, 3, 4);
            PanelSearchTypeToggle.Name = "PanelSearchTypeToggle";
            PanelSearchTypeToggle.Size = new Size(320, 28);
            PanelSearchTypeToggle.TabIndex = 1;
            // 
            // ToggleSearchType
            // 
            ToggleSearchType.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ToggleSearchType.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ToggleSearchType.CheckedState.InnerBorderColor = Color.White;
            ToggleSearchType.CheckedState.InnerColor = Color.White;
            ToggleSearchType.CustomizableEdges = customizableEdges1;
            ToggleSearchType.Dock = DockStyle.Fill;
            ToggleSearchType.Location = new Point(0, 0);
            ToggleSearchType.Margin = new Padding(3, 4, 3, 4);
            ToggleSearchType.Name = "ToggleSearchType";
            ToggleSearchType.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ToggleSearchType.Size = new Size(320, 28);
            ToggleSearchType.TabIndex = 0;
            ToggleSearchType.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ToggleSearchType.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ToggleSearchType.UncheckedState.InnerBorderColor = Color.White;
            ToggleSearchType.UncheckedState.InnerColor = Color.White;
            // 
            // PanelLabelsForSearch
            // 
            PanelLabelsForSearch.Controls.Add(LabelBinarySearch);
            PanelLabelsForSearch.Controls.Add(LabelLinearSearch);
            PanelLabelsForSearch.Dock = DockStyle.Top;
            PanelLabelsForSearch.Location = new Point(40, 0);
            PanelLabelsForSearch.Margin = new Padding(3, 4, 3, 4);
            PanelLabelsForSearch.Name = "PanelLabelsForSearch";
            PanelLabelsForSearch.Size = new Size(320, 40);
            PanelLabelsForSearch.TabIndex = 2;
            // 
            // LabelBinarySearch
            // 
            LabelBinarySearch.AutoSize = true;
            LabelBinarySearch.Dock = DockStyle.Right;
            LabelBinarySearch.FlatStyle = FlatStyle.Popup;
            LabelBinarySearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBinarySearch.Location = new Point(177, 0);
            LabelBinarySearch.Name = "LabelBinarySearch";
            LabelBinarySearch.Size = new Size(143, 23);
            LabelBinarySearch.TabIndex = 1;
            LabelBinarySearch.Text = "Binary Search";
            // 
            // LabelLinearSearch
            // 
            LabelLinearSearch.AutoSize = true;
            LabelLinearSearch.Dock = DockStyle.Left;
            LabelLinearSearch.FlatStyle = FlatStyle.Popup;
            LabelLinearSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLinearSearch.Location = new Point(0, 0);
            LabelLinearSearch.Name = "LabelLinearSearch";
            LabelLinearSearch.Size = new Size(141, 23);
            LabelLinearSearch.TabIndex = 0;
            LabelLinearSearch.Text = "Linear Search";
            // 
            // PanelContent
            // 
            PanelContent.Location = new Point(0, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(200, 100);
            PanelContent.TabIndex = 0;
            // 
            // tableLayoutPanelArtistResults
            // 
            tableLayoutPanelArtistResults.AutoScroll = true;
            tableLayoutPanelArtistResults.ColumnCount = 3;
            tableLayoutPanelArtistResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanelArtistResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanelArtistResults.Dock = DockStyle.Fill;
            tableLayoutPanelArtistResults.Location = new Point(0, 0);
            tableLayoutPanelArtistResults.Margin = new Padding(10);
            tableLayoutPanelArtistResults.MinimumSize = new Size(400, 400);
            tableLayoutPanelArtistResults.Name = "tableLayoutPanelArtistResults";
            tableLayoutPanelArtistResults.RowCount = 3;
            tableLayoutPanelArtistResults.Size = new Size(400, 400);
            tableLayoutPanelArtistResults.TabIndex = 0;
            // 
            // SearchDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(PanelSearchResults);
            Controls.Add(PanelSearchBar);
            Name = "SearchDisplay";
            Size = new Size(400, 512);
            Load += SearchDisplay_Load;
            PanelSearchBar.ResumeLayout(false);
            PanelSearchBar.PerformLayout();
            PanelSearchResults.ResumeLayout(false);
            PanelSearchResults.PerformLayout();
            TableLayoutPanelSearchResults.ResumeLayout(false);
            TableLayoutPanelSearchResults.PerformLayout();
            PanelCreatorsSection.ResumeLayout(false);
            PanelHeaderCreatorsSection.ResumeLayout(false);
            PanelHeaderCreatorsSection.PerformLayout();
            PanelReferencesSection.ResumeLayout(false);
            PanelHeaderReferencesSection.ResumeLayout(false);
            PanelHeaderReferencesSection.PerformLayout();
            PanelSearchTypeToggle.ResumeLayout(false);
            PanelLabelsForSearch.ResumeLayout(false);
            PanelLabelsForSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxSearchBar;
        private Panel PanelSearchBar;
        private Panel PanelSearchResults;
        private TableLayoutPanel TableLayoutPanelSearchResults;
        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanelArtistResults;
        private Panel PanelReferencesSection;
        private Panel PanelCreatorsSection;
        private Panel PanelHeaderReferencesSection;
        private Label LblReferences;
        private Panel PanelHeaderCreatorsSection;
        private Label LblCreators;
        private Panel PanelSearchTypeToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSearchType;
        private Panel PanelLabelsForSearch;
        private Label LabelBinarySearch;
        private Label LabelLinearSearch;
    }
}
