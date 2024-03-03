namespace Stylesheet.NET
{
    /// <summary>
    /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationStyle property sets the decoration line style. Valid values include solid, wavy, dotted, dashed, or double.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextDecorationStyle =  new TextDecorationStyle(...);</c>
    /// <br/>
    /// <c>TextDecorationStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextDecorationStyle = TextDecorationStyleOptions.Solid;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextDecorationStyle = TextDecorationStyle;</c>
    /// <br/>
    /// <c>string cssValue = TextDecorationStyle;</c>
    /// <br/>
    /// <c>TextDecorationStyleOptions option = TextDecorationStyle;</c>
    /// </summary>
    public class TextDecorationStyle
    {
        static TextDecorationStyleOptions Option = TextDecorationStyleOptions.Solid;
        static string Value = "solid";
        public TextDecorationStyle(TextDecorationStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextDecorationStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextDecorationStyle(TextDecorationStyleOptions option)
        {
            return new TextDecorationStyle(option);
        }

        public static implicit operator TextDecorationStyle(string value)
        {
            return new TextDecorationStyle(value);
        }

        public static implicit operator string(TextDecorationStyle conv)
        {
            return Value;
        }

        public static implicit operator TextDecorationStyleOptions(TextDecorationStyle conv)
        {
            return GetOption(Value);
        }
        string this[TextDecorationStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextDecorationStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextDecorationStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextDecorationStyleOptions>(val);
            if (op == null)
                return Option;
            return (TextDecorationStyleOptions)op;
        }
    }
}