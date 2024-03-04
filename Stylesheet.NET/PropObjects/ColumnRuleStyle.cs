namespace StylesheetNET
{
    /// <summary>
    /// A column rule is a line between columns in a multi-column layout. The ColumnRuleStyle property sets the style of this line. Possible values include solid, dashed, dotted, double, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnRuleStyle =  new ColumnRuleStyle(...);</c>
    /// <br/>
    /// <c>ColumnRuleStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnRuleStyle = ColumnRuleStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnRuleStyle = ColumnRuleStyle;</c>
    /// <br/>
    /// <c>string cssValue = ColumnRuleStyle;</c>
    /// <br/>
    /// <c>ColumnRuleStyleOptions option = ColumnRuleStyle;</c>
    /// </summary>
    public class ColumnRuleStyle
    {
        static ColumnRuleStyleOptions Option = ColumnRuleStyleOptions.None;
        static string Value = "none";
        public ColumnRuleStyle(ColumnRuleStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnRuleStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnRuleStyle(ColumnRuleStyleOptions option)
        {
            return new ColumnRuleStyle(option);
        }

        public static implicit operator ColumnRuleStyle(string value)
        {
            return new ColumnRuleStyle(value);
        }

        public static implicit operator string(ColumnRuleStyle conv)
        {
            return Value;
        }

        public static implicit operator ColumnRuleStyleOptions(ColumnRuleStyle conv)
        {
            return GetOption(Value);
        }
        string this[ColumnRuleStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnRuleStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnRuleStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnRuleStyleOptions>(val);
            if (op == null)
                return Option;
            return (ColumnRuleStyleOptions)op;
        }
    }
}