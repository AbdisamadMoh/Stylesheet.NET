namespace Stylesheet.NET
{
    /// <summary>
    /// The TextAlign property sets the text's horizontal alignment. Options include left, center, right, and justify. By default, text is left aligned.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextAlign =  new TextAlign(...);</c>
    /// <br/>
    /// <c>TextAlign = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextAlign = TextAlignOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextAlign = TextAlign;</c>
    /// <br/>
    /// <c>string cssValue = TextAlign;</c>
    /// <br/>
    /// <c>TextAlignOptions option = TextAlign;</c>
    /// </summary>
    public class TextAlign
    {
        static TextAlignOptions Option = TextAlignOptions.Initial;
        static string Value = "initial";
        public TextAlign(TextAlignOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextAlign(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextAlign(TextAlignOptions option)
        {
            return new TextAlign(option);
        }

        public static implicit operator TextAlign(string value)
        {
            return new TextAlign(value);
        }

        public static implicit operator string(TextAlign conv)
        {
            return Value;
        }

        public static implicit operator TextAlignOptions(TextAlign conv)
        {
            return GetOption(Value);
        }
        string this[TextAlignOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextAlignOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextAlignOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextAlignOptions>(val);
            if (op == null)
                return Option;
            return (TextAlignOptions)op;
        }
    }
}