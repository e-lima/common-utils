using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonUtils
{
    /// <summary>
    /// Basic validators interface
    /// </summary>
    /// <typeparam name="T">Type validated</typeparam>
    public interface IValidator
    {
        /// <summary>
        /// Validates
        /// </summary>
        /// <param name="t">Value to validate</param>
        /// <returns>true / false</returns>
        bool IsValid(object t);

        /// <summary>
        /// Validates and return the error list
        /// </summary>
        /// <param name="t">Value to validate</param>
        /// <param name="errors">The error list</param>
        /// <returns>true / false</returns>
        bool IsValid(object t, out string[] errors);
    }
}
