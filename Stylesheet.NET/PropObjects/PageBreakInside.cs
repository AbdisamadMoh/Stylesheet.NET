namespace Stylesheet.NET
{
    /// <summary>
    /// The PageBreakInside property specifies whether to avoid page-breaks. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty <div> elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PageBreakInside =  new PageBreakInside(...);</c>
    /// <br/>
    /// <c>PageBreakInside = "your css value(s) here";</c>
    /// <br/>
    /// <c>PageBreakInside = PageBreakInsideOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PageBreakInside = PageBreakInside;</c>
    /// <br/>
    /// <c>string cssValue = PageBreakInside;</c>
    /// <br/>
    /// <c>PageBreakInsideOptions option = PageBreakInside;</c>
    /// </summary>
    public class PageBreakInside
    {
        static PageBreakInsideOptions Option = PageBreakInsideOptions.Auto;
        static string Value = "auto";
        public PageBreakInside(PageBreakInsideOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PageBreakInside(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PageBreakInside(PageBreakInsideOptions option)
        {
            return new PageBreakInside(option);
        }

        public static implicit operator PageBreakInside(string value)
        {
            return new PageBreakInside(value);
        }

        public static implicit operator string(PageBreakInside conv)
        {
            return Value;
        }

        public static implicit operator PageBreakInsideOptions(PageBreakInside conv)
        {
            return GetOption(Value);
        }
        string this[PageBreakInsideOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PageBreakInsideOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PageBreakInsideOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PageBreakInsideOptions>(val);
            if (op == null)
                return Option;
            return (PageBreakInsideOptions)op;
        }
    }
}