namespace StylesheetNET
{
    /// <summary>
    /// The GridColumnEnd property sets the end column for a grid item. The value can also be a range of columns with a span n value Columns with insufficient or no items will be left blank or empty.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridColumnEnd =  new GridColumnEnd(...);</c>
    /// <br/>
    /// <c>GridColumnEnd = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridColumnEnd = GridColumnEndOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridColumnEnd = GridColumnEnd;</c>
    /// <br/>
    /// <c>string cssValue = GridColumnEnd;</c>
    /// <br/>
    /// <c>GridColumnEndOptions option = GridColumnEnd;</c>
    /// </summary>
    public class GridColumnEnd
    {
        static GridColumnEndOptions Option = GridColumnEndOptions.Auto;
        static string Value = "auto";
        public GridColumnEnd(GridColumnEndOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridColumnEnd(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridColumnEnd(GridColumnEndOptions option)
        {
            return new GridColumnEnd(option);
        }

        public static implicit operator GridColumnEnd(string value)
        {
            return new GridColumnEnd(value);
        }

        public static implicit operator string(GridColumnEnd conv)
        {
            return Value;
        }

        public static implicit operator GridColumnEndOptions(GridColumnEnd conv)
        {
            return GetOption(Value);
        }
        string this[GridColumnEndOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridColumnEndOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridColumnEndOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridColumnEndOptions>(val);
            if (op == null)
                return Option;
            return (GridColumnEndOptions)op;
        }
    }
}