using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_Wi_Fi_Cracker {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e) {


        }

        private void Form1_Load(object sender, EventArgs e) {
            List<Profile> profiles = new List<Profile>();
            List<string> profileNames = Profiling.GetProfiles();

            // Build <profile> list
            for (int i = 0; i < profileNames.Count; i++) {
                string key = profileNames[i].GetProfileKey();
                Profile profile = new Profile(profileNames[i], key);
                profiles.Add(profile);
            }

            // Display <profile> list
            string response = "";
            for (int i = 0; i < profiles.Count; i++) {
                response += profiles[i].Name + " => " + profiles[i].Key + "\n";
            }
            this.response.Text = response;
        }
    }
}
