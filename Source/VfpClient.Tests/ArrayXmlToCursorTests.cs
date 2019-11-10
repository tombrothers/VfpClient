using System;
using System.Data;
using System.Linq;
using VfpClient.Tests.Attributes;
using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests {
    public class ArrayXmlToCursorTests : IClassFixture<ArrayXmlToCursorFixture> {
        private readonly ArrayXmlToCursorFixture fixture;

        public ArrayXmlToCursorTests(ArrayXmlToCursorFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void BooleanArrayTest() {
            var array = new[] { true, false };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<bool>("Id")).ToArray();

            Assert.Equal(array, ids);
        }

        [Fact]
        public void ByteArrayTest() {
            var array = new[] { byte.MinValue, byte.MaxValue };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            Assert.Equal(array.Select(x => (int)x).ToArray(), ids);
        }

        [Fact]
        public void CharArrayTest() {
            var array = new[] { 'a', 'b' };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            Assert.Equal(array.Select(x => x.ToString()).ToArray(), ids);
        }

        [Fact]
        public void DateTimeArrayTest() {
            var array = Enumerable.Range(1, 10).Select(x => DateTime.Now.AddDays(x)).ToArray();
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<DateTime>("Id")).ToArray();

            var dateTimes1 = array.Select(x => x.ToString()).ToArray();
            var dateTimes2 = ids.Select(x => x.ToString()).ToArray();

            Assert.Equal(dateTimes1, dateTimes2);
        }

        [Fact]
        public void DecimalArrayTest() {
            var array = new[] { -1m, 0m, 1m, 1.5m };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array, ids);
        }

        [Fact]
        public void DoubleArrayTest() {
            var array = new double[] { -1, 1, 1.456 };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [Fact]
        public void GuidArrayTest() {
            var array = new[] { Guid.Empty, Guid.NewGuid() };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            Assert.Equal(array.Select(x => x.ToString()).ToArray(), ids);
        }

        [Fact]
        public void Int16ArrayTest() {
            var array = new Int16[] { -1, Int16.MaxValue };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            Assert.Equal(array.Select(x => (int)x).ToArray(), ids);
        }

        [Fact]
        public void Int32ArrayTest() {
            var array = new[] { -1, int.MaxValue };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            Assert.Equal(array, ids);
        }

        [Fact]
        public void Int64ArrayTest() {
            var array = new long[] { -1, 0, 1 };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [Fact]
        public void MemoArrayTest() {
            var array = new[] { "", "Test", "Test2", new string('x', VfpMapping.MaximumCharacterFieldSize + 1) };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            Assert.Equal(array, ids);
        }

        [Fact]
        public void SByteArrayTest() {
            var array = new SByte[] { 0, sbyte.MaxValue };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            Assert.Equal(array.Select(x => (int)x).ToArray(), ids);
        }

        [Fact]
        public void SingleArrayTest() {
            var array = new[] { -1f, 0f, 1f, 1.5f };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [Fact]
        public void StringArrayTest() {
            var array = new[] { "", "Test", "Test2", new string('x', VfpMapping.MaximumCharacterFieldSize), null };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<string>("Id")).ToArray();

            array = array.Take(4).ToArray();
            ids = ids.Take(4).ToArray();

            Assert.Equal(array, ids);
        }

        [Fact]
        public void UInt16ArrayTest() {
            var array = new UInt16[] { 0, 1 };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<int>("Id")).ToArray();

            Assert.Equal(array.Select(x => (int)x).ToArray(), ids);
        }

        [Fact]
        public void UInt32ArrayTest() {
            var array = new UInt32[] { 0, 1 };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array.Select(x => (decimal)x).ToArray(), ids);
        }

        [Fact]
        public void UInt64ArrayTest() {
            var array = new UInt64[] { 0, 1 };
            var table = this.fixture.Execute(array);
            var ids = table.AsEnumerable().Select(x => x.Field<decimal>("Id")).ToArray();

            Assert.Equal(array.Select(x => (decimal)x).ToArray(), ids);
        }
    }
}