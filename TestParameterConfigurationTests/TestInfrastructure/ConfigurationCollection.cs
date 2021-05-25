using Xunit;

namespace TestParameterConfigurationTests.TestInfrastructure
{
    [CollectionDefinition("Configuration collection")]
    public class ConfigurationCollection : ICollectionFixture<ConfigurationFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
