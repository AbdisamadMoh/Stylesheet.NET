namespace Stylesheet.NET
{
    /// <summary>
    /// The OverflowY property handles content that exceeds the container height (y-direction). Possible values include hidden, visible, scroll and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OverflowY =  new OverflowY(...);</c>
    /// <br/>
    /// <c>OverflowY = "your css value(s) here";</c>
    /// <br/>
    /// <c>OverflowY = OverflowYOptions.Visible;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OverflowY = OverflowY;</c>
    /// <br/>
    /// <c>string cssValue = OverflowY;</c>
    /// <br/>
    /// <c>OverflowYOptions option = OverflowY;</c>
    /// </summary>
    public class OverflowY
    {
        static OverflowYOptions Option = OverflowYOptions.Visible;
        static string Value = "visible";
        public OverflowY(OverflowYOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OverflowY(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OverflowY(OverflowYOptions option)
        {
            return new OverflowY(option);
        }

        public static implicit operator OverflowY(string value)
        {
            return new OverflowY(value);
        }

        public static implicit operator string(OverflowY conv)
        {
            return Value;
        }

        public static implicit operator OverflowYOptions(OverflowY conv)
        {
            return GetOption(Value);
        }
        string this[OverflowYOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OverflowYOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OverflowYOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OverflowYOptions>(val);
            if (op == null)
                return Option;
            return (OverflowYOptions)op;
        }
    }
}