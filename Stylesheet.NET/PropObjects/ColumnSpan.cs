namespace StylesheetNET
{
    /// <summary>
    /// The ColumnSpan property enables an element to span across columns. This property is used by headings that span multi-column layouts.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnSpan =  new ColumnSpan(...);</c>
    /// <br/>
    /// <c>ColumnSpan = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnSpan = ColumnSpanOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnSpan = ColumnSpan;</c>
    /// <br/>
    /// <c>string cssValue = ColumnSpan;</c>
    /// <br/>
    /// <c>ColumnSpanOptions option = ColumnSpan;</c>
    /// </summary>
    public class ColumnSpan
    {
        static ColumnSpanOptions Option = ColumnSpanOptions.None;
        static string Value = "none";
        public ColumnSpan(ColumnSpanOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnSpan(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnSpan(ColumnSpanOptions option)
        {
            return new ColumnSpan(option);
        }

        public static implicit operator ColumnSpan(string value)
        {
            return new ColumnSpan(value);
        }

        public static implicit operator string(ColumnSpan conv)
        {
            return Value;
        }

        public static implicit operator ColumnSpanOptions(ColumnSpan conv)
        {
            return GetOption(Value);
        }
        string this[ColumnSpanOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnSpanOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnSpanOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnSpanOptions>(val);
            if (op == null)
                return Option;
            return (ColumnSpanOptions)op;
        }
    }
}