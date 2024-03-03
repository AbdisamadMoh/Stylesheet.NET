namespace Stylesheet.NET
{
    /// <summary>
    /// The FlexFlow property is a shortcut for two flex properties. They are flex-direction and flex-wrap.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexFlow =  new FlexFlow(...);</c>
    /// <br/>
    /// <c>FlexFlow = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexFlow = FlexFlowOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexFlow = FlexFlow;</c>
    /// <br/>
    /// <c>string cssValue = FlexFlow;</c>
    /// <br/>
    /// <c>FlexFlowOptions option = FlexFlow;</c>
    /// </summary>
    public class FlexFlow
    {
        static FlexFlowOptions Option = FlexFlowOptions.Initial;
        static string Value = "initial";
        public FlexFlow(FlexFlowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexFlow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexFlow(FlexFlowOptions option)
        {
            return new FlexFlow(option);
        }

        public static implicit operator FlexFlow(string value)
        {
            return new FlexFlow(value);
        }

        public static implicit operator string(FlexFlow conv)
        {
            return Value;
        }

        public static implicit operator FlexFlowOptions(FlexFlow conv)
        {
            return GetOption(Value);
        }
        string this[FlexFlowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexFlowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexFlowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexFlowOptions>(val);
            if (op == null)
                return Option;
            return (FlexFlowOptions)op;
        }
    }
}