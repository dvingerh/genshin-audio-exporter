using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genshin_audio_exporter
{
    public static class WemToWav
    {
        public static void StartWemToWav(string inputFile, MainForm callback)
        {
            Process wemToWavProcess;
            string vgmstreamPath = Path.Combine(AppVariables.LibsDir, "vgmstream-cli.exe");
            string outputFilePath = Path.Combine(AppVariables.ProcessingDir, "wav", Path.GetFileNameWithoutExtension(inputFile) + ".wav");
            string wavFolder = Path.Combine(AppVariables.ProcessingDir, "wav");
            Directory.CreateDirectory(wavFolder);
            var startInfo = new ProcessStartInfo(vgmstreamPath)
            {
                WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Arguments = $"-o \"{outputFilePath}\" \"{inputFile}\"",
                CreateNoWindow = true,
                UseShellExecute = false,
            };

            using (wemToWavProcess = new Process())
            {
                try
                {
                    wemToWavProcess.StartInfo = startInfo;
                    wemToWavProcess.Start();
                    wemToWavProcess.WaitForExit();

                }
                catch (Exception ex)
                {
                    callback.WriteStatus($"Could not start vgmstream-cli.exe process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.");
                    MessageBox.Show($"Could not start vgmstream-cli.exe process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
