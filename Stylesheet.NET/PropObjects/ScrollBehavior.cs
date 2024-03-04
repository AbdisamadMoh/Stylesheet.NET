namespace StylesheetNET
{
    /// <summary>
    /// The ScrollBehavior property sets the scroll animation style. Scrolling can be instant, or it can be an animated scroll to the target. Not all browser support this property.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ScrollBehavior =  new ScrollBehavior(...);</c>
    /// <br/>
    /// <c>ScrollBehavior = "your css value(s) here";</c>
    /// <br/>
    /// <c>ScrollBehavior = ScrollBehaviorOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ScrollBehavior = ScrollBehavior;</c>
    /// <br/>
    /// <c>string cssValue = ScrollBehavior;</c>
    /// <br/>
    /// <c>ScrollBehaviorOptions option = ScrollBehavior;</c>
    /// </summary>
    public class ScrollBehavior
    {
        static ScrollBehaviorOptions Option = ScrollBehaviorOptions.Auto;
        static string Value = "auto";
        public ScrollBehavior(ScrollBehaviorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ScrollBehavior(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ScrollBehavior(ScrollBehaviorOptions option)
        {
            return new ScrollBehavior(option);
        }

        public static implicit operator ScrollBehavior(string value)
        {
            return new ScrollBehavior(value);
        }

        public static implicit operator string(ScrollBehavior conv)
        {
            return Value;
        }

        public static implicit operator ScrollBehaviorOptions(ScrollBehavior conv)
        {
            return GetOption(Value);
        }
        string this[ScrollBehaviorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ScrollBehaviorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ScrollBehaviorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ScrollBehaviorOptions>(val);
            if (op == null)
                return Option;
            return (ScrollBehaviorOptions)op;
        }
    }
}