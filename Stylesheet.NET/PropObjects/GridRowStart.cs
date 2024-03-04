namespace StylesheetNET
{
    /// <summary>
    /// The GridRowStart sets the start row of a grid item. The value can also be a range of rows with a span n value. Rows with insufficient or no items will be left blank or empty.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridRowStart =  new GridRowStart(...);</c>
    /// <br/>
    /// <c>GridRowStart = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridRowStart = GridRowStartOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridRowStart = GridRowStart;</c>
    /// <br/>
    /// <c>string cssValue = GridRowStart;</c>
    /// <br/>
    /// <c>GridRowStartOptions option = GridRowStart;</c>
    /// </summary>
    public class GridRowStart
    {
        static GridRowStartOptions Option = GridRowStartOptions.Auto;
        static string Value = "auto";
        public GridRowStart(GridRowStartOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridRowStart(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridRowStart(GridRowStartOptions option)
        {
            return new GridRowStart(option);
        }

        public static implicit operator GridRowStart(string value)
        {
            return new GridRowStart(value);
        }

        public static implicit operator string(GridRowStart conv)
        {
            return Value;
        }

        public static implicit operator GridRowStartOptions(GridRowStart conv)
        {
            return GetOption(Value);
        }
        string this[GridRowStartOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridRowStartOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridRowStartOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridRowStartOptions>(val);
            if (op == null)
                return Option;
            return (GridRowStartOptions)op;
        }
    }
}