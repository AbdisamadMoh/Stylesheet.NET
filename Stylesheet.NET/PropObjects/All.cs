namespace StylesheetNET
{
    /// <summary>
    /// The All property resets all element properties. Their values are reset to their default or inherited values. This property is used to reset styles and start with a clean slate.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>All =  new All(...);</c>
    /// <br/>
    /// <c>All = "your css value(s) here";</c>
    /// <br/>
    /// <c>All = AllOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_All = All;</c>
    /// <br/>
    /// <c>string cssValue = All;</c>
    /// <br/>
    /// <c>AllOptions option = All;</c>
    /// </summary>
    public class All
    {
        static AllOptions Option = AllOptions.Initial;
        static string Value = "initial";
        public All(AllOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public All(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator All(AllOptions option)
        {
            return new All(option);
        }

        public static implicit operator All(string value)
        {
            return new All(value);
        }

        public static implicit operator string(All conv)
        {
            return Value;
        }

        public static implicit operator AllOptions(All conv)
        {
            return GetOption(Value);
        }
        string this[AllOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AllOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AllOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AllOptions>(val);
            if (op == null)
                return Option;
            return (AllOptions)op;
        }
    }
}