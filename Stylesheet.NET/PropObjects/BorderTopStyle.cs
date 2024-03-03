namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderTopStyle property sets the top border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTopStyle =  new BorderTopStyle(...);</c>
    /// <br/>
    /// <c>BorderTopStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTopStyle = BorderTopStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTopStyle = BorderTopStyle;</c>
    /// <br/>
    /// <c>string cssValue = BorderTopStyle;</c>
    /// <br/>
    /// <c>BorderTopStyleOptions option = BorderTopStyle;</c>
    /// </summary>
    public class BorderTopStyle
    {
        static BorderTopStyleOptions Option = BorderTopStyleOptions.None;
        static string Value = "none";
        public BorderTopStyle(BorderTopStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTopStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTopStyle(BorderTopStyleOptions option)
        {
            return new BorderTopStyle(option);
        }

        public static implicit operator BorderTopStyle(string value)
        {
            return new BorderTopStyle(value);
        }

        public static implicit operator string(BorderTopStyle conv)
        {
            return Value;
        }

        public static implicit operator BorderTopStyleOptions(BorderTopStyle conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopStyleOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopStyleOptions)op;
        }
    }
}