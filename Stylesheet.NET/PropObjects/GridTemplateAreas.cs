namespace StylesheetNET
{
    /// <summary>
    /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateAreas property defines named grid areas. The value is a sequence of names that define rows and columns.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridTemplateAreas =  new GridTemplateAreas(...);</c>
    /// <br/>
    /// <c>GridTemplateAreas = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridTemplateAreas = GridTemplateAreasOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridTemplateAreas = GridTemplateAreas;</c>
    /// <br/>
    /// <c>string cssValue = GridTemplateAreas;</c>
    /// <br/>
    /// <c>GridTemplateAreasOptions option = GridTemplateAreas;</c>
    /// </summary>
    public class GridTemplateAreas
    {
        static GridTemplateAreasOptions Option = GridTemplateAreasOptions.None;
        static string Value = "none";
        public GridTemplateAreas(GridTemplateAreasOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridTemplateAreas(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridTemplateAreas(GridTemplateAreasOptions option)
        {
            return new GridTemplateAreas(option);
        }

        public static implicit operator GridTemplateAreas(string value)
        {
            return new GridTemplateAreas(value);
        }

        public static implicit operator string(GridTemplateAreas conv)
        {
            return Value;
        }

        public static implicit operator GridTemplateAreasOptions(GridTemplateAreas conv)
        {
            return GetOption(Value);
        }
        string this[GridTemplateAreasOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridTemplateAreasOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridTemplateAreasOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridTemplateAreasOptions>(val);
            if (op == null)
                return Option;
            return (GridTemplateAreasOptions)op;
        }
    }
}