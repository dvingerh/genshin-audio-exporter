using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace genshin_audio_exporter
{
    public class PckToWem
    {
        public static void StartPckToWem(string inputFile, MainForm callback)
        {
            Process pckToWemProcess;
            string quickBmsPath = Path.Combine(AppVariables.LibsDir, "quickbms.exe");
            string waveScanBms = Path.Combine(AppVariables.LibsDir, "wavescan.bms");
            string wemFolder = Path.Combine(AppVariables.ProcessingDir, "wem");
            Directory.CreateDirectory(wemFolder);
            var startInfo = new ProcessStartInfo(quickBmsPath)
            {
                WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Arguments = $"\"{waveScanBms}\" \"{inputFile}\" \"{wemFolder}\"",
                CreateNoWindow = true,
                UseShellExecute = false,
            };

            using (pckToWemProcess = new Process())
            {
                try
                {
                    pckToWemProcess.StartInfo = startInfo;
                    pckToWemProcess.Start();

                    pckToWemProcess.WaitForExit();
                }
                catch (Exception ex)
                {
                    callback.WriteStatus($"Could not start quickbms.exe process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.");
                    MessageBox.Show($"Could not start quickbms.exe process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
