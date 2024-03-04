using System;
using System.Collections.Generic;

namespace StylesheetNET
{
    public class Validation
    {
        internal bool? IsValidSelector(string selector)
        {
            if (selector.IsNullOrWhiteSpace())
                return null;
            if (selector.Contains("{") || selector.Contains("}") || selector.Contains(";"))
                return false;

            return true;
        }

        internal string ValidateProperty(string property, string value, bool minified = false)
        {
            value = value.Trim();

        TrimTrailingSemiColon:
            if (value.EndsWith(";"))
                value = value.Substring(0, value.Length - 1);
            if (value.EndsWith(";"))
                goto TrimTrailingSemiColon; //loop back

            if (value.Contains(";") || value.Contains(":"))
                throw new Exception($"\"{property}: {value};\" is not a valid property.");
            var indent = minified ? "" : Extension.Indent;
            var space = minified ? "" : " ";
            return $"{indent}{property}:{space}{value};";
        }

        internal bool ClassPseudoExist(string ps, string selector, Dictionary<string, Dictionary<string, Element>> cp)
        {
            if (selector.IsNullOrWhiteSpace() || ps.IsNullOrWhiteSpace())
                return false;
            if (cp == null)
                throw new Exception("Passed collection is null");
            if (!cp.ContainsKey(ps))
                return false;

            var pseudoList = cp[ps];
            if (pseudoList.ContainsKey(selector))
                return true;

            return false;

        }
    }
}
