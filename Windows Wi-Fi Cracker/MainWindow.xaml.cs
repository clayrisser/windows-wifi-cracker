using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.IO;
using Microsoft.Win32;

namespace Windows_Wi_Fi_Cracker {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private List<Profile> profiles = new List<Profile>();

        public MainWindow() {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e) {
            BackgroundWorker bw = new BackgroundWorker();

            crackProgressBar.IsIndeterminate = true;

            bw.DoWork += (send, args) => {
                List<string> profileNames = Profiling.GetProfiles();
                this.profiles.Clear();
                for (int i = 0; i < profileNames.Count; i++) {
                    string name = profileNames[i];
                    string key = profileNames[i].GetProfileKey();
                    Profile profile = new Profile(name, key);
                    this.profiles.Add(profile);
                }
            };

            bw.RunWorkerCompleted += (backgroundSender, backgroundE) => {
                this.profilesListView.Items.Clear();
                for (int i = 0; i < profiles.Count; i++) {
                    this.profilesListView.Items.Add(profiles[i]);
                }
                crackProgressBar.IsIndeterminate = false;
            };
            bw.RunWorkerAsync();
        }


        private void exportButton_Click(object sender, RoutedEventArgs e) {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (send, args) => {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = "profiles.csv";
                sfd.DefaultExt = "csv";
                sfd.Filter = "CSV File|*.csv";
                bool result = (bool)sfd.ShowDialog();
                if (result) { // Generate CSV file
                    try {
                        string path = sfd.FileName;
                        string file = Path.GetFileName(path);
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write("Name,Key\n");
                        for (int i = 0; i < profiles.Count; i++) {
                            sw.Write(profiles[i].Name + "," + profiles[i].Key + "\n");
                        }
                        sw.Close();
                        MessageBox.Show(file + " was saved to \"" + path + "\"");
                    } catch(IOException) {
                        MessageBox.Show("The file cannot be overwritten because it is being used by another process.");
                    }
                }
            };
            bw.RunWorkerAsync();
        }
    }
}
