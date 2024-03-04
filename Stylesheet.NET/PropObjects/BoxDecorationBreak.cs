namespace StylesheetNET
{
    /// <summary>
    /// A BoxDecorationBreak sets the style of element fragments. Fragments are the pieces that occur when an in-line element does not fit inside its container and needs to wrap.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BoxDecorationBreak =  new BoxDecorationBreak(...);</c>
    /// <br/>
    /// <c>BoxDecorationBreak = "your css value(s) here";</c>
    /// <br/>
    /// <c>BoxDecorationBreak = BoxDecorationBreakOptions.Slice;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BoxDecorationBreak = BoxDecorationBreak;</c>
    /// <br/>
    /// <c>string cssValue = BoxDecorationBreak;</c>
    /// <br/>
    /// <c>BoxDecorationBreakOptions option = BoxDecorationBreak;</c>
    /// </summary>
    public class BoxDecorationBreak
    {
        static BoxDecorationBreakOptions Option = BoxDecorationBreakOptions.Slice;
        static string Value = "slice";
        public BoxDecorationBreak(BoxDecorationBreakOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BoxDecorationBreak(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BoxDecorationBreak(BoxDecorationBreakOptions option)
        {
            return new BoxDecorationBreak(option);
        }

        public static implicit operator BoxDecorationBreak(string value)
        {
            return new BoxDecorationBreak(value);
        }

        public static implicit operator string(BoxDecorationBreak conv)
        {
            return Value;
        }

        public static implicit operator BoxDecorationBreakOptions(BoxDecorationBreak conv)
        {
            return GetOption(Value);
        }
        string this[BoxDecorationBreakOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BoxDecorationBreakOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BoxDecorationBreakOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BoxDecorationBreakOptions>(val);
            if (op == null)
                return Option;
            return (BoxDecorationBreakOptions)op;
        }
    }
}