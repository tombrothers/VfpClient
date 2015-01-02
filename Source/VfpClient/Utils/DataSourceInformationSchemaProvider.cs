using System;
using System.Data;
using System.Data.Common;
using DataSourceInformation = VfpClient.VfpConnection.SchemaColumnNames.DataSourceInformation;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class DataSourceInformationSchemaProvider : SchemaProviderBase {
            public DataSourceInformationSchemaProvider()
                : base(VfpConnection.SchemaNames.DataSourceInformation) {
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var dataTable = new DataTable(Name);

                #region columns

                dataTable.Columns.Add(DataSourceInformation.CompositeIdentifierSeparatorPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.DataSourceProductName, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.DataSourceProductVersion, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.DataSourceProductVersionNormalized, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.GroupByBehavior, typeof(GroupByBehavior));
                dataTable.Columns.Add(DataSourceInformation.IdentifierPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.IdentifierCase, typeof(IdentifierCase));
                dataTable.Columns.Add(DataSourceInformation.OrderByColumnsInSelect, typeof(bool));
                dataTable.Columns.Add(DataSourceInformation.ParameterMarkerFormat, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.ParameterMarkerPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.ParameterNameMaxLength, typeof(int));
                dataTable.Columns.Add(DataSourceInformation.ParameterNamePattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.QuotedIdentifierPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.QuotedIdentifierCase, typeof(IdentifierCase));
                dataTable.Columns.Add(DataSourceInformation.StatementSeparatorPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.StringLiteralPattern, typeof(string));
                dataTable.Columns.Add(DataSourceInformation.SupportedJoinOperators, typeof(SupportedJoinOperators));

                #endregion columns

                #region rows

                DataRow row;

                #region row 0

                row = dataTable.NewRow();
                row[DataSourceInformation.CompositeIdentifierSeparatorPattern] = "!";
                row[DataSourceInformation.DataSourceProductName] = "Microsoft Visual FoxPro";
                row[DataSourceInformation.DataSourceProductVersion] = "09.00.0000.5815";
                row[DataSourceInformation.DataSourceProductVersionNormalized] = "09.00.0000.5815";
                row[DataSourceInformation.GroupByBehavior] = 3;
                row[DataSourceInformation.IdentifierPattern] = "[^0123456789 !\"#\\$%&'\\(\\)\\*\\+,-\\./:;<=>\\?@\\[\\\\\\]\\^`\\{\\|}~][^ !\"#\\$%&'\\(\\)\\*\\+,-\\./:;<=>\\?@\\[\\\\\\]\\^`\\{\\|}~]*";
                row[DataSourceInformation.IdentifierCase] = 1;
                row[DataSourceInformation.OrderByColumnsInSelect] = false;
                row[DataSourceInformation.ParameterMarkerFormat] = "{0}";
                row[DataSourceInformation.ParameterMarkerPattern] = @"@[\p{Lo}\p{Lu}\p{Ll}\p{Lm}_@#][\p{Lo}\p{Lu}\p{Ll}\p{Lm}\p{Nd}\uff3f_@#\$]*(?=\s+|$)";
                row[DataSourceInformation.ParameterNameMaxLength] = 128;
                row[DataSourceInformation.ParameterNamePattern] = @"^[\p{Lo}\p{Lu}\p{Ll}\p{Lm}_@#][\p{Lo}\p{Lu}\p{Ll}\p{Lm}\p{Nd}\uff3f_@#\$]*(?=\s+|$)";
                row[DataSourceInformation.QuotedIdentifierPattern] = "`(([^`]|``)*)`";
                row[DataSourceInformation.QuotedIdentifierCase] = 1;
                row[DataSourceInformation.StatementSeparatorPattern] = DBNull.Value;
                row[DataSourceInformation.StringLiteralPattern] = DBNull.Value;
                row[DataSourceInformation.SupportedJoinOperators] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #endregion rows

                return dataTable;
            }
        }
    }
}