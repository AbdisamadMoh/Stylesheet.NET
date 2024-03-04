namespace StylesheetNET
{
    /// <summary>
    /// The MinWidth property sets the minimum width of an element. It prevents an element from becoming any smaller than the specified value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MinWidth =  new MinWidth(...);</c>
    /// <br/>
    /// <c>MinWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>MinWidth = MinWidthOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MinWidth = MinWidth;</c>
    /// <br/>
    /// <c>string cssValue = MinWidth;</c>
    /// <br/>
    /// <c>MinWidthOptions option = MinWidth;</c>
    /// </summary>
    public class MinWidth
    {
        static MinWidthOptions Option = MinWidthOptions.Initial;
        static string Value = "initial";
        public MinWidth(MinWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MinWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MinWidth(MinWidthOptions option)
        {
            return new MinWidth(option);
        }

        public static implicit operator MinWidth(string value)
        {
            return new MinWidth(value);
        }

        public static implicit operator string(MinWidth conv)
        {
            return Value;
        }

        public static implicit operator MinWidthOptions(MinWidth conv)
        {
            return GetOption(Value);
        }
        string this[MinWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MinWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MinWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MinWidthOptions>(val);
            if (op == null)
                return Option;
            return (MinWidthOptions)op;
        }
    }
}