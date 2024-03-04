namespace StylesheetNET
{
    /// <summary>
    /// A column rule is a line between columns in a multi-column layout. The ColumnRuleWidth property sets the width of this line. If no value is specified, it uses medium or 1px column width.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnRuleWidth =  new ColumnRuleWidth(...);</c>
    /// <br/>
    /// <c>ColumnRuleWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnRuleWidth = ColumnRuleWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnRuleWidth = ColumnRuleWidth;</c>
    /// <br/>
    /// <c>string cssValue = ColumnRuleWidth;</c>
    /// <br/>
    /// <c>ColumnRuleWidthOptions option = ColumnRuleWidth;</c>
    /// </summary>
    public class ColumnRuleWidth
    {
        static ColumnRuleWidthOptions Option = ColumnRuleWidthOptions.Medium;
        static string Value = "medium";
        public ColumnRuleWidth(ColumnRuleWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnRuleWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnRuleWidth(ColumnRuleWidthOptions option)
        {
            return new ColumnRuleWidth(option);
        }

        public static implicit operator ColumnRuleWidth(string value)
        {
            return new ColumnRuleWidth(value);
        }

        public static implicit operator string(ColumnRuleWidth conv)
        {
            return Value;
        }

        public static implicit operator ColumnRuleWidthOptions(ColumnRuleWidth conv)
        {
            return GetOption(Value);
        }
        string this[ColumnRuleWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnRuleWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnRuleWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnRuleWidthOptions>(val);
            if (op == null)
                return Option;
            return (ColumnRuleWidthOptions)op;
        }
    }
}