namespace StylesheetNET
{
    /// <summary>
    /// The GridAutoFlow specifies the placement of items in a grid. By default, grid items will flow in rows, from left to right. Other options include column, row dense, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridAutoFlow =  new GridAutoFlow(...);</c>
    /// <br/>
    /// <c>GridAutoFlow = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridAutoFlow = GridAutoFlowOptions.Row;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridAutoFlow = GridAutoFlow;</c>
    /// <br/>
    /// <c>string cssValue = GridAutoFlow;</c>
    /// <br/>
    /// <c>GridAutoFlowOptions option = GridAutoFlow;</c>
    /// </summary>
    public class GridAutoFlow
    {
        static GridAutoFlowOptions Option = GridAutoFlowOptions.Row;
        static string Value = "row";
        public GridAutoFlow(GridAutoFlowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridAutoFlow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridAutoFlow(GridAutoFlowOptions option)
        {
            return new GridAutoFlow(option);
        }

        public static implicit operator GridAutoFlow(string value)
        {
            return new GridAutoFlow(value);
        }

        public static implicit operator string(GridAutoFlow conv)
        {
            return Value;
        }

        public static implicit operator GridAutoFlowOptions(GridAutoFlow conv)
        {
            return GetOption(Value);
        }
        string this[GridAutoFlowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridAutoFlowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridAutoFlowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridAutoFlowOptions>(val);
            if (op == null)
                return Option;
            return (GridAutoFlowOptions)op;
        }
    }
}