using System;
using System.Data;
using VfpClient.Utils;

namespace VfpClient.Tests.Fixtures {
    public class ArrayXmlToCursorFixture : DataFixtureBase {
        public DataTable Execute(Array array) {
            var arrayXmlToCursor = new ArrayXmlToCursor(array);

            return GetDataTable(arrayXmlToCursor);
        }

        private DataTable GetDataTable(ArrayXmlToCursor arrayXmlToCursor) {
            var table = new DataTable();

            this.ExecuteCommand(command => {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "XmlToCursor";
                command.Parameters.Add(new VfpParameter("xml", arrayXmlToCursor.Xml));
                command.Parameters.Add(new VfpParameter("cursor", "curXmlTemp"));
                command.ExecuteNonQuery();

                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM curXmlTemp";

                var adapter = new VfpDataAdapter(command);

                adapter.Fill(table);
            });

            return table;
        }
    }
}
