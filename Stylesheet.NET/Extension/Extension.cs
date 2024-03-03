using System.Collections.Generic;

namespace Stylesheet.NET
{
    internal static class Extension
    {
        public static string Indent
        {
            get
            {
                return "    ";
            }
        }
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str?.Trim());
        }
        public static bool Contains(this List<string> list, string str2, bool caseSenstive = true)
        {
            if (list == null)
                return false;
            if (!caseSenstive)
                return list.Contains(str2);
            foreach (var item in list)
            {
                if (caseSenstive)
                    if (item.ToLower() == str2.ToLower())
                        return true;
            }
            return false;

        }
    }
}
