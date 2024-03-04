namespace StylesheetNET
{
    /// <summary>
    /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateColumns property defines grid columns. The value is a space-separated list with column widths.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridTemplateColumns =  new GridTemplateColumns(...);</c>
    /// <br/>
    /// <c>GridTemplateColumns = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridTemplateColumns = GridTemplateColumnsOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridTemplateColumns = GridTemplateColumns;</c>
    /// <br/>
    /// <c>string cssValue = GridTemplateColumns;</c>
    /// <br/>
    /// <c>GridTemplateColumnsOptions option = GridTemplateColumns;</c>
    /// </summary>
    public class GridTemplateColumns
    {
        static GridTemplateColumnsOptions Option = GridTemplateColumnsOptions.None;
        static string Value = "none";
        public GridTemplateColumns(GridTemplateColumnsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridTemplateColumns(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridTemplateColumns(GridTemplateColumnsOptions option)
        {
            return new GridTemplateColumns(option);
        }

        public static implicit operator GridTemplateColumns(string value)
        {
            return new GridTemplateColumns(value);
        }

        public static implicit operator string(GridTemplateColumns conv)
        {
            return Value;
        }

        public static implicit operator GridTemplateColumnsOptions(GridTemplateColumns conv)
        {
            return GetOption(Value);
        }
        string this[GridTemplateColumnsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridTemplateColumnsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridTemplateColumnsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridTemplateColumnsOptions>(val);
            if (op == null)
                return Option;
            return (GridTemplateColumnsOptions)op;
        }
    }
}