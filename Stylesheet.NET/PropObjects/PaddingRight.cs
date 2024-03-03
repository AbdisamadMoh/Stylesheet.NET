namespace Stylesheet.NET
{
    /// <summary>
    /// Padding is the space between the content and the border of an element. The PaddingRight property adds spacing to the right of the element. It accepts any length value, such as, px, %, em, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PaddingRight =  new PaddingRight(...);</c>
    /// <br/>
    /// <c>PaddingRight = "your css value(s) here";</c>
    /// <br/>
    /// <c>PaddingRight = PaddingRightOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PaddingRight = PaddingRight;</c>
    /// <br/>
    /// <c>string cssValue = PaddingRight;</c>
    /// <br/>
    /// <c>PaddingRightOptions option = PaddingRight;</c>
    /// </summary>
    public class PaddingRight
    {
        static PaddingRightOptions Option = PaddingRightOptions.Initial;
        static string Value = "initial";
        public PaddingRight(PaddingRightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PaddingRight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PaddingRight(PaddingRightOptions option)
        {
            return new PaddingRight(option);
        }

        public static implicit operator PaddingRight(string value)
        {
            return new PaddingRight(value);
        }

        public static implicit operator string(PaddingRight conv)
        {
            return Value;
        }

        public static implicit operator PaddingRightOptions(PaddingRight conv)
        {
            return GetOption(Value);
        }
        string this[PaddingRightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PaddingRightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PaddingRightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PaddingRightOptions>(val);
            if (op == null)
                return Option;
            return (PaddingRightOptions)op;
        }
    }
}