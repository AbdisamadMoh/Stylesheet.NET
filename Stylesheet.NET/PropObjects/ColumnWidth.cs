namespace Stylesheet.NET
{
    /// <summary>
    /// The ColumnWidth property sets the minimum width of a column. The browser then calculates the number of columns to fit the element. If the value exceeds the element width, a single column is rendered.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnWidth =  new ColumnWidth(...);</c>
    /// <br/>
    /// <c>ColumnWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnWidth = ColumnWidthOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnWidth = ColumnWidth;</c>
    /// <br/>
    /// <c>string cssValue = ColumnWidth;</c>
    /// <br/>
    /// <c>ColumnWidthOptions option = ColumnWidth;</c>
    /// </summary>
    public class ColumnWidth
    {
        static ColumnWidthOptions Option = ColumnWidthOptions.Auto;
        static string Value = "auto";
        public ColumnWidth(ColumnWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnWidth(ColumnWidthOptions option)
        {
            return new ColumnWidth(option);
        }

        public static implicit operator ColumnWidth(string value)
        {
            return new ColumnWidth(value);
        }

        public static implicit operator string(ColumnWidth conv)
        {
            return Value;
        }

        public static implicit operator ColumnWidthOptions(ColumnWidth conv)
        {
            return GetOption(Value);
        }
        string this[ColumnWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnWidthOptions>(val);
            if (op == null)
                return Option;
            return (ColumnWidthOptions)op;
        }
    }
}