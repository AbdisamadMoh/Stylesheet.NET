namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderTopWidth defines the width of the tpp border. The width is set as a pixel value, or as thin, medium, or thick.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTopWidth =  new BorderTopWidth(...);</c>
    /// <br/>
    /// <c>BorderTopWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTopWidth = BorderTopWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTopWidth = BorderTopWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderTopWidth;</c>
    /// <br/>
    /// <c>BorderTopWidthOptions option = BorderTopWidth;</c>
    /// </summary>
    public class BorderTopWidth
    {
        static BorderTopWidthOptions Option = BorderTopWidthOptions.Medium;
        static string Value = "medium";
        public BorderTopWidth(BorderTopWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTopWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTopWidth(BorderTopWidthOptions option)
        {
            return new BorderTopWidth(option);
        }

        public static implicit operator BorderTopWidth(string value)
        {
            return new BorderTopWidth(value);
        }

        public static implicit operator string(BorderTopWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderTopWidthOptions(BorderTopWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopWidthOptions)op;
        }
    }
}