namespace StylesheetNET
{
    /// <summary>
    /// Kerning is the spacing between letters. It's part of the font file. It can make text easier and more pleasing to read. The FontKerning property enables kerning.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontKerning =  new FontKerning(...);</c>
    /// <br/>
    /// <c>FontKerning = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontKerning = FontKerningOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontKerning = FontKerning;</c>
    /// <br/>
    /// <c>string cssValue = FontKerning;</c>
    /// <br/>
    /// <c>FontKerningOptions option = FontKerning;</c>
    /// </summary>
    public class FontKerning
    {
        static FontKerningOptions Option = FontKerningOptions.Auto;
        static string Value = "auto";
        public FontKerning(FontKerningOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontKerning(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontKerning(FontKerningOptions option)
        {
            return new FontKerning(option);
        }

        public static implicit operator FontKerning(string value)
        {
            return new FontKerning(value);
        }

        public static implicit operator string(FontKerning conv)
        {
            return Value;
        }

        public static implicit operator FontKerningOptions(FontKerning conv)
        {
            return GetOption(Value);
        }
        string this[FontKerningOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontKerningOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontKerningOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontKerningOptions>(val);
            if (op == null)
                return Option;
            return (FontKerningOptions)op;
        }
    }
}