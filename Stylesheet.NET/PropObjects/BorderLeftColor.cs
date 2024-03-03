namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderLeftColor property sets the color of the left border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-left-style value is required for a border to show.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderLeftColor =  new BorderLeftColor(...);</c>
    /// <br/>
    /// <c>BorderLeftColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderLeftColor = BorderLeftColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderLeftColor = BorderLeftColor;</c>
    /// <br/>
    /// <c>string cssValue = BorderLeftColor;</c>
    /// <br/>
    /// <c>BorderLeftColorOptions option = BorderLeftColor;</c>
    /// </summary>
    public class BorderLeftColor
    {
        static BorderLeftColorOptions Option = BorderLeftColorOptions.Initial;
        static string Value = "initial";
        public BorderLeftColor(BorderLeftColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderLeftColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderLeftColor(BorderLeftColorOptions option)
        {
            return new BorderLeftColor(option);
        }

        public static implicit operator BorderLeftColor(string value)
        {
            return new BorderLeftColor(value);
        }

        public static implicit operator string(BorderLeftColor conv)
        {
            return Value;
        }

        public static implicit operator BorderLeftColorOptions(BorderLeftColor conv)
        {
            return GetOption(Value);
        }
        string this[BorderLeftColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderLeftColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderLeftColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderLeftColorOptions>(val);
            if (op == null)
                return Option;
            return (BorderLeftColorOptions)op;
        }
    }
}