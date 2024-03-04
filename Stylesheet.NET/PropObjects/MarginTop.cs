namespace StylesheetNET
{
    /// <summary>
    /// Margin is spacing added to the outside of an element. The MarginTop property specifies the top margin of an element.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MarginTop =  new MarginTop(...);</c>
    /// <br/>
    /// <c>MarginTop = "your css value(s) here";</c>
    /// <br/>
    /// <c>MarginTop = MarginTopOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MarginTop = MarginTop;</c>
    /// <br/>
    /// <c>string cssValue = MarginTop;</c>
    /// <br/>
    /// <c>MarginTopOptions option = MarginTop;</c>
    /// </summary>
    public class MarginTop
    {
        static MarginTopOptions Option = MarginTopOptions.Initial;
        static string Value = "initial";
        public MarginTop(MarginTopOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MarginTop(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MarginTop(MarginTopOptions option)
        {
            return new MarginTop(option);
        }

        public static implicit operator MarginTop(string value)
        {
            return new MarginTop(value);
        }

        public static implicit operator string(MarginTop conv)
        {
            return Value;
        }

        public static implicit operator MarginTopOptions(MarginTop conv)
        {
            return GetOption(Value);
        }
        string this[MarginTopOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MarginTopOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MarginTopOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MarginTopOptions>(val);
            if (op == null)
                return Option;
            return (MarginTopOptions)op;
        }
    }
}