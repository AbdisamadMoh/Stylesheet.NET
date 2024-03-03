namespace Stylesheet.NET
{
    /// <summary>
    /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationLine property specifies the type of decoration. Options include underline, overline, and line-through.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextDecorationLine =  new TextDecorationLine(...);</c>
    /// <br/>
    /// <c>TextDecorationLine = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextDecorationLine = TextDecorationLineOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextDecorationLine = TextDecorationLine;</c>
    /// <br/>
    /// <c>string cssValue = TextDecorationLine;</c>
    /// <br/>
    /// <c>TextDecorationLineOptions option = TextDecorationLine;</c>
    /// </summary>
    public class TextDecorationLine
    {
        static TextDecorationLineOptions Option = TextDecorationLineOptions.None;
        static string Value = "none";
        public TextDecorationLine(TextDecorationLineOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextDecorationLine(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextDecorationLine(TextDecorationLineOptions option)
        {
            return new TextDecorationLine(option);
        }

        public static implicit operator TextDecorationLine(string value)
        {
            return new TextDecorationLine(value);
        }

        public static implicit operator string(TextDecorationLine conv)
        {
            return Value;
        }

        public static implicit operator TextDecorationLineOptions(TextDecorationLine conv)
        {
            return GetOption(Value);
        }
        string this[TextDecorationLineOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextDecorationLineOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextDecorationLineOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextDecorationLineOptions>(val);
            if (op == null)
                return Option;
            return (TextDecorationLineOptions)op;
        }
    }
}