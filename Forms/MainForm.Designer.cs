
namespace genshin_audio_exporter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.FormatFlacCheckBox = new System.Windows.Forms.CheckBox();
            this.FormatOggCheckBox = new System.Windows.Forms.CheckBox();
            this.FormatMp3CheckBox = new System.Windows.Forms.CheckBox();
            this.ExportToLabel = new System.Windows.Forms.Label();
            this.OutputFolderBrowseButton = new System.Windows.Forms.Button();
            this.OutputDirTextBox = new System.Windows.Forms.TextBox();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.PckDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.PckFileDirTextBox = new System.Windows.Forms.TextBox();
            this.PckDirectoryLabel = new System.Windows.Forms.Label();
            this.FormatWavCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.OverallExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExportProgressToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsGroupBox.SuspendLayout();
            this.StatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.FormatFlacCheckBox);
            this.SettingsGroupBox.Controls.Add(this.FormatOggCheckBox);
            this.SettingsGroupBox.Controls.Add(this.FormatMp3CheckBox);
            this.SettingsGroupBox.Controls.Add(this.ExportToLabel);
            this.SettingsGroupBox.Controls.Add(this.OutputFolderBrowseButton);
            this.SettingsGroupBox.Controls.Add(this.OutputDirTextBox);
            this.SettingsGroupBox.Controls.Add(this.OutputDirectoryLabel);
            this.SettingsGroupBox.Controls.Add(this.PckDirectoryBrowseButton);
            this.SettingsGroupBox.Controls.Add(this.PckFileDirTextBox);
            this.SettingsGroupBox.Controls.Add(this.PckDirectoryLabel);
            this.SettingsGroupBox.Controls.Add(this.FormatWavCheckBox);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(560, 110);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // FormatFlacCheckBox
            // 
            this.FormatFlacCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatFlacCheckBox.AutoSize = true;
            this.FormatFlacCheckBox.Location = new System.Drawing.Point(248, 79);
            this.FormatFlacCheckBox.Name = "FormatFlacCheckBox";
            this.FormatFlacCheckBox.Size = new System.Drawing.Size(42, 23);
            this.FormatFlacCheckBox.TabIndex = 10;
            this.FormatFlacCheckBox.Text = "FLAC";
            this.FormatFlacCheckBox.UseVisualStyleBackColor = true;
            this.FormatFlacCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // FormatOggCheckBox
            // 
            this.FormatOggCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatOggCheckBox.AutoSize = true;
            this.FormatOggCheckBox.Location = new System.Drawing.Point(200, 79);
            this.FormatOggCheckBox.Name = "FormatOggCheckBox";
            this.FormatOggCheckBox.Size = new System.Drawing.Size(42, 23);
            this.FormatOggCheckBox.TabIndex = 9;
            this.FormatOggCheckBox.Text = "OGG";
            this.FormatOggCheckBox.UseVisualStyleBackColor = true;
            this.FormatOggCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // FormatMp3CheckBox
            // 
            this.FormatMp3CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatMp3CheckBox.AutoSize = true;
            this.FormatMp3CheckBox.Checked = true;
            this.FormatMp3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormatMp3CheckBox.Location = new System.Drawing.Point(155, 79);
            this.FormatMp3CheckBox.Name = "FormatMp3CheckBox";
            this.FormatMp3CheckBox.Size = new System.Drawing.Size(39, 23);
            this.FormatMp3CheckBox.TabIndex = 8;
            this.FormatMp3CheckBox.Text = "MP3";
            this.FormatMp3CheckBox.UseVisualStyleBackColor = true;
            this.FormatMp3CheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // ExportToLabel
            // 
            this.ExportToLabel.AutoSize = true;
            this.ExportToLabel.Location = new System.Drawing.Point(6, 84);
            this.ExportToLabel.Name = "ExportToLabel";
            this.ExportToLabel.Size = new System.Drawing.Size(99, 13);
            this.ExportToLabel.TabIndex = 7;
            this.ExportToLabel.Text = "Export to formats:";
            // 
            // OutputFolderBrowseButton
            // 
            this.OutputFolderBrowseButton.Location = new System.Drawing.Point(479, 50);
            this.OutputFolderBrowseButton.Name = "OutputFolderBrowseButton";
            this.OutputFolderBrowseButton.Size = new System.Drawing.Size(75, 24);
            this.OutputFolderBrowseButton.TabIndex = 6;
            this.OutputFolderBrowseButton.Text = "Browse...";
            this.OutputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.OutputFolderBrowseButton.Click += new System.EventHandler(this.BrowseOutputFolder);
            // 
            // OutputDirTextBox
            // 
            this.OutputDirTextBox.Location = new System.Drawing.Point(108, 51);
            this.OutputDirTextBox.Name = "OutputDirTextBox";
            this.OutputDirTextBox.ReadOnly = true;
            this.OutputDirTextBox.Size = new System.Drawing.Size(365, 22);
            this.OutputDirTextBox.TabIndex = 5;
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(6, 56);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(96, 13);
            this.OutputDirectoryLabel.TabIndex = 4;
            this.OutputDirectoryLabel.Text = "Output directory:";
            // 
            // PckDirectoryBrowseButton
            // 
            this.PckDirectoryBrowseButton.Location = new System.Drawing.Point(479, 20);
            this.PckDirectoryBrowseButton.Name = "PckDirectoryBrowseButton";
            this.PckDirectoryBrowseButton.Size = new System.Drawing.Size(75, 24);
            this.PckDirectoryBrowseButton.TabIndex = 3;
            this.PckDirectoryBrowseButton.Text = "Browse...";
            this.PckDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.PckDirectoryBrowseButton.Click += new System.EventHandler(this.BrowsePckFolder);
            // 
            // PckFileDirTextBox
            // 
            this.PckFileDirTextBox.Location = new System.Drawing.Point(108, 21);
            this.PckFileDirTextBox.Name = "PckFileDirTextBox";
            this.PckFileDirTextBox.ReadOnly = true;
            this.PckFileDirTextBox.Size = new System.Drawing.Size(365, 22);
            this.PckFileDirTextBox.TabIndex = 2;
            // 
            // PckDirectoryLabel
            // 
            this.PckDirectoryLabel.AutoSize = true;
            this.PckDirectoryLabel.Location = new System.Drawing.Point(6, 26);
            this.PckDirectoryLabel.Name = "PckDirectoryLabel";
            this.PckDirectoryLabel.Size = new System.Drawing.Size(96, 13);
            this.PckDirectoryLabel.TabIndex = 1;
            this.PckDirectoryLabel.Text = "PCK file directory:";
            // 
            // FormatWavCheckBox
            // 
            this.FormatWavCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatWavCheckBox.AutoSize = true;
            this.FormatWavCheckBox.Checked = true;
            this.FormatWavCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormatWavCheckBox.Location = new System.Drawing.Point(108, 79);
            this.FormatWavCheckBox.Name = "FormatWavCheckBox";
            this.FormatWavCheckBox.Size = new System.Drawing.Size(41, 23);
            this.FormatWavCheckBox.TabIndex = 11;
            this.FormatWavCheckBox.Text = "WAV";
            this.FormatWavCheckBox.UseVisualStyleBackColor = true;
            this.FormatWavCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.StatusTextBox);
            this.StatusGroupBox.Location = new System.Drawing.Point(12, 128);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(560, 175);
            this.StatusGroupBox.TabIndex = 1;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(6, 21);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(548, 148);
            this.StatusTextBox.TabIndex = 0;
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(497, 309);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 40);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportOrAbort);
            // 
            // OverallExportProgressBar
            // 
            this.OverallExportProgressBar.Location = new System.Drawing.Point(12, 333);
            this.OverallExportProgressBar.MarqueeAnimationSpeed = 1;
            this.OverallExportProgressBar.Name = "OverallExportProgressBar";
            this.OverallExportProgressBar.Size = new System.Drawing.Size(479, 15);
            this.OverallExportProgressBar.Step = 1;
            this.OverallExportProgressBar.TabIndex = 13;
            this.ExportProgressToolTip.SetToolTip(this.OverallExportProgressBar, "Progress of the entire export operation.");
            // 
            // CurrentExportProgressBar
            // 
            this.CurrentExportProgressBar.Location = new System.Drawing.Point(12, 310);
            this.CurrentExportProgressBar.Name = "CurrentExportProgressBar";
            this.CurrentExportProgressBar.Size = new System.Drawing.Size(479, 15);
            this.CurrentExportProgressBar.TabIndex = 14;
            this.ExportProgressToolTip.SetToolTip(this.CurrentExportProgressBar, "Progress of the current export stage.");
            // 
            // ExportProgressToolTip
            // 
            this.ExportProgressToolTip.AutoPopDelay = 5000;
            this.ExportProgressToolTip.InitialDelay = 0;
            this.ExportProgressToolTip.ReshowDelay = 100;
            this.ExportProgressToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExportProgressToolTip.ToolTipTitle = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.CurrentExportProgressBar);
            this.Controls.Add(this.OverallExportProgressBar);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "genshin-audio-exporter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApplication);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.StatusGroupBox.ResumeLayout(false);
            this.StatusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.TextBox PckFileDirTextBox;
        private System.Windows.Forms.Label PckDirectoryLabel;
        private System.Windows.Forms.Button PckDirectoryBrowseButton;
        private System.Windows.Forms.Button OutputFolderBrowseButton;
        private System.Windows.Forms.TextBox OutputDirTextBox;
        private System.Windows.Forms.Label OutputDirectoryLabel;
        private System.Windows.Forms.CheckBox FormatMp3CheckBox;
        private System.Windows.Forms.Label ExportToLabel;
        private System.Windows.Forms.CheckBox FormatOggCheckBox;
        private System.Windows.Forms.CheckBox FormatFlacCheckBox;
        private System.Windows.Forms.CheckBox FormatWavCheckBox;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.ProgressBar OverallExportProgressBar;
        internal System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.ProgressBar CurrentExportProgressBar;
        private System.Windows.Forms.ToolTip ExportProgressToolTip;
    }
}

