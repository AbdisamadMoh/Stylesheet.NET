namespace StylesheetNET
{
    /// <summary>
    /// The BorderColor property sets the color of the border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-style value is required for a border to show.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderColor =  new BorderColor(...);</c>
    /// <br/>
    /// <c>BorderColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderColor = BorderColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderColor = BorderColor;</c>
    /// <br/>
    /// <c>string cssValue = BorderColor;</c>
    /// <br/>
    /// <c>BorderColorOptions option = BorderColor;</c>
    /// </summary>
    public class BorderColor
    {
        static BorderColorOptions Option = BorderColorOptions.Initial;
        static string Value = "initial";
        public BorderColor(BorderColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderColor(BorderColorOptions option)
        {
            return new BorderColor(option);
        }

        public static implicit operator BorderColor(string value)
        {
            return new BorderColor(value);
        }

        public static implicit operator string(BorderColor conv)
        {
            return Value;
        }

        public static implicit operator BorderColorOptions(BorderColor conv)
        {
            return GetOption(Value);
        }
        string this[BorderColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderColorOptions>(val);
            if (op == null)
                return Option;
            return (BorderColorOptions)op;
        }
    }
}