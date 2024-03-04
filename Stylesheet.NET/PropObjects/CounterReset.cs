namespace StylesheetNET
{
    /// <summary>
    /// A counter is an incrementing variable that can be used in CSS. The CounterReset property resets a CSS counter value. This property works together with counter-increment and content.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>CounterReset =  new CounterReset(...);</c>
    /// <br/>
    /// <c>CounterReset = "your css value(s) here";</c>
    /// <br/>
    /// <c>CounterReset = CounterResetOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_CounterReset = CounterReset;</c>
    /// <br/>
    /// <c>string cssValue = CounterReset;</c>
    /// <br/>
    /// <c>CounterResetOptions option = CounterReset;</c>
    /// </summary>
    public class CounterReset
    {
        static CounterResetOptions Option = CounterResetOptions.None;
        static string Value = "none";
        public CounterReset(CounterResetOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public CounterReset(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator CounterReset(CounterResetOptions option)
        {
            return new CounterReset(option);
        }

        public static implicit operator CounterReset(string value)
        {
            return new CounterReset(value);
        }

        public static implicit operator string(CounterReset conv)
        {
            return Value;
        }

        public static implicit operator CounterResetOptions(CounterReset conv)
        {
            return GetOption(Value);
        }
        string this[CounterResetOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(CounterResetOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static CounterResetOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<CounterResetOptions>(val);
            if (op == null)
                return Option;
            return (CounterResetOptions)op;
        }
    }
}