namespace Stylesheet.NET
{
    /// <summary>
    /// The CaptionSide property sets the position of a table caption. Options are the top or bottom of the table. By default, the caption is located at the bottom.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>CaptionSide =  new CaptionSide(...);</c>
    /// <br/>
    /// <c>CaptionSide = "your css value(s) here";</c>
    /// <br/>
    /// <c>CaptionSide = CaptionSideOptions.Top;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_CaptionSide = CaptionSide;</c>
    /// <br/>
    /// <c>string cssValue = CaptionSide;</c>
    /// <br/>
    /// <c>CaptionSideOptions option = CaptionSide;</c>
    /// </summary>
    public class CaptionSide
    {
        static CaptionSideOptions Option = CaptionSideOptions.Top;
        static string Value = "top";
        public CaptionSide(CaptionSideOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public CaptionSide(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator CaptionSide(CaptionSideOptions option)
        {
            return new CaptionSide(option);
        }

        public static implicit operator CaptionSide(string value)
        {
            return new CaptionSide(value);
        }

        public static implicit operator string(CaptionSide conv)
        {
            return Value;
        }

        public static implicit operator CaptionSideOptions(CaptionSide conv)
        {
            return GetOption(Value);
        }
        string this[CaptionSideOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(CaptionSideOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static CaptionSideOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<CaptionSideOptions>(val);
            if (op == null)
                return Option;
            return (CaptionSideOptions)op;
        }
    }
}