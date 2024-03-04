namespace StylesheetNET
{
    /// <summary>
    /// The WhiteSpace property handles WhiteSpace inside an element. It specifies whether WhiteSpace should collapse (into a single space). And whether lines should wrap at the end of a line.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>WhiteSpace =  new WhiteSpace(...);</c>
    /// <br/>
    /// <c>WhiteSpace = "your css value(s) here";</c>
    /// <br/>
    /// <c>WhiteSpace = WhiteSpaceOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_WhiteSpace = WhiteSpace;</c>
    /// <br/>
    /// <c>string cssValue = WhiteSpace;</c>
    /// <br/>
    /// <c>WhiteSpaceOptions option = WhiteSpace;</c>
    /// </summary>
    public class WhiteSpace
    {
        static WhiteSpaceOptions Option = WhiteSpaceOptions.Normal;
        static string Value = "normal";
        public WhiteSpace(WhiteSpaceOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public WhiteSpace(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator WhiteSpace(WhiteSpaceOptions option)
        {
            return new WhiteSpace(option);
        }

        public static implicit operator WhiteSpace(string value)
        {
            return new WhiteSpace(value);
        }

        public static implicit operator string(WhiteSpace conv)
        {
            return Value;
        }

        public static implicit operator WhiteSpaceOptions(WhiteSpace conv)
        {
            return GetOption(Value);
        }
        string this[WhiteSpaceOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WhiteSpaceOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WhiteSpaceOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WhiteSpaceOptions>(val);
            if (op == null)
                return Option;
            return (WhiteSpaceOptions)op;
        }
    }
}