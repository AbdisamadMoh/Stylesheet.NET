namespace StylesheetNET
{
    /// <summary>
    /// The WordSpacing property specifies the spacing between words. This property accepts any CSS length value, such as, px, %, em, and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>WordSpacing =  new WordSpacing(...);</c>
    /// <br/>
    /// <c>WordSpacing = "your css value(s) here";</c>
    /// <br/>
    /// <c>WordSpacing = WordSpacingOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_WordSpacing = WordSpacing;</c>
    /// <br/>
    /// <c>string cssValue = WordSpacing;</c>
    /// <br/>
    /// <c>WordSpacingOptions option = WordSpacing;</c>
    /// </summary>
    public class WordSpacing
    {
        static WordSpacingOptions Option = WordSpacingOptions.Normal;
        static string Value = "normal";
        public WordSpacing(WordSpacingOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public WordSpacing(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator WordSpacing(WordSpacingOptions option)
        {
            return new WordSpacing(option);
        }

        public static implicit operator WordSpacing(string value)
        {
            return new WordSpacing(value);
        }

        public static implicit operator string(WordSpacing conv)
        {
            return Value;
        }

        public static implicit operator WordSpacingOptions(WordSpacing conv)
        {
            return GetOption(Value);
        }
        string this[WordSpacingOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WordSpacingOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WordSpacingOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WordSpacingOptions>(val);
            if (op == null)
                return Option;
            return (WordSpacingOptions)op;
        }
    }
}