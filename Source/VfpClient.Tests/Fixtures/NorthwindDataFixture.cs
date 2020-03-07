using System.IO;
using System.IO.Compression;
using System.Threading;

namespace VfpClient.Tests.Fixtures {
    public class NorthwindDataFixture : DataFixtureBase {
        private static readonly string zipFullPath;

        static NorthwindDataFixture() {
            zipFullPath = Path.Combine(RootDirectory, "NorthwindVfp.zip");
        }

        public NorthwindDataFixture() {
            EnsureZipFileExists();

            ZipFile.ExtractToDirectory(zipFullPath, this.DataDirectory);
        }

        protected override string GetConnectionString() => Path.Combine(this.DataDirectory, "northwind.dbc");

        private static void EnsureZipFileExists() {
            const int maxAttempts = 5;
            var attempt = 0;

            while(true) {
                if(File.Exists(zipFullPath)) {
                    return;
                }

                try {
                    File.WriteAllBytes(zipFullPath, Properties.Resources.NorthwindVfpZip);
                }
                catch(IOException) {
                    if(!File.Exists(zipFullPath) && attempt == maxAttempts) {
                        throw;
                    }

                    Thread.Sleep(500);
                    attempt++;
                }
            }
        }
    }
}
