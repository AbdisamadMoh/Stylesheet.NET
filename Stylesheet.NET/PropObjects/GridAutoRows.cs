namespace Stylesheet.NET
{
    /// <summary>
    /// The GridAutoRows property sets the row sizes in a grid. The value represents the minimum height of a grid item. Values include a length value, or auto, min-content, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridAutoRows =  new GridAutoRows(...);</c>
    /// <br/>
    /// <c>GridAutoRows = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridAutoRows = GridAutoRowsOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridAutoRows = GridAutoRows;</c>
    /// <br/>
    /// <c>string cssValue = GridAutoRows;</c>
    /// <br/>
    /// <c>GridAutoRowsOptions option = GridAutoRows;</c>
    /// </summary>
    public class GridAutoRows
    {
        static GridAutoRowsOptions Option = GridAutoRowsOptions.Auto;
        static string Value = "auto";
        public GridAutoRows(GridAutoRowsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridAutoRows(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridAutoRows(GridAutoRowsOptions option)
        {
            return new GridAutoRows(option);
        }

        public static implicit operator GridAutoRows(string value)
        {
            return new GridAutoRows(value);
        }

        public static implicit operator string(GridAutoRows conv)
        {
            return Value;
        }

        public static implicit operator GridAutoRowsOptions(GridAutoRows conv)
        {
            return GetOption(Value);
        }
        string this[GridAutoRowsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridAutoRowsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridAutoRowsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridAutoRowsOptions>(val);
            if (op == null)
                return Option;
            return (GridAutoRowsOptions)op;
        }
    }
}