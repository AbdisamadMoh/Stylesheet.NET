namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderCollapse property sets how table borders display. Possible values are separate and collapse. By default, table borders are separate.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderCollapse =  new BorderCollapse(...);</c>
    /// <br/>
    /// <c>BorderCollapse = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderCollapse = BorderCollapseOptions.Separate;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderCollapse = BorderCollapse;</c>
    /// <br/>
    /// <c>string cssValue = BorderCollapse;</c>
    /// <br/>
    /// <c>BorderCollapseOptions option = BorderCollapse;</c>
    /// </summary>
    public class BorderCollapse
    {
        static BorderCollapseOptions Option = BorderCollapseOptions.Separate;
        static string Value = "separate";
        public BorderCollapse(BorderCollapseOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderCollapse(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderCollapse(BorderCollapseOptions option)
        {
            return new BorderCollapse(option);
        }

        public static implicit operator BorderCollapse(string value)
        {
            return new BorderCollapse(value);
        }

        public static implicit operator string(BorderCollapse conv)
        {
            return Value;
        }

        public static implicit operator BorderCollapseOptions(BorderCollapse conv)
        {
            return GetOption(Value);
        }
        string this[BorderCollapseOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderCollapseOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderCollapseOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderCollapseOptions>(val);
            if (op == null)
                return Option;
            return (BorderCollapseOptions)op;
        }
    }
}