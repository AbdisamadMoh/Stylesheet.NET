namespace StylesheetNET
{
    /// <summary>
    /// The page-break-before property adds a page-break after an element. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty <div> elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PageBreakAfter =  new PageBreakAfter(...);</c>
    /// <br/>
    /// <c>PageBreakAfter = "your css value(s) here";</c>
    /// <br/>
    /// <c>PageBreakAfter = PageBreakAfterOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PageBreakAfter = PageBreakAfter;</c>
    /// <br/>
    /// <c>string cssValue = PageBreakAfter;</c>
    /// <br/>
    /// <c>PageBreakAfterOptions option = PageBreakAfter;</c>
    /// </summary>
    public class PageBreakAfter
    {
        static PageBreakAfterOptions Option = PageBreakAfterOptions.Auto;
        static string Value = "auto";
        public PageBreakAfter(PageBreakAfterOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PageBreakAfter(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PageBreakAfter(PageBreakAfterOptions option)
        {
            return new PageBreakAfter(option);
        }

        public static implicit operator PageBreakAfter(string value)
        {
            return new PageBreakAfter(value);
        }

        public static implicit operator string(PageBreakAfter conv)
        {
            return Value;
        }

        public static implicit operator PageBreakAfterOptions(PageBreakAfter conv)
        {
            return GetOption(Value);
        }
        string this[PageBreakAfterOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PageBreakAfterOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PageBreakAfterOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PageBreakAfterOptions>(val);
            if (op == null)
                return Option;
            return (PageBreakAfterOptions)op;
        }
    }
}