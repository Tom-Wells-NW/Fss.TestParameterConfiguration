namespace TestParameterConfigurationTests.TestInfrastructure
{
    public interface ITestParameters
    {
        string DefaultServiceIpAddress { get; }
        string DefaultServicePort { get; }
        string DefaultUserName { get; }
        string DefaultUserPassword { get; }
    }
}