namespace Combine_Files {
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Text;
    using System.Linq;
    using System.IO;
    using System.Windows.Input;
    using System.Windows.Forms;

    public partial class Main : Form {
        private List<String> Files = new List<string>();
        public Main() {
            InitializeComponent();

            //Load Properties
            txtISIRDirectory.Text = Properties.Settings.Default.ISIRDirectory;
            txtSaveDirectory.Text = Properties.Settings.Default.SaveDirectory;
            txtBrowseDirectory.Text = Properties.Settings.Default.BrowseDirectory;

            if (Properties.Settings.Default.ISIRFileNames != null) {
                listISIRNames.Items.AddRange(Properties.Settings.Default.ISIRFileNames.Cast<string>().ToArray());
            }

            OpenFileDialog.InitialDirectory = Properties.Settings.Default.BrowseDirectory;
            SaveFileDialog.InitialDirectory = Properties.Settings.Default.SaveDirectory;
            var Range = Enumerable.Range(DateTime.Now.Year - 5, 10).ToArray();

            foreach (var Year in Range) {
                this.cbAutoLoadYear.Items.Add(Year.ToString());
            }
            this.cbAutoLoadYear.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            var Result = OpenFileDialog.ShowDialog();
            if (Result == DialogResult.OK) {
                Files.AddRange(OpenFileDialog.FileNames);

                Files = Files.Distinct().OrderBy(F => F).ToList();

                lbFileNames.Items.AddRange(Files.ToArray());
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
                    //Genereate Log File
                    GenerateLogFile(this.SaveFileDialog.FileName);

                    //Open folder for viewing.
                    Process.Start(Path.GetDirectoryName(SaveFileDialog.FileName + ".dat"));
                }
            }
        }


        private void GenerateLogFile(string FileName) {
            foreach (var FilePath in Files) {
                File.AppendAllText(FileName + ".log", FilePath + Environment.NewLine);
            }
        }

        private void btnAutoLoad_Click(object sender, EventArgs e) {
            //Format the year so that only the last two digits remain.
            string Year = this.cbAutoLoadYear.SelectedItem.ToString();
            Year = Year.Substring(Year.Length - 2);

            var FilteredFiles = new List<string>();
            foreach (var Filter in Properties.Settings.Default.ISIRFileNames) {
                FilteredFiles.AddRange(Directory
                                       .EnumerateFiles(Properties.Settings.Default.ISIRDirectory)
                                       .Where(F => F.Contains(Filter + Year))
                                       .ToList());
            }

            //Backup Files - Remove from List
            var Reject = FilteredFiles.Where(F => F.Contains("BK."));
            FilteredFiles = FilteredFiles.Except(Reject).ToList();

            FilteredFiles = FilteredFiles.Distinct().OrderBy(F => F).ToList();
            lbFileNames.Items.AddRange(FilteredFiles.ToArray());

        }

        private void btnAddFileName_Click(object sender, EventArgs e) {
            if (txtCommonFileName.Text != string.Empty) {
                this.listISIRNames.Items.Add(this.txtCommonFileName.Text);
                Properties.Settings.Default.ISIRFileNames.Add(this.txtCommonFileName.Text);

                this.txtCommonFileName.Text = string.Empty;
            }
        }

        private void btnISIRBrowse_Click(object sender, EventArgs e) {
            var ISIRFolder = this.FolderBrowseDialog.ShowDialog();

            if (ISIRFolder == DialogResult.OK) {
                Properties.Settings.Default.ISIRDirectory = FolderBrowseDialog.SelectedPath;
                txtISIRDirectory.Text = FolderBrowseDialog.SelectedPath;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e) {
            Properties.Settings.Default.ISIRDirectory = txtISIRDirectory.Text;
            Properties.Settings.Default.SaveDirectory = txtSaveDirectory.Text;
            Properties.Settings.Default.BrowseDirectory = txtBrowseDirectory.Text;
            Properties.Settings.Default.Save();
        }

        private void btnBrowseBrowse_Click(object sender, EventArgs e) {
            var Browse = this.FolderBrowseDialog.ShowDialog();

            if (Browse == DialogResult.OK) {
                Properties.Settings.Default.BrowseDirectory = FolderBrowseDialog.SelectedPath;
                txtBrowseDirectory.Text = FolderBrowseDialog.SelectedPath;
            }
        }

        private void btnSaveBrowse_Click(object sender, EventArgs e) {
            var Browse = this.FolderBrowseDialog.ShowDialog();

            if (Browse == DialogResult.OK) {
                Properties.Settings.Default.SaveDirectory = FolderBrowseDialog.SelectedPath;
                this.txtSaveDirectory.Text = FolderBrowseDialog.SelectedPath;
            }
        }

        private void listISIRNames_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Delete && listISIRNames.SelectedIndex != -1) {
                this.listISIRNames.Items.RemoveAt(this.listISIRNames.SelectedIndex);

                var FileCollection = new StringCollection();
                FileCollection.AddRange(this.listISIRNames.Items.Cast<string>().Select(F => F).ToArray());

                Properties.Settings.Default.ISIRFileNames = FileCollection;
            }
        }

        private void lbFileNames_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Delete && lbFileNames.SelectedIndex != -1) {
                this.lbFileNames.Items.RemoveAt(this.lbFileNames.SelectedIndex);
            }
        }
    }
}
