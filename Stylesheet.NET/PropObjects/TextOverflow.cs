namespace Stylesheet.NET
{
    /// <summary>
    /// The TextOverflow property sets how overflowing text is handled. Options include clip, ellipsis, and others. white-space:nowrap and overflow:hidden are required to make it work.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TextOverflow =  new TextOverflow(...);</c>
    /// <br/>
    /// <c>TextOverflow = "your css value(s) here";</c>
    /// <br/>
    /// <c>TextOverflow = TextOverflowOptions.Clip;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TextOverflow = TextOverflow;</c>
    /// <br/>
    /// <c>string cssValue = TextOverflow;</c>
    /// <br/>
    /// <c>TextOverflowOptions option = TextOverflow;</c>
    /// </summary>
    public class TextOverflow
    {
        static TextOverflowOptions Option = TextOverflowOptions.Clip;
        static string Value = "clip";
        public TextOverflow(TextOverflowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TextOverflow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TextOverflow(TextOverflowOptions option)
        {
            return new TextOverflow(option);
        }

        public static implicit operator TextOverflow(string value)
        {
            return new TextOverflow(value);
        }

        public static implicit operator string(TextOverflow conv)
        {
            return Value;
        }

        public static implicit operator TextOverflowOptions(TextOverflow conv)
        {
            return GetOption(Value);
        }
        string this[TextOverflowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TextOverflowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TextOverflowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TextOverflowOptions>(val);
            if (op == null)
                return Option;
            return (TextOverflowOptions)op;
        }
    }
}