using AutoFixture.Xunit2;
using System.Data;
using VfpClient.Tests.Attributes;
using VfpClient.Tests.TestCases;
using Xunit;
using static System.String;

namespace VfpClient.Tests {
    public class VfpParameterTests {
        [Fact]
        public void DbType_ShouldDefaultToString() {
            var parameter = new VfpParameter();

            Assert.Equal(System.Data.DbType.String, parameter.DbType);
        }

        [Theory]
        [DbTypeToVfpTypeData]
        public void DbTypeShouldSetVfpType(VfpTypeAndDbTypeTestCase testCase) {
            var parameter = new VfpParameter {
                DbType = testCase.DbType
            };

            Assert.Equal(testCase.VfpType, parameter.VfpType);
        }

        [Fact]
        public void VfpType_ShouldDefaultToVarchar() {
            var parameter = new VfpParameter();

            Assert.Equal(VfpClient.VfpType.Varchar, parameter.VfpType);
        }

        [Theory]
        [VfpTypeToDbTypeData]
        public void VfpType_ShouldSetDbType(VfpTypeAndDbTypeTestCase testCase) {
            var parameter = new VfpParameter {
                VfpType = testCase.VfpType
            };

            Assert.Equal(testCase.DbType, parameter.DbType);
        }

        [Fact]
        public void Direction_ShouldDefaultToInput() {
            var parameter = new VfpParameter();

            Assert.Equal(ParameterDirection.Input, parameter.Direction);
        }

        [Theory]
        [EnumData(typeof(ParameterDirection))]
        public void Direction_ShouldSetDirection(ParameterDirection direction) {
            var parameter = new VfpParameter {
                Direction = direction
            };

            Assert.Equal(direction, parameter.Direction);
        }

        [Fact]
        public void IsNullable_ShouldDefaultToFalse() {
            var parameter = new VfpParameter();

            Assert.False(parameter.IsNullable);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void IsNullable_ShouldSetIsNullable(bool isNullable) {
            var parameter = new VfpParameter {
                IsNullable = isNullable
            };

            Assert.Equal(isNullable, parameter.IsNullable);
        }

        [Fact]
        public void ParameterName_ShouldDefaultToEmptyString() {
            var parameter = new VfpParameter();

            Assert.Equal(Empty, parameter.ParameterName);

        }

        [Theory]
        [AutoData]
        public void ParameterName_ShouldSetParameterName(string parameterName) {
            var parameter = new VfpParameter {
                ParameterName = parameterName
            };

            Assert.Equal(parameterName, parameter.ParameterName);
        }

        [Fact]
        public void Size_ShouldDefaultToZero() {
            var parameter = new VfpParameter();

            Assert.Equal(0, parameter.Size);

        }

        [Theory]
        [AutoData]
        public void Size_ShouldSetSize(int size) {
            var parameter = new VfpParameter {
                Size = size
            };

            Assert.Equal(size, parameter.Size);
        }

        [Fact]
        public void SourceColumn_ShouldDefaultToEmptyString() {
            var parameter = new VfpParameter();

            Assert.Equal(Empty, parameter.SourceColumn);

        }

        [Theory]
        [AutoData]
        public void SourceColumn_ShouldSetSourceColumn(string sourceColumn) {
            var parameter = new VfpParameter {
                SourceColumn = sourceColumn
            };

            Assert.Equal(sourceColumn, parameter.SourceColumn);
        }

        [Fact]
        public void SourceColumnNullMapping_ShouldDefaultToFalse() {
            var parameter = new VfpParameter();

            Assert.False(parameter.SourceColumnNullMapping);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SourceColumnNullMapping_ShouldSetSourceColumnNullMapping(bool sourceColumnNullMapping) {
            var parameter = new VfpParameter {
                SourceColumnNullMapping = sourceColumnNullMapping
            };

            Assert.Equal(sourceColumnNullMapping, parameter.SourceColumnNullMapping);
        }

        [Fact]
        public void SourceVersion_ShouldDefaultToCurrent() {
            var parameter = new VfpParameter();

            Assert.Equal(DataRowVersion.Current, parameter.SourceVersion);
        }

        [Theory]
        [EnumData(typeof(DataRowVersion))]
        public void SourceVersion_ShouldSetSourceVersion(DataRowVersion dataRowVersion) {
            var parameter = new VfpParameter {
                SourceVersion = dataRowVersion
            };

            Assert.Equal(dataRowVersion, parameter.SourceVersion);
        }

        [Fact]
        public void Value_ShouldDefaultToNull() {
            var parameter = new VfpParameter();

            Assert.Null(parameter.Value);
        }

        [Theory]
        [InlineData("100", VfpClient.VfpType.Varchar)]
        [InlineData(1000, VfpClient.VfpType.Integer)]
        [InlineData(false, VfpClient.VfpType.Logical)]
        [InlineData(2462.2325, VfpClient.VfpType.Double)]
        [InlineData(32.41f, VfpClient.VfpType.Float)]
        public void Value_ShouldSetValueAndVfpType(object value, VfpClient.VfpType vfpType) {
            var parameter = new VfpParameter {
                Value = value
            };

            Assert.Equal(value, parameter.Value);
            Assert.Equal(vfpType, parameter.VfpType);
        }
    }
}
