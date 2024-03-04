namespace StylesheetNET
{
    /// <summary>
    /// The FlexGrow property sets the growth factor for a flex item. This setting is relevant when space is left inside a container. FlexGrow sets the growth relative to other items.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexGrow =  new FlexGrow(...);</c>
    /// <br/>
    /// <c>FlexGrow = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexGrow = FlexGrowOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexGrow = FlexGrow;</c>
    /// <br/>
    /// <c>string cssValue = FlexGrow;</c>
    /// <br/>
    /// <c>FlexGrowOptions option = FlexGrow;</c>
    /// </summary>
    public class FlexGrow
    {
        static FlexGrowOptions Option = FlexGrowOptions.Initial;
        static string Value = "initial";
        public FlexGrow(FlexGrowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexGrow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexGrow(FlexGrowOptions option)
        {
            return new FlexGrow(option);
        }

        public static implicit operator FlexGrow(string value)
        {
            return new FlexGrow(value);
        }

        public static implicit operator string(FlexGrow conv)
        {
            return Value;
        }

        public static implicit operator FlexGrowOptions(FlexGrow conv)
        {
            return GetOption(Value);
        }
        string this[FlexGrowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexGrowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexGrowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexGrowOptions>(val);
            if (op == null)
                return Option;
            return (FlexGrowOptions)op;
        }
    }
}