namespace Cyllaros.Testing.UtilsUT
{
    /// <summary>
    /// Wraps the .NET test framework. Uses inheritance to expose initialization and
    /// clean-up behaviors.
    /// 
    /// Derived classes only need to mark test methods with the [TestMethod] attribute;
    /// all other initialization may be done by overriding virtual methods.
    /// </summary>
    public abstract class TestWrapper
    {
        public void Init()
        {
            TestInit();
        }

        protected virtual void TestInit()
        { }

        public void CleanUp()
        {
            TestCleanUp();
        }

        protected virtual void TestCleanUp()
        { }
    }
}
