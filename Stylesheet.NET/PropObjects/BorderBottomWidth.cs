namespace StylesheetNET
{
    /// <summary>
    /// BorderBottomWidth defines the width of the bottom border. The width is set as a pixel value, or as thin, medium, or thick.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottomWidth =  new BorderBottomWidth(...);</c>
    /// <br/>
    /// <c>BorderBottomWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottomWidth = BorderBottomWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottomWidth = BorderBottomWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottomWidth;</c>
    /// <br/>
    /// <c>BorderBottomWidthOptions option = BorderBottomWidth;</c>
    /// </summary>
    public class BorderBottomWidth
    {
        static BorderBottomWidthOptions Option = BorderBottomWidthOptions.Medium;
        static string Value = "medium";
        public BorderBottomWidth(BorderBottomWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottomWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottomWidth(BorderBottomWidthOptions option)
        {
            return new BorderBottomWidth(option);
        }

        public static implicit operator BorderBottomWidth(string value)
        {
            return new BorderBottomWidth(value);
        }

        public static implicit operator string(BorderBottomWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomWidthOptions(BorderBottomWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomWidthOptions)op;
        }
    }
}