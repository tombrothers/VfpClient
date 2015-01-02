using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
//    [TestClass]
//    public class VfpCommandParameterRewritterTests {
//        [TestMethod]
//        public void VfpCommandParameterRewritterTests_Test() {
//            var command = new VfpCommand();
//            command.CommandText =
//@"
//SELECT t0.City, t0.CompanyName, t0.ContactName, t0.Country, t0.CustomerID, t0.Phone
//    FROM Customers AS t0
//    WHERE ((STRTRAN(t0.City, @__Param__0__, @__Param__1__) = @__Param__2__) 
//        OR (STRTRAN(t0.City, @__param__0__, @__param__1__) = @__param__2__))
//            and Phone = @phone";

//            command.Parameters.Add(new VfpParameter("__Param__1__", "y"));
//            command.Parameters.Add(new VfpParameter("__Param__0__", "e"));
//            command.Parameters.Add(new VfpParameter("__Param__2__", "Syattly"));
//            command.Parameters.Add(new VfpParameter("phone", "(206) 555-4112"));
//            command.Parameters.Add(new VfpParameter("aaa", string.Empty));

//            var rewritter = new VfpCommandParameterRewritter();
//            rewritter.Rewrite(command);

//            var expectedCommandText =
//@"
//SELECT t0.City, t0.CompanyName, t0.ContactName, t0.Country, t0.CustomerID, t0.Phone
//    FROM Customers AS t0
//    WHERE ((STRTRAN(t0.City, ?, ?) = ?) 
//        OR (STRTRAN(t0.City, ?, ?) = ?))
//            and Phone = ?";

//            Assert.AreEqual(expectedCommandText, command.CommandText);
//            Assert.AreEqual(7, command.Parameters.Count);

//            Assert.AreEqual("__Param__0___2", command.Parameters[0].ParameterName);
//            Assert.AreEqual("e", command.Parameters[0].Value);

//            Assert.AreEqual("__Param__1___2", command.Parameters[1].ParameterName);
//            Assert.AreEqual("y", command.Parameters[1].Value);

//            Assert.AreEqual("__Param__2___2", command.Parameters[2].ParameterName);
//            Assert.AreEqual("Syattly", command.Parameters[2].Value);

//            Assert.AreEqual("__Param__0___1", command.Parameters[3].ParameterName);
//            Assert.AreEqual("e", command.Parameters[3].Value);

//            Assert.AreEqual("__Param__1___1", command.Parameters[4].ParameterName);
//            Assert.AreEqual("y", command.Parameters[4].Value);

//            Assert.AreEqual("__Param__2___1", command.Parameters[5].ParameterName);
//            Assert.AreEqual("Syattly", command.Parameters[5].Value);

//            Assert.AreEqual("phone", command.Parameters[6].ParameterName);
//            Assert.AreEqual("(206) 555-4112", command.Parameters[6].Value);
//        }
//    }
}