namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderBottomStyle property sets the bottom border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottomStyle =  new BorderBottomStyle(...);</c>
    /// <br/>
    /// <c>BorderBottomStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottomStyle = BorderBottomStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottomStyle = BorderBottomStyle;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottomStyle;</c>
    /// <br/>
    /// <c>BorderBottomStyleOptions option = BorderBottomStyle;</c>
    /// </summary>
    public class BorderBottomStyle
    {
        static BorderBottomStyleOptions Option = BorderBottomStyleOptions.None;
        static string Value = "none";
        public BorderBottomStyle(BorderBottomStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottomStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottomStyle(BorderBottomStyleOptions option)
        {
            return new BorderBottomStyle(option);
        }

        public static implicit operator BorderBottomStyle(string value)
        {
            return new BorderBottomStyle(value);
        }

        public static implicit operator string(BorderBottomStyle conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomStyleOptions(BorderBottomStyle conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomStyleOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomStyleOptions)op;
        }
    }
}