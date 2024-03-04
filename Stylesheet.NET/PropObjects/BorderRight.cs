namespace StylesheetNET
{
    /// <summary>
    /// The BorderRight property adds a right border to an element. Borders can vary in width, line style, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderRight =  new BorderRight(...);</c>
    /// <br/>
    /// <c>BorderRight = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderRight = BorderRightOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderRight = BorderRight;</c>
    /// <br/>
    /// <c>string cssValue = BorderRight;</c>
    /// <br/>
    /// <c>BorderRightOptions option = BorderRight;</c>
    /// </summary>
    public class BorderRight
    {
        static BorderRightOptions Option = BorderRightOptions.Initial;
        static string Value = "initial";
        public BorderRight(BorderRightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderRight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderRight(BorderRightOptions option)
        {
            return new BorderRight(option);
        }

        public static implicit operator BorderRight(string value)
        {
            return new BorderRight(value);
        }

        public static implicit operator string(BorderRight conv)
        {
            return Value;
        }

        public static implicit operator BorderRightOptions(BorderRight conv)
        {
            return GetOption(Value);
        }
        string this[BorderRightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderRightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderRightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderRightOptions>(val);
            if (op == null)
                return Option;
            return (BorderRightOptions)op;
        }
    }
}