namespace StylesheetNET
{
    /// <summary>
    /// The Font property specifies several Font styling settings. These include Font, color, height, style, weight, and more.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Font =  new Font(...);</c>
    /// <br/>
    /// <c>Font = "your css value(s) here";</c>
    /// <br/>
    /// <c>Font = FontOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Font = Font;</c>
    /// <br/>
    /// <c>string cssValue = Font;</c>
    /// <br/>
    /// <c>FontOptions option = Font;</c>
    /// </summary>
    public class Font
    {
        static FontOptions Option = FontOptions.Initial;
        static string Value = "initial";
        public Font(FontOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Font(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Font(FontOptions option)
        {
            return new Font(option);
        }

        public static implicit operator Font(string value)
        {
            return new Font(value);
        }

        public static implicit operator string(Font conv)
        {
            return Value;
        }

        public static implicit operator FontOptions(Font conv)
        {
            return GetOption(Value);
        }
        string this[FontOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontOptions>(val);
            if (op == null)
                return Option;
            return (FontOptions)op;
        }
    }
}