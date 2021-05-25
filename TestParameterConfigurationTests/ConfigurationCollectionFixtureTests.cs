using FluentAssertions;
using TestParameterConfigurationTests.TestInfrastructure;
using Xunit;

namespace TestParameterConfigurationTests
{
    /* 
     * all test classes marked with this attribute 
     * and collection name: 'Configuration collection'  
     * will have access to test parameters from the
     * test-parameters.jsonm file.
     */
    [Collection("Configuration collection")] 
    public class ConfigurationCollectionFixtureTests 
    {
        ConfigurationFixture _configurationFixture;

        public ConfigurationCollectionFixtureTests(ConfigurationFixture configurationFixture)
        {
            _configurationFixture = configurationFixture;
        }


        [Fact]
        public void Can_resolve_test_parameters_from_config_file()
        {
            // Given

            // When
            var userName = _configurationFixture.TestParameters.DefaultUserName;

            // Then
            userName.Should().Be("JohnSmith");
        }
    }
}
