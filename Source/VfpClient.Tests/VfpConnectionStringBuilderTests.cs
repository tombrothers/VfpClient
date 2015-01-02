using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpConnectionStringBuilderTests {
        [TestMethod]
        public void VfpConnectionStringBuilderPropertiesTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder("northwind.dbc") { Ansi = true, Deleted = false, CollatingSequence = Collation.GENERAL };

            Assert.AreEqual("data source=northwind.dbc;Ansi=True;Deleted=False;Collating Sequence=GENERAL", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual("northwind.dbc", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual("northwind.dbc", vfpConnectionStringBuilder.Database, false);
            Assert.AreEqual(true, vfpConnectionStringBuilder.Ansi);
            Assert.AreEqual(false, vfpConnectionStringBuilder.Deleted);
            Assert.AreEqual(Collation.GENERAL, vfpConnectionStringBuilder.CollatingSequence);
            Assert.AreEqual(4, vfpConnectionStringBuilder.Count);
        }

        [TestMethod]
        public void VfpOleDbConnectionStringTest() {
            var connectionString = "provider=vfpoledb;data source=northwind.dbc;deleted=false;ansi=true;";
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder(connectionString);

            Assert.AreEqual("provider=vfpoledb;data source=northwind.dbc;deleted=false;ansi=true", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual("northwind.dbc", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual("northwind.dbc", vfpConnectionStringBuilder.Database, false);
            Assert.AreEqual(4, vfpConnectionStringBuilder.Count);
        }

        [TestMethod]
        public void ZeroArgumentContructorTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder();

            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);
            Assert.AreEqual(0, vfpConnectionStringBuilder.Count);
        }

        [TestMethod]
        public void FreeTableTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder(@"c:\");

            Assert.AreEqual(@"Data Source=c:\", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(@"c:\", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);
        }

        [TestMethod]
        public void DbcOnlyTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder("Northwind.dbc");

            Assert.AreEqual("Data Source=Northwind.dbc", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.Database, false);
        }

        [TestMethod]
        public void OneStringArgumentConstructorTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder(null);

            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);

            vfpConnectionStringBuilder = new VfpConnectionStringBuilder(String.Empty);

            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);

            vfpConnectionStringBuilder = new VfpConnectionStringBuilder("Data Source=Northwind.dbc");

            Assert.AreEqual("Data Source=Northwind.dbc", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.Database, false);
        }

        [TestMethod]
        public void ConnectionStringTest() {
            var vfpConnectionStringBuilder = new VfpConnectionStringBuilder();

            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.ConnectionString, false);

            vfpConnectionStringBuilder.ConnectionString = "Data Source=Northwind.dbc";

            Assert.AreEqual("Data Source=Northwind.dbc", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual("Northwind.dbc", vfpConnectionStringBuilder.Database, false);

            vfpConnectionStringBuilder.ConnectionString = String.Empty;

            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);

            vfpConnectionStringBuilder.ConnectionString = "Provider=FoxPro";

            Assert.AreEqual("Provider=FoxPro", vfpConnectionStringBuilder.ConnectionString, true);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.DataSource, false);
            Assert.AreEqual(string.Empty, vfpConnectionStringBuilder.Database, false);

            vfpConnectionStringBuilder.DataSource = "Test.dbc";

            Assert.AreEqual(vfpConnectionStringBuilder.Database, vfpConnectionStringBuilder.DataSource);
            vfpConnectionStringBuilder.DataSource = "Test2.dbc";
            Assert.AreEqual(vfpConnectionStringBuilder.DataSource, vfpConnectionStringBuilder.Database);
        }
    }
}