namespace Stylesheet.NET
{
    /// <summary>
    /// The ColumnGap property specifies the space between columns. The gap value can be any length value, including percentages. This property is used by column, flexbox and grid layout systems.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnGap =  new ColumnGap(...);</c>
    /// <br/>
    /// <c>ColumnGap = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnGap = ColumnGapOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnGap = ColumnGap;</c>
    /// <br/>
    /// <c>string cssValue = ColumnGap;</c>
    /// <br/>
    /// <c>ColumnGapOptions option = ColumnGap;</c>
    /// </summary>
    public class ColumnGap
    {
        static ColumnGapOptions Option = ColumnGapOptions.Normal;
        static string Value = "normal";
        public ColumnGap(ColumnGapOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnGap(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnGap(ColumnGapOptions option)
        {
            return new ColumnGap(option);
        }

        public static implicit operator ColumnGap(string value)
        {
            return new ColumnGap(value);
        }

        public static implicit operator string(ColumnGap conv)
        {
            return Value;
        }

        public static implicit operator ColumnGapOptions(ColumnGap conv)
        {
            return GetOption(Value);
        }
        string this[ColumnGapOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnGapOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnGapOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnGapOptions>(val);
            if (op == null)
                return Option;
            return (ColumnGapOptions)op;
        }
    }
}