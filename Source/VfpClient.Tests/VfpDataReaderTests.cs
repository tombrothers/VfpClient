using System;
using System.Data;
using System.Data.Common;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpDataReaderTests : TestBase {
        [TestMethod]
        public void GetValues_Should_Read_Binary_String_Fields_As_Strings_Test() {
            using (var connection = GetConnection(Path.Combine(TestContext.TestDeploymentDir, "FreeTables"), true)) {
                connection.Open();
                using (var command = connection.CreateCommand()) {
                    command.CommandText = "Select * from AllTypes";
                    
                    using (var reader = command.ExecuteReader()) {
                        reader.Read();
                        
                        var values = new object[reader.FieldCount];

                        reader.GetValues(values);

                        Assert.AreEqual(reader.GetString(1), values[1].ToString());
                        Assert.AreEqual(reader.GetString(2), values[2].ToString());

                        Assert.AreEqual(reader.GetString(13), values[13].ToString());
                        Assert.AreEqual(reader.GetString(14), values[14].ToString());
                        Assert.AreEqual(reader.GetString(15), values[15].ToString());
                        Assert.AreEqual(reader.GetString(16), values[16].ToString());
                    }
                }
            }
        }

        [TestMethod]
        public void GetGuidTest() {
            using (var connection = GetConnection(TestContext.TestDeploymentDir, true)) {
                connection.Open();
                using (var command = connection.CreateCommand()) {
                    command.CommandText = "Select '8A9CE5A3-981C-44FC-896F-C4EB0858BD9F' from SingleColumnSingleRow";
                    using (var reader = command.ExecuteReader()) {
                        reader.Read();
                        Assert.AreEqual(new Guid("8A9CE5A3-981C-44FC-896F-C4EB0858BD9F"), reader.GetGuid(0));
                    }
                }
            }
        }

        [TestMethod]
        public void DepthTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Customers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(0, reader.Depth);
                    reader.Close();
                }
            }

            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Northwind.dbc";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(0, reader.Depth);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void FieldCountTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Customers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(11, reader.FieldCount);
                    reader.Close();
                }
            }

            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Northwind.dbc";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(8, reader.FieldCount);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void HasRowsTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Shippers";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsTrue(reader.HasRows);
                    reader.Close();
                }
            }

            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from CustomerCustomerDemo";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsFalse(reader.HasRows);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void IsClosedTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Products";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsFalse(reader.IsClosed);
                    reader.Close();
                    Assert.IsTrue(reader.IsClosed);
                }
            }
        }

        [TestMethod]
        public void RecordsAffectedTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Customers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(91, reader.RecordsAffected);
                    reader.Close();
                }
            }

            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Orders";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(830, reader.RecordsAffected);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetDataTypeNameTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Orders";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual("Integer", reader.GetDataTypeName(0));
                    Assert.AreEqual("Character", reader.GetDataTypeName(1));
                    Assert.AreEqual("Integer", reader.GetDataTypeName(2));
                    Assert.AreEqual("Date", reader.GetDataTypeName(3));
                    Assert.AreEqual("Integer", reader.GetDataTypeName(6));
                    Assert.AreEqual("Currency", reader.GetDataTypeName(7));
                    Assert.AreEqual("Character", reader.GetDataTypeName(8));
                    Assert.AreEqual("Character", reader.GetDataTypeName(9));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetEnumeratorTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "SELECT * FROM ORDERS";
                using (var reader = command.ExecuteReader()) {
                    IEnumerator enumerator = reader.GetEnumerator();

                    while (enumerator.MoveNext()) {
                        DbDataRecord record = (DbDataRecord)enumerator.Current;
                        Assert.AreEqual(reader.FieldCount, record.FieldCount);
                        Assert.AreEqual(reader.GetInt32(0), record.GetInt32(0));
                        Assert.AreEqual(reader.GetString(1), record.GetString(1));
                        Assert.AreEqual(reader.GetInt32(2), record.GetInt32(2));
                        Assert.AreEqual(reader.GetDateTime(3), record.GetDateTime(3));
                        Assert.AreEqual(reader.GetDateTime(4), record.GetDateTime(4));
                        Assert.AreEqual(reader.GetValue(5), record.GetValue(5));
                        Assert.AreEqual(reader.GetInt32(6), record.GetInt32(6));
                        Assert.AreEqual(reader.GetDecimal(7), record.GetDecimal(7));
                        reader.Read();
                    }
                }
            }
        }

        [TestMethod]
        public void GetFieldTypeTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Orders";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(typeof(int), reader.GetFieldType(0));
                    Assert.AreEqual(typeof(string), reader.GetFieldType(1));
                    Assert.AreEqual(typeof(int), reader.GetFieldType(2));
                    Assert.AreEqual(typeof(DateTime), reader.GetFieldType(3));
                    Assert.AreEqual(typeof(int), reader.GetFieldType(6));
                    Assert.AreEqual(typeof(decimal), reader.GetFieldType(7));
                    Assert.AreEqual(typeof(string), reader.GetFieldType(8));
                    Assert.AreEqual(typeof(string), reader.GetFieldType(9));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetNameTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Products";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual("Productid", reader.GetName(0));
                    Assert.AreEqual("Productname", reader.GetName(1));
                    Assert.AreEqual("Supplierid", reader.GetName(2));
                    Assert.AreEqual("Categoryid", reader.GetName(3));
                    Assert.AreEqual("Quantityperunit", reader.GetName(4));
                    Assert.AreEqual("Unitprice", reader.GetName(5));
                    Assert.AreEqual("Unitsinstock", reader.GetName(6));
                    Assert.AreEqual("Unitsonorder", reader.GetName(7));
                    Assert.AreEqual("Reorderlevel", reader.GetName(8));
                    Assert.AreEqual("Discontinued", reader.GetName(9));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetNameWithOutOfBoundIndexTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(string.Empty, reader.GetName(20));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetNameWithNegativeIndexTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(string.Empty, reader.GetName(-1));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetOrdinalTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(0, reader.GetOrdinal("supplierid"));
                    Assert.AreEqual(1, reader.GetOrdinal("companyname"));
                    Assert.AreEqual(2, reader.GetOrdinal("contactname"));
                    Assert.AreEqual(3, reader.GetOrdinal("contacttitle"));
                    Assert.AreEqual(4, reader.GetOrdinal("address"));
                    Assert.AreEqual(5, reader.GetOrdinal("city"));
                    Assert.AreEqual(6, reader.GetOrdinal("region"));
                    Assert.AreEqual(7, reader.GetOrdinal("postalcode"));
                    Assert.AreEqual(8, reader.GetOrdinal("country"));
                    Assert.AreEqual(9, reader.GetOrdinal("phone"));
                    Assert.AreEqual(10, reader.GetOrdinal("fax"));
                    Assert.AreEqual(11, reader.GetOrdinal("homepage"));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetOrdinalWithNonExistNameTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(-1, reader.GetOrdinal("notexist"));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOrdinalWithNullNameTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(-1, reader.GetOrdinal(null));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetOrdinalWithEmptyStringTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.AreEqual(-1, reader.GetOrdinal(string.Empty));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetSchemaTableTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Customers";
                using (var reader = command.ExecuteReader()) {
                    DataTable schemaTable = reader.GetSchemaTable();
                    Assert.AreEqual(20, schemaTable.Columns.Count);
                    Assert.AreEqual("Customerid", schemaTable.Rows[0]["ColumnName"]);
                    Assert.AreEqual(0, schemaTable.Rows[0]["ColumnOrdinal"]);
                    Assert.AreEqual(5, schemaTable.Rows[0]["ColumnSize"]);
                    Assert.AreEqual("Companyname", schemaTable.Rows[1]["ColumnName"]);
                    Assert.AreEqual((short)255, schemaTable.Rows[1]["NumericPrecision"]);
                    Assert.AreEqual(Type.GetType("System.String"), schemaTable.Rows[1]["DataType"]);
                    Assert.AreEqual("Phone", schemaTable.Rows[9]["ColumnName"]);
                    Assert.AreEqual(9, schemaTable.Rows[9]["ColumnOrdinal"]);
                    Assert.AreEqual(24, schemaTable.Rows[9]["ColumnSize"]);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetBooleanTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Products";
                using (var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.IsFalse(reader.GetBoolean(9));
                    reader.Read();
                    Assert.IsFalse(reader.GetBoolean(9));
                    reader.Read();
                    Assert.IsFalse(reader.GetBoolean(9));
                    reader.Read();
                    Assert.IsFalse(reader.GetBoolean(9));
                    reader.Read();
                    Assert.IsTrue(reader.GetBoolean(9));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetBooleanWithNonBooleanDataTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Suppliers";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsFalse(reader.GetBoolean(0));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetDateTimeTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select orderdate, shippeddate from orders";
                using (var reader = command.ExecuteReader()) {
                    reader.Read();
                    DateTime date = reader.GetDateTime(0);
                    Assert.AreEqual(7, date.Month);
                    Assert.AreEqual(4, date.Day);
                    Assert.AreEqual(1996, date.Year);
                    date = reader.GetDateTime(1);
                    Assert.AreEqual(7, date.Month);
                    Assert.AreEqual(16, date.Day);
                    Assert.AreEqual(1996, date.Year);
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    date = reader.GetDateTime(0);
                    Assert.AreEqual(7, date.Month);
                    Assert.AreEqual(11, date.Day);
                    Assert.AreEqual(1996, date.Year);
                    date = reader.GetDateTime(1);
                    Assert.AreEqual(7, date.Month);
                    Assert.AreEqual(23, date.Day);
                    Assert.AreEqual(1996, date.Year);
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void GetDecimalTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from Orders";
                using (var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.AreEqual((decimal)32.38, reader.GetDecimal(7));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void IsDbNullTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from categories";
                using (var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.IsFalse(reader.IsDBNull(0));
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void NextResultTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from customers";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsFalse(reader.NextResult());
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void ReadTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "Select * from summary_of_sales_by_year";
                using (var reader = command.ExecuteReader()) {
                    Assert.IsTrue(reader.Read());
                    Assert.IsTrue(reader.Read());
                    Assert.IsTrue(reader.Read());
                    Assert.IsFalse(reader.Read());
                    reader.Close();
                }
            }
        }
    }
}