namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderStyle property sets the style of the border. It accepts one to four values for top, right, bottom, and left style. A BorderStyle value is required for any border to display.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderStyle =  new BorderStyle(...);</c>
    /// <br/>
    /// <c>BorderStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderStyle = BorderStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderStyle = BorderStyle;</c>
    /// <br/>
    /// <c>string cssValue = BorderStyle;</c>
    /// <br/>
    /// <c>BorderStyleOptions option = BorderStyle;</c>
    /// </summary>
    public class BorderStyle
    {
        static BorderStyleOptions Option = BorderStyleOptions.None;
        static string Value = "none";
        public BorderStyle(BorderStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderStyle(BorderStyleOptions option)
        {
            return new BorderStyle(option);
        }

        public static implicit operator BorderStyle(string value)
        {
            return new BorderStyle(value);
        }

        public static implicit operator string(BorderStyle conv)
        {
            return Value;
        }

        public static implicit operator BorderStyleOptions(BorderStyle conv)
        {
            return GetOption(Value);
        }
        string this[BorderStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderStyleOptions>(val);
            if (op == null)
                return Option;
            return (BorderStyleOptions)op;
        }
    }
}