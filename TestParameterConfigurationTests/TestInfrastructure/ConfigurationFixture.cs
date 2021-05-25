using System.IO;
using Microsoft.Extensions.Configuration;

namespace TestParameterConfigurationTests.TestInfrastructure
{
    public class ConfigurationFixture
    {
        private readonly IConfigurationRoot _configurationRoot;
        private readonly ITestParameters _testParameters;

        public ConfigurationFixture()
        {

            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                // load in the json file as configuration
                .AddJsonFile(path: "test-parameters.json", optional: false, reloadOnChange: true)
                // override configuration from the json file with commandline arguments
                //.AddCommandLine(args) /* ??? how to get working for unit test project ??? */
                .Build(); 
            

            _testParameters = new TestParameters();
            ConfigurationRoot.Bind(_testParameters);
        }

        public void Dispose()
        {
            // ... clean up test data from the config ...
        }

        private IConfigurationRoot ConfigurationRoot { get { return _configurationRoot; } }
        public ITestParameters TestParameters { get { return _testParameters; } }
    }
}
