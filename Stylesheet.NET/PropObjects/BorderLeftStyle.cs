namespace StylesheetNET
{
    /// <summary>
    /// The BorderLeftStyle property sets the left border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderLeftStyle =  new BorderLeftStyle(...);</c>
    /// <br/>
    /// <c>BorderLeftStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderLeftStyle = BorderLeftStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderLeftStyle = BorderLeftStyle;</c>
    /// <br/>
    /// <c>string cssValue = BorderLeftStyle;</c>
    /// <br/>
    /// <c>BorderLeftStyleOptions option = BorderLeftStyle;</c>
    /// </summary>
    public class BorderLeftStyle
    {
        static BorderLeftStyleOptions Option = BorderLeftStyleOptions.None;
        static string Value = "none";
        public BorderLeftStyle(BorderLeftStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderLeftStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderLeftStyle(BorderLeftStyleOptions option)
        {
            return new BorderLeftStyle(option);
        }

        public static implicit operator BorderLeftStyle(string value)
        {
            return new BorderLeftStyle(value);
        }

        public static implicit operator string(BorderLeftStyle conv)
        {
            return Value;
        }

        public static implicit operator BorderLeftStyleOptions(BorderLeftStyle conv)
        {
            return GetOption(Value);
        }
        string this[BorderLeftStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderLeftStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderLeftStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderLeftStyleOptions>(val);
            if (op == null)
                return Option;
            return (BorderLeftStyleOptions)op;
        }
    }
}