﻿namespace Anababi.UserControls
{
        partial class TopReferencesPage
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
                this.PanelHeader = new System.Windows.Forms.Panel();
                this.LblPageTitle = new System.Windows.Forms.Label();
                this.tableLayoutPanelAllReferences = new System.Windows.Forms.TableLayoutPanel();
                this.PanelHeader.SuspendLayout();
                this.SuspendLayout();
                // 
                // PanelHeader
                // 
                this.PanelHeader.Controls.Add(this.LblPageTitle);
                this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
                this.PanelHeader.Location = new System.Drawing.Point(0, 0);
                this.PanelHeader.Name = "PanelHeader";
                this.PanelHeader.Padding = new System.Windows.Forms.Padding(20);
                this.PanelHeader.Size = new System.Drawing.Size(953, 74);
                this.PanelHeader.TabIndex = 0;
                // 
                // LblPageTitle
                // 
                this.LblPageTitle.AutoSize = true;
                this.LblPageTitle.BackColor = System.Drawing.Color.Transparent;
                this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
                this.LblPageTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.LblPageTitle.Location = new System.Drawing.Point(20, 20);
                this.LblPageTitle.Name = "LblPageTitle";
                this.LblPageTitle.Size = new System.Drawing.Size(201, 37);
                this.LblPageTitle.TabIndex = 1;
                this.LblPageTitle.Text = "Top References";
                // 
                // tableLayoutPanelAllReferences
                // 
                this.tableLayoutPanelAllReferences.AutoScroll = true;
                this.tableLayoutPanelAllReferences.AutoSize = true;
                this.tableLayoutPanelAllReferences.ColumnCount = 1;
                this.tableLayoutPanelAllReferences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                this.tableLayoutPanelAllReferences.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanelAllReferences.Location = new System.Drawing.Point(0, 74);
                this.tableLayoutPanelAllReferences.Margin = new System.Windows.Forms.Padding(10);
                this.tableLayoutPanelAllReferences.MinimumSize = new System.Drawing.Size(400, 400);
                this.tableLayoutPanelAllReferences.Name = "tableLayoutPanelAllReferences";
                this.tableLayoutPanelAllReferences.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
                this.tableLayoutPanelAllReferences.RowCount = 3;
                this.tableLayoutPanelAllReferences.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanelAllReferences.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanelAllReferences.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanelAllReferences.Size = new System.Drawing.Size(953, 2200);
                this.tableLayoutPanelAllReferences.TabIndex = 3;
                // 
                // TopbooksPage
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScroll = true;
                this.AutoSize = true;
                this.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(this.tableLayoutPanelAllReferences);
                this.Controls.Add(this.PanelHeader);
                this.Name = "TopReferencesPage";
                this.Size = new System.Drawing.Size(953, 2274);
                this.Load += new System.EventHandler(this.TopBooksPage_Load);
                this.PanelHeader.ResumeLayout(false);
                this.PanelHeader.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private Panel PanelHeader;
            private Label LblPageTitle;
            private TableLayoutPanel tableLayoutPanelAllReferences;
        }
    }
