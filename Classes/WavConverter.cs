using System.Diagnostics;
using System.IO;

namespace genshin_audio_exporter
{
    public static class WavConverter
    {
        private static string ffmpegPath = Path.Combine(AppVariables.LibsDir, "ffmpeg.exe");
        public static void ConvertWav(string inputFilePath, string format)
        {
            Process wavConvertProc;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            string outputFilePath = Path.Combine(AppVariables.ProcessingDir, format, Path.GetFileNameWithoutExtension(inputFilePath) + $".{format}");
            switch (format)
            {
                case "mp3":
                    startInfo = new ProcessStartInfo(ffmpegPath)
                    {
                        Arguments = $"-i \"{inputFilePath}\" -y -b:a 320k \"{outputFilePath}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };
                    break;
                case "ogg":
                    startInfo = new ProcessStartInfo(ffmpegPath)
                    {
                        Arguments = $"-i \"{inputFilePath}\" -y -acodec libvorbis -qscale:a 10 \"{outputFilePath}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };
                    break;
                case "flac":
                    startInfo = new ProcessStartInfo(ffmpegPath)
                    {
                        Arguments = $"-i \"{inputFilePath}\" -y -af aformat=s16:44100 \"{outputFilePath}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };
                    break;
            }
            using (wavConvertProc = new Process())
            {
                wavConvertProc.StartInfo = startInfo;
                wavConvertProc.Start();
                wavConvertProc.WaitForExit();
            }
        }
    }
}
