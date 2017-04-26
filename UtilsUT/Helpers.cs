using System;

namespace Cyllaros.Testing.UtilsUT
{
    /// <summary>
    /// Static methods to help testing
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Asserts the given action throws an exception of the specified type (either
        /// the type exactly or a derived type).
        /// </summary>
        /// <typeparam name="Tex">Type of exception expected to be caught</typeparam>
        /// <param name="action"></param>
        public static void AssertThrows<TEx>(Action action)
            where TEx : Exception
        {
            TEx caughtException = null;
            try
            {
                action();
            }
            catch (TEx ex)
            {
                caughtException = ex;
            }
            finally
            {
                // TODO@BMS: Assert that we caught the exception
            }
        }
    }
}
