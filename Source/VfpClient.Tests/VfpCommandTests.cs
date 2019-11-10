using System;
using System.Data;
using VfpClient.Tests.Fixtures;
using Xunit;

namespace VfpClient.Tests {
    public class VfpCommandTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpCommandTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void NamedParameterTest() {
            using(var connection = this.fixture.CreateConnection()) {
                using(var command = connection.CreateCommand()) {

                    command.CommandText = @"
SELECT CAST('Supplier' as v(254)) Type, CompanyName Name 
    FROM suppliers WHERE UPPER(ALLTRIM(CompanyName)) like @Name 
UNION SELECT CAST('Shipper' as v(254)) Entity, CompanyName 
        FROM Shippers WHERE UPPER(ALLTRIM(CompanyName)) like @Name
UNION SELECT CAST('Customer' as v(254)) Entity, CompanyName 
        FROM Customers WHERE UPPER(ALLTRIM(CompanyName)) like @Name
UNION SELECT CAST('Product' as v(254)) Entity, ProductName 
        FROM Products WHERE UPPER(ALLTRIM(ProductName)) like @Name
UNION SELECT CAST('Category' as v(254)) Entity, CategoryName 
        FROM Categories WHERE UPPER(ALLTRIM(CategoryName)) like @Name
UNION SELECT CAST('Employee' as v(254)) Entity, ALLTRIM(FirstName) + ' ' + ALLTRIM(LastName) 
        FROM Employees WHERE UPPER(ALLTRIM(FirstName)) like @Name OR UPPER(ALLTRIM(LastName)) like @Name
Order by 2";

                    command.Parameters.AddWithValue("Name", "%AB%");

                    var dataAdapter = new VfpDataAdapter(command);
                    var dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    Assert.Equal(14, dataTable.Rows.Count);
                }
            }
        }

        [Fact]
        public void ToVfpCodeTest() {
            using(var connection = this.fixture.CreateConnection())
            using(var command = connection.CreateCommand()) {
                command.CommandText =
    @"select count(*)
    from customers
    where customerid = @customerid or customerid = @customerid";

                command.Parameters.Add(new VfpParameter("customerid", "ALFKI"));

                var expected =
    @"__vfpClient_customerid = 'ALFKI'

select count(*) ;
    from customers ;
    where customerid = __vfpClient_customerid or customerid = __vfpClient_customerid";

                var actual = command.ToVfpCode();

                Assert.Equal(expected, actual);
                Assert.Equal(1, Convert.ToInt32(command.ExecuteScalar()));
            }
        }
    }
}