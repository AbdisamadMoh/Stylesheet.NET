namespace StylesheetNET
{
    /// <summary>
    /// The TableLayout property specifies the table layout algorithm. This algorithm calculates the table, column, and cell widths. This property informs the browser how to best render a table.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TableLayout =  new TableLayout(...);</c>
    /// <br/>
    /// <c>TableLayout = "your css value(s) here";</c>
    /// <br/>
    /// <c>TableLayout = TableLayoutOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TableLayout = TableLayout;</c>
    /// <br/>
    /// <c>string cssValue = TableLayout;</c>
    /// <br/>
    /// <c>TableLayoutOptions option = TableLayout;</c>
    /// </summary>
    public class TableLayout
    {
        static TableLayoutOptions Option = TableLayoutOptions.Auto;
        static string Value = "auto";
        public TableLayout(TableLayoutOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TableLayout(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TableLayout(TableLayoutOptions option)
        {
            return new TableLayout(option);
        }

        public static implicit operator TableLayout(string value)
        {
            return new TableLayout(value);
        }

        public static implicit operator string(TableLayout conv)
        {
            return Value;
        }

        public static implicit operator TableLayoutOptions(TableLayout conv)
        {
            return GetOption(Value);
        }
        string this[TableLayoutOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TableLayoutOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TableLayoutOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TableLayoutOptions>(val);
            if (op == null)
                return Option;
            return (TableLayoutOptions)op;
        }
    }
}