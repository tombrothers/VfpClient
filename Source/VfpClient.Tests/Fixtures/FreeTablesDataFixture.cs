using System.IO;
using System.IO.Compression;

namespace VfpClient.Tests.Fixtures {
    public class FreeTablesDataFixture : DataFixtureBase {
        private static readonly string zipFullPath;

        static FreeTablesDataFixture() {
            zipFullPath = Path.Combine(RootDirectory, "FreeTables.zip");
        }

        public FreeTablesDataFixture() {
            EnsureZipFileExists();

            ZipFile.ExtractToDirectory(zipFullPath, this.DataDirectory);
        }

        protected override string GetConnectionString() => this.DataDirectory;

        private static void EnsureZipFileExists() {
            if(File.Exists(zipFullPath)) {
                return;
            }

            File.WriteAllBytes(zipFullPath, Properties.Resources.FreeTablesZip);
        }
    }
}
