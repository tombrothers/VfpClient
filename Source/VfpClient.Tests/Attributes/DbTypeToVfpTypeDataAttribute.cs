using System.Collections.Generic;
using System.Reflection;
using VfpClient.Tests.TestCases;
using Xunit.Sdk;

namespace VfpClient.Tests.Attributes {
    public class DbTypeToVfpTypeDataAttribute : DataAttribute {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod) {
            var testCases = new List<object[]>();

            foreach(var item in VfpMapping.DbTypeToVfpType) {
                testCases.Add(new object[] {
                    new VfpTypeAndDbTypeTestCase(item.Value, item.Key)                    
                });
            }

            return testCases;
        }
    }
}
