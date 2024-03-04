namespace StylesheetNET
{
    /// <summary>
    /// The BorderRightStyle property sets the right border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderRightStyle =  new BorderRightStyle(...);</c>
    /// <br/>
    /// <c>BorderRightStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderRightStyle = BorderRightStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderRightStyle = BorderRightStyle;</c>
    /// <br/>
    /// <c>string cssValue = BorderRightStyle;</c>
    /// <br/>
    /// <c>BorderRightStyleOptions option = BorderRightStyle;</c>
    /// </summary>
    public class BorderRightStyle
    {
        static BorderRightStyleOptions Option = BorderRightStyleOptions.None;
        static string Value = "none";
        public BorderRightStyle(BorderRightStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderRightStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderRightStyle(BorderRightStyleOptions option)
        {
            return new BorderRightStyle(option);
        }

        public static implicit operator BorderRightStyle(string value)
        {
            return new BorderRightStyle(value);
        }

        public static implicit operator string(BorderRightStyle conv)
        {
            return Value;
        }

        public static implicit operator BorderRightStyleOptions(BorderRightStyle conv)
        {
            return GetOption(Value);
        }
        string this[BorderRightStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderRightStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderRightStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderRightStyleOptions>(val);
            if (op == null)
                return Option;
            return (BorderRightStyleOptions)op;
        }
    }
}