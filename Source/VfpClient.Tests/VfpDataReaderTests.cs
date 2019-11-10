using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests {
    public class VfpDataReaderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpDataReaderTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData("Customers", 91)]
        [InlineData("Orders", 830)]
        public void RecordsAffected_ShouldHaveExpectedValue(string table, int recordsAffected) {
            this.fixture.ExecuteReader($"Select * from {table}", reader => {
                Assert.Equal(recordsAffected, reader.RecordsAffected);
            });
        }

        [Theory]
        [InlineData("Shippers", true)]
        [InlineData("CustomerCustomerDemo", false)]
        public void HasRows_ShouldHaveExpectedValue(string table, bool hasRows) {
            this.fixture.ExecuteReader($"Select * from {table}", reader => {
                Assert.Equal(hasRows, reader.HasRows);
            });
        }

        [Theory]
        [InlineData("Customers", 11)]
        [InlineData("northwind.dbc", 8)]
        public void FieldCount_ShouldHaveExpectedValue(string table, int fieldCount) {
            this.fixture.ExecuteReader($"Select * from {table}", reader => {
                Assert.Equal(fieldCount, reader.FieldCount);
            });
        }

        [Theory]
        [InlineData("Customers", 0)]
        [InlineData("northwind.dbc", 0)]
        public void Depth_ShouldHaveExpectedValue(string table, int fieldCount) {
            this.fixture.ExecuteReader($"Select * from {table}", reader => {
                Assert.Equal(fieldCount, reader.Depth);
            });
        }

        [Fact]
        public void IsClosedTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Products";
                using(var reader = command.ExecuteReader()) {
                    Assert.False(reader.IsClosed);
                    reader.Close();
                    Assert.True(reader.IsClosed);
                }
            });
        }

        [Fact]
        public void GetDataTypeNameTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Orders";
                using(var reader = command.ExecuteReader()) {
                    Assert.Equal("Integer", reader.GetDataTypeName(0));
                    Assert.Equal("Character", reader.GetDataTypeName(1));
                    Assert.Equal("Integer", reader.GetDataTypeName(2));
                    Assert.Equal("Date", reader.GetDataTypeName(3));
                    Assert.Equal("Integer", reader.GetDataTypeName(6));
                    Assert.Equal("Currency", reader.GetDataTypeName(7));
                    Assert.Equal("Character", reader.GetDataTypeName(8));
                    Assert.Equal("Character", reader.GetDataTypeName(9));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetEnumeratorTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "SELECT * FROM ORDERS";
                using(var reader = command.ExecuteReader()) {
                    IEnumerator enumerator = reader.GetEnumerator();

                    while(enumerator.MoveNext()) {
                        DbDataRecord record = (DbDataRecord)enumerator.Current;
                        Assert.Equal(reader.FieldCount, record.FieldCount);
                        Assert.Equal(reader.GetInt32(0), record.GetInt32(0));
                        Assert.Equal(reader.GetString(1), record.GetString(1));
                        Assert.Equal(reader.GetInt32(2), record.GetInt32(2));
                        Assert.Equal(reader.GetDateTime(3), record.GetDateTime(3));
                        Assert.Equal(reader.GetDateTime(4), record.GetDateTime(4));
                        Assert.Equal(reader.GetValue(5), record.GetValue(5));
                        Assert.Equal(reader.GetInt32(6), record.GetInt32(6));
                        Assert.Equal(reader.GetDecimal(7), record.GetDecimal(7));
                        reader.Read();
                    }
                }
            });
        }

        [Fact]
        public void GetFieldTypeTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Orders";
                using(var reader = command.ExecuteReader()) {
                    Assert.Equal(typeof(int), reader.GetFieldType(0));
                    Assert.Equal(typeof(string), reader.GetFieldType(1));
                    Assert.Equal(typeof(int), reader.GetFieldType(2));
                    Assert.Equal(typeof(DateTime), reader.GetFieldType(3));
                    Assert.Equal(typeof(int), reader.GetFieldType(6));
                    Assert.Equal(typeof(decimal), reader.GetFieldType(7));
                    Assert.Equal(typeof(string), reader.GetFieldType(8));
                    Assert.Equal(typeof(string), reader.GetFieldType(9));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetNameTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Products";
                using(var reader = command.ExecuteReader()) {
                    Assert.Equal("Productid", reader.GetName(0));
                    Assert.Equal("Productname", reader.GetName(1));
                    Assert.Equal("Supplierid", reader.GetName(2));
                    Assert.Equal("Categoryid", reader.GetName(3));
                    Assert.Equal("Quantityperunit", reader.GetName(4));
                    Assert.Equal("Unitprice", reader.GetName(5));
                    Assert.Equal("Unitsinstock", reader.GetName(6));
                    Assert.Equal("Unitsonorder", reader.GetName(7));
                    Assert.Equal("Reorderlevel", reader.GetName(8));
                    Assert.Equal("Discontinued", reader.GetName(9));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetNameWithOutOfBoundIndexTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<IndexOutOfRangeException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.Equal(string.Empty, reader.GetName(20));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetNameWithNegativeIndexTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<IndexOutOfRangeException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.Equal(string.Empty, reader.GetName(-1));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetOrdinalTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";
                using(var reader = command.ExecuteReader()) {
                    Assert.Equal(0, reader.GetOrdinal("supplierid"));
                    Assert.Equal(1, reader.GetOrdinal("companyname"));
                    Assert.Equal(2, reader.GetOrdinal("contactname"));
                    Assert.Equal(3, reader.GetOrdinal("contacttitle"));
                    Assert.Equal(4, reader.GetOrdinal("address"));
                    Assert.Equal(5, reader.GetOrdinal("city"));
                    Assert.Equal(6, reader.GetOrdinal("region"));
                    Assert.Equal(7, reader.GetOrdinal("postalcode"));
                    Assert.Equal(8, reader.GetOrdinal("country"));
                    Assert.Equal(9, reader.GetOrdinal("phone"));
                    Assert.Equal(10, reader.GetOrdinal("fax"));
                    Assert.Equal(11, reader.GetOrdinal("homepage"));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetOrdinalWithNonExistNameTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<IndexOutOfRangeException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.Equal(-1, reader.GetOrdinal("notexist"));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetOrdinalWithNullNameTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<ArgumentNullException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.Equal(-1, reader.GetOrdinal(null));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetOrdinalWithEmptyStringTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<IndexOutOfRangeException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.Equal(-1, reader.GetOrdinal(string.Empty));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetSchemaTableTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Customers";

                using(var reader = command.ExecuteReader()) {
                    DataTable schemaTable = reader.GetSchemaTable();
                    Assert.Equal(20, schemaTable.Columns.Count);
                    Assert.Equal("Customerid", schemaTable.Rows[0]["ColumnName"]);
                    Assert.Equal(0, schemaTable.Rows[0]["ColumnOrdinal"]);
                    Assert.Equal(5, schemaTable.Rows[0]["ColumnSize"]);
                    Assert.Equal("Companyname", schemaTable.Rows[1]["ColumnName"]);
                    Assert.Equal((short)255, schemaTable.Rows[1]["NumericPrecision"]);
                    Assert.Equal(Type.GetType("System.String"), schemaTable.Rows[1]["DataType"]);
                    Assert.Equal("Phone", schemaTable.Rows[9]["ColumnName"]);
                    Assert.Equal(9, schemaTable.Rows[9]["ColumnOrdinal"]);
                    Assert.Equal(24, schemaTable.Rows[9]["ColumnSize"]);
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetBooleanTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Products";
                using(var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.False(reader.GetBoolean(9));
                    reader.Read();
                    Assert.False(reader.GetBoolean(9));
                    reader.Read();
                    Assert.False(reader.GetBoolean(9));
                    reader.Read();
                    Assert.False(reader.GetBoolean(9));
                    reader.Read();
                    Assert.True(reader.GetBoolean(9));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetBooleanWithNonBooleanDataTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Suppliers";

                Assert.Throws<InvalidOperationException>(() => {
                    using(var reader = command.ExecuteReader()) {
                        Assert.False(reader.GetBoolean(0));
                        reader.Close();
                    }
                });
            });
        }

        [Fact]
        public void GetDateTimeTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select orderdate, shippeddate from orders";

                using(var reader = command.ExecuteReader()) {
                    reader.Read();
                    DateTime date = reader.GetDateTime(0);
                    Assert.Equal(7, date.Month);
                    Assert.Equal(4, date.Day);
                    Assert.Equal(1996, date.Year);
                    date = reader.GetDateTime(1);
                    Assert.Equal(7, date.Month);
                    Assert.Equal(16, date.Day);
                    Assert.Equal(1996, date.Year);
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    date = reader.GetDateTime(0);
                    Assert.Equal(7, date.Month);
                    Assert.Equal(11, date.Day);
                    Assert.Equal(1996, date.Year);
                    date = reader.GetDateTime(1);
                    Assert.Equal(7, date.Month);
                    Assert.Equal(23, date.Day);
                    Assert.Equal(1996, date.Year);
                    reader.Close();
                }
            });
        }

        [Fact]
        public void GetDecimalTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Orders";
                using(var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.Equal((decimal)32.38, reader.GetDecimal(7));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void IsDbNullTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from categories";

                using(var reader = command.ExecuteReader()) {
                    reader.Read();
                    Assert.False(reader.IsDBNull(0));
                    reader.Close();
                }
            });
        }

        [Fact]
        public void NextResultTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from customers";

                using(var reader = command.ExecuteReader()) {
                    Assert.False(reader.NextResult());
                    reader.Close();
                }
            });
        }

        [Fact]
        public void ReadTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from summary_of_sales_by_year";
                using(var reader = command.ExecuteReader()) {
                    Assert.True(reader.Read());
                    Assert.True(reader.Read());
                    Assert.True(reader.Read());
                    Assert.False(reader.Read());
                    reader.Close();
                }
            });
        }
    }
}
