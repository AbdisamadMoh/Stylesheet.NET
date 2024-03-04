namespace StylesheetNET
{
    /// <summary>
    /// The TextIndent property sets the indentation of text. Indentation is extra space that is added before the first line of text. This property accepts any CSS length value, such as, px, %, em, and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextIndent =  new TextIndent(...);</c>
    /// <br/>
    /// <c>TextIndent = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextIndent = TextIndentOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextIndent = TextIndent;</c>
    /// <br/>
    /// <c>string cssValue = TextIndent;</c>
    /// <br/>
    /// <c>TextIndentOptions option = TextIndent;</c>
    /// </summary>
    public class TextIndent
    {
        static TextIndentOptions Option = TextIndentOptions.Initial;
        static string Value = "initial";
        public TextIndent(TextIndentOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextIndent(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextIndent(TextIndentOptions option)
        {
            return new TextIndent(option);
        }

        public static implicit operator TextIndent(string value)
        {
            return new TextIndent(value);
        }

        public static implicit operator string(TextIndent conv)
        {
            return Value;
        }

        public static implicit operator TextIndentOptions(TextIndent conv)
        {
            return GetOption(Value);
        }
        string this[TextIndentOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextIndentOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextIndentOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextIndentOptions>(val);
            if (op == null)
                return Option;
            return (TextIndentOptions)op;
        }
    }
}