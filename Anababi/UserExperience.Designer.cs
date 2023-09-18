namespace Anababi
{
    partial class UserExperience
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SplitContainerAll = new SplitContainer();
            PanelNavButtons = new Panel();
            PanelNavAppInfo = new Panel();
            label1 = new Label();
            LblAppName = new Label();
            PanelNavUserInfo = new Panel();
            LblUsername = new Label();
            LblFullName = new Label();
            guna2CirclePictureBoxProfilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            PanelContent = new Panel();
            PanelHeader = new Panel();
            sortIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            BtnNavigation = new Guna.UI2.WinForms.Guna2ImageButton();
            BtnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)SplitContainerAll).BeginInit();
            SplitContainerAll.Panel1.SuspendLayout();
            SplitContainerAll.Panel2.SuspendLayout();
            SplitContainerAll.SuspendLayout();
            PanelNavAppInfo.SuspendLayout();
            PanelNavUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBoxProfilePic).BeginInit();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sortIcon).BeginInit();
            SuspendLayout();
            // 
            // SplitContainerAll
            // 
            SplitContainerAll.BackColor = SystemColors.ControlLightLight;
            SplitContainerAll.Dock = DockStyle.Fill;
            SplitContainerAll.FixedPanel = FixedPanel.Panel1;
            SplitContainerAll.Location = new Point(0, 0);
            SplitContainerAll.Name = "SplitContainerAll";
            // 
            // SplitContainerAll.Panel1
            // 
            SplitContainerAll.Panel1.AccessibleName = "PanelNavigation";
            SplitContainerAll.Panel1.Controls.Add(PanelNavButtons);
            SplitContainerAll.Panel1.Controls.Add(PanelNavAppInfo);
            SplitContainerAll.Panel1.Controls.Add(PanelNavUserInfo);
            // 
            // SplitContainerAll.Panel2
            // 
            SplitContainerAll.Panel2.AccessibleName = "PanelContent";
            SplitContainerAll.Panel2.AutoScroll = true;
            SplitContainerAll.Panel2.Controls.Add(PanelContent);
            SplitContainerAll.Panel2.Controls.Add(PanelHeader);
            SplitContainerAll.Size = new Size(1200, 715);
            SplitContainerAll.SplitterDistance = 244;
            SplitContainerAll.SplitterWidth = 5;
            SplitContainerAll.TabIndex = 8;
            // 
            // PanelNavButtons
            // 
            PanelNavButtons.BackColor = Color.Transparent;
            PanelNavButtons.Dock = DockStyle.Fill;
            PanelNavButtons.Location = new Point(0, 248);
            PanelNavButtons.Name = "PanelNavButtons";
            PanelNavButtons.Size = new Size(244, 368);
            PanelNavButtons.TabIndex = 17;
            // 
            // PanelNavAppInfo
            // 
            PanelNavAppInfo.BackColor = SystemColors.ControlLight;
            PanelNavAppInfo.Controls.Add(label1);
            PanelNavAppInfo.Controls.Add(LblAppName);
            PanelNavAppInfo.Dock = DockStyle.Bottom;
            PanelNavAppInfo.Location = new Point(0, 616);
            PanelNavAppInfo.Name = "PanelNavAppInfo";
            PanelNavAppInfo.Size = new Size(244, 99);
            PanelNavAppInfo.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "Version 1.0 x64";
            // 
            // LblAppName
            // 
            LblAppName.AutoSize = true;
            LblAppName.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblAppName.Location = new Point(3, 47);
            LblAppName.Name = "LblAppName";
            LblAppName.Size = new Size(86, 22);
            LblAppName.TabIndex = 0;
            LblAppName.Text = "Anababi";
            // 
            // PanelNavUserInfo
            // 
            PanelNavUserInfo.BackColor = SystemColors.ControlLight;
            PanelNavUserInfo.Controls.Add(LblUsername);
            PanelNavUserInfo.Controls.Add(LblFullName);
            PanelNavUserInfo.Controls.Add(guna2CirclePictureBoxProfilePic);
            PanelNavUserInfo.Dock = DockStyle.Top;
            PanelNavUserInfo.Location = new Point(0, 0);
            PanelNavUserInfo.Name = "PanelNavUserInfo";
            PanelNavUserInfo.Size = new Size(244, 248);
            PanelNavUserInfo.TabIndex = 13;
            // 
            // LblUsername
            // 
            LblUsername.Anchor = AnchorStyles.None;
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsername.ForeColor = SystemColors.ControlDarkDark;
            LblUsername.Location = new Point(75, 118);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(93, 18);
            LblUsername.TabIndex = 17;
            LblUsername.Text = "@Username";
            LblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblFullName
            // 
            LblFullName.Anchor = AnchorStyles.None;
            LblFullName.AutoSize = true;
            LblFullName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblFullName.Location = new Point(44, 91);
            LblFullName.Name = "LblFullName";
            LblFullName.Size = new Size(155, 18);
            LblFullName.TabIndex = 17;
            LblFullName.Text = "FirstName LastName";
            LblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBoxProfilePic
            // 
            guna2CirclePictureBoxProfilePic.Anchor = AnchorStyles.None;
            guna2CirclePictureBoxProfilePic.Image = Properties.Resources.user;
            guna2CirclePictureBoxProfilePic.ImageRotate = 0F;
            guna2CirclePictureBoxProfilePic.Location = new Point(95, 16);
            guna2CirclePictureBoxProfilePic.Name = "guna2CirclePictureBoxProfilePic";
            guna2CirclePictureBoxProfilePic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBoxProfilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBoxProfilePic.Size = new Size(55, 59);
            guna2CirclePictureBoxProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBoxProfilePic.TabIndex = 16;
            guna2CirclePictureBoxProfilePic.TabStop = false;
            // 
            // PanelContent
            // 
            PanelContent.AutoScroll = true;
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(0, 85);
            PanelContent.Margin = new Padding(10, 11, 10, 11);
            PanelContent.Name = "PanelContent";
            PanelContent.Padding = new Padding(21, 20, 21, 20);
            PanelContent.Size = new Size(951, 630);
            PanelContent.TabIndex = 10;
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(sortIcon);
            PanelHeader.Controls.Add(cmbSort);
            PanelHeader.Controls.Add(BtnNavigation);
            PanelHeader.Controls.Add(BtnSearch);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Padding = new Padding(21, 20, 21, 20);
            PanelHeader.Size = new Size(951, 85);
            PanelHeader.TabIndex = 9;
            // 
            // sortIcon
            // 
            sortIcon.Dock = DockStyle.Right;
            sortIcon.Image = Properties.Resources.sortingIcon;
            sortIcon.ImageRotate = 0F;
            sortIcon.Location = new Point(592, 20);
            sortIcon.Name = "sortIcon";
            sortIcon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            sortIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            sortIcon.Size = new Size(93, 45);
            sortIcon.SizeMode = PictureBoxSizeMode.Zoom;
            sortIcon.TabIndex = 17;
            sortIcon.TabStop = false;
            // 
            // cmbSort
            // 
            cmbSort.BackColor = Color.Transparent;
            cmbSort.BorderColor = Color.Transparent;
            cmbSort.BorderRadius = 7;
            cmbSort.CustomizableEdges = customizableEdges3;
            cmbSort.Dock = DockStyle.Right;
            cmbSort.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbSort.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbSort.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSort.ForeColor = Color.FromArgb(68, 88, 112);
            cmbSort.ItemHeight = 30;
            cmbSort.Items.AddRange(new object[] { "Author", "Published Date", "Title" });
            cmbSort.ItemsAppearance.Font = new Font("Maiandra GD", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSort.ItemsAppearance.SelectedBackColor = Color.LightSkyBlue;
            cmbSort.Location = new Point(685, 20);
            cmbSort.Margin = new Padding(3, 4, 3, 4);
            cmbSort.Name = "cmbSort";
            cmbSort.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbSort.Size = new Size(161, 36);
            cmbSort.Sorted = true;
            cmbSort.TabIndex = 10;
            cmbSort.Tag = "Sort By";
            cmbSort.SelectedValueChanged += UserExperience_Load;
            // 
            // BtnNavigation
            // 
            BtnNavigation.BackColor = Color.Transparent;
            BtnNavigation.CheckedState.ImageSize = new Size(40, 40);
            BtnNavigation.Dock = DockStyle.Left;
            BtnNavigation.HoverState.ImageSize = new Size(45, 45);
            BtnNavigation.Image = Properties.Resources.menu_bar;
            BtnNavigation.ImageOffset = new Point(0, 0);
            BtnNavigation.ImageRotate = 0F;
            BtnNavigation.ImageSize = new Size(40, 40);
            BtnNavigation.Location = new Point(21, 20);
            BtnNavigation.Margin = new Padding(6, 5, 6, 5);
            BtnNavigation.Name = "BtnNavigation";
            BtnNavigation.PressedState.ImageSize = new Size(40, 40);
            BtnNavigation.ShadowDecoration.CustomizableEdges = customizableEdges5;
            BtnNavigation.Size = new Size(57, 45);
            BtnNavigation.TabIndex = 9;
            BtnNavigation.Click += BtnNavigation_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.AccessibleRole = AccessibleRole.None;
            BtnSearch.BackColor = Color.Transparent;
            BtnSearch.CheckedState.ImageSize = new Size(40, 40);
            BtnSearch.Dock = DockStyle.Right;
            BtnSearch.HoverState.ImageSize = new Size(45, 45);
            BtnSearch.Image = Properties.Resources.loupe;
            BtnSearch.ImageOffset = new Point(0, 0);
            BtnSearch.ImageRotate = 0F;
            BtnSearch.ImageSize = new Size(35, 35);
            BtnSearch.Location = new Point(846, 20);
            BtnSearch.Margin = new Padding(6, 5, 6, 5);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.PressedState.ImageSize = new Size(40, 40);
            BtnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnSearch.Size = new Size(84, 45);
            BtnSearch.TabIndex = 9;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // UserExperience
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            Controls.Add(SplitContainerAll);
            Name = "UserExperience";
            Size = new Size(1200, 715);
            Load += UserExperience_Load;
            SplitContainerAll.Panel1.ResumeLayout(false);
            SplitContainerAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerAll).EndInit();
            SplitContainerAll.ResumeLayout(false);
            PanelNavAppInfo.ResumeLayout(false);
            PanelNavAppInfo.PerformLayout();
            PanelNavUserInfo.ResumeLayout(false);
            PanelNavUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBoxProfilePic).EndInit();
            PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sortIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer SplitContainerAll;
        private Panel PanelHeader;
        private Panel PanelContent;
        private Panel PanelNavUserInfo;
        private Panel PanelNavAppInfo;
        private Guna.UI2.WinForms.Guna2ImageButton BtnNavigation;
        private Guna.UI2.WinForms.Guna2ImageButton BtnSearch;
        private Label LblFullName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBoxProfilePic;
        private Label label1;
        private Label LblAppName;
        private Label LblUsername;
        private Panel PanelNavButtons;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2CirclePictureBox sortIcon;
    }
}