
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
            this.PckFilesInfo = new System.Windows.Forms.TextBox();
            this.PckFilesLabel = new System.Windows.Forms.Label();
            this.FormatWavCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.OverallExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.DragDropPCKFilesToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.SettingsGroupBox.Controls.Add(this.PckFilesInfo);
            this.SettingsGroupBox.Controls.Add(this.PckFilesLabel);
            this.SettingsGroupBox.Controls.Add(this.FormatWavCheckBox);
            this.SettingsGroupBox.Location = new System.Drawing.Point(15, 15);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsGroupBox.Size = new System.Drawing.Size(700, 138);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // FormatFlacCheckBox
            // 
            this.FormatFlacCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatFlacCheckBox.AutoSize = true;
            this.FormatFlacCheckBox.Location = new System.Drawing.Point(310, 99);
            this.FormatFlacCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormatFlacCheckBox.Name = "FormatFlacCheckBox";
            this.FormatFlacCheckBox.Size = new System.Drawing.Size(51, 29);
            this.FormatFlacCheckBox.TabIndex = 10;
            this.FormatFlacCheckBox.Text = "FLAC";
            this.FormatFlacCheckBox.UseVisualStyleBackColor = true;
            this.FormatFlacCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // FormatOggCheckBox
            // 
            this.FormatOggCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatOggCheckBox.AutoSize = true;
            this.FormatOggCheckBox.Location = new System.Drawing.Point(250, 99);
            this.FormatOggCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormatOggCheckBox.Name = "FormatOggCheckBox";
            this.FormatOggCheckBox.Size = new System.Drawing.Size(50, 29);
            this.FormatOggCheckBox.TabIndex = 9;
            this.FormatOggCheckBox.Text = "OGG";
            this.FormatOggCheckBox.UseVisualStyleBackColor = true;
            this.FormatOggCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // FormatMp3CheckBox
            // 
            this.FormatMp3CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatMp3CheckBox.AutoSize = true;
            this.FormatMp3CheckBox.Location = new System.Drawing.Point(194, 99);
            this.FormatMp3CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormatMp3CheckBox.Name = "FormatMp3CheckBox";
            this.FormatMp3CheckBox.Size = new System.Drawing.Size(48, 29);
            this.FormatMp3CheckBox.TabIndex = 8;
            this.FormatMp3CheckBox.Text = "MP3";
            this.FormatMp3CheckBox.UseVisualStyleBackColor = true;
            this.FormatMp3CheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // ExportToLabel
            // 
            this.ExportToLabel.AutoSize = true;
            this.ExportToLabel.Location = new System.Drawing.Point(8, 105);
            this.ExportToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExportToLabel.Name = "ExportToLabel";
            this.ExportToLabel.Size = new System.Drawing.Size(119, 19);
            this.ExportToLabel.TabIndex = 7;
            this.ExportToLabel.Text = "Export to formats:";
            // 
            // OutputFolderBrowseButton
            // 
            this.OutputFolderBrowseButton.Location = new System.Drawing.Point(599, 62);
            this.OutputFolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputFolderBrowseButton.Name = "OutputFolderBrowseButton";
            this.OutputFolderBrowseButton.Size = new System.Drawing.Size(94, 30);
            this.OutputFolderBrowseButton.TabIndex = 6;
            this.OutputFolderBrowseButton.Text = "Browse...";
            this.OutputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.OutputFolderBrowseButton.Click += new System.EventHandler(this.BrowseOutputFolder);
            // 
            // OutputDirTextBox
            // 
            this.OutputDirTextBox.Location = new System.Drawing.Point(135, 64);
            this.OutputDirTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputDirTextBox.Name = "OutputDirTextBox";
            this.OutputDirTextBox.ReadOnly = true;
            this.OutputDirTextBox.Size = new System.Drawing.Size(455, 26);
            this.OutputDirTextBox.TabIndex = 5;
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(8, 70);
            this.OutputDirectoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(115, 19);
            this.OutputDirectoryLabel.TabIndex = 4;
            this.OutputDirectoryLabel.Text = "Output directory:";
            // 
            // PckDirectoryBrowseButton
            // 
            this.PckDirectoryBrowseButton.Location = new System.Drawing.Point(599, 25);
            this.PckDirectoryBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PckDirectoryBrowseButton.Name = "PckDirectoryBrowseButton";
            this.PckDirectoryBrowseButton.Size = new System.Drawing.Size(94, 30);
            this.PckDirectoryBrowseButton.TabIndex = 3;
            this.PckDirectoryBrowseButton.Text = "Browse...";
            this.PckDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.PckDirectoryBrowseButton.Click += new System.EventHandler(this.BrowsePckFiles);
            // 
            // PckFilesInfo
            // 
            this.PckFilesInfo.AllowDrop = true;
            this.PckFilesInfo.Location = new System.Drawing.Point(135, 26);
            this.PckFilesInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PckFilesInfo.Name = "PckFilesInfo";
            this.PckFilesInfo.ReadOnly = true;
            this.PckFilesInfo.Size = new System.Drawing.Size(455, 26);
            this.PckFilesInfo.TabIndex = 2;
            this.PckFilesInfo.TabStop = false;
            this.PckFilesInfo.Text = "No PCK files are currently selected.";
            this.PckFilesInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.PckFilesInfo_DragDrop);
            this.PckFilesInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.PckFilesInfo_DragEnter);
            this.PckFilesInfo.MouseLeave += new System.EventHandler(this.PckFilesInfo_Leave);
            this.PckFilesInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PckFilesInfo_MouseMove);
            // 
            // PckFilesLabel
            // 
            this.PckFilesLabel.AutoSize = true;
            this.PckFilesLabel.Location = new System.Drawing.Point(8, 32);
            this.PckFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PckFilesLabel.Name = "PckFilesLabel";
            this.PckFilesLabel.Size = new System.Drawing.Size(117, 19);
            this.PckFilesLabel.TabIndex = 1;
            this.PckFilesLabel.Text = "PCK files selected:";
            // 
            // FormatWavCheckBox
            // 
            this.FormatWavCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FormatWavCheckBox.AutoSize = true;
            this.FormatWavCheckBox.Checked = true;
            this.FormatWavCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormatWavCheckBox.Location = new System.Drawing.Point(135, 99);
            this.FormatWavCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormatWavCheckBox.Name = "FormatWavCheckBox";
            this.FormatWavCheckBox.Size = new System.Drawing.Size(48, 29);
            this.FormatWavCheckBox.TabIndex = 7;
            this.FormatWavCheckBox.Text = "WAV";
            this.FormatWavCheckBox.UseVisualStyleBackColor = true;
            this.FormatWavCheckBox.CheckedChanged += new System.EventHandler(this.UpdateAudioFormatStatus);
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.StatusTextBox);
            this.StatusGroupBox.Location = new System.Drawing.Point(15, 160);
            this.StatusGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusGroupBox.Size = new System.Drawing.Size(700, 219);
            this.StatusGroupBox.TabIndex = 1;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(8, 26);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(684, 184);
            this.StatusTextBox.TabIndex = 0;
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(621, 386);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(94, 50);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportOrAbort);
            // 
            // OverallExportProgressBar
            // 
            this.OverallExportProgressBar.Location = new System.Drawing.Point(15, 416);
            this.OverallExportProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OverallExportProgressBar.MarqueeAnimationSpeed = 1;
            this.OverallExportProgressBar.Name = "OverallExportProgressBar";
            this.OverallExportProgressBar.Size = new System.Drawing.Size(599, 19);
            this.OverallExportProgressBar.Step = 1;
            this.OverallExportProgressBar.TabIndex = 13;
            // 
            // CurrentExportProgressBar
            // 
            this.CurrentExportProgressBar.Location = new System.Drawing.Point(15, 388);
            this.CurrentExportProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CurrentExportProgressBar.Name = "CurrentExportProgressBar";
            this.CurrentExportProgressBar.Size = new System.Drawing.Size(599, 19);
            this.CurrentExportProgressBar.TabIndex = 14;
            // 
            // DragDropPCKFilesToolTip
            // 
            this.DragDropPCKFilesToolTip.AutoPopDelay = 5000;
            this.DragDropPCKFilesToolTip.BackColor = System.Drawing.Color.White;
            this.DragDropPCKFilesToolTip.InitialDelay = 0;
            this.DragDropPCKFilesToolTip.ReshowDelay = 100;
            this.DragDropPCKFilesToolTip.ShowAlways = true;
            this.DragDropPCKFilesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DragDropPCKFilesToolTip.ToolTipTitle = "Selecting files";
            this.DragDropPCKFilesToolTip.UseAnimation = false;
            this.DragDropPCKFilesToolTip.UseFading = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(730, 451);
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
        private System.Windows.Forms.TextBox PckFilesInfo;
        private System.Windows.Forms.Label PckFilesLabel;
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
        private System.Windows.Forms.ToolTip DragDropPCKFilesToolTip;
    }
}

