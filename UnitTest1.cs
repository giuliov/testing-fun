using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly IConfigurationRoot configuration;

        public UnitTest1()
        {
            configuration = TestHelpers.GetConfigurationRoot();
        }

        [Fact]
        public void Test1()
        {
            var key1value = configuration["my_Key_1"];
            Assert.Equal("value1", key1value);
        }
    }
}
