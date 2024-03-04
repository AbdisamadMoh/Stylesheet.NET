namespace StylesheetNET
{
    /// <summary>
    /// The BorderBottom property adds a bottom border to an element. Borders can vary in width, line style, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottom =  new BorderBottom(...);</c>
    /// <br/>
    /// <c>BorderBottom = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottom = BorderBottomOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottom = BorderBottom;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottom;</c>
    /// <br/>
    /// <c>BorderBottomOptions option = BorderBottom;</c>
    /// </summary>
    public class BorderBottom
    {
        static BorderBottomOptions Option = BorderBottomOptions.Initial;
        static string Value = "initial";
        public BorderBottom(BorderBottomOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottom(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottom(BorderBottomOptions option)
        {
            return new BorderBottom(option);
        }

        public static implicit operator BorderBottom(string value)
        {
            return new BorderBottom(value);
        }

        public static implicit operator string(BorderBottom conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomOptions(BorderBottom conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomOptions)op;
        }
    }
}