namespace StylesheetNET
{
    /// <summary>
    /// The FlexWrap property sets how items wrap in a container. By default, flex items do not wrap and are packed in a single row.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexWrap =  new FlexWrap(...);</c>
    /// <br/>
    /// <c>FlexWrap = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexWrap = FlexWrapOptions.Nowrap;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexWrap = FlexWrap;</c>
    /// <br/>
    /// <c>string cssValue = FlexWrap;</c>
    /// <br/>
    /// <c>FlexWrapOptions option = FlexWrap;</c>
    /// </summary>
    public class FlexWrap
    {
        static FlexWrapOptions Option = FlexWrapOptions.Nowrap;
        static string Value = "nowrap";
        public FlexWrap(FlexWrapOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexWrap(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexWrap(FlexWrapOptions option)
        {
            return new FlexWrap(option);
        }

        public static implicit operator FlexWrap(string value)
        {
            return new FlexWrap(value);
        }

        public static implicit operator string(FlexWrap conv)
        {
            return Value;
        }

        public static implicit operator FlexWrapOptions(FlexWrap conv)
        {
            return GetOption(Value);
        }
        string this[FlexWrapOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexWrapOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexWrapOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexWrapOptions>(val);
            if (op == null)
                return Option;
            return (FlexWrapOptions)op;
        }
    }
}