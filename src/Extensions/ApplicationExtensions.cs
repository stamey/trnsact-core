using System;
using System.Collections.Generic;

namespace trnsACT.Core.Extensions
{
    public static partial class ApplicationExtensions
    {
        public static bool ToBool(this string @this)
        {
            try
            {
                if (@this == null) return false;
                @this = @this.Trim().ToLower();
                if (@this == "true") return true;
                if (@this == "1") return true;
                if (@this == "yes") return true;
                if (@this == "y") return true;
                return false;
            }
            catch
            {
                return false;
            }
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