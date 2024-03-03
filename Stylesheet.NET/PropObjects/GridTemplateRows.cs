namespace Stylesheet.NET
{
    /// <summary>
    /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateRows property specifies grid rows. The value is a space-separated list with row heights.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridTemplateRows =  new GridTemplateRows(...);</c>
    /// <br/>
    /// <c>GridTemplateRows = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridTemplateRows = GridTemplateRowsOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridTemplateRows = GridTemplateRows;</c>
    /// <br/>
    /// <c>string cssValue = GridTemplateRows;</c>
    /// <br/>
    /// <c>GridTemplateRowsOptions option = GridTemplateRows;</c>
    /// </summary>
    public class GridTemplateRows
    {
        static GridTemplateRowsOptions Option = GridTemplateRowsOptions.None;
        static string Value = "none";
        public GridTemplateRows(GridTemplateRowsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridTemplateRows(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridTemplateRows(GridTemplateRowsOptions option)
        {
            return new GridTemplateRows(option);
        }

        public static implicit operator GridTemplateRows(string value)
        {
            return new GridTemplateRows(value);
        }

        public static implicit operator string(GridTemplateRows conv)
        {
            return Value;
        }

        public static implicit operator GridTemplateRowsOptions(GridTemplateRows conv)
        {
            return GetOption(Value);
        }
        string this[GridTemplateRowsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridTemplateRowsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridTemplateRowsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridTemplateRowsOptions>(val);
            if (op == null)
                return Option;
            return (GridTemplateRowsOptions)op;
        }
    }
}