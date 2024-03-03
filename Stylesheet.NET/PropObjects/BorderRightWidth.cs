namespace Stylesheet.NET
{
    /// <summary>
    /// BorderRightWidth defines the width of the right border. The width is set as a pixel value, or as thin, medium, or thick.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderRightWidth =  new BorderRightWidth(...);</c>
    /// <br/>
    /// <c>BorderRightWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderRightWidth = BorderRightWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderRightWidth = BorderRightWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderRightWidth;</c>
    /// <br/>
    /// <c>BorderRightWidthOptions option = BorderRightWidth;</c>
    /// </summary>
    public class BorderRightWidth
    {
        static BorderRightWidthOptions Option = BorderRightWidthOptions.Medium;
        static string Value = "medium";
        public BorderRightWidth(BorderRightWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderRightWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderRightWidth(BorderRightWidthOptions option)
        {
            return new BorderRightWidth(option);
        }

        public static implicit operator BorderRightWidth(string value)
        {
            return new BorderRightWidth(value);
        }

        public static implicit operator string(BorderRightWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderRightWidthOptions(BorderRightWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderRightWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderRightWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderRightWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderRightWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderRightWidthOptions)op;
        }
    }
}