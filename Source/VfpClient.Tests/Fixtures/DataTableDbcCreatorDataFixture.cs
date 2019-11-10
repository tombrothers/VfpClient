using System.IO;

namespace VfpClient.Tests.Fixtures {
    public class DataTableDbcCreatorDataFixture : DataFixtureBase {
        public string DbcPath => this.GetConnectionString();

        protected override string GetConnectionString() => Path.Combine(this.DataDirectory, "MyTest.dbc");

    }
}
