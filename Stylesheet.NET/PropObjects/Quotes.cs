namespace Stylesheet.NET
{
    /// <summary>
    /// The Quotes property sets the quotation marks to use for quotations. It accepts any kind of quotation mark: ", ', ‘, ’, “, ”, ‹, ›, «, », etc. This value overrides the default which is a pair of double Quotes ("").
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Quotes =  new Quotes(...);</c>
    /// <br/>
    /// <c>Quotes = "your css value(s) here";</c>
    /// <br/>
    /// <c>Quotes = QuotesOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Quotes = Quotes;</c>
    /// <br/>
    /// <c>string cssValue = Quotes;</c>
    /// <br/>
    /// <c>QuotesOptions option = Quotes;</c>
    /// </summary>
    public class Quotes
    {
        static QuotesOptions Option = QuotesOptions.Initial;
        static string Value = "initial";
        public Quotes(QuotesOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Quotes(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Quotes(QuotesOptions option)
        {
            return new Quotes(option);
        }

        public static implicit operator Quotes(string value)
        {
            return new Quotes(value);
        }

        public static implicit operator string(Quotes conv)
        {
            return Value;
        }

        public static implicit operator QuotesOptions(Quotes conv)
        {
            return GetOption(Value);
        }
        string this[QuotesOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(QuotesOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static QuotesOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<QuotesOptions>(val);
            if (op == null)
                return Option;
            return (QuotesOptions)op;
        }
    }
}