using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VfpClient.Tests.TestCases;
using Xunit.Sdk;
using static System.String;

namespace VfpClient.Tests.Attributes {
    public class ConnectionStringsAttribute : DataAttribute {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod) =>
            GetTestCases().Select(x => new object[] { x }).ToArray();

        private IEnumerable<ConnectionStringsTestCase> GetTestCases() {
            yield return GetNullTestCase();
            yield return GetEmptyTestCase();
            yield return GetFreeTableDirectoryTestCase();
            yield return GetDbcTestCase();
            yield return GetNonDefaultProviderTestCase();
        }

        private ConnectionStringsTestCase GetNonDefaultProviderTestCase() {
            var provider = VfpConnectionStringBuilder.DefaultProvider + ".1";
            var connectionString = $"Provider={provider}";

            return new ConnectionStringsTestCase(
                connectionString,
                connectionString,
                Empty,
                Empty,
                false,
                provider);
        }

        private ConnectionStringsTestCase GetDbcTestCase() {
            var file = "Northwind.dbc";

            return new ConnectionStringsTestCase(
                file,
                $"data source={file};Provider={VfpConnectionStringBuilder.DefaultProvider}",
                file,
                file,
                true,
                VfpConnectionStringBuilder.DefaultProvider);
        }

        private ConnectionStringsTestCase GetFreeTableDirectoryTestCase() {
            var freeTableDirectory = @"c:\";

            return new ConnectionStringsTestCase(
                freeTableDirectory,
                $"data source={freeTableDirectory};Provider={VfpConnectionStringBuilder.DefaultProvider}",
                freeTableDirectory,
                Empty,
                false,
                VfpConnectionStringBuilder.DefaultProvider);
        }

        private ConnectionStringsTestCase GetEmptyTestCase() =>
            new ConnectionStringsTestCase(Empty, Empty, Empty, Empty, false, Empty);

        private ConnectionStringsTestCase GetNullTestCase() =>
            new ConnectionStringsTestCase(null, Empty, Empty, Empty, false, Empty);
    }
}
