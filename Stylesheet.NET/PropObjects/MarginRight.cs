namespace StylesheetNET
{
    /// <summary>
    /// Margin is the spacing outside an element. The MarginRight property specifies the right margin of an element.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MarginRight =  new MarginRight(...);</c>
    /// <br/>
    /// <c>MarginRight = "your css value(s) here";</c>
    /// <br/>
    /// <c>MarginRight = MarginRightOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MarginRight = MarginRight;</c>
    /// <br/>
    /// <c>string cssValue = MarginRight;</c>
    /// <br/>
    /// <c>MarginRightOptions option = MarginRight;</c>
    /// </summary>
    public class MarginRight
    {
        static MarginRightOptions Option = MarginRightOptions.Initial;
        static string Value = "initial";
        public MarginRight(MarginRightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MarginRight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MarginRight(MarginRightOptions option)
        {
            return new MarginRight(option);
        }

        public static implicit operator MarginRight(string value)
        {
            return new MarginRight(value);
        }

        public static implicit operator string(MarginRight conv)
        {
            return Value;
        }

        public static implicit operator MarginRightOptions(MarginRight conv)
        {
            return GetOption(Value);
        }
        string this[MarginRightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MarginRightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MarginRightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MarginRightOptions>(val);
            if (op == null)
                return Option;
            return (MarginRightOptions)op;
        }
    }
}