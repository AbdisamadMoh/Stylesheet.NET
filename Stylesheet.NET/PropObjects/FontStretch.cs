namespace Stylesheet.NET
{
    /// <summary>
    /// The FontStretch property widens or narrows text. The font used must support condensed and expanded font faces. Many fonts do not support these separate faces.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontStretch =  new FontStretch(...);</c>
    /// <br/>
    /// <c>FontStretch = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontStretch = FontStretchOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontStretch = FontStretch;</c>
    /// <br/>
    /// <c>string cssValue = FontStretch;</c>
    /// <br/>
    /// <c>FontStretchOptions option = FontStretch;</c>
    /// </summary>
    public class FontStretch
    {
        static FontStretchOptions Option = FontStretchOptions.Normal;
        static string Value = "normal";
        public FontStretch(FontStretchOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontStretch(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontStretch(FontStretchOptions option)
        {
            return new FontStretch(option);
        }

        public static implicit operator FontStretch(string value)
        {
            return new FontStretch(value);
        }

        public static implicit operator string(FontStretch conv)
        {
            return Value;
        }

        public static implicit operator FontStretchOptions(FontStretch conv)
        {
            return GetOption(Value);
        }
        string this[FontStretchOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontStretchOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontStretchOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontStretchOptions>(val);
            if (op == null)
                return Option;
            return (FontStretchOptions)op;
        }
    }
}