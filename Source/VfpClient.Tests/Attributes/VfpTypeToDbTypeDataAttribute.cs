using System.Collections.Generic;
using System.Reflection;
using VfpClient.Tests.TestCases;
using Xunit.Sdk;

namespace VfpClient.Tests.Attributes
{
    public class VfpTypeToDbTypeDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var testCases = new List<object[]>();

            foreach (var item in VfpMapping.VfpTypeToDbType)
            {
                testCases.Add(new object[] {
                    new VfpTypeAndDbTypeTestCase(item.Key, item.Value)
                });
            }

            return testCases;
        }
    }
}
