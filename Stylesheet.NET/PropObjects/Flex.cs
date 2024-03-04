namespace StylesheetNET
{
    /// <summary>
    /// The Flex property is a shorthand for 3 Flex item properties: They are: Flex-grow, Flex-shrink, and Flex-basis. This property is commonly used to create responsive layouts.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Flex =  new Flex(...);</c>
    /// <br/>
    /// <c>Flex = "your css value(s) here";</c>
    /// <br/>
    /// <c>Flex = FlexOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Flex = Flex;</c>
    /// <br/>
    /// <c>string cssValue = Flex;</c>
    /// <br/>
    /// <c>FlexOptions option = Flex;</c>
    /// </summary>
    public class Flex
    {
        static FlexOptions Option = FlexOptions.Initial;
        static string Value = "initial";
        public Flex(FlexOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Flex(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Flex(FlexOptions option)
        {
            return new Flex(option);
        }

        public static implicit operator Flex(string value)
        {
            return new Flex(value);
        }

        public static implicit operator string(Flex conv)
        {
            return Value;
        }

        public static implicit operator FlexOptions(Flex conv)
        {
            return GetOption(Value);
        }
        string this[FlexOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexOptions>(val);
            if (op == null)
                return Option;
            return (FlexOptions)op;
        }
    }
}