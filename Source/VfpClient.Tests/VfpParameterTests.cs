using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpParameterTests : TestBase {
        [TestMethod]
        public void DbTypeTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.DbType = DbType.AnsiString;
            Assert.AreEqual(DbType.AnsiString, parameter.DbType);
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);

            parameter.DbType = DbType.AnsiStringFixedLength;
            Assert.AreEqual(DbType.AnsiStringFixedLength, parameter.DbType);
            Assert.AreEqual(VfpType.Character, parameter.VfpType);

            parameter.DbType = DbType.Binary;
            Assert.AreEqual(DbType.Binary, parameter.DbType);
            Assert.AreEqual(VfpType.Varbinary, parameter.VfpType);

            parameter.DbType = DbType.Boolean;
            Assert.AreEqual(DbType.Boolean, parameter.DbType);
            Assert.AreEqual(VfpType.Logical, parameter.VfpType);

            parameter.DbType = DbType.Byte;
            Assert.AreEqual(DbType.Byte, parameter.DbType);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);

            parameter.DbType = DbType.Currency;
            Assert.AreEqual(DbType.Currency, parameter.DbType);
            Assert.AreEqual(VfpType.Currency, parameter.VfpType);

            parameter.DbType = DbType.Date;
            Assert.AreEqual(DbType.Date, parameter.DbType);
            Assert.AreEqual(VfpType.Date, parameter.VfpType);

            parameter.DbType = DbType.DateTime;
            Assert.AreEqual(DbType.DateTime, parameter.DbType);
            Assert.AreEqual(VfpType.DateTime, parameter.VfpType);

            parameter.DbType = DbType.Decimal;
            Assert.AreEqual(DbType.Decimal, parameter.DbType);
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);

            parameter.DbType = DbType.Double;
            Assert.AreEqual(DbType.Double, parameter.DbType);
            Assert.AreEqual(VfpType.Double, parameter.VfpType);

            parameter.DbType = DbType.Guid;
            Assert.AreEqual(DbType.Guid, parameter.DbType);
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);

            parameter.DbType = DbType.Int16;
            Assert.AreEqual(DbType.Int16, parameter.DbType);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);

            parameter.DbType = DbType.Int32;
            Assert.AreEqual(DbType.Int32, parameter.DbType);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);

            parameter.DbType = DbType.Int64;
            Assert.AreEqual(DbType.Int64, parameter.DbType);
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);

            parameter.DbType = DbType.Object;
            Assert.AreEqual(DbType.Object, parameter.DbType);
            Assert.AreEqual(VfpType.Variant, parameter.VfpType);

            parameter.DbType = DbType.SByte;
            Assert.AreEqual(DbType.SByte, parameter.DbType);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);

            parameter.DbType = DbType.Single;
            Assert.AreEqual(DbType.Single, parameter.DbType);
            Assert.AreEqual(VfpType.Float, parameter.VfpType);

            parameter.DbType = DbType.String;
            Assert.AreEqual(DbType.String, parameter.DbType);
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);

            parameter.DbType = DbType.StringFixedLength;
            Assert.AreEqual(DbType.StringFixedLength, parameter.DbType);
            Assert.AreEqual(VfpType.Character, parameter.VfpType);

            parameter.DbType = DbType.Time;
            Assert.AreEqual(DbType.Time, parameter.DbType);
            Assert.AreEqual(VfpType.Date, parameter.VfpType);

            parameter.DbType = DbType.UInt16;
            Assert.AreEqual(DbType.UInt16, parameter.DbType);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);

            parameter.DbType = DbType.UInt32;
            Assert.AreEqual(DbType.UInt32, parameter.DbType);
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);

            parameter.DbType = DbType.UInt64;
            Assert.AreEqual(DbType.UInt64, parameter.DbType);
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);

            parameter.DbType = DbType.VarNumeric;
            Assert.AreEqual(DbType.VarNumeric, parameter.DbType);
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);

            parameter.DbType = DbType.Xml;
            Assert.AreEqual(DbType.String, parameter.DbType);
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);
        }

        public void VfpTypeTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);

            parameter.VfpType = VfpType.AutoIncInteger;
            Assert.AreEqual(VfpType.AutoIncInteger, parameter.VfpType);
            Assert.AreEqual(DbType.Int32, parameter.DbType);

            parameter.VfpType = VfpType.BinaryMemo;
            Assert.AreEqual(VfpType.BinaryMemo, parameter.VfpType);
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.VfpType = VfpType.BinaryVarchar;
            Assert.AreEqual(VfpType.BinaryVarchar, parameter.VfpType);
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.VfpType = VfpType.Blob;
            Assert.AreEqual(VfpType.Blob, parameter.VfpType);
            Assert.AreEqual(DbType.Binary, parameter.DbType);

            parameter.VfpType = VfpType.Character;
            Assert.AreEqual(VfpType.Character, parameter.VfpType);
            Assert.AreEqual(DbType.StringFixedLength, parameter.DbType);

            parameter.VfpType = VfpType.Currency;
            Assert.AreEqual(VfpType.Currency, parameter.VfpType);
            Assert.AreEqual(DbType.Currency, parameter.DbType);

            parameter.VfpType = VfpType.Date;
            Assert.AreEqual(VfpType.Date, parameter.VfpType);
            Assert.AreEqual(DbType.Date, parameter.DbType);

            parameter.VfpType = VfpType.DateTime;
            Assert.AreEqual(VfpType.DateTime, parameter.VfpType);
            Assert.AreEqual(DbType.DateTime, parameter.DbType);

            parameter.VfpType = VfpType.Double;
            Assert.AreEqual(VfpType.Double, parameter.VfpType);
            Assert.AreEqual(DbType.Double, parameter.DbType);

            parameter.VfpType = VfpType.Float;
            Assert.AreEqual(VfpType.Float, parameter.VfpType);
            Assert.AreEqual(DbType.Decimal, parameter.DbType);

            parameter.VfpType = VfpType.General;
            Assert.AreEqual(VfpType.General, parameter.VfpType);
            Assert.AreEqual(DbType.Object, parameter.DbType);

            parameter.VfpType = VfpType.Integer;
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);
            Assert.AreEqual(DbType.Int32, parameter.DbType);

            parameter.VfpType = VfpType.Logical;
            Assert.AreEqual(VfpType.Logical, parameter.VfpType);
            Assert.AreEqual(DbType.Boolean, parameter.DbType);

            parameter.VfpType = VfpType.Memo;
            Assert.AreEqual(VfpType.Memo, parameter.VfpType);
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.VfpType = VfpType.Numeric;
            Assert.AreEqual(VfpType.Numeric, parameter.VfpType);
            Assert.AreEqual(DbType.Decimal, parameter.DbType);

            parameter.VfpType = VfpType.Varbinary;
            Assert.AreEqual(VfpType.Varbinary, parameter.VfpType);
            Assert.AreEqual(DbType.Binary, parameter.DbType);

            parameter.VfpType = VfpType.Varchar;
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.VfpType = VfpType.Variant;
            Assert.AreEqual(VfpType.Variant, parameter.VfpType);
            Assert.AreEqual(DbType.Object, parameter.DbType);
        }

        [TestMethod]
        public void DirectionTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(ParameterDirection.Input, parameter.Direction);

            parameter.Direction = ParameterDirection.InputOutput;
            Assert.AreEqual(ParameterDirection.InputOutput, parameter.Direction);

            parameter.Direction = ParameterDirection.Output;
            Assert.AreEqual(ParameterDirection.Output, parameter.Direction);

            parameter.Direction = ParameterDirection.ReturnValue;
            Assert.AreEqual(ParameterDirection.ReturnValue, parameter.Direction);

            parameter.Direction = ParameterDirection.Input;
            Assert.AreEqual(ParameterDirection.Input, parameter.Direction);
        }

        [TestMethod]
        public void IsNullableTest() {
            var parameter = new VfpParameter();
            Assert.IsFalse(parameter.IsNullable);

            parameter.IsNullable = true;
            Assert.IsTrue(parameter.IsNullable);

            parameter.IsNullable = false;
            Assert.IsFalse(parameter.IsNullable);
        }

        [TestMethod]
        public void ParameterNameTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(string.Empty, parameter.ParameterName);

            parameter.ParameterName = "Input";
            Assert.AreEqual("Input", parameter.ParameterName);
            Assert.AreNotEqual("INPUT", parameter.ParameterName);

            parameter = new VfpParameter("Output", VfpType.Double);
            Assert.AreEqual("Output", parameter.ParameterName);
            Assert.AreNotEqual("output", parameter.ParameterName);
        }

        [TestMethod]
        public void SizeTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(0, parameter.Size);

            parameter.Size = 8;
            Assert.AreEqual(8, parameter.Size);
        }

        [TestMethod]
        public void SourceColumnTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(string.Empty, parameter.SourceColumn);

            parameter.SourceColumn = "Name";
            Assert.AreEqual("Name", parameter.SourceColumn);
            Assert.AreNotEqual("NAME", parameter.SourceColumn);
        }

        [TestMethod]
        public void SourceColumnNullMappingTest() {
            var parameter = new VfpParameter();
            Assert.IsFalse(parameter.SourceColumnNullMapping);

            parameter.SourceColumnNullMapping = true;
            Assert.IsTrue(parameter.SourceColumnNullMapping);

            parameter.SourceColumnNullMapping = false;
            Assert.IsFalse(parameter.SourceColumnNullMapping);
        }

        [TestMethod]
        public void SourceVersionTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(DataRowVersion.Current, parameter.SourceVersion);

            parameter.SourceVersion = DataRowVersion.Default;
            Assert.AreEqual(DataRowVersion.Default, parameter.SourceVersion);

            parameter.SourceVersion = DataRowVersion.Original;
            Assert.AreEqual(DataRowVersion.Original, parameter.SourceVersion);

            parameter.SourceVersion = DataRowVersion.Proposed;
            Assert.AreEqual(DataRowVersion.Proposed, parameter.SourceVersion);

            parameter.SourceVersion = DataRowVersion.Current;
            Assert.AreEqual(DataRowVersion.Current, parameter.SourceVersion);
        }

        [TestMethod]
        public void ValueTest() {
            var parameter = new VfpParameter();
            Assert.AreEqual(null, parameter.Value);

            parameter.Value = "100";
            Assert.AreEqual("100", parameter.Value);
            Assert.AreNotEqual(100, parameter.Value);
            Assert.AreNotEqual(Int32.Parse("100"), parameter.Value);
            Assert.AreEqual(VfpType.Varchar, parameter.VfpType);
            Assert.AreEqual(DbType.String, parameter.DbType);

            parameter.Value = 1000;
            Assert.AreEqual(1000, parameter.Value);
            Assert.AreEqual(Int32.Parse("1000"), parameter.Value);
            Assert.AreNotEqual("1000", parameter.Value);
            Assert.AreEqual(VfpType.Integer, parameter.VfpType);
            Assert.AreEqual(DbType.Int32, parameter.DbType);

            parameter.Value = false;
            Assert.AreEqual(false, parameter.Value);
            Assert.AreNotEqual("false", parameter.Value);
            Assert.AreNotEqual(0, parameter.Value);
            Assert.AreEqual(VfpType.Logical, parameter.VfpType);
            Assert.AreEqual(DbType.Boolean, parameter.DbType);

            parameter.Value = 2462.2325;
            Assert.AreEqual(2462.2325, parameter.Value);
            Assert.AreNotEqual(2462.23, parameter.Value);
            Assert.AreNotEqual(2462, parameter.Value);
            Assert.AreEqual(VfpType.Double, parameter.VfpType);
            Assert.AreEqual(DbType.Double, parameter.DbType);

            parameter.Value = 32.41f;
            Assert.AreEqual(32.41f, parameter.Value);
            Assert.AreNotEqual(32.41, parameter.Value);
            Assert.AreEqual(VfpType.Float, parameter.VfpType);
            Assert.AreEqual(DbType.Single, parameter.DbType);
        }
    }
}