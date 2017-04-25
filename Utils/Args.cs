using System;

namespace Cyllaros.Utils
{
    /// <summary>
    /// Helper class to confirm arguments are valid 
    /// </summary>
    public static class Args
    {
        /// <summary>
        /// If the given object is null, throws an exception
        /// </summary>
        /// <param name="obj">Object to check</param>
        public static void NotNull(object obj)
        {
            NotNull(obj, String.Empty);
        }

        /// <summary>
        /// If the given object is null, throws an exception
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <param name="paramName">Name of the parameter</param>
        public static void NotNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName ?? String.Empty, "parameter may not be null!");
            }
        }

        /// <summary>
        /// Throws an exception if the given condition is not true
        /// </summary>
        /// <param name="b">Condition to confirm</param>
        public static void Cond(bool b)
        {
            Cond(b, String.Empty);
        }

        /// <summary>
        /// Throws an exception if the given condition is not true
        /// </summary>
        /// <param name="b">Condition to confirm</param>
        /// <param name="message">Message describing the reason for the exception</param>
        public static void Cond(bool b, string message)
        {
            if (!b)
            {
                if (String.IsNullOrEmpty(message))
                {
                    throw new ArgumentException();
                }
                else
                {
                    throw new ArgumentException(message);
                }
            }
        }
    }
}