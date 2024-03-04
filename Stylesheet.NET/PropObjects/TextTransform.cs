namespace StylesheetNET
{
    /// <summary>
    /// The TextTransform property specifies the casing of the font. Options include none, uppercase, lowercase, and capitalized.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextTransform =  new TextTransform(...);</c>
    /// <br/>
    /// <c>TextTransform = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextTransform = TextTransformOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextTransform = TextTransform;</c>
    /// <br/>
    /// <c>string cssValue = TextTransform;</c>
    /// <br/>
    /// <c>TextTransformOptions option = TextTransform;</c>
    /// </summary>
    public class TextTransform
    {
        static TextTransformOptions Option = TextTransformOptions.None;
        static string Value = "none";
        public TextTransform(TextTransformOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextTransform(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextTransform(TextTransformOptions option)
        {
            return new TextTransform(option);
        }

        public static implicit operator TextTransform(string value)
        {
            return new TextTransform(value);
        }

        public static implicit operator string(TextTransform conv)
        {
            return Value;
        }

        public static implicit operator TextTransformOptions(TextTransform conv)
        {
            return GetOption(Value);
        }
        string this[TextTransformOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextTransformOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextTransformOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextTransformOptions>(val);
            if (op == null)
                return Option;
            return (TextTransformOptions)op;
        }
    }
}