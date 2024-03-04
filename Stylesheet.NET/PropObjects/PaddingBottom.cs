namespace StylesheetNET
{
    /// <summary>
    /// Padding is the space between the content of an element and its border. The PaddingBottom property adds spacing to the bottom of the element. It accepts any length value, such as, px, %, em, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PaddingBottom =  new PaddingBottom(...);</c>
    /// <br/>
    /// <c>PaddingBottom = "your css value(s) here";</c>
    /// <br/>
    /// <c>PaddingBottom = PaddingBottomOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PaddingBottom = PaddingBottom;</c>
    /// <br/>
    /// <c>string cssValue = PaddingBottom;</c>
    /// <br/>
    /// <c>PaddingBottomOptions option = PaddingBottom;</c>
    /// </summary>
    public class PaddingBottom
    {
        static PaddingBottomOptions Option = PaddingBottomOptions.Initial;
        static string Value = "initial";
        public PaddingBottom(PaddingBottomOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PaddingBottom(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PaddingBottom(PaddingBottomOptions option)
        {
            return new PaddingBottom(option);
        }

        public static implicit operator PaddingBottom(string value)
        {
            return new PaddingBottom(value);
        }

        public static implicit operator string(PaddingBottom conv)
        {
            return Value;
        }

        public static implicit operator PaddingBottomOptions(PaddingBottom conv)
        {
            return GetOption(Value);
        }
        string this[PaddingBottomOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PaddingBottomOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PaddingBottomOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PaddingBottomOptions>(val);
            if (op == null)
                return Option;
            return (PaddingBottomOptions)op;
        }
    }
}