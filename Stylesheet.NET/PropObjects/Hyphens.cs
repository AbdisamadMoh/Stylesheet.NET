namespace Stylesheet.NET
{
    /// <summary>
    /// The Hyphens property specifies how words break at the end of a line. One option is to hyphenate, with a hyphen (-), at specified text positions. Another is to disallow hyphenation, or let the browser handle it entirely.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Hyphens =  new Hyphens(...);</c>
    /// <br/>
    /// <c>Hyphens = "your css value(s) here";</c>
    /// <br/>
    /// <c>Hyphens = HyphensOptions.Manual;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Hyphens = Hyphens;</c>
    /// <br/>
    /// <c>string cssValue = Hyphens;</c>
    /// <br/>
    /// <c>HyphensOptions option = Hyphens;</c>
    /// </summary>
    public class Hyphens
    {
        static HyphensOptions Option = HyphensOptions.Manual;
        static string Value = "manual";
        public Hyphens(HyphensOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Hyphens(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Hyphens(HyphensOptions option)
        {
            return new Hyphens(option);
        }

        public static implicit operator Hyphens(string value)
        {
            return new Hyphens(value);
        }

        public static implicit operator string(Hyphens conv)
        {
            return Value;
        }

        public static implicit operator HyphensOptions(Hyphens conv)
        {
            return GetOption(Value);
        }
        string this[HyphensOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(HyphensOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static HyphensOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<HyphensOptions>(val);
            if (op == null)
                return Option;
            return (HyphensOptions)op;
        }
    }
}