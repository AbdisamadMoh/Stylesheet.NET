namespace StylesheetNET
{
    /// <summary>
    /// The Overflow property handles content that exceeds the size of the container. Options include scroll, visible, hidden and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Overflow =  new Overflow(...);</c>
    /// <br/>
    /// <c>Overflow = "your css value(s) here";</c>
    /// <br/>
    /// <c>Overflow = OverflowOptions.Visible;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Overflow = Overflow;</c>
    /// <br/>
    /// <c>string cssValue = Overflow;</c>
    /// <br/>
    /// <c>OverflowOptions option = Overflow;</c>
    /// </summary>
    public class Overflow
    {
        static OverflowOptions Option = OverflowOptions.Visible;
        static string Value = "visible";
        public Overflow(OverflowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Overflow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Overflow(OverflowOptions option)
        {
            return new Overflow(option);
        }

        public static implicit operator Overflow(string value)
        {
            return new Overflow(value);
        }

        public static implicit operator string(Overflow conv)
        {
            return Value;
        }

        public static implicit operator OverflowOptions(Overflow conv)
        {
            return GetOption(Value);
        }
        string this[OverflowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OverflowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OverflowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OverflowOptions>(val);
            if (op == null)
                return Option;
            return (OverflowOptions)op;
        }
    }
}