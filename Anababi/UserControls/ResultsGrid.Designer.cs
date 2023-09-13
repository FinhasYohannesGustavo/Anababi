namespace Anababi.UserControls
{
        partial class ResultsGrid
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
                this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
                this.SuspendLayout();
                // 
                // tableLayoutPanelResults
                // 
                this.tableLayoutPanelResults.AutoSize = true;
                this.tableLayoutPanelResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.tableLayoutPanelResults.ColumnCount = 3;
                this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
                this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
                this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
                this.tableLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Top;
                this.tableLayoutPanelResults.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanelResults.Margin = new System.Windows.Forms.Padding(0);
                this.tableLayoutPanelResults.MinimumSize = new System.Drawing.Size(400, 200);
                this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
                this.tableLayoutPanelResults.RowCount = 1;
                this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanelResults.Size = new System.Drawing.Size(500, 200);
                this.tableLayoutPanelResults.TabIndex = 3;
                // 
                // ResultsGrid
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoSize = true;
                this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(this.tableLayoutPanelResults);
                this.MinimumSize = new System.Drawing.Size(500, 200);
                this.Name = "ResultsGrid";
                this.Size = new System.Drawing.Size(500, 200);
                this.Load += new System.EventHandler(this.ResultsGrid_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion
            private TableLayoutPanel tableLayoutPanelResults;
        }
    }

