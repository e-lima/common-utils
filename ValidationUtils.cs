using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CommonUtils
{
    /// <summary>
    /// Provides static validations helpers.
    /// </summary>
    public static class ValidationUtils
    {
        public delegate bool ValidationHandler<T>(T t);
        public delegate bool ValidationHandlerWithReport<T>(T t, out string[] errors);

        /// <summary>
        /// Perform the specified validation on t
        /// </summary>
        /// <typeparam name="T">Type of t</typeparam>
        /// <param name="t">Instance of t</param>
        /// <param name="validator">Validator</param>
        /// <returns>true: valid / false: invalid</returns>
        public static bool IsValid<T>(T t, ValidationHandler<T> validator)
        {
            return validator(t);
        }

        /// <summary>
        /// Perform the specified validation on t
        /// </summary>
        /// <typeparam name="T">Type of t</typeparam>
        /// <param name="t">Instance of t</param>
        /// <param name="validator">Validator</param>
        /// <returns>true: valid / false: invalid</returns>
        public static bool IsValid<T>(T t, ValidationHandlerWithReport<T> validator, out string[] errors)
        {
            return validator(t, out errors);
        }

        /// <summary>
        /// Validates the specified value (TValueType) with the specified validator (TValidator)
        /// </summary>
        /// <typeparam name="TValueType">The value type</typeparam>
        /// <typeparam name="TValidator">The validator class/type</typeparam>
        /// <param name="value">The value</param>
        /// <returns>true / false</returns>
        public static bool IsValid<TValidator>(this object value) where TValidator : IValidator, new()
        {
            TValidator v = new TValidator();
            return v.IsValid(value);
        }

        /// <summary>
        /// Validates the specified value (TValueType) with the specified validator (TValidator) and return the error list
        /// </summary>
        /// <typeparam name="TValueType">The value type</typeparam>
        /// <typeparam name="TValidator">The validator class/type</typeparam>
        /// <param name="value">The value</param>
        /// <returns>true / false</returns>
        public static bool IsValid<TValidator>(this object value, out string[] errors) where TValidator : IValidator, new()
        {
            TValidator v = new TValidator();
            return v.IsValid(value, out errors);
        }

        /// <summary>
        /// Validates all properties of the specified object with the ValidateAttribute attribute.
        /// </summary>
        /// <typeparam name="T">Tyoe of o.</typeparam>
        /// <param name="o">the object instance to validate.</param>
        /// <returns>A dictionary containing 0 or more validation errors per property name.</returns>
        public static Dictionary<string, string[]> Validate<T>(this T o)
        {
            Type t = typeof(T);
            Dictionary<PropertyInfo, ValidateAttribute[]> map = new Dictionary<PropertyInfo, ValidateAttribute[]>();
            Dictionary<string, string[]> erros = new Dictionary<string, string[]>();

            foreach (var prop in t.GetProperties())
            {
                ValidateAttribute[] attrs = (ValidateAttribute[])prop.GetCustomAttributes(typeof(ValidateAttribute), true);
                if (attrs.Length > 0) map.Add(prop, attrs);
            }

            foreach (var entry in map)
            {
                foreach (var attr in entry.Value)
                {
                    string[] _erros = null;
                    if (!attr.Validator.IsValid(entry.Key.GetValue(o, null), out _erros))
                        erros.Add(entry.Key.Name, _erros);
                }
            }

            return erros;
        }
    }
}
