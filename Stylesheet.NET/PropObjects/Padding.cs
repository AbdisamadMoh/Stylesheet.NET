namespace Stylesheet.NET
{
    /// <summary>
    /// Padding is the space between the content and the border of an element. The Padding property add spacing inside the element. This property accepts any length value, such as, px, %, em, and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Padding =  new Padding(...);</c>
    /// <br/>
    /// <c>Padding = "your css value(s) here";</c>
    /// <br/>
    /// <c>Padding = PaddingOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Padding = Padding;</c>
    /// <br/>
    /// <c>string cssValue = Padding;</c>
    /// <br/>
    /// <c>PaddingOptions option = Padding;</c>
    /// </summary>
    public class Padding
    {
        static PaddingOptions Option = PaddingOptions.Initial;
        static string Value = "initial";
        public Padding(PaddingOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Padding(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Padding(PaddingOptions option)
        {
            return new Padding(option);
        }

        public static implicit operator Padding(string value)
        {
            return new Padding(value);
        }

        public static implicit operator string(Padding conv)
        {
            return Value;
        }

        public static implicit operator PaddingOptions(Padding conv)
        {
            return GetOption(Value);
        }
        string this[PaddingOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PaddingOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PaddingOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PaddingOptions>(val);
            if (op == null)
                return Option;
            return (PaddingOptions)op;
        }
    }
}