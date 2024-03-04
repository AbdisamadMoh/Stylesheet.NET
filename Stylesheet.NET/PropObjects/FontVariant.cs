namespace StylesheetNET
{
    /// <summary>
    /// The FontVariant property displays text in small-caps font. Small caps are uppercase letters, but in a smaller font size.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontVariant =  new FontVariant(...);</c>
    /// <br/>
    /// <c>FontVariant = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontVariant = FontVariantOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontVariant = FontVariant;</c>
    /// <br/>
    /// <c>string cssValue = FontVariant;</c>
    /// <br/>
    /// <c>FontVariantOptions option = FontVariant;</c>
    /// </summary>
    public class FontVariant
    {
        static FontVariantOptions Option = FontVariantOptions.Normal;
        static string Value = "normal";
        public FontVariant(FontVariantOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontVariant(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontVariant(FontVariantOptions option)
        {
            return new FontVariant(option);
        }

        public static implicit operator FontVariant(string value)
        {
            return new FontVariant(value);
        }

        public static implicit operator string(FontVariant conv)
        {
            return Value;
        }

        public static implicit operator FontVariantOptions(FontVariant conv)
        {
            return GetOption(Value);
        }
        string this[FontVariantOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontVariantOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontVariantOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontVariantOptions>(val);
            if (op == null)
                return Option;
            return (FontVariantOptions)op;
        }
    }
}