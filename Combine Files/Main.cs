namespace Combine_Files {
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Text;
    using System.IO;
    using System.Windows.Forms;

    public partial class Main : Form {
        private List<String> Files;
        public Main() {
            InitializeComponent();
            Files = new List<string>();

            var InitialDirectory = ConfigurationManager.AppSettings["InitialDirectory"];
            if (InitialDirectory != String.Empty && Directory.Exists(InitialDirectory)) {
                OpenFileDialog.InitialDirectory = InitialDirectory;
                SaveFileDialog.InitialDirectory = InitialDirectory;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            var Result = OpenFileDialog.ShowDialog();
            if (Result == DialogResult.OK) {
                Files.AddRange(OpenFileDialog.FileNames);
                lbFileNames.Items.AddRange(OpenFileDialog.FileNames);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (Files.Count != 0) {
                var Save = SaveFileDialog.ShowDialog();
                if (Save == DialogResult.OK && SaveFileDialog.FileName != String.Empty) {
                    foreach (var FilePath in Files) {
                        var Text = File.ReadAllText(FilePath);
                        File.AppendAllText(SaveFileDialog.FileName + ".dat", Text); 
                    }
                    //Open folder for viewing.
                    Process.Start(Path.GetDirectoryName(SaveFileDialog.FileName + ".dat"));
                }
            }
        }
    }
}
