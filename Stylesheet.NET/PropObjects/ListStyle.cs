namespace Stylesheet.NET
{
    /// <summary>
    /// Markers are the bullets on a list of items. The ListStyle property specifies the markers for the items. This includes marker type, position, and, optionally, an image.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ListStyle =  new ListStyle(...);</c>
    /// <br/>
    /// <c>ListStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>ListStyle = ListStyleOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ListStyle = ListStyle;</c>
    /// <br/>
    /// <c>string cssValue = ListStyle;</c>
    /// <br/>
    /// <c>ListStyleOptions option = ListStyle;</c>
    /// </summary>
    public class ListStyle
    {
        static ListStyleOptions Option = ListStyleOptions.Initial;
        static string Value = "initial";
        public ListStyle(ListStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ListStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ListStyle(ListStyleOptions option)
        {
            return new ListStyle(option);
        }

        public static implicit operator ListStyle(string value)
        {
            return new ListStyle(value);
        }

        public static implicit operator string(ListStyle conv)
        {
            return Value;
        }

        public static implicit operator ListStyleOptions(ListStyle conv)
        {
            return GetOption(Value);
        }
        string this[ListStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ListStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ListStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ListStyleOptions>(val);
            if (op == null)
                return Option;
            return (ListStyleOptions)op;
        }
    }
}