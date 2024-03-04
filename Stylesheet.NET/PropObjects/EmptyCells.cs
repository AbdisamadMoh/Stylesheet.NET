namespace StylesheetNET
{
    /// <summary>
    /// The EmptyCells property sets borders on empty table cells. The setting only affects the borders, not the space the cells occupy.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>EmptyCells =  new EmptyCells(...);</c>
    /// <br/>
    /// <c>EmptyCells = "your css value(s) here";</c>
    /// <br/>
    /// <c>EmptyCells = EmptyCellsOptions.Show;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_EmptyCells = EmptyCells;</c>
    /// <br/>
    /// <c>string cssValue = EmptyCells;</c>
    /// <br/>
    /// <c>EmptyCellsOptions option = EmptyCells;</c>
    /// </summary>
    public class EmptyCells
    {
        static EmptyCellsOptions Option = EmptyCellsOptions.Show;
        static string Value = "show";
        public EmptyCells(EmptyCellsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public EmptyCells(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator EmptyCells(EmptyCellsOptions option)
        {
            return new EmptyCells(option);
        }

        public static implicit operator EmptyCells(string value)
        {
            return new EmptyCells(value);
        }

        public static implicit operator string(EmptyCells conv)
        {
            return Value;
        }

        public static implicit operator EmptyCellsOptions(EmptyCells conv)
        {
            return GetOption(Value);
        }
        string this[EmptyCellsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(EmptyCellsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static EmptyCellsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<EmptyCellsOptions>(val);
            if (op == null)
                return Option;
            return (EmptyCellsOptions)op;
        }
    }
}