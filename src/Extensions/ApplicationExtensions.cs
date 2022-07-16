using System;
using System.Collections.Generic;

namespace trnsACT.Core.Extensions
{
    public static partial class ApplicationExtensions
    {
        public static bool IsNumeric(this string input)
        {
            long retNum;
            return long.TryParse(input, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
        }

        public static bool IsDate(this string input)
        {
            DateTime dt;
            return string.IsNullOrEmpty(input) ? false : (DateTime.TryParse(input, out dt));
        }

        public static bool ToBool(this string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input)) return false;
                if (input == null) return false;
                input = input.Trim().ToLower();
                if (input == "true") return true;
                if (input == "1") return true;
                if (input == "yes") return true;
                if (input == "y") return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static DateTime ToDate(this string input, bool throwExceptionIfFailed = false)
        {
            DateTime result;
            var valid = DateTime.TryParse(input, out result);
            if (!valid)
                if (throwExceptionIfFailed)
                    throw new FormatException(string.Format("'{0}' cannot be converted as DateTime", input));
            return result;
        }

        public static int ToInt(this string input, bool throwExceptionIfFailed = false)
        {
            int result;
            var valid = int.TryParse(input, out result);
            if (!valid)
                if (throwExceptionIfFailed)
                    throw new FormatException(string.Format("'{0}' cannot be converted as int", input));
            return result;
        }

        public static bool NotContains<T>(this List<T> list, T item)
        {
            return !list.Contains(item);
        }

        public static string TrimEnd(this string input,
                                     string suffixToRemove,
                                     StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (suffixToRemove != null && input.EndsWith(suffixToRemove, comparisonType))
            {
                return input.Substring(0, input.Length - suffixToRemove.Length);
            }
            return input;
        }

        public static string TrimStart(this string input,
                                       string prefixToRemove,
                                       StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (prefixToRemove != null && input.StartsWith(prefixToRemove, comparisonType))
            {
                return input.Substring(prefixToRemove.Length, input.Length - prefixToRemove.Length);
            }
            return input;
        }
    }
}