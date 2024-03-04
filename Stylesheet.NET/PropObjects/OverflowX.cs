namespace StylesheetNET
{
    /// <summary>
    /// The OverflowX property handles content that exceeds the container width (x-direction) Possible values include hidden, visible, scroll and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OverflowX =  new OverflowX(...);</c>
    /// <br/>
    /// <c>OverflowX = "your css value(s) here";</c>
    /// <br/>
    /// <c>OverflowX = OverflowXOptions.Visible;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OverflowX = OverflowX;</c>
    /// <br/>
    /// <c>string cssValue = OverflowX;</c>
    /// <br/>
    /// <c>OverflowXOptions option = OverflowX;</c>
    /// </summary>
    public class OverflowX
    {
        static OverflowXOptions Option = OverflowXOptions.Visible;
        static string Value = "visible";
        public OverflowX(OverflowXOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OverflowX(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OverflowX(OverflowXOptions option)
        {
            return new OverflowX(option);
        }

        public static implicit operator OverflowX(string value)
        {
            return new OverflowX(value);
        }

        public static implicit operator string(OverflowX conv)
        {
            return Value;
        }

        public static implicit operator OverflowXOptions(OverflowX conv)
        {
            return GetOption(Value);
        }
        string this[OverflowXOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OverflowXOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OverflowXOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OverflowXOptions>(val);
            if (op == null)
                return Option;
            return (OverflowXOptions)op;
        }
    }
}