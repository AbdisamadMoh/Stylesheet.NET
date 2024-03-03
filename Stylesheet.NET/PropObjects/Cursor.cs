namespace Stylesheet.NET
{
    /// <summary>
    /// The Cursor property defines a mouse Cursor for an element. The Cursor value can be a keyword or an image. The Cursor appears when the pointer hovers over the element.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Cursor =  new Cursor(...);</c>
    /// <br/>
    /// <c>Cursor = "your css value(s) here";</c>
    /// <br/>
    /// <c>Cursor = CursorOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Cursor = Cursor;</c>
    /// <br/>
    /// <c>string cssValue = Cursor;</c>
    /// <br/>
    /// <c>CursorOptions option = Cursor;</c>
    /// </summary>
    public class Cursor
    {
        static CursorOptions Option = CursorOptions.Auto;
        static string Value = "auto";
        public Cursor(CursorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Cursor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Cursor(CursorOptions option)
        {
            return new Cursor(option);
        }

        public static implicit operator Cursor(string value)
        {
            return new Cursor(value);
        }

        public static implicit operator string(Cursor conv)
        {
            return Value;
        }

        public static implicit operator CursorOptions(Cursor conv)
        {
            return GetOption(Value);
        }
        string this[CursorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(CursorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static CursorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<CursorOptions>(val);
            if (op == null)
                return Option;
            return (CursorOptions)op;
        }
    }
}