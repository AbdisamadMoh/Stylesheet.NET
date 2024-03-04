namespace StylesheetNET
{
    /// <summary>
    /// The VerticalAlign property sets the element's vertical alignment. Vertical alignment only affects inline, inline-block, and table-cell boxes. Elements can be aligned at the top, bottom, and some values in between.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>VerticalAlign =  new VerticalAlign(...);</c>
    /// <br/>
    /// <c>VerticalAlign = "your css value(s) here";</c>
    /// <br/>
    /// <c>VerticalAlign = VerticalAlignOptions.Baseline;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_VerticalAlign = VerticalAlign;</c>
    /// <br/>
    /// <c>string cssValue = VerticalAlign;</c>
    /// <br/>
    /// <c>VerticalAlignOptions option = VerticalAlign;</c>
    /// </summary>
    public class VerticalAlign
    {
        static VerticalAlignOptions Option = VerticalAlignOptions.Baseline;
        static string Value = "baseline";
        public VerticalAlign(VerticalAlignOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public VerticalAlign(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator VerticalAlign(VerticalAlignOptions option)
        {
            return new VerticalAlign(option);
        }

        public static implicit operator VerticalAlign(string value)
        {
            return new VerticalAlign(value);
        }

        public static implicit operator string(VerticalAlign conv)
        {
            return Value;
        }

        public static implicit operator VerticalAlignOptions(VerticalAlign conv)
        {
            return GetOption(Value);
        }
        string this[VerticalAlignOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(VerticalAlignOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static VerticalAlignOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<VerticalAlignOptions>(val);
            if (op == null)
                return Option;
            return (VerticalAlignOptions)op;
        }
    }
}