using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpCommandTests : TestBase {
        [TestMethod]
        public void NamedParameterTest() {
            using (var connection = GetConnection()) {
                using (var command = connection.CreateCommand()) {

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

                    Assert.AreEqual(14, dataTable.Rows.Count);
                }
            }
        }

        [TestMethod]
        public void ToVfpCodeTest() {
            using (var connection = GetConnection())
            using (var command = connection.CreateCommand()) {
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

                Assert.AreEqual(expected, actual);
                Assert.AreEqual(1, Convert.ToInt32(command.ExecuteScalar()));
            }
        }
    }
}