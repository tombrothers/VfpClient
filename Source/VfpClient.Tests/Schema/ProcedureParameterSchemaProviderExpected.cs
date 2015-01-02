using System.Data;

namespace VfpClient.Tests.Schema {
    class ProcedureParameterSchemaProviderExpected {
        public static DataTable GetSchemaWithProcedureNameReferentialIntegrity() {
            DataTable dataTable = new DataTable("ProcedureParameters");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ParameterName", typeof(System.String));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcFieldName";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcNewValue";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 2;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcCascadeParent";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 3;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithReferentialIntegrity() {
            DataTable dataTable = new DataTable("ProcedureParameters");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ParameterName", typeof(System.String));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcFieldName";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcNewValue";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 2;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ParameterName"] = "tcCascadeParent";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 3;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rierror";
            row["ParameterName"] = "tnErrNo";
            row["VfpTypeName"] = "Numeric";
            row["VfpType"] = 7;
            row["Ordinal"] = 1;
            row["DataType"] = 7;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rierror";
            row["ParameterName"] = "tcMessage";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 2;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rierror";
            row["ParameterName"] = "tcCode";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 3;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rierror";
            row["ParameterName"] = "tcProgram";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 4;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riopen";
            row["ParameterName"] = "tcTable";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riopen";
            row["ParameterName"] = "tcOrder";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 2;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riend";
            row["ParameterName"] = "tlSuccess";
            row["VfpTypeName"] = "Logical";
            row["VfpType"] = 6;
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rireuse";
            row["ParameterName"] = "tcTableName";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rireuse";
            row["ParameterName"] = "tcWkArea";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 2;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ParameterName"] = "tcCustomerID";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["ParameterName"] = "tiOrderID";
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Ordinal"] = 1;
            row["DataType"] = 11;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["ParameterName"] = "tcCustomerID";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ParameterName"] = "tdBeginning_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 1;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ParameterName"] = "tdEnding_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 2;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ParameterName"] = "tdBeginning_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 1;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ParameterName"] = "tdEnding_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 2;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithProcedureName() {
            DataTable dataTable = new DataTable("ProcedureParameters");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ParameterName", typeof(System.String));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ParameterName"] = "tcCustomerID";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("ProcedureParameters");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ParameterName", typeof(System.String));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ParameterName"] = "tcCustomerID";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["ParameterName"] = "tiOrderID";
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Ordinal"] = 1;
            row["DataType"] = 11;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["ParameterName"] = "tcCustomerID";
            row["VfpTypeName"] = "Varchar";
            row["VfpType"] = 17;
            row["Ordinal"] = 1;
            row["DataType"] = 16;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ParameterName"] = "tdBeginning_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 1;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ParameterName"] = "tdEnding_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 2;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ParameterName"] = "tdBeginning_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 1;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ParameterName"] = "tdEnding_Date";
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Ordinal"] = 2;
            row["DataType"] = 5;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}