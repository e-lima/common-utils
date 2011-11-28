using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace CommonUtils
{
    /// <summary>
    /// Provides static methods and extensions to perform common parsing operations.
    /// </summary>
    public static class ParseUtils
    {
        #region Int Parsing
        /// <summary>
        /// Try to parse a string to int. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The int representation of value</returns>
        public static int AsInt(this string value, int fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            int i;

            if (!int.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to short. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The short representation of value</returns>
        public static short AsShort(this string value, short fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            short i;

            if (!short.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to long. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The long representation of value</returns>
        public static long AsLong(this string value, long fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            long i;

            if (!long.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to uint. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The uint representation of value</returns>
        public static uint AsUInt(this string value, uint fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            uint i;

            if (!uint.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to ushort. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The ushort representation of value</returns>
        public static ushort AsUShort(this string value, ushort fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            ushort i;

            if (!ushort.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to ulong. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The ulong representation of value</returns>
        public static ulong AsULong(this string value, ulong fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            ulong i;

            if (!ulong.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to byte. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The byte representation of value</returns>
        public static byte AsByte(this string value, byte fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            byte i;

            if (!byte.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to sbyte. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The sbyte representation of value</returns>
        public static sbyte AsSignedByte(this string value, sbyte fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Integer, IFormatProvider formatProvider = null, Exception failException = null)
        {
            sbyte i;

            if (!sbyte.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }
        #endregion

        #region Float Parsing

        /// <summary>
        /// Try to parse a string to float. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The int representation of value</returns>
        public static float AsFloat(this string value, float fallbackValue = 0f, NumberStyles numberStyles = NumberStyles.Float | NumberStyles.AllowThousands, IFormatProvider formatProvider = null, Exception failException = null)
        {
            float i;

            if (!float.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to double. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The double representation of value</returns>
        public static double AsDouble(this string value, double fallbackValue = 0f, NumberStyles numberStyles = NumberStyles.Float | NumberStyles.AllowThousands, IFormatProvider formatProvider = null, Exception failException = null)
        {
            double i;

            if (!double.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        /// <summary>
        /// Try to parse a string to double. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="numberStyles">The number styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The double representation of value</returns>
        public static Decimal AsDecimal(this string value, Decimal fallbackValue = 0, NumberStyles numberStyles = NumberStyles.Number, IFormatProvider formatProvider = null, Exception failException = null)
        {
            Decimal i;

            if (!Decimal.TryParse(value, numberStyles, formatProvider, out i))
            {
                if (failException is Exception)
                {
                    failException.Data["value"] = value;
                    failException.Data["numberStyles"] = numberStyles;
                    failException.Data["formatProvider"] = formatProvider;
                    throw failException;
                }
                i = fallbackValue;
            }

            return i;
        }

        #endregion

        #region Date & Time Parsing

        /// <summary>
        /// Try to parse a string to DateTime. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="datetimeStyles">The datetime styles.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The DateTime representation of value</returns>
        public static DateTime AsDateTime(this string value, DateTime fallbackValue, DateTimeStyles datetimeStyles = DateTimeStyles.None, IFormatProvider formatProvider = null, Exception failException = null)
        {
            DateTime d;

            if (!DateTime.TryParse(value, formatProvider, datetimeStyles, out d))
            {
                if (failException is Exception)
                    throw failException;
                d = fallbackValue;
            }

            return d;
        }

        /// <summary>
        /// Try to parse a string to TimeSpan. Use the fallbackValue if the parse fails or throw the failException. 
        /// </summary>
        /// <param name="value">The value to try parse.</param>
        /// <param name="fallbackValue">The value to use if the parse fails.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="failException">The exception to throw if the parse fails. Or null to don't throw.</param>
        /// <returns>The TimeSpan representation of value</returns>
        public static TimeSpan AsTimeSpan(this string value, TimeSpan fallbackValue,  IFormatProvider formatProvider = null, Exception failException = null)
        {
            TimeSpan d;

            if (!TimeSpan.TryParse(value, formatProvider, out d))
            {
                if (failException is Exception)
                    throw failException;
                d = fallbackValue;
            }

            return d;
        }

        #endregion

        #region Nullable
        /// <summary>
        /// Gets the parsed value or null.
        /// </summary>
        /// <typeparam name="T">The type to try parse.</typeparam>
        /// <param name="value">a String</param>
        /// <param name="parser">a delegate of: bool f(string, out T)</param>
        /// <returns>T or null</returns>
        public static T? AsNullableOf<T>(this string value, TryParseDelegate<T> parser) where T : struct
        {
            T? result;
            T _t;

            if (parser(value, out _t)) result = _t;
            else result = null;

            return result;
        }

        /// <summary>
        /// Gets the parsed value or null.
        /// </summary>
        /// <typeparam name="T">The type to try parse.</typeparam>
        /// <param name="value">a String</param>
        /// <returns>T or null</returns>
        public static T? AsNullableOf<T>(this string value) where T : struct
        {
            TryParseDelegate<T> p = GetParserFor<T>();
            return value.AsNullableOf<T>(p);
        }

        private static TryParseDelegate<T> GetParserFor<T>() where T : struct
        {
            object parser;
            string typeName = typeof(T).Name;

            switch (typeName)
            {
                case "DateTime":
                    parser = new TryParseDelegate<DateTime>(DateTime.TryParse);
                    break;
                case "TimeSpan":
                    parser = new TryParseDelegate<TimeSpan>(TimeSpan.TryParse);
                    break;
                case "SByte":
                    parser = new TryParseDelegate<SByte>(SByte.TryParse);
                    break;
                case "Int16":
                    parser = new TryParseDelegate<Int16>(Int16.TryParse);
                    break;
                case "Int32":
                    parser = new TryParseDelegate<Int32>(Int32.TryParse);
                    break;
                case "Int64":
                    parser = new TryParseDelegate<Int64>(Int64.TryParse);
                    break;
                case "Byte":
                    parser = new TryParseDelegate<Byte>(Byte.TryParse);
                    break;
                case "UInt16":
                    parser = new TryParseDelegate<UInt16>(UInt16.TryParse);
                    break;
                case "UInt32":
                    parser = new TryParseDelegate<UInt32>(UInt32.TryParse);
                    break;
                case "UInt64":
                    parser = new TryParseDelegate<UInt64>(UInt64.TryParse);
                    break;
                case "Decimal":
                    parser = new TryParseDelegate<Decimal>(Decimal.TryParse);
                    break;
                case "Double":
                    parser = new TryParseDelegate<Double>(Double.TryParse);
                    break;
                case "Single":
                    parser = new TryParseDelegate<Single>(Single.TryParse);
                    break;
                default:
                    parser = new TryParseDelegate<T>(NullParserHandler<T>);
                    break;
            }

            return (TryParseDelegate<T>)parser;
        }

        /// <summary>
        /// TryParse delegate. Matches the almost framework struct. 
        /// </summary>
        /// <typeparam name="T">Type to parse to.</typeparam>
        /// <param name="value">String  value.</param>
        /// <param name="result">Parsed result.</param>
        /// <returns>true / false</returns>
        public delegate bool TryParseDelegate<T>(string value, out T result);

        /// <summary>
        /// Default parser. Always fails the parse.
        /// </summary>
        /// <typeparam name="T">Type to parse to.</typeparam>
        /// <param name="value">String value.</param>
        /// <param name="result">Parsed result.</param>
        /// <returns>false</returns>
        public static bool NullParserHandler<T>(string value, out T result)
        {
            result = default(T);
            return false;
        } 
        #endregion

        #region Misc

        /// <summary>
        /// Verifies if the string can be converted to the Type T
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value">string</param>
        /// <returns>true / false</returns>
        public static bool CanBe<T>(this string value) where T : struct
        {
            var p = GetParserFor<T>();
            T t;
            return p(value, out t);
        }

        #endregion
    }
}
