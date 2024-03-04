namespace StylesheetNET
{
    /// <summary>
    /// The BorderWidth property sets the width of the border. The width is set as a pixel value, or as thin, medium, or thick.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderWidth =  new BorderWidth(...);</c>
    /// <br/>
    /// <c>BorderWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderWidth = BorderWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderWidth = BorderWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderWidth;</c>
    /// <br/>
    /// <c>BorderWidthOptions option = BorderWidth;</c>
    /// </summary>
    public class BorderWidth
    {
        static BorderWidthOptions Option = BorderWidthOptions.Medium;
        static string Value = "medium";
        public BorderWidth(BorderWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderWidth(BorderWidthOptions option)
        {
            return new BorderWidth(option);
        }

        public static implicit operator BorderWidth(string value)
        {
            return new BorderWidth(value);
        }

        public static implicit operator string(BorderWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderWidthOptions(BorderWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderWidthOptions)op;
        }
    }
}