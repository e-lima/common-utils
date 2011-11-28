using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CommonUtils
{
    /// <summary>
    /// Provide static methods to handle exceptions.
    /// </summary>
    public static class ExceptionUtils
    {
        /// <summary>
        /// Extracts the StackTrace from the exception and its InnerException
        /// </summary>
        /// <param name="ex">The exception to extract</param>
        /// <param name="lastStackTrace">The last extracted StackTrace (for recursivity), String.Empty or null</param>
        /// <param name="exCount">The extracted StackTrace number (for recursivity)</param>
        /// <returns>Syste.String</returns>
        public static string ExtractAllStackTrace(this Exception ex, String lastStackTrace = null, int exCount = 1)
        {
            Exception _ex = ex;
            string _entryFormat = "#{0}: {1}\r\n{2}";

            //Fix a null lastStackTrace parameter
            lastStackTrace = lastStackTrace ?? String.Empty;

            //Add the exception's StackTrace
            lastStackTrace += String.Format(_entryFormat, exCount, _ex.Message, _ex.StackTrace);

            if (ex.Data.Count > 0)
            {
                lastStackTrace += "\r\n    Data: ";
                foreach (var item in ex.Data)
                {
                    DictionaryEntry entry = (DictionaryEntry)item; 
                    lastStackTrace += String.Format("\r\n\t{0}: {1}", entry.Key.ToString(), ex.Data[entry.Key]);
                }
            }

            //Recursive add InnerException
            if ((_ex = _ex.InnerException) != null)
                return _ex.ExtractAllStackTrace(String.Format("{0}\r\n\r\n", lastStackTrace), ++exCount);
            else
                return lastStackTrace;
        }

        /// <summary>
        /// Creates a new exception with the exception instance as InnerException.
        /// </summary>
        /// <param name="ex">The exception to use as Inner.</param>
        /// <param name="message">The new exception message.</param>
        public static Exception AsInner(this Exception ex, string message)
        {
            Exception nex = new Exception(message, ex);
            return nex;
        }
    }
}
