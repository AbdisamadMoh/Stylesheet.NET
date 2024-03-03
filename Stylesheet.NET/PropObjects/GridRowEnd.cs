namespace Stylesheet.NET
{
    /// <summary>
    /// The GridRowEnd property sets the end row for a grid item. The value can also be a range of rows with a span n value Rows with insufficient or no items will be left blank or empty.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridRowEnd =  new GridRowEnd(...);</c>
    /// <br/>
    /// <c>GridRowEnd = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridRowEnd = GridRowEndOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridRowEnd = GridRowEnd;</c>
    /// <br/>
    /// <c>string cssValue = GridRowEnd;</c>
    /// <br/>
    /// <c>GridRowEndOptions option = GridRowEnd;</c>
    /// </summary>
    public class GridRowEnd
    {
        static GridRowEndOptions Option = GridRowEndOptions.Auto;
        static string Value = "auto";
        public GridRowEnd(GridRowEndOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridRowEnd(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridRowEnd(GridRowEndOptions option)
        {
            return new GridRowEnd(option);
        }

        public static implicit operator GridRowEnd(string value)
        {
            return new GridRowEnd(value);
        }

        public static implicit operator string(GridRowEnd conv)
        {
            return Value;
        }

        public static implicit operator GridRowEndOptions(GridRowEnd conv)
        {
            return GetOption(Value);
        }
        string this[GridRowEndOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridRowEndOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridRowEndOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridRowEndOptions>(val);
            if (op == null)
                return Option;
            return (GridRowEndOptions)op;
        }
    }
}