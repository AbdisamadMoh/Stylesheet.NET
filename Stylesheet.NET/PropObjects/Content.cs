namespace Stylesheet.NET
{
    /// <summary>
    /// The Content property inserts Content before or after an element. It uses the ::before and ::after pseudo-elements with this. Content can be a string, a symbol, or an image.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Content =  new Content(...);</c>
    /// <br/>
    /// <c>Content = "your css value(s) here";</c>
    /// <br/>
    /// <c>Content = ContentOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Content = Content;</c>
    /// <br/>
    /// <c>string cssValue = Content;</c>
    /// <br/>
    /// <c>ContentOptions option = Content;</c>
    /// </summary>
    public class Content
    {
        static ContentOptions Option = ContentOptions.Normal;
        static string Value = "normal";
        public Content(ContentOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Content(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Content(ContentOptions option)
        {
            return new Content(option);
        }

        public static implicit operator Content(string value)
        {
            return new Content(value);
        }

        public static implicit operator string(Content conv)
        {
            return Value;
        }

        public static implicit operator ContentOptions(Content conv)
        {
            return GetOption(Value);
        }
        string this[ContentOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ContentOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ContentOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ContentOptions>(val);
            if (op == null)
                return Option;
            return (ContentOptions)op;
        }
    }
}