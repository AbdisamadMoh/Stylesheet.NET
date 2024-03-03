namespace Stylesheet.NET
{
    /// <summary>
    /// The MaxWidth property sets the maximum width of an element. It prevents an element from becoming any larger than the specified value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MaxWidth =  new MaxWidth(...);</c>
    /// <br/>
    /// <c>MaxWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>MaxWidth = MaxWidthOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MaxWidth = MaxWidth;</c>
    /// <br/>
    /// <c>string cssValue = MaxWidth;</c>
    /// <br/>
    /// <c>MaxWidthOptions option = MaxWidth;</c>
    /// </summary>
    public class MaxWidth
    {
        static MaxWidthOptions Option = MaxWidthOptions.None;
        static string Value = "none";
        public MaxWidth(MaxWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MaxWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MaxWidth(MaxWidthOptions option)
        {
            return new MaxWidth(option);
        }

        public static implicit operator MaxWidth(string value)
        {
            return new MaxWidth(value);
        }

        public static implicit operator string(MaxWidth conv)
        {
            return Value;
        }

        public static implicit operator MaxWidthOptions(MaxWidth conv)
        {
            return GetOption(Value);
        }
        string this[MaxWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MaxWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MaxWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MaxWidthOptions>(val);
            if (op == null)
                return Option;
            return (MaxWidthOptions)op;
        }
    }
}