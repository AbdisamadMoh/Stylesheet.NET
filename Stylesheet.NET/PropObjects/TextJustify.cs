namespace StylesheetNET
{
    /// <summary>
    /// The TextJustify property sets the text justification method. Justification means that text is spread out to fill the available space. It does this by spacing words or characters. This property is only relevant when text-align:justified is set.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextJustify =  new TextJustify(...);</c>
    /// <br/>
    /// <c>TextJustify = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextJustify = TextJustifyOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextJustify = TextJustify;</c>
    /// <br/>
    /// <c>string cssValue = TextJustify;</c>
    /// <br/>
    /// <c>TextJustifyOptions option = TextJustify;</c>
    /// </summary>
    public class TextJustify
    {
        static TextJustifyOptions Option = TextJustifyOptions.Auto;
        static string Value = "auto";
        public TextJustify(TextJustifyOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextJustify(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextJustify(TextJustifyOptions option)
        {
            return new TextJustify(option);
        }

        public static implicit operator TextJustify(string value)
        {
            return new TextJustify(value);
        }

        public static implicit operator string(TextJustify conv)
        {
            return Value;
        }

        public static implicit operator TextJustifyOptions(TextJustify conv)
        {
            return GetOption(Value);
        }
        string this[TextJustifyOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextJustifyOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextJustifyOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextJustifyOptions>(val);
            if (op == null)
                return Option;
            return (TextJustifyOptions)op;
        }
    }
}