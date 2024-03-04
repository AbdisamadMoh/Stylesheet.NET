namespace StylesheetNET
{
    /// <summary>
    /// The BorderImageWidth property sets the image border width. It accepts any length value, such as, px, %, em, etc. If no value is provided, it inherits the border-width value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImageWidth =  new BorderImageWidth(...);</c>
    /// <br/>
    /// <c>BorderImageWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImageWidth = BorderImageWidthOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImageWidth = BorderImageWidth;</c>
    /// <br/>
    /// <c>string cssValue = BorderImageWidth;</c>
    /// <br/>
    /// <c>BorderImageWidthOptions option = BorderImageWidth;</c>
    /// </summary>
    public class BorderImageWidth
    {
        static BorderImageWidthOptions Option = BorderImageWidthOptions.Initial;
        static string Value = "initial";
        public BorderImageWidth(BorderImageWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImageWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImageWidth(BorderImageWidthOptions option)
        {
            return new BorderImageWidth(option);
        }

        public static implicit operator BorderImageWidth(string value)
        {
            return new BorderImageWidth(value);
        }

        public static implicit operator string(BorderImageWidth conv)
        {
            return Value;
        }

        public static implicit operator BorderImageWidthOptions(BorderImageWidth conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageWidthOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageWidthOptions)op;
        }
    }
}