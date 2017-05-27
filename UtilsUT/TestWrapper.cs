using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyllaros.Testing.UtilsUT
{
    /// <summary>
    /// Wraps the .NET test framework. Uses inheritance to expose initialization and
    /// clean-up behaviors.
    /// 
    /// Derived classes only need to mark test methods with the [TestMethod] attribute;
    /// all other initialization may be done by overriding virtual methods.
    /// </summary>
    /// <remarks>
    /// TODO@BMS:
    ///     1. Create a test environment; setup and tear-down
    ///         - look at some sort of TestContext
    ///     2. Look at making sure that things are always called, even if people don't
    ///        know how to correctly override and call base classes
    ///     3. Look at how assembly based things work (context, initialization, clean-up?)
    /// </remarks>
    [TestClass]
    public abstract class TestWrapper
    {
        [TestInitialize]
        public void Init()
        {
            TestInit();
        }

        protected virtual void TestInit()
        { }

        [TestCleanup]
        public void CleanUp()
        {
            TestCleanUp();
        }

        protected virtual void TestCleanUp()
        { }
    }
}
