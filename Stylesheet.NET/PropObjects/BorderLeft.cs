namespace StylesheetNET
{
    /// <summary>
    /// The BorderLeft property adds a left border to an element. Borders can vary in width, line style, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderLeft =  new BorderLeft(...);</c>
    /// <br/>
    /// <c>BorderLeft = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderLeft = BorderLeftOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderLeft = BorderLeft;</c>
    /// <br/>
    /// <c>string cssValue = BorderLeft;</c>
    /// <br/>
    /// <c>BorderLeftOptions option = BorderLeft;</c>
    /// </summary>
    public class BorderLeft
    {
        static BorderLeftOptions Option = BorderLeftOptions.Initial;
        static string Value = "initial";
        public BorderLeft(BorderLeftOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderLeft(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderLeft(BorderLeftOptions option)
        {
            return new BorderLeft(option);
        }

        public static implicit operator BorderLeft(string value)
        {
            return new BorderLeft(value);
        }

        public static implicit operator string(BorderLeft conv)
        {
            return Value;
        }

        public static implicit operator BorderLeftOptions(BorderLeft conv)
        {
            return GetOption(Value);
        }
        string this[BorderLeftOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderLeftOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderLeftOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderLeftOptions>(val);
            if (op == null)
                return Option;
            return (BorderLeftOptions)op;
        }
    }
}