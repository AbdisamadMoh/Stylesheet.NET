namespace Stylesheet.NET
{
    /// <summary>
    /// The CounterIncrement property increases a CSS counter value. This property works with counter-reset and content properties.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>CounterIncrement =  new CounterIncrement(...);</c>
    /// <br/>
    /// <c>CounterIncrement = "your css value(s) here";</c>
    /// <br/>
    /// <c>CounterIncrement = CounterIncrementOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_CounterIncrement = CounterIncrement;</c>
    /// <br/>
    /// <c>string cssValue = CounterIncrement;</c>
    /// <br/>
    /// <c>CounterIncrementOptions option = CounterIncrement;</c>
    /// </summary>
    public class CounterIncrement
    {
        static CounterIncrementOptions Option = CounterIncrementOptions.None;
        static string Value = "none";
        public CounterIncrement(CounterIncrementOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public CounterIncrement(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator CounterIncrement(CounterIncrementOptions option)
        {
            return new CounterIncrement(option);
        }

        public static implicit operator CounterIncrement(string value)
        {
            return new CounterIncrement(value);
        }

        public static implicit operator string(CounterIncrement conv)
        {
            return Value;
        }

        public static implicit operator CounterIncrementOptions(CounterIncrement conv)
        {
            return GetOption(Value);
        }
        string this[CounterIncrementOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(CounterIncrementOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static CounterIncrementOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<CounterIncrementOptions>(val);
            if (op == null)
                return Option;
            return (CounterIncrementOptions)op;
        }
    }
}