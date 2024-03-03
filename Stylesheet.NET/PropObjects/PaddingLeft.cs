namespace Stylesheet.NET
{
    /// <summary>
    /// Padding is the space between the content of an element and its border. The PaddingLeft property adds spacing to the left of the element. It accepts any length value, such as, px, %, em, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PaddingLeft =  new PaddingLeft(...);</c>
    /// <br/>
    /// <c>PaddingLeft = "your css value(s) here";</c>
    /// <br/>
    /// <c>PaddingLeft = PaddingLeftOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PaddingLeft = PaddingLeft;</c>
    /// <br/>
    /// <c>string cssValue = PaddingLeft;</c>
    /// <br/>
    /// <c>PaddingLeftOptions option = PaddingLeft;</c>
    /// </summary>
    public class PaddingLeft
    {
        static PaddingLeftOptions Option = PaddingLeftOptions.Initial;
        static string Value = "initial";
        public PaddingLeft(PaddingLeftOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PaddingLeft(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PaddingLeft(PaddingLeftOptions option)
        {
            return new PaddingLeft(option);
        }

        public static implicit operator PaddingLeft(string value)
        {
            return new PaddingLeft(value);
        }

        public static implicit operator string(PaddingLeft conv)
        {
            return Value;
        }

        public static implicit operator PaddingLeftOptions(PaddingLeft conv)
        {
            return GetOption(Value);
        }
        string this[PaddingLeftOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PaddingLeftOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PaddingLeftOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PaddingLeftOptions>(val);
            if (op == null)
                return Option;
            return (PaddingLeftOptions)op;
        }
    }
}