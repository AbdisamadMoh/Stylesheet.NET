namespace StylesheetNET
{
    /// <summary>
    /// The ColumnFill property defines how columns are filled with text. One option is balance, in which column heights are equal. Another is auto, in which columns are filled by height first.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnFill =  new ColumnFill(...);</c>
    /// <br/>
    /// <c>ColumnFill = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnFill = ColumnFillOptions.Balance;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnFill = ColumnFill;</c>
    /// <br/>
    /// <c>string cssValue = ColumnFill;</c>
    /// <br/>
    /// <c>ColumnFillOptions option = ColumnFill;</c>
    /// </summary>
    public class ColumnFill
    {
        static ColumnFillOptions Option = ColumnFillOptions.Balance;
        static string Value = "balance";
        public ColumnFill(ColumnFillOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnFill(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnFill(ColumnFillOptions option)
        {
            return new ColumnFill(option);
        }

        public static implicit operator ColumnFill(string value)
        {
            return new ColumnFill(value);
        }

        public static implicit operator string(ColumnFill conv)
        {
            return Value;
        }

        public static implicit operator ColumnFillOptions(ColumnFill conv)
        {
            return GetOption(Value);
        }
        string this[ColumnFillOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnFillOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnFillOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnFillOptions>(val);
            if (op == null)
                return Option;
            return (ColumnFillOptions)op;
        }
    }
}