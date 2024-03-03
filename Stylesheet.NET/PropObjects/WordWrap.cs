namespace Stylesheet.NET
{
    /// <summary>
    /// When a word does not fit its container it wraps onto the next line. The WordWrap property specifies how words break and wrap. It does not specify where the break occurs; for that you use <wbr>.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>WordWrap =  new WordWrap(...);</c>
    /// <br/>
    /// <c>WordWrap = "your css value(s) here";</c>
    /// <br/>
    /// <c>WordWrap = WordWrapOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_WordWrap = WordWrap;</c>
    /// <br/>
    /// <c>string cssValue = WordWrap;</c>
    /// <br/>
    /// <c>WordWrapOptions option = WordWrap;</c>
    /// </summary>
    public class WordWrap
    {
        static WordWrapOptions Option = WordWrapOptions.Normal;
        static string Value = "normal";
        public WordWrap(WordWrapOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public WordWrap(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator WordWrap(WordWrapOptions option)
        {
            return new WordWrap(option);
        }

        public static implicit operator WordWrap(string value)
        {
            return new WordWrap(value);
        }

        public static implicit operator string(WordWrap conv)
        {
            return Value;
        }

        public static implicit operator WordWrapOptions(WordWrap conv)
        {
            return GetOption(Value);
        }
        string this[WordWrapOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WordWrapOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WordWrapOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WordWrapOptions>(val);
            if (op == null)
                return Option;
            return (WordWrapOptions)op;
        }
    }
}