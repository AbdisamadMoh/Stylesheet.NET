namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderTopColor property sets the color of the top border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-top-style value is required for a border to show.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTopColor =  new BorderTopColor(...);</c>
    /// <br/>
    /// <c>BorderTopColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTopColor = BorderTopColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTopColor = BorderTopColor;</c>
    /// <br/>
    /// <c>string cssValue = BorderTopColor;</c>
    /// <br/>
    /// <c>BorderTopColorOptions option = BorderTopColor;</c>
    /// </summary>
    public class BorderTopColor
    {
        static BorderTopColorOptions Option = BorderTopColorOptions.Initial;
        static string Value = "initial";
        public BorderTopColor(BorderTopColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTopColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTopColor(BorderTopColorOptions option)
        {
            return new BorderTopColor(option);
        }

        public static implicit operator BorderTopColor(string value)
        {
            return new BorderTopColor(value);
        }

        public static implicit operator string(BorderTopColor conv)
        {
            return Value;
        }

        public static implicit operator BorderTopColorOptions(BorderTopColor conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopColorOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopColorOptions)op;
        }
    }
}