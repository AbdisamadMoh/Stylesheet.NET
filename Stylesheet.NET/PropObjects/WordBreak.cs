namespace Stylesheet.NET
{
    /// <summary>
    /// The WordBreak property sets how words break at the end of a line. By default, a line of text only breaks at a space or a hyphen position. To insert hyphens (-) at the end of a break, add the hyphens property.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>WordBreak =  new WordBreak(...);</c>
    /// <br/>
    /// <c>WordBreak = "your css value(s) here";</c>
    /// <br/>
    /// <c>WordBreak = WordBreakOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_WordBreak = WordBreak;</c>
    /// <br/>
    /// <c>string cssValue = WordBreak;</c>
    /// <br/>
    /// <c>WordBreakOptions option = WordBreak;</c>
    /// </summary>
    public class WordBreak
    {
        static WordBreakOptions Option = WordBreakOptions.Normal;
        static string Value = "normal";
        public WordBreak(WordBreakOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public WordBreak(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator WordBreak(WordBreakOptions option)
        {
            return new WordBreak(option);
        }

        public static implicit operator WordBreak(string value)
        {
            return new WordBreak(value);
        }

        public static implicit operator string(WordBreak conv)
        {
            return Value;
        }

        public static implicit operator WordBreakOptions(WordBreak conv)
        {
            return GetOption(Value);
        }
        string this[WordBreakOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WordBreakOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WordBreakOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WordBreakOptions>(val);
            if (op == null)
                return Option;
            return (WordBreakOptions)op;
        }
    }
}