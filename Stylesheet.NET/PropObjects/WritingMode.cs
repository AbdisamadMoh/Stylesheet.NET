namespace Stylesheet.NET
{
    /// <summary>
    /// The WritingMode property writes text horizontally or vertically. This is important for languages where text flows vertically (Chinese, Korean, etc.). For other languages WritingMode can help with page design.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>WritingMode =  new WritingMode(...);</c>
    /// <br/>
    /// <c>WritingMode = "your css value(s) here";</c>
    /// <br/>
    /// <c>WritingMode = WritingModeOptions.HorizontalTb;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_WritingMode = WritingMode;</c>
    /// <br/>
    /// <c>string cssValue = WritingMode;</c>
    /// <br/>
    /// <c>WritingModeOptions option = WritingMode;</c>
    /// </summary>
    public class WritingMode
    {
        static WritingModeOptions Option = WritingModeOptions.HorizontalTb;
        static string Value = "horizontal-tb";
        public WritingMode(WritingModeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public WritingMode(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator WritingMode(WritingModeOptions option)
        {
            return new WritingMode(option);
        }

        public static implicit operator WritingMode(string value)
        {
            return new WritingMode(value);
        }

        public static implicit operator string(WritingMode conv)
        {
            return Value;
        }

        public static implicit operator WritingModeOptions(WritingMode conv)
        {
            return GetOption(Value);
        }
        string this[WritingModeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WritingModeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WritingModeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WritingModeOptions>(val);
            if (op == null)
                return Option;
            return (WritingModeOptions)op;
        }
    }
}