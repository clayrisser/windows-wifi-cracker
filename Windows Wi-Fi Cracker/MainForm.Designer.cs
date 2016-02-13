namespace Windows_Wi_Fi_Cracker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.response = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.profilesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exportButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.Location = new System.Drawing.Point(3, 0);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(207, 24);
            this.response.TabIndex = 1;
            this.response.Text = "Windows Wi-Fi Cracker";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.Controls.Add(this.response, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.profilesTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.exportButton, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(553, 332);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // profilesTableLayoutPanel
            // 
            this.profilesTableLayoutPanel.AutoScroll = true;
            this.profilesTableLayoutPanel.ColumnCount = 3;
            this.profilesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.profilesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.profilesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.profilesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilesTableLayoutPanel.Location = new System.Drawing.Point(3, 73);
            this.profilesTableLayoutPanel.Name = "profilesTableLayoutPanel";
            this.profilesTableLayoutPanel.RowCount = 1;
            this.profilesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.profilesTableLayoutPanel.Size = new System.Drawing.Size(380, 256);
            this.profilesTableLayoutPanel.TabIndex = 2;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exportButton.Location = new System.Drawing.Point(432, 306);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 332);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Windows Wi-Fi Cracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel profilesTableLayoutPanel;
        private System.Windows.Forms.Button exportButton;
    }
}

