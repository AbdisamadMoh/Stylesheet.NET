namespace Stylesheet.NET
{
    /// <summary>
    /// Margin is the spacing outside an element. The MarginLeft property specifies the left margin of an element.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MarginLeft =  new MarginLeft(...);</c>
    /// <br/>
    /// <c>MarginLeft = "your css value(s) here";</c>
    /// <br/>
    /// <c>MarginLeft = MarginLeftOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MarginLeft = MarginLeft;</c>
    /// <br/>
    /// <c>string cssValue = MarginLeft;</c>
    /// <br/>
    /// <c>MarginLeftOptions option = MarginLeft;</c>
    /// </summary>
    public class MarginLeft
    {
        static MarginLeftOptions Option = MarginLeftOptions.Initial;
        static string Value = "initial";
        public MarginLeft(MarginLeftOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MarginLeft(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MarginLeft(MarginLeftOptions option)
        {
            return new MarginLeft(option);
        }

        public static implicit operator MarginLeft(string value)
        {
            return new MarginLeft(value);
        }

        public static implicit operator string(MarginLeft conv)
        {
            return Value;
        }

        public static implicit operator MarginLeftOptions(MarginLeft conv)
        {
            return GetOption(Value);
        }
        string this[MarginLeftOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MarginLeftOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MarginLeftOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MarginLeftOptions>(val);
            if (op == null)
                return Option;
            return (MarginLeftOptions)op;
        }
    }
}