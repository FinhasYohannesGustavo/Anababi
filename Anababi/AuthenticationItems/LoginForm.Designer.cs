namespace Anababi.AuthenticationItems
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPnl = new System.Windows.Forms.Panel();
            this.loginClearBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.haveAccLinkLbl = new System.Windows.Forms.LinkLabel();
            this.loginUserNameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabelPnl = new System.Windows.Forms.Panel();
            this.loginShowPwdCheckBox = new System.Windows.Forms.CheckBox();
            this.loginPwdTextBox = new System.Windows.Forms.TextBox();
            this.loginUserNameLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.btnPnl.SuspendLayout();
            this.loginLabelPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPnl
            // 
            this.btnPnl.Controls.Add(this.loginClearBtn);
            this.btnPnl.Controls.Add(this.loginBtn);
            this.btnPnl.Controls.Add(this.haveAccLinkLbl);
            this.btnPnl.Location = new System.Drawing.Point(126, 249);
            this.btnPnl.Name = "btnPnl";
            this.btnPnl.Size = new System.Drawing.Size(347, 168);
            this.btnPnl.TabIndex = 38;
            // 
            // loginClearBtn
            // 
            this.loginClearBtn.BackColor = System.Drawing.Color.White;
            this.loginClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginClearBtn.FlatAppearance.BorderSize = 0;
            this.loginClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginClearBtn.ForeColor = System.Drawing.Color.Black;
            this.loginClearBtn.Location = new System.Drawing.Point(62, 59);
            this.loginClearBtn.Name = "loginClearBtn";
            this.loginClearBtn.Size = new System.Drawing.Size(233, 38);
            this.loginClearBtn.TabIndex = 30;
            this.loginClearBtn.Text = "Clear";
            this.loginClearBtn.UseVisualStyleBackColor = false;
            this.loginClearBtn.Click += new System.EventHandler(this.loginClearBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Black;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(62, 16);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(233, 38);
            this.loginBtn.TabIndex = 26;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // haveAccLinkLbl
            // 
            this.haveAccLinkLbl.AutoSize = true;
            this.haveAccLinkLbl.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haveAccLinkLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.haveAccLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.haveAccLinkLbl.LinkColor = System.Drawing.Color.Black;
            this.haveAccLinkLbl.Location = new System.Drawing.Point(114, 99);
            this.haveAccLinkLbl.Name = "haveAccLinkLbl";
            this.haveAccLinkLbl.Size = new System.Drawing.Size(122, 13);
            this.haveAccLinkLbl.TabIndex = 27;
            this.haveAccLinkLbl.TabStop = true;
            this.haveAccLinkLbl.Text = "Don\'t have an account";
            this.haveAccLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginUserNameTextBox
            // 
            this.loginUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.loginUserNameTextBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginUserNameTextBox.Location = new System.Drawing.Point(16, 25);
            this.loginUserNameTextBox.Multiline = true;
            this.loginUserNameTextBox.Name = "loginUserNameTextBox";
            this.loginUserNameTextBox.Size = new System.Drawing.Size(295, 34);
            this.loginUserNameTextBox.TabIndex = 8;
            // 
            // loginLabelPnl
            // 
            this.loginLabelPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabelPnl.Controls.Add(this.loginShowPwdCheckBox);
            this.loginLabelPnl.Controls.Add(this.loginPwdTextBox);
            this.loginLabelPnl.Controls.Add(this.loginUserNameLbl);
            this.loginLabelPnl.Controls.Add(this.loginUserNameTextBox);
            this.loginLabelPnl.Location = new System.Drawing.Point(126, 100);
            this.loginLabelPnl.Name = "loginLabelPnl";
            this.loginLabelPnl.Size = new System.Drawing.Size(347, 143);
            this.loginLabelPnl.TabIndex = 36;
            // 
            // loginShowPwdCheckBox
            // 
            this.loginShowPwdCheckBox.AutoSize = true;
            this.loginShowPwdCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginShowPwdCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginShowPwdCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginShowPwdCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.loginShowPwdCheckBox.Location = new System.Drawing.Point(16, 112);
            this.loginShowPwdCheckBox.Name = "loginShowPwdCheckBox";
            this.loginShowPwdCheckBox.Size = new System.Drawing.Size(97, 20);
            this.loginShowPwdCheckBox.TabIndex = 29;
            this.loginShowPwdCheckBox.Text = "Show Password";
            this.loginShowPwdCheckBox.UseVisualStyleBackColor = true;
            this.loginShowPwdCheckBox.CheckedChanged += new System.EventHandler(this.loginShowPwdCheckBox_CheckedChanged);
            // 
            // loginPwdTextBox
            // 
            this.loginPwdTextBox.BackColor = System.Drawing.Color.White;
            this.loginPwdTextBox.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPwdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.loginPwdTextBox.Location = new System.Drawing.Point(16, 73);
            this.loginPwdTextBox.Multiline = true;
            this.loginPwdTextBox.Name = "loginPwdTextBox";
            this.loginPwdTextBox.Size = new System.Drawing.Size(295, 33);
            this.loginPwdTextBox.TabIndex = 9;
            this.loginPwdTextBox.Text = "Password";
            this.loginPwdTextBox.TextChanged += new System.EventHandler(this.loginPwdTextBox_TextChanged);
            this.loginPwdTextBox.Enter += new System.EventHandler(this.loginPwdTextBox_Enter);
            // 
            // loginUserNameLbl
            // 
            this.loginUserNameLbl.AutoSize = true;
            this.loginUserNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginUserNameLbl.ForeColor = System.Drawing.Color.Gray;
            this.loginUserNameLbl.Location = new System.Drawing.Point(16, 6);
            this.loginUserNameLbl.Name = "loginUserNameLbl";
            this.loginUserNameLbl.Size = new System.Drawing.Size(56, 16);
            this.loginUserNameLbl.TabIndex = 2;
            this.loginUserNameLbl.Text = "Username";
            this.loginUserNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginLbl.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLbl.ForeColor = System.Drawing.Color.Black;
            this.loginLbl.Location = new System.Drawing.Point(240, 37);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(114, 47);
            this.loginLbl.TabIndex = 35;
            this.loginLbl.Text = "Log in";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 466);
            this.Controls.Add(this.btnPnl);
            this.Controls.Add(this.loginLabelPnl);
            this.Controls.Add(this.loginLbl);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLoginForm";
            this.btnPnl.ResumeLayout(false);
            this.btnPnl.PerformLayout();
            this.loginLabelPnl.ResumeLayout(false);
            this.loginLabelPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnPnl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel haveAccLinkLbl;
        private System.Windows.Forms.TextBox loginUserNameTextBox;
        private System.Windows.Forms.Panel loginLabelPnl;
        private System.Windows.Forms.Label loginUserNameLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox loginPwdTextBox;
        private System.Windows.Forms.CheckBox loginShowPwdCheckBox;
        private System.Windows.Forms.Button loginClearBtn;
    }
}