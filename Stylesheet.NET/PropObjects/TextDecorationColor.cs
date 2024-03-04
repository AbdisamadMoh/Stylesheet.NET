namespace StylesheetNET
{
    /// <summary>
    /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationColor property specifies the color of the line. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextDecorationColor =  new TextDecorationColor(...);</c>
    /// <br/>
    /// <c>TextDecorationColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextDecorationColor = TextDecorationColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextDecorationColor = TextDecorationColor;</c>
    /// <br/>
    /// <c>string cssValue = TextDecorationColor;</c>
    /// <br/>
    /// <c>TextDecorationColorOptions option = TextDecorationColor;</c>
    /// </summary>
    public class TextDecorationColor
    {
        static TextDecorationColorOptions Option = TextDecorationColorOptions.Initial;
        static string Value = "initial";
        public TextDecorationColor(TextDecorationColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextDecorationColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextDecorationColor(TextDecorationColorOptions option)
        {
            return new TextDecorationColor(option);
        }

        public static implicit operator TextDecorationColor(string value)
        {
            return new TextDecorationColor(value);
        }

        public static implicit operator string(TextDecorationColor conv)
        {
            return Value;
        }

        public static implicit operator TextDecorationColorOptions(TextDecorationColor conv)
        {
            return GetOption(Value);
        }
        string this[TextDecorationColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextDecorationColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextDecorationColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextDecorationColorOptions>(val);
            if (op == null)
                return Option;
            return (TextDecorationColorOptions)op;
        }
    }
}