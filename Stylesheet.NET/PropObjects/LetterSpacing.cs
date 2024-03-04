namespace StylesheetNET
{
    /// <summary>
    /// LetterSpacing specifies the spacing between text characters. This property accepts any length value, such as, px, pt, em, etc. Both positive and negative values are allowed.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>LetterSpacing =  new LetterSpacing(...);</c>
    /// <br/>
    /// <c>LetterSpacing = "your css value(s) here";</c>
    /// <br/>
    /// <c>LetterSpacing = LetterSpacingOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_LetterSpacing = LetterSpacing;</c>
    /// <br/>
    /// <c>string cssValue = LetterSpacing;</c>
    /// <br/>
    /// <c>LetterSpacingOptions option = LetterSpacing;</c>
    /// </summary>
    public class LetterSpacing
    {
        static LetterSpacingOptions Option = LetterSpacingOptions.Normal;
        static string Value = "normal";
        public LetterSpacing(LetterSpacingOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public LetterSpacing(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator LetterSpacing(LetterSpacingOptions option)
        {
            return new LetterSpacing(option);
        }

        public static implicit operator LetterSpacing(string value)
        {
            return new LetterSpacing(value);
        }

        public static implicit operator string(LetterSpacing conv)
        {
            return Value;
        }

        public static implicit operator LetterSpacingOptions(LetterSpacing conv)
        {
            return GetOption(Value);
        }
        string this[LetterSpacingOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(LetterSpacingOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static LetterSpacingOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<LetterSpacingOptions>(val);
            if (op == null)
                return Option;
            return (LetterSpacingOptions)op;
        }
    }
}