namespace StylesheetNET
{
    /// <summary>
    /// The FontFamily property specifies the font to use for text. The value can be any number of font names. All but the first font are fallback fonts. A fallback will be used if the first font is not supported.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontFamily =  new FontFamily(...);</c>
    /// <br/>
    /// <c>FontFamily = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontFamily = FontFamilyOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontFamily = FontFamily;</c>
    /// <br/>
    /// <c>string cssValue = FontFamily;</c>
    /// <br/>
    /// <c>FontFamilyOptions option = FontFamily;</c>
    /// </summary>
    public class FontFamily
    {
        static FontFamilyOptions Option = FontFamilyOptions.Initial;
        static string Value = "initial";
        public FontFamily(FontFamilyOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontFamily(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontFamily(FontFamilyOptions option)
        {
            return new FontFamily(option);
        }

        public static implicit operator FontFamily(string value)
        {
            return new FontFamily(value);
        }

        public static implicit operator string(FontFamily conv)
        {
            return Value;
        }

        public static implicit operator FontFamilyOptions(FontFamily conv)
        {
            return GetOption(Value);
        }
        string this[FontFamilyOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontFamilyOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontFamilyOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontFamilyOptions>(val);
            if (op == null)
                return Option;
            return (FontFamilyOptions)op;
        }
    }
}