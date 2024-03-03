namespace Stylesheet.NET
{
    /// <summary>
    /// The FontStyle property specifies the style of the font. Fonts can be styled as normal, italic, or oblique.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontStyle =  new FontStyle(...);</c>
    /// <br/>
    /// <c>FontStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontStyle = FontStyleOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontStyle = FontStyle;</c>
    /// <br/>
    /// <c>string cssValue = FontStyle;</c>
    /// <br/>
    /// <c>FontStyleOptions option = FontStyle;</c>
    /// </summary>
    public class FontStyle
    {
        static FontStyleOptions Option = FontStyleOptions.Normal;
        static string Value = "normal";
        public FontStyle(FontStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontStyle(FontStyleOptions option)
        {
            return new FontStyle(option);
        }

        public static implicit operator FontStyle(string value)
        {
            return new FontStyle(value);
        }

        public static implicit operator string(FontStyle conv)
        {
            return Value;
        }

        public static implicit operator FontStyleOptions(FontStyle conv)
        {
            return GetOption(Value);
        }
        string this[FontStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontStyleOptions>(val);
            if (op == null)
                return Option;
            return (FontStyleOptions)op;
        }
    }
}