namespace Stylesheet.NET
{
    /// <summary>
    /// The FontSize property defines the text size. It accepts any length value, such as, px, %, em, and others. Keywords, such as, small, larger, and x-large are also accepted.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontSize =  new FontSize(...);</c>
    /// <br/>
    /// <c>FontSize = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontSize = FontSizeOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontSize = FontSize;</c>
    /// <br/>
    /// <c>string cssValue = FontSize;</c>
    /// <br/>
    /// <c>FontSizeOptions option = FontSize;</c>
    /// </summary>
    public class FontSize
    {
        static FontSizeOptions Option = FontSizeOptions.Medium;
        static string Value = "medium";
        public FontSize(FontSizeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontSize(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontSize(FontSizeOptions option)
        {
            return new FontSize(option);
        }

        public static implicit operator FontSize(string value)
        {
            return new FontSize(value);
        }

        public static implicit operator string(FontSize conv)
        {
            return Value;
        }

        public static implicit operator FontSizeOptions(FontSize conv)
        {
            return GetOption(Value);
        }
        string this[FontSizeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontSizeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontSizeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontSizeOptions>(val);
            if (op == null)
                return Option;
            return (FontSizeOptions)op;
        }
    }
}