using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class FreeTableSchemaTests : IClassFixture<FreeTablesDataFixture> {
        private readonly FreeTablesDataFixture fixture;

        public FreeTableSchemaTests(FreeTablesDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void FreeTableSchemaTests_GetDataTypesSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.DataTypes);
                var expected = FreeTableSchemaExpected.GetDataTypesSchema();

                //DataTableHelper.WriteDataTableCode("DataTypesSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetCandidateKeySchemaWithTableNameAndNoTablesWithMultipleCandidateKeysTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys, new[] { "sample_c1", "true" });
                var expected = FreeTableSchemaExpected.GetCandidateKeySchemaWithTableNameAndNoTablesWithMultipleCandidateKeys();

                //DataTableHelper.WriteDataTableCode("CandidateKeySchemaWithTableNameAndNoTablesWithMultipleCandidateKeys", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetCandidateKeySchemaWithTableNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys, new[] { "sample_c1" });
                var expected = FreeTableSchemaExpected.GetCandidateKeySchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("CandidateKeySchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetCandidateKeySchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys);
                var expected = FreeTableSchemaExpected.GetCandidateKeySchema();

                //DataTableHelper.WriteDataTableCode("CandidateKeySchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetForeignKeySchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys);
                var expected = FreeTableSchemaExpected.GetForeignKeySchema();

                //DataTableHelper.WriteDataTableCode("ForeignKeySchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetPrimaryKeySchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.PrimaryKeys);
                var expected = FreeTableSchemaExpected.GetPrimaryKeySchema();

                //DataTableHelper.WriteDataTableCode("PrimaryKeySchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetIndexSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes);
                var expected = FreeTableSchemaExpected.GetIndexSchema();

                //DataTableHelper.WriteDataTableCode("IndexSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetProcedureParameterSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters);
                var expected = FreeTableSchemaExpected.GetProcedureParameterSchema();

                //DataTableHelper.WriteDataTableCode("ProcedureParameterSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetProcedureSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures);
                var expected = FreeTableSchemaExpected.GetProcedureSchema();

                //DataTableHelper.WriteDataTableCode("ProcedureSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetTableFieldSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields);
                var expected = FreeTableSchemaExpected.GetTableFieldSchema();

                //DataTableHelper.WriteDataTableCode("TableFieldSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetTableSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Tables);
                var expected = FreeTableSchemaExpected.GetTableSchema();

                //DataTableHelper.WriteDataTableCode("TableSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetViewFieldSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ViewFields);
                var expected = FreeTableSchemaExpected.GetViewFieldSchema();

                //DataTableHelper.WriteDataTableCode("ViewFieldSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void FreeTableSchemaTests_GetViewSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Views);
                var expected = FreeTableSchemaExpected.GetViewSchema();

                //DataTableHelper.WriteDataTableCode("ViewSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}