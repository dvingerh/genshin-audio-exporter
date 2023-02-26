using SevenZipExtractor;
using System.IO;
using System.Reflection;

namespace genshin_audio_exporter
{
    public static class AppResources
    {
        private static bool isUnpacked = false;

        public static bool IsUnpacked { get => isUnpacked; set => isUnpacked = value; }

        public static void UnpackResources()
        {
            if (!IsUnpacked)
            {
                string zipPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "libs.zip");
                string unzipPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "7z.dll");
                File.WriteAllBytes(zipPath, Properties.Resources.libs);
                File.WriteAllBytes(unzipPath, Properties.Resources.svnzip);

                using (ArchiveFile archiveFile = new ArchiveFile(zipPath, unzipPath))
                {
                    archiveFile.Extract(Path.GetDirectoryName(zipPath));
                }
                File.Delete(zipPath);
                File.Delete(unzipPath);
            }
            IsUnpacked = true;
        }
    }
}