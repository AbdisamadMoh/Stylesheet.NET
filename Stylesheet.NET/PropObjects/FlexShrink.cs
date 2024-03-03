namespace Stylesheet.NET
{
    /// <summary>
    /// The FlexShrink property sets the shrink factor for a flex item. This is relevant when items do not fit inside a container. FlexShrink sets the shrinkage relative to other items.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexShrink =  new FlexShrink(...);</c>
    /// <br/>
    /// <c>FlexShrink = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexShrink = FlexShrinkOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexShrink = FlexShrink;</c>
    /// <br/>
    /// <c>string cssValue = FlexShrink;</c>
    /// <br/>
    /// <c>FlexShrinkOptions option = FlexShrink;</c>
    /// </summary>
    public class FlexShrink
    {
        static FlexShrinkOptions Option = FlexShrinkOptions.Initial;
        static string Value = "initial";
        public FlexShrink(FlexShrinkOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexShrink(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexShrink(FlexShrinkOptions option)
        {
            return new FlexShrink(option);
        }

        public static implicit operator FlexShrink(string value)
        {
            return new FlexShrink(value);
        }

        public static implicit operator string(FlexShrink conv)
        {
            return Value;
        }

        public static implicit operator FlexShrinkOptions(FlexShrink conv)
        {
            return GetOption(Value);
        }
        string this[FlexShrinkOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexShrinkOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexShrinkOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexShrinkOptions>(val);
            if (op == null)
                return Option;
            return (FlexShrinkOptions)op;
        }
    }
}