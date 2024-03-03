namespace Stylesheet.NET
{
    /// <summary>
    /// Padding is the space between the content and the border of an element. The PaddingTop property adds spacing to the top of the element. It accepts any length value, such as, px, %, em, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PaddingTop =  new PaddingTop(...);</c>
    /// <br/>
    /// <c>PaddingTop = "your css value(s) here";</c>
    /// <br/>
    /// <c>PaddingTop = PaddingTopOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PaddingTop = PaddingTop;</c>
    /// <br/>
    /// <c>string cssValue = PaddingTop;</c>
    /// <br/>
    /// <c>PaddingTopOptions option = PaddingTop;</c>
    /// </summary>
    public class PaddingTop
    {
        static PaddingTopOptions Option = PaddingTopOptions.Initial;
        static string Value = "initial";
        public PaddingTop(PaddingTopOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PaddingTop(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PaddingTop(PaddingTopOptions option)
        {
            return new PaddingTop(option);
        }

        public static implicit operator PaddingTop(string value)
        {
            return new PaddingTop(value);
        }

        public static implicit operator string(PaddingTop conv)
        {
            return Value;
        }

        public static implicit operator PaddingTopOptions(PaddingTop conv)
        {
            return GetOption(Value);
        }
        string this[PaddingTopOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PaddingTopOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PaddingTopOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PaddingTopOptions>(val);
            if (op == null)
                return Option;
            return (PaddingTopOptions)op;
        }
    }
}