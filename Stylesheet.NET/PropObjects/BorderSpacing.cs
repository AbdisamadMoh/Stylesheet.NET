namespace StylesheetNET
{
    /// <summary>
    /// BorderSpacing sets the table cell border spacing. This property is used for table cells only.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderSpacing =  new BorderSpacing(...);</c>
    /// <br/>
    /// <c>BorderSpacing = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderSpacing = BorderSpacingOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderSpacing = BorderSpacing;</c>
    /// <br/>
    /// <c>string cssValue = BorderSpacing;</c>
    /// <br/>
    /// <c>BorderSpacingOptions option = BorderSpacing;</c>
    /// </summary>
    public class BorderSpacing
    {
        static BorderSpacingOptions Option = BorderSpacingOptions.Initial;
        static string Value = "initial";
        public BorderSpacing(BorderSpacingOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderSpacing(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderSpacing(BorderSpacingOptions option)
        {
            return new BorderSpacing(option);
        }

        public static implicit operator BorderSpacing(string value)
        {
            return new BorderSpacing(value);
        }

        public static implicit operator string(BorderSpacing conv)
        {
            return Value;
        }

        public static implicit operator BorderSpacingOptions(BorderSpacing conv)
        {
            return GetOption(Value);
        }
        string this[BorderSpacingOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderSpacingOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderSpacingOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderSpacingOptions>(val);
            if (op == null)
                return Option;
            return (BorderSpacingOptions)op;
        }
    }
}