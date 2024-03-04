namespace StylesheetNET
{
    /// <summary>
    /// The FlexBasis property sets the initial width of a flex item. Flex items are elements inside a flex container.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexBasis =  new FlexBasis(...);</c>
    /// <br/>
    /// <c>FlexBasis = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexBasis = FlexBasisOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexBasis = FlexBasis;</c>
    /// <br/>
    /// <c>string cssValue = FlexBasis;</c>
    /// <br/>
    /// <c>FlexBasisOptions option = FlexBasis;</c>
    /// </summary>
    public class FlexBasis
    {
        static FlexBasisOptions Option = FlexBasisOptions.Auto;
        static string Value = "auto";
        public FlexBasis(FlexBasisOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexBasis(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexBasis(FlexBasisOptions option)
        {
            return new FlexBasis(option);
        }

        public static implicit operator FlexBasis(string value)
        {
            return new FlexBasis(value);
        }

        public static implicit operator string(FlexBasis conv)
        {
            return Value;
        }

        public static implicit operator FlexBasisOptions(FlexBasis conv)
        {
            return GetOption(Value);
        }
        string this[FlexBasisOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexBasisOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexBasisOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexBasisOptions>(val);
            if (op == null)
                return Option;
            return (FlexBasisOptions)op;
        }
    }
}