namespace StylesheetNET
{
    /// <summary>
    /// The TextAlignLast property aligns the last line of a block of text. Options include left, center, right, justify, and others. Not all browsers support this property.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextAlignLast =  new TextAlignLast(...);</c>
    /// <br/>
    /// <c>TextAlignLast = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextAlignLast = TextAlignLastOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextAlignLast = TextAlignLast;</c>
    /// <br/>
    /// <c>string cssValue = TextAlignLast;</c>
    /// <br/>
    /// <c>TextAlignLastOptions option = TextAlignLast;</c>
    /// </summary>
    public class TextAlignLast
    {
        static TextAlignLastOptions Option = TextAlignLastOptions.Auto;
        static string Value = "auto";
        public TextAlignLast(TextAlignLastOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextAlignLast(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextAlignLast(TextAlignLastOptions option)
        {
            return new TextAlignLast(option);
        }

        public static implicit operator TextAlignLast(string value)
        {
            return new TextAlignLast(value);
        }

        public static implicit operator string(TextAlignLast conv)
        {
            return Value;
        }

        public static implicit operator TextAlignLastOptions(TextAlignLast conv)
        {
            return GetOption(Value);
        }
        string this[TextAlignLastOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextAlignLastOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextAlignLastOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextAlignLastOptions>(val);
            if (op == null)
                return Option;
            return (TextAlignLastOptions)op;
        }
    }
}