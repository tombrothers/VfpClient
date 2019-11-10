using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace VfpClient.Tests.Attributes
{
    public class EnumDataAttribute : DataAttribute
    {
        private readonly Type enumType;

        public EnumDataAttribute(Type enumType)
        {
            this.enumType = enumType;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var testCases = new List<object[]>();

            foreach (var value in Enum.GetValues(enumType))
            {
                testCases.Add(new object[] { value });
            }

            return testCases;
        }
    }
}
