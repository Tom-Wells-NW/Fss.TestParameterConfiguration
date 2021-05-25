namespace TestParameterConfigurationTests.TestInfrastructure
{
    public class TestParameters : ITestParameters
    {
        public string DefaultUserName { get; set; }
        public string DefaultUserPassword { get; set; }
        public string DefaultServiceIpAddress { get; set; }
        public string DefaultServicePort { get; set; }
    }
}
