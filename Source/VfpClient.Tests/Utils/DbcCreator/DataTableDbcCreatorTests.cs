using System;
using System.Data;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VfpClient.Utils.DbcCreator;

namespace VfpClient.Tests.Utils.DbcCreator {
    [TestClass]
    public class DataTableDbcCreatorTests : TestBase {
        [TestMethod]
        public void TestAllTypes() {
            var actual = CreateDataTable();
            //DataTableHelper.WriteDataTableCode("Expected", actual);

            var dbcPath = Path.Combine(TestContext.TestDeploymentDir, @"Data\MyTest.dbc");
            var creator = new DataTableDbcCreator(dbcPath);

            creator.Add(actual);

            var expected = new DataTable(actual.TableName);

            using (var connection = GetConnection(dbcPath)) {
                var sql = string.Format("select * from '{0}'", actual.TableName);
                var adapter = new VfpDataAdapter(sql, connection);

                adapter.Fill(expected);
            }

            Console.WriteLine(dbcPath);
        }

        private static DataTable CreateDataTable() {
            var dataTable = new DataTable("DataTableTest");

            dataTable.Columns.Add("Column1", typeof(bool));
            dataTable.Columns.Add("Column2", typeof(byte));
            dataTable.Columns.Add("Column3", typeof(DateTime));
            dataTable.Columns.Add("Column4", typeof(double));
            dataTable.Columns.Add("Column5", typeof(decimal));
            dataTable.Columns.Add("Column6", typeof(float));
            dataTable.Columns.Add("Column7", typeof(Guid));
            dataTable.Columns.Add("Column8", typeof(short));
            dataTable.Columns.Add("Column9", typeof(int));
            dataTable.Columns.Add("Column10", typeof(long));
            dataTable.Columns.Add("Column11", typeof(string));

            dataTable.Rows.Add(
                new object[]
                    {
                        false, 1, new DateTime(2012, 7, 2, 1, 9, 33), 2.2, 123456789.9, 567.99,
                        new Guid("{17EA04B6-9E32-4978-BDF5-3D47EB6E9650}"), 88, 4, 2147483648, "test"
                    });

            return dataTable;
        }

        public static DataTable GetExpected() {
            var dataTable = new DataTable("DataTableTest");

            #region columns

            dataTable.Columns.Add("Column1", typeof(System.Boolean));
            dataTable.Columns.Add("Column2", typeof(System.Byte));
            dataTable.Columns.Add("Column3", typeof(System.DateTime));
            dataTable.Columns.Add("Column4", typeof(System.Double));
            dataTable.Columns.Add("Column5", typeof(System.Decimal));
            dataTable.Columns.Add("Column6", typeof(System.Single));
            dataTable.Columns.Add("Column7", typeof(System.Guid));
            dataTable.Columns.Add("Column8", typeof(System.Int16));
            dataTable.Columns.Add("Column9", typeof(System.Int32));
            dataTable.Columns.Add("Column10", typeof(System.Int64));
            dataTable.Columns.Add("Column11", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["Column1"] = false;
            row["Column2"] = 1;
            row["Column3"] = DateTime.Parse("7/2/2012 1:09:33 AM");
            row["Column4"] = 2.2;
            row["Column5"] = 123456789.9;
            row["Column6"] = 567.99;
            row["Column7"] = new Guid("{17ea04b6-9e32-4978-bdf5-3d47eb6e9650}");
            row["Column8"] = 88;
            row["Column9"] = 4;
            row["Column10"] = 2147483648;
            row["Column11"] = "test";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
