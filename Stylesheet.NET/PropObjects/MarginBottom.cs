namespace StylesheetNET
{
    /// <summary>
    /// Margin is the spacing outside an element. The MarginBottom property specifies the bottom margin of an element.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MarginBottom =  new MarginBottom(...);</c>
    /// <br/>
    /// <c>MarginBottom = "your css value(s) here";</c>
    /// <br/>
    /// <c>MarginBottom = MarginBottomOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MarginBottom = MarginBottom;</c>
    /// <br/>
    /// <c>string cssValue = MarginBottom;</c>
    /// <br/>
    /// <c>MarginBottomOptions option = MarginBottom;</c>
    /// </summary>
    public class MarginBottom
    {
        static MarginBottomOptions Option = MarginBottomOptions.Initial;
        static string Value = "initial";
        public MarginBottom(MarginBottomOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MarginBottom(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MarginBottom(MarginBottomOptions option)
        {
            return new MarginBottom(option);
        }

        public static implicit operator MarginBottom(string value)
        {
            return new MarginBottom(value);
        }

        public static implicit operator string(MarginBottom conv)
        {
            return Value;
        }

        public static implicit operator MarginBottomOptions(MarginBottom conv)
        {
            return GetOption(Value);
        }
        string this[MarginBottomOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MarginBottomOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MarginBottomOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MarginBottomOptions>(val);
            if (op == null)
                return Option;
            return (MarginBottomOptions)op;
        }
    }
}