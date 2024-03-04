namespace StylesheetNET
{
    /// <summary>
    /// The TextShadow property adds a shadow effect to text. The details of the shadow are specified by a number of values. These include x-offset, y-offset, blur-radius, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextShadow =  new TextShadow(...);</c>
    /// <br/>
    /// <c>TextShadow = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextShadow = TextShadowOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextShadow = TextShadow;</c>
    /// <br/>
    /// <c>string cssValue = TextShadow;</c>
    /// <br/>
    /// <c>TextShadowOptions option = TextShadow;</c>
    /// </summary>
    public class TextShadow
    {
        static TextShadowOptions Option = TextShadowOptions.None;
        static string Value = "none";
        public TextShadow(TextShadowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextShadow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextShadow(TextShadowOptions option)
        {
            return new TextShadow(option);
        }

        public static implicit operator TextShadow(string value)
        {
            return new TextShadow(value);
        }

        public static implicit operator string(TextShadow conv)
        {
            return Value;
        }

        public static implicit operator TextShadowOptions(TextShadow conv)
        {
            return GetOption(Value);
        }
        string this[TextShadowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextShadowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextShadowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextShadowOptions>(val);
            if (op == null)
                return Option;
            return (TextShadowOptions)op;
        }
    }
}