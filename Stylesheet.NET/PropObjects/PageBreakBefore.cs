namespace Stylesheet.NET
{
    /// <summary>
    /// The PageBreakBefore property adds a page-break before an element. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty <div> elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PageBreakBefore =  new PageBreakBefore(...);</c>
    /// <br/>
    /// <c>PageBreakBefore = "your css value(s) here";</c>
    /// <br/>
    /// <c>PageBreakBefore = PageBreakBeforeOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PageBreakBefore = PageBreakBefore;</c>
    /// <br/>
    /// <c>string cssValue = PageBreakBefore;</c>
    /// <br/>
    /// <c>PageBreakBeforeOptions option = PageBreakBefore;</c>
    /// </summary>
    public class PageBreakBefore
    {
        static PageBreakBeforeOptions Option = PageBreakBeforeOptions.Auto;
        static string Value = "auto";
        public PageBreakBefore(PageBreakBeforeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PageBreakBefore(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PageBreakBefore(PageBreakBeforeOptions option)
        {
            return new PageBreakBefore(option);
        }

        public static implicit operator PageBreakBefore(string value)
        {
            return new PageBreakBefore(value);
        }

        public static implicit operator string(PageBreakBefore conv)
        {
            return Value;
        }

        public static implicit operator PageBreakBeforeOptions(PageBreakBefore conv)
        {
            return GetOption(Value);
        }
        string this[PageBreakBeforeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PageBreakBeforeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PageBreakBeforeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PageBreakBeforeOptions>(val);
            if (op == null)
                return Option;
            return (PageBreakBeforeOptions)op;
        }
    }
}