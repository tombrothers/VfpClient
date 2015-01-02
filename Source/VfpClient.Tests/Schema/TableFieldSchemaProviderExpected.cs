using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class TableFieldSchemaProviderExpected {
        public static DataTable GetSchemaWithTableNameAndFieldName() {
            DataTable dataTable = new DataTable("TableFields");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("Format", typeof(System.String));
            dataTable.Columns.Add("InputMask", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Category ID";
            row["Comment"] = "Number automatically assigned to a new category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithFieldName() {
            DataTable dataTable = new DataTable("TableFields");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("Format", typeof(System.String));
            dataTable.Columns.Add("InputMask", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Category ID";
            row["Comment"] = "Number automatically assigned to a new category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Category ID";
            row["Comment"] = "Categories table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("TableFields");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("Format", typeof(System.String));
            dataTable.Columns.Add("InputMask", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Category ID";
            row["Comment"] = "Number automatically assigned to a new category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Category Name";
            row["Comment"] = "Name of food category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Description";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Description";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Picture";
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Picture";
            row["Comment"] = "A picture representing the food category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("TableFields");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("Format", typeof(System.String));
            dataTable.Columns.Add("InputMask", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Category ID";
            row["Comment"] = "Number automatically assigned to a new category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Category Name";
            row["Comment"] = "Name of food category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Description";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Description";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Picture";
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Picture";
            row["Comment"] = "A picture representing the food category.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "CustomerCustomerDemo";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Customer ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "CustomerCustomerDemo";
            row["FieldName"] = "Customertypeid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Customer Type ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "CustomerDemographics";
            row["FieldName"] = "Customertypeid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Customer Type";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "CustomerDemographics";
            row["FieldName"] = "Customerdesc";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "Customer Description";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Customer ID";
            row["Comment"] = "Unique five-character code based on customer name.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "!A";
            row["InputMask"] = "XXXXX";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Company Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Contactname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Contact Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Contacttitle";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Contact Title";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Address";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "Address";
            row["Comment"] = "Street or post-office box.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "City";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Region";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "Region";
            row["Comment"] = "State or province.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Postalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "Postal Code";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "Country";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Phone";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "Phone";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Fax";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "Fax";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Employeeid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Employee ID";
            row["Comment"] = "Number automatically assigned to new employee.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Lastname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Last Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Firstname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "First Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Title";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Title";
            row["Comment"] = "Employee's title.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Titleofcourtesy";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 25;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "Title Of Courtesy";
            row["Comment"] = "Title used in salutations.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Birthdate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "Birth Date";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "D";
            row["RuleExpression"] = "birthdate<DATE()";
            row["RuleText"] = "\"Birth date can't be in the future.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Hiredate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "Hire Date";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Address";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "Address";
            row["Comment"] = "Street or post-office box.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "City";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Region";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "Region";
            row["Comment"] = "State or province.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Postalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "Postal Code";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 12;
            row["Nullable"] = true;
            row["Caption"] = "Country";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 31

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Homephone";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 13;
            row["Nullable"] = true;
            row["Caption"] = "Home Phone";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 32

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Extension";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 14;
            row["Nullable"] = true;
            row["Caption"] = "Extension";
            row["Comment"] = "Internal telephone extension number.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 33

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Photo";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 15;
            row["Nullable"] = true;
            row["Caption"] = "Photo";
            row["Comment"] = "Picture of employee.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 34

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Notes";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 16;
            row["Nullable"] = true;
            row["Caption"] = "Notes";
            row["Comment"] = "General information about employee's background.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 35

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Reportsto";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 17;
            row["Nullable"] = true;
            row["Caption"] = "Reports To";
            row["Comment"] = "Employee's supervisor.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 36

            row = dataTable.NewRow();
            row["TableName"] = "EmployeeTerritories";
            row["FieldName"] = "Employeeid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Employee ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 37

            row = dataTable.NewRow();
            row["TableName"] = "EmployeeTerritories";
            row["FieldName"] = "Territoryid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Territory ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 38

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Order ID";
            row["Comment"] = "Orders table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 39

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Product ID";
            row["Comment"] = "Products table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 40

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = 8;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "Unit Price";
            row["Comment"] = "";
            row["DefaultValue"] = "0";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "$";
            row["InputMask"] = "";
            row["RuleExpression"] = "unitprice=>0";
            row["RuleText"] = "\"You must enter a positive number.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 41

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Quantity";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = "Quantity";
            row["Comment"] = "";
            row["DefaultValue"] = "1";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "quantity>0";
            row["RuleText"] = "\"Quantity must be greater than 0.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 42

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Discount";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 19;
            row["Decimal"] = 5;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = "Discount";
            row["Comment"] = "";
            row["DefaultValue"] = "0";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "discount=>0.AND.discount<1";
            row["RuleText"] = "\"You must enter a value  between 0 and 1.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 43

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Order ID";
            row["Comment"] = "Unique order number.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 44

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "Customer";
            row["Comment"] = "Customer table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "!A";
            row["InputMask"] = "XXXXX";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 45

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Employeeid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Employee";
            row["Comment"] = "Employee table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 46

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Orderdate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Order Date";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "D";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 47

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Requireddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "Required Date";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "D";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 48

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shippeddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "Shipped Date";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "D";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 49

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipvia";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "Ship Via";
            row["Comment"] = "Shippers table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 50

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Freight";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = 8;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "Freight";
            row["Comment"] = "";
            row["DefaultValue"] = "0";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "$";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 51

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "Ship Name";
            row["Comment"] = "Name of person or company to receive the shipment.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 52

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipaddress";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "Ship Address";
            row["Comment"] = "Street address only -- no post-office box allowed.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 53

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipcity";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "Ship City";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 54

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipregion";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 12;
            row["Nullable"] = true;
            row["Caption"] = "Ship Region";
            row["Comment"] = "State or province.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 55

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shippostalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 13;
            row["Nullable"] = true;
            row["Caption"] = "Ship Postal Code";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 56

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Shipcountry";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 14;
            row["Nullable"] = true;
            row["Caption"] = "Ship Country";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 57

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Product ID";
            row["Comment"] = "Number automatically assigned to new product.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 58

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Product Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 59

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Supplierid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Supplier ID";
            row["Comment"] = "Suppliers table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 60

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Category ID";
            row["Comment"] = "Categories table foreign key.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 61

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Quantityperunit";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "Quantity Per Unit";
            row["Comment"] = "(e.g., 24-count case, 1-liter bottle).";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 62

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = 8;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "Unit Price";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "$";
            row["InputMask"] = "";
            row["RuleExpression"] = "unitprice=>0";
            row["RuleText"] = "\"You must enter a positive number.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 63

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Unitsinstock";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "Units in Stock";
            row["Comment"] = "";
            row["DefaultValue"] = "0";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "unitsinstock=>0";
            row["RuleText"] = "\"You must enter a positive number.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 64

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Unitsonorder";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "Units On Order";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "unitsonorder=>0";
            row["RuleText"] = "\"You must enter a positive number.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 65

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Reorderlevel";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "Reorder Level";
            row["Comment"] = "Minimum units to maintain in stock.";
            row["DefaultValue"] = "0";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "reorderlevel=>0";
            row["RuleText"] = "\"You must enter a positive number.\"";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 66

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Discontinued";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = "Discontinued";
            row["Comment"] = "Yes (.T.) means item is no longer available.";
            row["DefaultValue"] = ".F.";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 67

            row = dataTable.NewRow();
            row["TableName"] = "Region";
            row["FieldName"] = "Regionid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Region ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 68

            row = dataTable.NewRow();
            row["TableName"] = "Region";
            row["FieldName"] = "Regiondescription";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 50;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Region Description";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 69

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["FieldName"] = "Shipperid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Shipper ID";
            row["Comment"] = "Number automatically assigned to new shipper.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 70

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Company Name";
            row["Comment"] = "Name of shipping company.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 71

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["FieldName"] = "Phone";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Phone";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 72

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Supplierid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Supplier ID";
            row["Comment"] = "Number automatically assigned to new supplier.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 73

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Company Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 74

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Contactname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "Contact Name";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 75

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Contacttitle";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "Contact Title";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 76

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Address";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "Address";
            row["Comment"] = "Street or post-office box.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 77

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "City";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 78

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Region";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "Region";
            row["Comment"] = "State or province.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 79

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Postalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "Postal Code";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 80

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "Country";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 81

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Phone";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "Phone";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 82

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Fax";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 24;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "Fax";
            row["Comment"] = "Phone number includes country code or area code.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 83

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Homepage";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 12;
            row["Nullable"] = true;
            row["Caption"] = "Home Page";
            row["Comment"] = "Supplier's home page on World Wide Web.";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 84

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["FieldName"] = "Territoryid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "Territory ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 85

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["FieldName"] = "Territorydescription";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 50;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "Territory Description";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 86

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["FieldName"] = "Regionid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "Region ID";
            row["Comment"] = "";
            row["DefaultValue"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["Format"] = "";
            row["InputMask"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
