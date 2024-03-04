namespace StylesheetNET
{
    /// <summary>
    /// BorderLeftWidth defines the width of the left border. The width is set as a pixel value, or as thin, medium, or thick.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderLeftWidth =  new BorderLeftWidth(...);</c>
    /// <br/>
    /// <c>BorderLeftWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderLeftWidth = BorderLeftWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderLeftWidth = BorderLeftWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderLeftWidth;</c>
    /// <br/>
    /// <c>BorderLeftWidthOptions option = BorderLeftWidth;</c>
    /// </summary>
    public class BorderLeftWidth
    {
        static BorderLeftWidthOptions Option = BorderLeftWidthOptions.Medium;
        static string Value = "medium";
        public BorderLeftWidth(BorderLeftWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderLeftWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderLeftWidth(BorderLeftWidthOptions option)
        {
            return new BorderLeftWidth(option);
        }

        public static implicit operator BorderLeftWidth(string value)
        {
            return new BorderLeftWidth(value);
        }

        public static implicit operator string(BorderLeftWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderLeftWidthOptions(BorderLeftWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderLeftWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderLeftWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderLeftWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderLeftWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderLeftWidthOptions)op;
        }
    }
}