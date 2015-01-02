using System.Data;

namespace VfpClient.Tests.Schema
{
    class ViewSchemaProviderExpected
    {
        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("Views");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("AllowSimultaneousFetch", typeof(System.Boolean));
            dataTable.Columns.Add("BatchUpdateCount", typeof(System.Int32));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("CompareMemo", typeof(System.Boolean));
            dataTable.Columns.Add("ConnectName", typeof(System.String));
            dataTable.Columns.Add("FetchAsNeeded", typeof(System.Boolean));
            dataTable.Columns.Add("FetchMemo", typeof(System.Boolean));
            dataTable.Columns.Add("FetchSize", typeof(System.Int32));
            dataTable.Columns.Add("MaxRecords", typeof(System.Int32));
            dataTable.Columns.Add("Offline", typeof(System.Boolean));
            dataTable.Columns.Add("ParameterList", typeof(System.String));
            dataTable.Columns.Add("Prepared", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("SendUpdates", typeof(System.Boolean));
            dataTable.Columns.Add("ShareConnection", typeof(System.Boolean));
            dataTable.Columns.Add("SourceType", typeof(System.Int32));
            dataTable.Columns.Add("SQL", typeof(System.String));
            dataTable.Columns.Add("Tables", typeof(System.String));
            dataTable.Columns.Add("UpdateType", typeof(System.Int32));
            dataTable.Columns.Add("UseMemoSize", typeof(System.Int32));
            dataTable.Columns.Add("WhereType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Products.*, Categories.categoryname FROM  northwind!Categories  INNER JOIN northwind!Products  ON  Categories.categoryid = Products.categoryid WHERE  Products.discontinued = .F. ORDER BY Products.productname";
            row["Tables"] = "northwind!Products,northwind!Categories";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ViewName"] = "Category_Sales_For_1997";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Product_Sales_For_1997.CategoryName, Sum(Product_Sales_For_1997.ProductSales) AS CategorySales FROM Product_Sales_For_1997 GROUP BY Product_Sales_For_1997.CategoryName";
            row["Tables"] = "Product_Sales_For_1997";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ViewName"] = "Current_Product_List";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Product_List.ProductID, Product_List.ProductName  FROM Products AS Product_List  WHERE (((Product_List.Discontinued)=.F.))  ORDER BY Product_List.ProductName";
            row["Tables"] = "";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ViewName"] = "Customer_And_Suppliers_By_City";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT City, CompanyName, ContactName, 'Customers' AS Relationship  FROM Customers  UNION SELECT City, CompanyName, ContactName, 'Suppliers' FROM Suppliers";
            row["Tables"] = "Customers";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode,  Orders.ShipCountry, Orders.CustomerID, Customers.CompanyName AS CustomerName, Customers.Address, Customers.City,  Customers.Region, Customers.PostalCode, Customers.Country,  (ALLTRIM(FirstName) + ' ' + ALLTRIM(LastName)) AS Salesperson,  Orders.OrderID, Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Shippers.CompanyName As ShipperName,  OrderDetails.ProductID, Products.ProductName, OrderDetails.UnitPrice, OrderDetails.Quantity,  OrderDetails.Discount,  (OrderDetails.UnitPrice*OrderDetails.Quantity*(1-OrderDetails.Discount)/100) *100 AS ExtendedPrice, Orders.Freight FROM Shippers INNER JOIN  (Products INNER JOIN (  (Employees INNER JOIN  (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID)  ON Employees.EmployeeID = Orders.EmployeeID)  INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID)  ON Products.ProductID = OrderDetails.ProductID)  ON Shippers.ShipperID = Orders.ShipVia ORDER BY Orders.CustomerID, Orders.ShippedDate DESC";
            row["Tables"] = "";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT OrderDetails.OrderID, OrderDetails.ProductID, Products.ProductName,  OrderDetails.UnitPrice, OrderDetails.Quantity, OrderDetails.Discount,  ((OrderDetails.UnitPrice*OrderDetails.Quantity*(1-OrderDetails.Discount)/100)*100) AS ExtendedPrice FROM Products INNER JOIN OrderDetails ON Products.ProductID = OrderDetails.ProductID";
            row["Tables"] = "OrderDetails,Products";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Subtotals";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT OrderDetails.OrderID, Sum( (OrderDetails.UnitPrice*OrderDetails.Quantity*(1-OrderDetails.Discount)/100) *100) AS Subtotal FROM OrderDetails GROUP BY OrderDetails.OrderID";
            row["Tables"] = "OrderDetails";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Orders.OrderID, Orders.CustomerID, Orders.EmployeeID, Orders.OrderDate, Orders.RequiredDate,  Orders.ShippedDate, Orders.ShipVia, Orders.Freight, Orders.ShipName, Orders.ShipAddress, Orders.ShipCity,  Orders.ShipRegion, Orders.ShipPostalCode, Orders.ShipCountry,  Customers.CompanyName, Customers.Address, Customers.City, Customers.Region, Customers.PostalCode, Customers.Country FROM Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID";
            row["Tables"] = "Orders,Customers";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ViewName"] = "Product_Sales_For_1997";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Categories.CategoryName, Products.ProductName,  Sum( (OrderDetails.UnitPrice*OrderDetails.Quantity*(1-OrderDetails.Discount)/100) *100) AS ProductSales  FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID)  INNER JOIN (Orders INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID)  ON Products.ProductID = OrderDetails.ProductID  WHERE BETWEEN(Orders.ShippedDate, {^1997/01/01},{^1997/12/31}) GROUP BY Categories.CategoryName, Products.ProductName";
            row["Tables"] = "";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ViewName"] = "Products_Above_Average_Price";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Products.ProductName, Products.UnitPrice FROM Products WHERE Products.UnitPrice>(SELECT AVG(UnitPrice) From Products)";
            row["Tables"] = "Products";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Categories.CategoryName, Products.ProductName, Products.QuantityPerUnit, Products.UnitsInStock, Products.Discontinued FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID WHERE Products.Discontinued = .F. ORDER BY Categories.CategoryName, Products.ProductName";
            row["Tables"] = "Categories,Products";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ViewName"] = "Quarterly_Orders";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT DISTINCT Customers.CustomerID, Customers.CompanyName, Customers.City, Customers.Country FROM Customers RIGHT JOIN Orders ON Customers.CustomerID = Orders.CustomerID WHERE BETWEEN(Orders.OrderDate, {^1997/01/01},{^1997/12/31})";
            row["Tables"] = "Customers";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Categories.CategoryID, Categories.CategoryName, Products.ProductName,  Sum(Order_Details_Extended.ExtendedPrice) AS ProductSales FROM 	Categories INNER JOIN  (Products INNER JOIN  (Orders INNER JOIN Order_Details_Extended ON Orders.OrderID = Order_Details_Extended.OrderID)  ON Products.ProductID = Order_Details_Extended.ProductID)  ON Categories.CategoryID = Products.CategoryID WHERE BETWEEN(Orders.OrderDate, {^1997/01/01},{^1997/12/31}) GROUP BY Categories.CategoryID, Categories.CategoryName, Products.ProductName ORDER BY Products.ProductName";
            row["Tables"] = "Categories,Products";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_Totals_By_Amount";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Order_Subtotals.Subtotal AS SaleAmount, Orders.OrderID, Customers.CompanyName, Orders.ShippedDate FROM 	Customers INNER JOIN  (Orders INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID)  ON Customers.CustomerID = Orders.CustomerID WHERE (Order_Subtotals.Subtotal >2500) AND BETWEEN(Orders.ShippedDate, {^1997/01/01},{^1997/12/31})";
            row["Tables"] = "Orders,Customers";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Quarter";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT     YEAR(Orders.ShippedDate) as Year, INT(MONTH(Orders.ShippedDate)/4)+1 as Quarter,   SUM(Order_Subtotals.Subtotal) as Total FROM         Orders INNER JOIN  Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID  WHERE     NOT EMPTY(NVL(Orders.ShippedDate,\"\")) GROUP BY Year, Quarter  ORDER BY Year, Quarter";
            row["Tables"] = "";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Year";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT	 YEAR(Orders.ShippedDate) as Year, SUM(Order_Subtotals.Subtotal) as Total  FROM 	Orders INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID  WHERE     NOT EMPTY(NVL(Orders.ShippedDate,\"\")) GROUP BY Year  ORDER BY Year";
            row["Tables"] = "";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ViewName"] = "Ten_Most_Expensive_Products";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT TOP 10 Products.ProductName AS TenMostExpensiveProducts, Products.UnitPrice FROM Products ORDER BY Products.UnitPrice DESC";
            row["Tables"] = "Products";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("Views");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("AllowSimultaneousFetch", typeof(System.Boolean));
            dataTable.Columns.Add("BatchUpdateCount", typeof(System.Int32));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("CompareMemo", typeof(System.Boolean));
            dataTable.Columns.Add("ConnectName", typeof(System.String));
            dataTable.Columns.Add("FetchAsNeeded", typeof(System.Boolean));
            dataTable.Columns.Add("FetchMemo", typeof(System.Boolean));
            dataTable.Columns.Add("FetchSize", typeof(System.Int32));
            dataTable.Columns.Add("MaxRecords", typeof(System.Int32));
            dataTable.Columns.Add("Offline", typeof(System.Boolean));
            dataTable.Columns.Add("ParameterList", typeof(System.String));
            dataTable.Columns.Add("Prepared", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("SendUpdates", typeof(System.Boolean));
            dataTable.Columns.Add("ShareConnection", typeof(System.Boolean));
            dataTable.Columns.Add("SourceType", typeof(System.Int32));
            dataTable.Columns.Add("SQL", typeof(System.String));
            dataTable.Columns.Add("Tables", typeof(System.String));
            dataTable.Columns.Add("UpdateType", typeof(System.Int32));
            dataTable.Columns.Add("UseMemoSize", typeof(System.Int32));
            dataTable.Columns.Add("WhereType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["AllowSimultaneousFetch"] = false;
            row["BatchUpdateCount"] = 1;
            row["Comment"] = "";
            row["CompareMemo"] = true;
            row["ConnectName"] = "";
            row["FetchAsNeeded"] = false;
            row["FetchMemo"] = true;
            row["FetchSize"] = 100;
            row["MaxRecords"] = -1;
            row["Offline"] = false;
            row["ParameterList"] = "";
            row["Prepared"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["SendUpdates"] = false;
            row["ShareConnection"] = false;
            row["SourceType"] = 1;
            row["SQL"] = "SELECT Products.*, Categories.categoryname FROM  northwind!Categories  INNER JOIN northwind!Products  ON  Categories.categoryid = Products.categoryid WHERE  Products.discontinued = .F. ORDER BY Products.productname";
            row["Tables"] = "northwind!Products,northwind!Categories";
            row["UpdateType"] = 1;
            row["UseMemoSize"] = 255;
            row["WhereType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}