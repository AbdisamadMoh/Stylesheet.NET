namespace StylesheetNET
{
    /// <summary>
    /// A column rule is a line between columns in a multi-column layout. The ColumnRule property is a shorthand property that specifies the style, width, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnRule =  new ColumnRule(...);</c>
    /// <br/>
    /// <c>ColumnRule = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnRule = ColumnRuleOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnRule = ColumnRule;</c>
    /// <br/>
    /// <c>string cssValue = ColumnRule;</c>
    /// <br/>
    /// <c>ColumnRuleOptions option = ColumnRule;</c>
    /// </summary>
    public class ColumnRule
    {
        static ColumnRuleOptions Option = ColumnRuleOptions.Initial;
        static string Value = "initial";
        public ColumnRule(ColumnRuleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnRule(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnRule(ColumnRuleOptions option)
        {
            return new ColumnRule(option);
        }

        public static implicit operator ColumnRule(string value)
        {
            return new ColumnRule(value);
        }

        public static implicit operator string(ColumnRule conv)
        {
            return Value;
        }

        public static implicit operator ColumnRuleOptions(ColumnRule conv)
        {
            return GetOption(Value);
        }
        string this[ColumnRuleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnRuleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnRuleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnRuleOptions>(val);
            if (op == null)
                return Option;
            return (ColumnRuleOptions)op;
        }
    }
}