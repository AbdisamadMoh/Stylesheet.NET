namespace StylesheetNET
{
    /// <summary>
    /// Margin is the spacing outside an element. The Margin property specifies the element‘s Margins.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Margin =  new Margin(...);</c>
    /// <br/>
    /// <c>Margin = "your css value(s) here";</c>
    /// <br/>
    /// <c>Margin = MarginOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Margin = Margin;</c>
    /// <br/>
    /// <c>string cssValue = Margin;</c>
    /// <br/>
    /// <c>MarginOptions option = Margin;</c>
    /// </summary>
    public class Margin
    {
        static MarginOptions Option = MarginOptions.Initial;
        static string Value = "initial";
        public Margin(MarginOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Margin(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Margin(MarginOptions option)
        {
            return new Margin(option);
        }

        public static implicit operator Margin(string value)
        {
            return new Margin(value);
        }

        public static implicit operator string(Margin conv)
        {
            return Value;
        }

        public static implicit operator MarginOptions(Margin conv)
        {
            return GetOption(Value);
        }
        string this[MarginOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MarginOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MarginOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MarginOptions>(val);
            if (op == null)
                return Option;
            return (MarginOptions)op;
        }
    }
}