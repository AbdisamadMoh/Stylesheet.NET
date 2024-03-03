namespace Stylesheet.NET
{
    /// <summary>
    /// The GridAutoColumns property sets the column sizes in a grid. The value represents the minimum width of a grid item. Options include a length value, or auto, min-content, minmax, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridAutoColumns =  new GridAutoColumns(...);</c>
    /// <br/>
    /// <c>GridAutoColumns = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridAutoColumns = GridAutoColumnsOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridAutoColumns = GridAutoColumns;</c>
    /// <br/>
    /// <c>string cssValue = GridAutoColumns;</c>
    /// <br/>
    /// <c>GridAutoColumnsOptions option = GridAutoColumns;</c>
    /// </summary>
    public class GridAutoColumns
    {
        static GridAutoColumnsOptions Option = GridAutoColumnsOptions.Auto;
        static string Value = "auto";
        public GridAutoColumns(GridAutoColumnsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridAutoColumns(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridAutoColumns(GridAutoColumnsOptions option)
        {
            return new GridAutoColumns(option);
        }

        public static implicit operator GridAutoColumns(string value)
        {
            return new GridAutoColumns(value);
        }

        public static implicit operator string(GridAutoColumns conv)
        {
            return Value;
        }

        public static implicit operator GridAutoColumnsOptions(GridAutoColumns conv)
        {
            return GetOption(Value);
        }
        string this[GridAutoColumnsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridAutoColumnsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridAutoColumnsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridAutoColumnsOptions>(val);
            if (op == null)
                return Option;
            return (GridAutoColumnsOptions)op;
        }
    }
}