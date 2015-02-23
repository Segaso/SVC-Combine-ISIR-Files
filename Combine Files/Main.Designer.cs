namespace Combine_Files {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.lbFileNames = new System.Windows.Forms.ListBox();
            this.btnAutoLoad = new System.Windows.Forms.Button();
            this.cbAutoLoadYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCombine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listISIRNames = new System.Windows.Forms.ListBox();
            this.txtCommonFileName = new System.Windows.Forms.TextBox();
            this.btnAddFileName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISIRDirectory = new System.Windows.Forms.TextBox();
            this.txtSaveDirectory = new System.Windows.Forms.TextBox();
            this.txtBrowseDirectory = new System.Windows.Forms.TextBox();
            this.btnISIRBrowse = new System.Windows.Forms.Button();
            this.btnSaveBrowse = new System.Windows.Forms.Button();
            this.btnBrowseBrowse = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.FolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbFiles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCombine.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(3, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(488, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(494, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Multiselect = true;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Import Files (*.dat)|";
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.lbFileNames);
            this.gbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiles.Location = new System.Drawing.Point(3, 3);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(494, 256);
            this.gbFiles.TabIndex = 2;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // lbFileNames
            // 
            this.lbFileNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileNames.FormattingEnabled = true;
            this.lbFileNames.HorizontalScrollbar = true;
            this.lbFileNames.Location = new System.Drawing.Point(3, 16);
            this.lbFileNames.Name = "lbFileNames";
            this.lbFileNames.Size = new System.Drawing.Size(488, 237);
            this.lbFileNames.TabIndex = 0;
            this.lbFileNames.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lbFileNames_PreviewKeyDown);
            // 
            // btnAutoLoad
            // 
            this.btnAutoLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAutoLoad.Location = new System.Drawing.Point(149, 3);
            this.btnAutoLoad.Name = "btnAutoLoad";
            this.btnAutoLoad.Size = new System.Drawing.Size(336, 23);
            this.btnAutoLoad.TabIndex = 3;
            this.btnAutoLoad.Text = "Load ISIR Files";
            this.btnAutoLoad.UseVisualStyleBackColor = true;
            this.btnAutoLoad.Click += new System.EventHandler(this.btnAutoLoad_Click);
            // 
            // cbAutoLoadYear
            // 
            this.cbAutoLoadYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAutoLoadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoLoadYear.FormattingEnabled = true;
            this.cbAutoLoadYear.Items.AddRange(new object[] {
            "Select Year"});
            this.cbAutoLoadYear.Location = new System.Drawing.Point(3, 3);
            this.cbAutoLoadYear.Name = "cbAutoLoadYear";
            this.cbAutoLoadYear.Size = new System.Drawing.Size(140, 21);
            this.cbAutoLoadYear.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatically Load ISIRs";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnAutoLoad, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAutoLoadYear, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Loadding";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCombine);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(514, 456);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 456);
            this.tabControl1.TabIndex = 7;
            // 
            // tpCombine
            // 
            this.tpCombine.BackColor = System.Drawing.SystemColors.Control;
            this.tpCombine.Controls.Add(this.tableLayoutPanel2);
            this.tpCombine.Location = new System.Drawing.Point(4, 22);
            this.tpCombine.Name = "tpCombine";
            this.tpCombine.Padding = new System.Windows.Forms.Padding(3);
            this.tpCombine.Size = new System.Drawing.Size(506, 430);
            this.tpCombine.TabIndex = 0;
            this.tpCombine.Text = "Combine ISIR Files";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gbFiles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 424);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tpSettings.Controls.Add(this.tableLayoutPanel3);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(506, 430);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtISIRDirectory, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSaveDirectory, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBrowseDirectory, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnISIRBrowse, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveBrowse, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnBrowseBrowse, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveSettings, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 424);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox3, 3);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 274);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ISIR File Names (Don\'t Include Year)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.listISIRNames, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCommonFileName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnAddFileName, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(488, 255);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // listISIRNames
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.listISIRNames, 2);
            this.listISIRNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listISIRNames.FormattingEnabled = true;
            this.listISIRNames.Location = new System.Drawing.Point(3, 3);
            this.listISIRNames.Name = "listISIRNames";
            this.listISIRNames.Size = new System.Drawing.Size(482, 220);
            this.listISIRNames.TabIndex = 1;
            this.listISIRNames.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listISIRNames_PreviewKeyDown);
            // 
            // txtCommonFileName
            // 
            this.txtCommonFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommonFileName.Location = new System.Drawing.Point(100, 229);
            this.txtCommonFileName.Name = "txtCommonFileName";
            this.txtCommonFileName.Size = new System.Drawing.Size(385, 20);
            this.txtCommonFileName.TabIndex = 0;
            // 
            // btnAddFileName
            // 
            this.btnAddFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFileName.Location = new System.Drawing.Point(3, 229);
            this.btnAddFileName.Name = "btnAddFileName";
            this.btnAddFileName.Size = new System.Drawing.Size(91, 23);
            this.btnAddFileName.TabIndex = 2;
            this.btnAddFileName.Text = "Add File Name";
            this.btnAddFileName.UseVisualStyleBackColor = true;
            this.btnAddFileName.Click += new System.EventHandler(this.btnAddFileName_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISIR Directory";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Save Directory";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Default Browse Directory";
            // 
            // txtISIRDirectory
            // 
            this.txtISIRDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtISIRDirectory.Location = new System.Drawing.Point(133, 283);
            this.txtISIRDirectory.Name = "txtISIRDirectory";
            this.txtISIRDirectory.Size = new System.Drawing.Size(253, 20);
            this.txtISIRDirectory.TabIndex = 5;
            // 
            // txtSaveDirectory
            // 
            this.txtSaveDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaveDirectory.Location = new System.Drawing.Point(133, 313);
            this.txtSaveDirectory.Name = "txtSaveDirectory";
            this.txtSaveDirectory.Size = new System.Drawing.Size(253, 20);
            this.txtSaveDirectory.TabIndex = 6;
            // 
            // txtBrowseDirectory
            // 
            this.txtBrowseDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrowseDirectory.Location = new System.Drawing.Point(133, 343);
            this.txtBrowseDirectory.Name = "txtBrowseDirectory";
            this.txtBrowseDirectory.Size = new System.Drawing.Size(253, 20);
            this.txtBrowseDirectory.TabIndex = 7;
            // 
            // btnISIRBrowse
            // 
            this.btnISIRBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnISIRBrowse.Location = new System.Drawing.Point(392, 283);
            this.btnISIRBrowse.Name = "btnISIRBrowse";
            this.btnISIRBrowse.Size = new System.Drawing.Size(105, 24);
            this.btnISIRBrowse.TabIndex = 8;
            this.btnISIRBrowse.Text = "Browse";
            this.btnISIRBrowse.UseVisualStyleBackColor = true;
            this.btnISIRBrowse.Click += new System.EventHandler(this.btnISIRBrowse_Click);
            // 
            // btnSaveBrowse
            // 
            this.btnSaveBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveBrowse.Location = new System.Drawing.Point(392, 313);
            this.btnSaveBrowse.Name = "btnSaveBrowse";
            this.btnSaveBrowse.Size = new System.Drawing.Size(105, 24);
            this.btnSaveBrowse.TabIndex = 9;
            this.btnSaveBrowse.Text = "Browse";
            this.btnSaveBrowse.UseVisualStyleBackColor = true;
            this.btnSaveBrowse.Click += new System.EventHandler(this.btnSaveBrowse_Click);
            // 
            // btnBrowseBrowse
            // 
            this.btnBrowseBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseBrowse.Location = new System.Drawing.Point(392, 343);
            this.btnBrowseBrowse.Name = "btnBrowseBrowse";
            this.btnBrowseBrowse.Size = new System.Drawing.Size(105, 24);
            this.btnBrowseBrowse.TabIndex = 10;
            this.btnBrowseBrowse.Text = "Browse";
            this.btnBrowseBrowse.UseVisualStyleBackColor = true;
            this.btnBrowseBrowse.Click += new System.EventHandler(this.btnBrowseBrowse_Click);
            // 
            // btnSaveSettings
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnSaveSettings, 3);
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSettings.Location = new System.Drawing.Point(3, 373);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(494, 48);
            this.btnSaveSettings.TabIndex = 11;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 456);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Combine ISIR Files";
            this.gbFiles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCombine.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.ListBox lbFileNames;
        private System.Windows.Forms.Button btnAutoLoad;
        private System.Windows.Forms.ComboBox cbAutoLoadYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCombine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox listISIRNames;
        private System.Windows.Forms.TextBox txtCommonFileName;
        private System.Windows.Forms.Button btnAddFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISIRDirectory;
        private System.Windows.Forms.TextBox txtSaveDirectory;
        private System.Windows.Forms.TextBox txtBrowseDirectory;
        private System.Windows.Forms.Button btnISIRBrowse;
        private System.Windows.Forms.Button btnSaveBrowse;
        private System.Windows.Forms.Button btnBrowseBrowse;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowseDialog;
    }
}

