namespace StylesheetNET
{
    /// <summary>
    /// The MaxHeight property sets the maximum height of an element. It prevents an element from becoming any larger than the specified value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MaxHeight =  new MaxHeight(...);</c>
    /// <br/>
    /// <c>MaxHeight = "your css value(s) here";</c>
    /// <br/>
    /// <c>MaxHeight = MaxHeightOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MaxHeight = MaxHeight;</c>
    /// <br/>
    /// <c>string cssValue = MaxHeight;</c>
    /// <br/>
    /// <c>MaxHeightOptions option = MaxHeight;</c>
    /// </summary>
    public class MaxHeight
    {
        static MaxHeightOptions Option = MaxHeightOptions.None;
        static string Value = "none";
        public MaxHeight(MaxHeightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MaxHeight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MaxHeight(MaxHeightOptions option)
        {
            return new MaxHeight(option);
        }

        public static implicit operator MaxHeight(string value)
        {
            return new MaxHeight(value);
        }

        public static implicit operator string(MaxHeight conv)
        {
            return Value;
        }

        public static implicit operator MaxHeightOptions(MaxHeight conv)
        {
            return GetOption(Value);
        }
        string this[MaxHeightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MaxHeightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MaxHeightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MaxHeightOptions>(val);
            if (op == null)
                return Option;
            return (MaxHeightOptions)op;
        }
    }
}