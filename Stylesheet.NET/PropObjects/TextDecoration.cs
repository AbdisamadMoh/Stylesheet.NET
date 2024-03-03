namespace Stylesheet.NET
{
    /// <summary>
    /// A text decoration is an underline, an overline, or a strike-through line. The TextDecoration property adds one of these lines to text. The lines can be customized with different styles and colors.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextDecoration =  new TextDecoration(...);</c>
    /// <br/>
    /// <c>TextDecoration = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextDecoration = TextDecorationOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextDecoration = TextDecoration;</c>
    /// <br/>
    /// <c>string cssValue = TextDecoration;</c>
    /// <br/>
    /// <c>TextDecorationOptions option = TextDecoration;</c>
    /// </summary>
    public class TextDecoration
    {
        static TextDecorationOptions Option = TextDecorationOptions.Initial;
        static string Value = "initial";
        public TextDecoration(TextDecorationOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextDecoration(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextDecoration(TextDecorationOptions option)
        {
            return new TextDecoration(option);
        }

        public static implicit operator TextDecoration(string value)
        {
            return new TextDecoration(value);
        }

        public static implicit operator string(TextDecoration conv)
        {
            return Value;
        }

        public static implicit operator TextDecorationOptions(TextDecoration conv)
        {
            return GetOption(Value);
        }
        string this[TextDecorationOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextDecorationOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextDecorationOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextDecorationOptions>(val);
            if (op == null)
                return Option;
            return (TextDecorationOptions)op;
        }
    }
}