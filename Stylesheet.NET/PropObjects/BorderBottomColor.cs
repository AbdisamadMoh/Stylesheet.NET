namespace StylesheetNET
{
    /// <summary>
    /// The BorderBottomColor property sets the bottom border color. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-bottom-style value is required for any border to show.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottomColor =  new BorderBottomColor(...);</c>
    /// <br/>
    /// <c>BorderBottomColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottomColor = BorderBottomColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottomColor = BorderBottomColor;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottomColor;</c>
    /// <br/>
    /// <c>BorderBottomColorOptions option = BorderBottomColor;</c>
    /// </summary>
    public class BorderBottomColor
    {
        static BorderBottomColorOptions Option = BorderBottomColorOptions.Initial;
        static string Value = "initial";
        public BorderBottomColor(BorderBottomColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottomColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottomColor(BorderBottomColorOptions option)
        {
            return new BorderBottomColor(option);
        }

        public static implicit operator BorderBottomColor(string value)
        {
            return new BorderBottomColor(value);
        }

        public static implicit operator string(BorderBottomColor conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomColorOptions(BorderBottomColor conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomColorOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomColorOptions)op;
        }
    }
}