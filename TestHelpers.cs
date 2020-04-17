using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    class TestHelpers
    {
        // pass TestContext.CurrentContext.TestDirectory in NUnit
        public static IConfigurationRoot GetConfigurationRoot(string outputPath = null)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath ?? Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables() // environment overrides file
                .Build();
        }
    }
}
