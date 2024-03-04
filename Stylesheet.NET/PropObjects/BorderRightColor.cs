namespace StylesheetNET
{
    /// <summary>
    /// The BorderRightColor property sets the color of the right border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-right-style value is required for a border to show.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderRightColor =  new BorderRightColor(...);</c>
    /// <br/>
    /// <c>BorderRightColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderRightColor = BorderRightColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderRightColor = BorderRightColor;</c>
    /// <br/>
    /// <c>string cssValue = BorderRightColor;</c>
    /// <br/>
    /// <c>BorderRightColorOptions option = BorderRightColor;</c>
    /// </summary>
    public class BorderRightColor
    {
        static BorderRightColorOptions Option = BorderRightColorOptions.Initial;
        static string Value = "initial";
        public BorderRightColor(BorderRightColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderRightColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderRightColor(BorderRightColorOptions option)
        {
            return new BorderRightColor(option);
        }

        public static implicit operator BorderRightColor(string value)
        {
            return new BorderRightColor(value);
        }

        public static implicit operator string(BorderRightColor conv)
        {
            return Value;
        }

        public static implicit operator BorderRightColorOptions(BorderRightColor conv)
        {
            return GetOption(Value);
        }
        string this[BorderRightColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderRightColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderRightColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderRightColorOptions>(val);
            if (op == null)
                return Option;
            return (BorderRightColorOptions)op;
        }
    }
}