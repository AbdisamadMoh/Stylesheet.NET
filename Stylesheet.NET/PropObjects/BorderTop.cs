namespace StylesheetNET
{
    /// <summary>
    /// The BorderTop property adds a top border to an element. Borders can vary in width, line style, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTop =  new BorderTop(...);</c>
    /// <br/>
    /// <c>BorderTop = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTop = BorderTopOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTop = BorderTop;</c>
    /// <br/>
    /// <c>string cssValue = BorderTop;</c>
    /// <br/>
    /// <c>BorderTopOptions option = BorderTop;</c>
    /// </summary>
    public class BorderTop
    {
        static BorderTopOptions Option = BorderTopOptions.Initial;
        static string Value = "initial";
        public BorderTop(BorderTopOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTop(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTop(BorderTopOptions option)
        {
            return new BorderTop(option);
        }

        public static implicit operator BorderTop(string value)
        {
            return new BorderTop(value);
        }

        public static implicit operator string(BorderTop conv)
        {
            return Value;
        }

        public static implicit operator BorderTopOptions(BorderTop conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopOptions)op;
        }
    }
}