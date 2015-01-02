using System;
using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VfpClient.Utils;

namespace VfpClient.Tests {
    [TestClass]
    public class ArrayXmlToCursorTests : TestBase {
        [TestMethod]
        public void BooleanArrayTest() {
            var array = new[] { true, false };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<bool>("Id")).ToArray();

            CollectionAssert.AreEqual(array, ids);
        }

        [TestMethod]
        public void ByteArrayTest() {
            var array = new[] { byte.MinValue, byte.MaxValue };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (int)x).ToArray(), ids);
        }

        [TestMethod]
        public void CharArrayTest() {
            var array = new[] { 'a', 'b' };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => x.ToString()).ToArray(), ids);
        }

        [TestMethod]
        public void DateTimeArrayTest() {
            var array = Enumerable.Range(1, 10).Select(x => DateTime.Now.AddDays(x)).ToArray();
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<DateTime>("Id")).ToArray();

            var dateTimes1 = array.Select(x => x.ToString()).ToArray();
            var dateTimes2 = ids.Select(x => x.ToString()).ToArray();

            CollectionAssert.AreEqual(dateTimes1, dateTimes2);
        }

        [TestMethod]
        public void DecimalArrayTest() {
            var array = new[] { -1m, 0m, 1m, 1.5m };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array, ids);
        }

        [TestMethod]
        public void DoubleArrayTest() {
            var array = new double[] { -1, 1, 1.456 };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [TestMethod]
        public void GuidArrayTest() {
            var array = new[] { Guid.Empty, Guid.NewGuid() };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => x.ToString()).ToArray(), ids);
        }

        [TestMethod]
        public void Int16ArrayTest() {
            var array = new Int16[] { -1, Int16.MaxValue };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (int)x).ToArray(), ids);
        }

        [TestMethod]
        public void Int32ArrayTest() {
            var array = new[] { -1, int.MaxValue };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            CollectionAssert.AreEqual(array, ids);
        }

        [TestMethod]
        public void Int64ArrayTest() {
            var array = new long[] { -1, 0, 1 };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [TestMethod]
        public void MemoArrayTest() {
            var array = new[] { "", "Test", "Test2", new string('x', VfpMapping.MaximumCharacterFieldSize + 1) };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            CollectionAssert.AreEqual(array, ids);
        }

        [TestMethod]
        public void SByteArrayTest() {
            var array = new SByte[] { 0, sbyte.MaxValue };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (int)x).ToArray(), ids);
        }

        [TestMethod]
        public void SingleArrayTest() {
            var array = new[] { -1f, 0f, 1f, 1.5f };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [TestMethod]
        public void StringArrayTest() {
            var array = new[] { "", "Test", "Test2", new string('x', VfpMapping.MaximumCharacterFieldSize), null };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            array = array.Take(4).ToArray();
            ids = ids.Take(4).ToArray();

            CollectionAssert.AreEqual(array, ids);
        }

        [TestMethod]
        public void UInt16ArrayTest() {
            var array = new UInt16[] { 0, 1 };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (int)x).ToArray(), ids);
        }

        [TestMethod]
        public void UInt32ArrayTest() {
            var array = new UInt32[] { 0, 1 };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [TestMethod]
        public void UInt64ArrayTest() {
            var array = new UInt64[] { 0, 1 };
            var arrayXmlToCursor = new ArrayXmlToCursor(array);
            var table = GetDataTable(arrayXmlToCursor);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            CollectionAssert.AreEqual(array.Select(x => (decimal)x).ToArray(), ids);
        }

        private DataTable GetDataTable(ArrayXmlToCursor arrayXmlToCursor) {
            using (var connection = GetConnection(TestContext.TestDeploymentDir)) {
                using (var command = connection.CreateCommand()) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "XmlToCursor";
                    command.Parameters.Add(new VfpParameter("xml", arrayXmlToCursor.Xml));
                    command.Parameters.Add(new VfpParameter("cursor", "curXmlTemp"));
                    command.ExecuteNonQuery();

                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM curXmlTemp";

                    var table = new DataTable();
                    var adapter = new VfpDataAdapter(command);

                    adapter.Fill(table);

                    return table;
                }
            }
        }
    }
}