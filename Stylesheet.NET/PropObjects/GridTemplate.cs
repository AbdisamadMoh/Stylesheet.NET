namespace Stylesheet.NET
{
    /// <summary>
    /// Grid is a layout system that uses a grid with rows and columns. A GridTemplate defines rows, columns, and areas in a grid layout. It's a shorthand for 3 properties that define rows, columns, and areas.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>GridTemplate =  new GridTemplate(...);</c>
    /// <br/>
    /// <c>GridTemplate = "your css value(s) here";</c>
    /// <br/>
    /// <c>GridTemplate = GridTemplateOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_GridTemplate = GridTemplate;</c>
    /// <br/>
    /// <c>string cssValue = GridTemplate;</c>
    /// <br/>
    /// <c>GridTemplateOptions option = GridTemplate;</c>
    /// </summary>
    public class GridTemplate
    {
        static GridTemplateOptions Option = GridTemplateOptions.Initial;
        static string Value = "initial";
        public GridTemplate(GridTemplateOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public GridTemplate(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator GridTemplate(GridTemplateOptions option)
        {
            return new GridTemplate(option);
        }

        public static implicit operator GridTemplate(string value)
        {
            return new GridTemplate(value);
        }

        public static implicit operator string(GridTemplate conv)
        {
            return Value;
        }

        public static implicit operator GridTemplateOptions(GridTemplate conv)
        {
            return GetOption(Value);
        }
        string this[GridTemplateOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(GridTemplateOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static GridTemplateOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<GridTemplateOptions>(val);
            if (op == null)
                return Option;
            return (GridTemplateOptions)op;
        }
    }
}