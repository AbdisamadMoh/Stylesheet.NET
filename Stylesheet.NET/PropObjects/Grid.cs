namespace StylesheetNET
{
    /// <summary>
    /// The Grid property defines a Grid layout. It specifies rows, columns, and areas by name and position. This property is a shorthand for several Grid settings.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Grid =  new Grid(...);</c>
    /// <br/>
    /// <c>Grid = "your css value(s) here";</c>
    /// <br/>
    /// <c>Grid = GridOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Grid = Grid;</c>
    /// <br/>
    /// <c>string cssValue = Grid;</c>
    /// <br/>
    /// <c>GridOptions option = Grid;</c>
    /// </summary>
    public class Grid
    {
        static GridOptions Option = GridOptions.Initial;
        static string Value = "initial";
        public Grid(GridOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Grid(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Grid(GridOptions option)
        {
            return new Grid(option);
        }

        public static implicit operator Grid(string value)
        {
            return new Grid(value);
        }

        public static implicit operator string(Grid conv)
        {
            return Value;
        }

        public static implicit operator GridOptions(Grid conv)
        {
            return GetOption(Value);
        }
        string this[GridOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridOptions>(val);
            if (op == null)
                return Option;
            return (GridOptions)op;
        }
    }
}