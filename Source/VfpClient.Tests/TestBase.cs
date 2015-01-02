using System;
using System.Diagnostics;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public abstract class TestBase {
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context) {
            File.WriteAllBytes("NorthwindVfp.zip", Properties.Resources.NorthwindVfpZip);
            File.WriteAllBytes(Path.Combine(context.TestDeploymentDir, "Artist.dbf"), Properties.Resources.ArtistDbf);
            File.WriteAllBytes(Path.Combine(context.TestDeploymentDir, "SingleColumnSingleRow.dbf"), Properties.Resources.SingleColumnSingleRowDbf);
            File.WriteAllBytes("FreeTables.zip", Properties.Resources.FreeTablesZip);

            var zip = new FastZip();
            zip.ExtractZip("NorthwindVfp.zip", context.TestDeploymentDir, string.Empty);
            zip.ExtractZip("FreeTables.zip", Path.Combine(context.TestDeploymentDir, "FreeTables"), string.Empty);

            VfpClientTracing.Tracer = new TraceSource("VfpClient", SourceLevels.All);
            VfpClientTracing.Tracer.Listeners.Add(new TestContextTraceListener(context));
        }

        protected virtual VfpConnection GetConnection(string connectionString = null, bool keepClosed = false) {
            var northwind = Path.Combine(TestContext.TestDeploymentDir, "northwind.dbc");
            var connection = new VfpConnection(connectionString ?? "Data Source=" + northwind);

            if (!keepClosed) {
                connection.Open();
            }

            if (!Debugger.IsAttached) {
                connection.CommandExecuting = details => TestContext.WriteLine(details.ToTraceString() + Environment.NewLine);
                connection.CommandFailed = details => TestContext.WriteLine(details.ToTraceString() + Environment.NewLine);
                connection.CommandFinished = details => TestContext.WriteLine(details.ToTraceString() + Environment.NewLine);
            }

            return connection;
        }

        protected void CommandAction(Action<VfpCommand> action) {
            using (var connection = GetConnection()) {
                using (var command = connection.CreateCommand()) {
                    action(command);
                }
            }
        }

        private class TestContextTraceListener : TraceListener {
            private readonly TestContext _context;

            public TestContextTraceListener(TestContext context) {
                _context = context;
            }

            public override void Write(string message) {
                _context.WriteLine(message);
            }

            public override void WriteLine(string message) {
                _context.WriteLine(message.Replace("{", "{{").Replace("}", "}}"));
            }
        }
    }
}