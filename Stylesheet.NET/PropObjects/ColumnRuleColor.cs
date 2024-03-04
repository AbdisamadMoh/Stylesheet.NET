namespace StylesheetNET
{
    /// <summary>
    /// A column rule is a line between columns in a multi-column layout. The ColumnRuleColor property sets the color of this line. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnRuleColor =  new ColumnRuleColor(...);</c>
    /// <br/>
    /// <c>ColumnRuleColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnRuleColor = ColumnRuleColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnRuleColor = ColumnRuleColor;</c>
    /// <br/>
    /// <c>string cssValue = ColumnRuleColor;</c>
    /// <br/>
    /// <c>ColumnRuleColorOptions option = ColumnRuleColor;</c>
    /// </summary>
    public class ColumnRuleColor
    {
        static ColumnRuleColorOptions Option = ColumnRuleColorOptions.Initial;
        static string Value = "initial";
        public ColumnRuleColor(ColumnRuleColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnRuleColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnRuleColor(ColumnRuleColorOptions option)
        {
            return new ColumnRuleColor(option);
        }

        public static implicit operator ColumnRuleColor(string value)
        {
            return new ColumnRuleColor(value);
        }

        public static implicit operator string(ColumnRuleColor conv)
        {
            return Value;
        }

        public static implicit operator ColumnRuleColorOptions(ColumnRuleColor conv)
        {
            return GetOption(Value);
        }
        string this[ColumnRuleColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnRuleColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnRuleColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnRuleColorOptions>(val);
            if (op == null)
                return Option;
            return (ColumnRuleColorOptions)op;
        }
    }
}