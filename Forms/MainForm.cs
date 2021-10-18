using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genshin_audio_exporter
{
    public partial class MainForm : Form
    {
        private bool doUpdateFormatSettings = false;
        private bool isBusy = false;
        private bool isAborted = false;
        private int exportedAudioFiles = 0;
        public MainForm()
        {
            InitializeComponent();
            OutputDirTextBox.Text = Properties.Settings.Default.OutputDirectory;
            FormatWavCheckBox.Checked = Properties.Settings.Default.CreateWav;
            FormatMp3CheckBox.Checked = Properties.Settings.Default.CreateMp3;
            FormatOggCheckBox.Checked = Properties.Settings.Default.CreateOgg;
            FormatFlacCheckBox.Checked = Properties.Settings.Default.CreateFlac;
            doUpdateFormatSettings = true;
            UpdateCanExportStatus();

        }

        public void WriteStatus(string text, bool prefix = true)
        {
            StatusTextBox.AppendText($"{((text.Length> 0 && prefix) ? "> " + text : "  " + text)}" + Environment.NewLine);
        }

        private void BrowsePckFiles(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PCK Files|*.pck"
            };
            DialogResult fbdResult = ofd.ShowDialog();
            if (fbdResult == DialogResult.OK)
            {
                AppVariables.PckFiles.Clear();
                AppVariables.PckFiles = ofd.FileNames.ToList();
                PckFilesInfo.Text = $"Selected {AppVariables.PckFiles.Count} PCK file{(AppVariables.PckFiles.Count > 1 ? "s" : "")} to extract.";
            }
            UpdateCanExportStatus();
        }

        private void BrowseOutputFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            DialogResult fbdResult = fbd.ShowDialog();
            if (fbdResult == DialogResult.OK)
            {
                AppVariables.OutputDir = fbd.SelectedPath;
                OutputDirTextBox.Text = fbd.SelectedPath;

            }
            UpdateCanExportStatus();
        }

        private void UpdateAudioFormatStatus(object sender, EventArgs e)
        {
            if (doUpdateFormatSettings)
                UpdateCanExportStatus();
        }

        private void UpdateCanExportStatus()
        {
            bool canExport = true;

            AppVariables.CreateWav = FormatWavCheckBox.Checked;
            AppVariables.CreateMp3 = FormatMp3CheckBox.Checked;
            AppVariables.CreateOgg = FormatOggCheckBox.Checked;
            AppVariables.CreateFlac = FormatFlacCheckBox.Checked;

            if (!AppVariables.CreateWav && !AppVariables.CreateMp3 && !AppVariables.CreateOgg && !AppVariables.CreateFlac)
                canExport = false;
            if (AppVariables.PckFiles.Count == 0 || !Directory.Exists(OutputDirTextBox.Text))
                canExport = false;
            if (canExport)
            {
                Properties.Settings.Default.CreateWav = AppVariables.CreateWav;
                Properties.Settings.Default.CreateMp3 = AppVariables.CreateMp3;
                Properties.Settings.Default.CreateOgg = AppVariables.CreateOgg;
                Properties.Settings.Default.CreateFlac = AppVariables.CreateFlac;
                AppVariables.OutputDir = OutputDirTextBox.Text;
                Properties.Settings.Default.OutputDirectory = OutputDirTextBox.Text;
                ExportButton.Enabled = canExport;
                AppVariables.UpdateProcessingFolder();
            }
            else
                ExportButton.Enabled = false;
        }

        private async void ExportOrAbort(object sender, EventArgs e)
        {
            if (!isBusy)
            {
                isBusy = true;
                ExportButton.Text = "Abort";
                SettingsGroupBox.Enabled = false;
                Directory.CreateDirectory(AppVariables.ProcessingDir);
                Directory.CreateDirectory(AppVariables.LibsDir);
                ClearTempDirectories();
                StatusTextBox.Clear();
                if (!AppResources.IsUnpacked)
                {
                    WriteStatus("Unpacking libraries", prefix:false);
                    WriteStatus("");
                    await Task.Run(() =>
                    {
                        AppResources.UnpackResources();
                    });

                }
                OverallExportProgressBar.Value = 0;
                OverallExportProgressBar.Style = ProgressBarStyle.Marquee;
                CurrentExportProgressBar.Value = 0;
                CurrentExportProgressBar.Maximum = 0;
                int index = 0;
                int overallIndex = 0;
                Directory.CreateDirectory(AppVariables.ProcessingDir);
                Directory.CreateDirectory(Path.Combine(AppVariables.ProcessingDir, "wem"));
                if (AppVariables.CreateWav)
                    Directory.CreateDirectory(Path.Combine(AppVariables.ProcessingDir, "wav"));
                if (AppVariables.CreateMp3)
                    Directory.CreateDirectory(Path.Combine(AppVariables.ProcessingDir, "mp3"));
                if (AppVariables.CreateOgg)
                    Directory.CreateDirectory(Path.Combine(AppVariables.ProcessingDir, "ogg"));
                if (AppVariables.CreateFlac)
                    Directory.CreateDirectory(Path.Combine(AppVariables.ProcessingDir, "flac"));

                if (!isAborted)
                {
                    WriteStatus("Exporting PCK  =>  WEM  (Required)", prefix:false);
                    WriteStatus("");
                    await Task.Run(() =>
                    {
                        IProgress<int> progress = new Progress<int>(value =>
                        {
                            BeginInvoke((System.Action)(() =>
                            {
                                CurrentExportProgressBar.Maximum = AppVariables.PckFiles.Count;
                                CurrentExportProgressBar.Value = value;
                            }));
                        });
                        foreach (string pckFile in AppVariables.PckFiles)
                        {
                            if (!isAborted)
                            {
                                PckToWem.StartPckToWem(pckFile, this);
                                BeginInvoke((System.Action)(() =>
                                {
                                    WriteStatus($"{Path.GetFileName(pckFile)}  =>  {Path.GetFileNameWithoutExtension(pckFile)}.wem");
                                }));
                                index += 1;
                                progress.Report(index);
                            }
                            else
                                break;
                        }
                    });
                }
                if (!isAborted)
                {
                    WriteStatus("");
                    WriteStatus("Exporting WEM  =>  WAV  (Required)", prefix: false);
                    WriteStatus("");
                    index = 0;
                    await Task.Run(() =>
                    {
                        AppVariables.WemFiles = Directory.GetFiles(Path.Combine(AppVariables.ProcessingDir, "wem"), "*.wem").ToList();
                        BeginInvoke((System.Action)(() =>
                        {
                            OverallExportProgressBar.Style = ProgressBarStyle.Blocks;
                            int overallMaximum = AppVariables.WemFiles.Count;
                            foreach (CheckBox formatCheckBox in SettingsGroupBox.Controls.OfType<CheckBox>())
                            {
                                if (formatCheckBox.Checked)
                                    overallMaximum += AppVariables.WemFiles.Count;
                            }

                            OverallExportProgressBar.Maximum = overallMaximum;
                        }));
                        IProgress<int> progress = new Progress<int>(value =>
                        {
                            BeginInvoke((System.Action)(() =>
                            {
                                CurrentExportProgressBar.Maximum = AppVariables.WemFiles.Count;
                                CurrentExportProgressBar.Value = value;
                                OverallExportProgressBar.Value = overallIndex;
                            }));
                        });
                        foreach (string wemFile in AppVariables.WemFiles)
                        {
                            if (!isAborted)
                            {
                                WemToWav.StartWemToWav(wemFile, this);
                                BeginInvoke((System.Action)(() =>
                                {
                                    WriteStatus($"{Path.GetFileName(wemFile)}  =>  {Path.GetFileNameWithoutExtension(wemFile)}.wav");
                                }));
                                index += 1;
                                overallIndex += 1;
                                progress.Report(index);
                            }
                            else
                                break;
                        }
                    });
                }

                AppVariables.WavFiles = Directory.GetFiles(Path.Combine(AppVariables.ProcessingDir, "wav"), "*.wav").ToList();

                if (AppVariables.CreateWav && !isAborted)
                    await ExportAudioFormat("wav");
                if (AppVariables.CreateMp3 && !isAborted)
                    await ExportAudioFormat("mp3");
                if (AppVariables.CreateOgg && !isAborted)
                    await ExportAudioFormat("ogg");
                if (AppVariables.CreateFlac && !isAborted)
                    await ExportAudioFormat("flac");
            }
            else
            {
                isAborted = true;
                ExportButton.Text = "Aborting...";
                ExportButton.Enabled = false;
                return;
            }
            Application.DoEvents();
            OnExportEnded(isAborted);
        }

        private async Task ExportAudioFormat(string format)
        {
            Directory.CreateDirectory(Path.Combine(AppVariables.OutputDir, format));
            int index = 0;
            int overallIndex = OverallExportProgressBar.Value;

            WriteStatus("");
            if (format == "wav")
                WriteStatus("Copying WAV Files to destination directory", prefix: false);
            else
                WriteStatus($"Exporting WAV  =>  {format.ToUpper()}", prefix: false);
            WriteStatus("");

            await Task.Run(() =>
            {
                IProgress<int> progress = new Progress<int>(value =>
                {
                    BeginInvoke((System.Action)(() =>
                    {
                        CurrentExportProgressBar.Maximum = AppVariables.WavFiles.Count;
                        CurrentExportProgressBar.Value = value;
                        OverallExportProgressBar.Value = overallIndex;
                    }));
                });
                foreach (string wavFile in AppVariables.WavFiles)
                {
                    if (!isAborted)
                    {
                        if (format != "wav")
                            WavConverter.ConvertWav(wavFile, format);
                        string srcFile = Path.Combine(AppVariables.ProcessingDir, format, Path.GetFileNameWithoutExtension(wavFile) + $".{format}");
                        string destFile = Path.Combine(AppVariables.OutputDir, format, Path.GetFileNameWithoutExtension(wavFile) + $".{format}");

                        File.Copy(srcFile, destFile, true);
                        BeginInvoke((System.Action)(() =>
                        {
                            WriteStatus($"{Path.GetFileName(wavFile)}  =>  {Path.GetFileName(srcFile)}");
                            exportedAudioFiles += 1;
                            index += 1;
                            overallIndex += 1;
                            progress.Report(index);
                        }));
                    }
                    else
                        break;
                }
            });
        }

        private void OnExportEnded(bool aborted)
        {
            CurrentExportProgressBar.Value = 0;
            OverallExportProgressBar.Value = 0;
            OverallExportProgressBar.Style = ProgressBarStyle.Blocks;
            ExportButton.Enabled = true;
            ExportButton.Text = "Export";
            SettingsGroupBox.Enabled = true;
            ClearTempDirectories();
            isAborted = false;
            isBusy = false;
            WriteStatus("");
            if (!aborted)
                WriteStatus($"{exportedAudioFiles} audio files have been exported ({AppVariables.WavFiles.Count} unique sounds)", prefix: false);
            else
                WriteStatus($"Task has been aborted, {exportedAudioFiles} audio files were exported", prefix: false);
            WriteStatus("");
            exportedAudioFiles = 0;
        }

        private static void ClearTempDirectories()
        {
            while (Process.GetProcessesByName("quickbms").Length>0)
                foreach (var process in Process.GetProcessesByName("quickbms"))
                    process.Kill();

            while (Process.GetProcessesByName("vgmstream-cli").Length>0)
                foreach (var process in Process.GetProcessesByName("vgmstream-cli"))
                    process.Kill();

            while (Process.GetProcessesByName("ffmpeg").Length>0)
                foreach (var process in Process.GetProcessesByName("ffmpeg"))
                    process.Kill();

            DirectoryInfo processingDir = new DirectoryInfo(AppVariables.ProcessingDir);
            foreach (FileInfo file in processingDir.GetFiles()) file.Delete();
            foreach (DirectoryInfo subDirectory in processingDir.GetDirectories()) subDirectory.Delete(true);
        }

        private async void CloseApplication(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Properties.Settings.Default.Save();

            if (isBusy && !isAborted)
                ExportOrAbort(null, null);

            while (isAborted)
                await Task.Delay(100);

            try
            {
                Directory.Delete(AppVariables.LibsDir, true);
                Directory.Delete(AppVariables.ProcessingDir, true);
            }
            catch { }
            Application.DoEvents();
            Environment.Exit(0);
        }
    }
}