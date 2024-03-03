namespace Stylesheet.NET
{
    /// <summary>
    /// The GridColumnStart sets the start column of a grid item. Its value can also be a range of columns with span n. Columns with insufficient or no items will be left blank or empty.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridColumnStart =  new GridColumnStart(...);</c>
    /// <br/>
    /// <c>GridColumnStart = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridColumnStart = GridColumnStartOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridColumnStart = GridColumnStart;</c>
    /// <br/>
    /// <c>string cssValue = GridColumnStart;</c>
    /// <br/>
    /// <c>GridColumnStartOptions option = GridColumnStart;</c>
    /// </summary>
    public class GridColumnStart
    {
        static GridColumnStartOptions Option = GridColumnStartOptions.Auto;
        static string Value = "auto";
        public GridColumnStart(GridColumnStartOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridColumnStart(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridColumnStart(GridColumnStartOptions option)
        {
            return new GridColumnStart(option);
        }

        public static implicit operator GridColumnStart(string value)
        {
            return new GridColumnStart(value);
        }

        public static implicit operator string(GridColumnStart conv)
        {
            return Value;
        }

        public static implicit operator GridColumnStartOptions(GridColumnStart conv)
        {
            return GetOption(Value);
        }
        string this[GridColumnStartOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridColumnStartOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridColumnStartOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridColumnStartOptions>(val);
            if (op == null)
                return Option;
            return (GridColumnStartOptions)op;
        }
    }
}