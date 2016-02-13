using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Windows_Wi_Fi_Cracker {
    public partial class MainForm : Form {

        private static List<Profile> profiles = new List<Profile>();

        public MainForm() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            List<string> profileNames = Profiling.GetProfiles();

            // Build <profile> list
            for (int i = 0; i < profileNames.Count; i++) {
                string key = profileNames[i].GetProfileKey();
                Profile profile = new Profile(profileNames[i], key);
                profiles.Add(profile);
            }

            // Display <profile> list
            for (int i = 0; i < profiles.Count; i++) {
                TableLayoutPanel panel = this.profilesTableLayoutPanel;

                panel.RowCount++; // Add new row
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                Label nameLabel = new Label() { // Profile name
                    Text = profiles[i].Name,
                    TextAlign = ContentAlignment.TopRight
                };
                panel.Controls.Add(nameLabel, 0, panel.RowCount - 1);

                TextBox keyTextBox = new TextBox() { // Profile key
                    Text = profiles[i].Key,
                    ReadOnly = true,
                    Dock = DockStyle.Fill
                };
                panel.Controls.Add(keyTextBox, 1, panel.RowCount - 1);

                Button copyButton = new Button() { // Copy
                    Text = "Copy"
                };
                panel.Controls.Add(copyButton, 2, panel.RowCount - 1);
            }
        }

        private void exportButton_Click(object sender, EventArgs e) {
            // Select location
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string location = folderBrowserDialog.SelectedPath + "\\profiles.csv";

                StreamWriter streamWriter = new StreamWriter(location);
                streamWriter.Write("Name,Key\n");

                for (int i = 0; i < profiles.Count; i++) {
                    streamWriter.Write(profiles[i].Name + "," + profiles[i].Key + "\n");
                }
                streamWriter.Close();

                MessageBox.Show("The Wi-Fi profiles have been saved to \"" + location + "\"");
            }

        }
    }
}
