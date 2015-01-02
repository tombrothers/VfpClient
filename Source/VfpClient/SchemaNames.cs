using System.Data.Common;
using System.Data.OleDb;

namespace VfpClient {
    public partial class VfpConnection {
        public static class SchemaNames {
            public static readonly string MetaDataCollections = DbMetaDataCollectionNames.MetaDataCollections;
            public static readonly string DataSourceInformation = DbMetaDataCollectionNames.DataSourceInformation;
            public static readonly string DataTypes = DbMetaDataCollectionNames.DataTypes;
            public static readonly string Restrictions = DbMetaDataCollectionNames.Restrictions;
            public static readonly string ReservedWords = DbMetaDataCollectionNames.ReservedWords;

            public static readonly string Tables = OleDbMetaDataCollectionNames.Tables;
            public static readonly string TableFields = "TableFields";
            public static readonly string Views = OleDbMetaDataCollectionNames.Views;
            public static readonly string ViewFields = "ViewFields";

            public static readonly string ProcedureParameters = OleDbMetaDataCollectionNames.ProcedureParameters;
            public static readonly string Procedures = OleDbMetaDataCollectionNames.Procedures;
            public static readonly string ForeignKeys = "ForeignKeys";
            public static readonly string Indexes = OleDbMetaDataCollectionNames.Indexes;
            public static readonly string PrimaryKeys = "PrimaryKeys";
            public static readonly string ProcedureColumns = "ProcedureColumns";
            public static readonly string CandidateKeys = "CandidateKeys";
        }
    }
}