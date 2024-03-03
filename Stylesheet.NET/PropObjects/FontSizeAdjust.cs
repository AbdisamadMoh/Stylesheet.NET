namespace Stylesheet.NET
{
    /// <summary>
    /// The FontSizeAdjust property gives you better control of the font size when the first selected font is not available.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontSizeAdjust =  new FontSizeAdjust(...);</c>
    /// <br/>
    /// <c>FontSizeAdjust = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontSizeAdjust = FontSizeAdjustOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontSizeAdjust = FontSizeAdjust;</c>
    /// <br/>
    /// <c>string cssValue = FontSizeAdjust;</c>
    /// <br/>
    /// <c>FontSizeAdjustOptions option = FontSizeAdjust;</c>
    /// </summary>
    public class FontSizeAdjust
    {
        static FontSizeAdjustOptions Option = FontSizeAdjustOptions.None;
        static string Value = "none";
        public FontSizeAdjust(FontSizeAdjustOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontSizeAdjust(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontSizeAdjust(FontSizeAdjustOptions option)
        {
            return new FontSizeAdjust(option);
        }

        public static implicit operator FontSizeAdjust(string value)
        {
            return new FontSizeAdjust(value);
        }

        public static implicit operator string(FontSizeAdjust conv)
        {
            return Value;
        }

        public static implicit operator FontSizeAdjustOptions(FontSizeAdjust conv)
        {
            return GetOption(Value);
        }
        string this[FontSizeAdjustOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontSizeAdjustOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontSizeAdjustOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontSizeAdjustOptions>(val);
            if (op == null)
                return Option;
            return (FontSizeAdjustOptions)op;
        }
    }
}