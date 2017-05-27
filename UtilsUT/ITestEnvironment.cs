using System;

namespace Cyllaros.Testing.UtilsUT
{
    public interface ITestEnvironment
    {
        string TestName { get; }
    }

    internal class TestEnv : ITestEnvironment
    {
        public string TestName => throw new NotImplementedException();
    }
}
