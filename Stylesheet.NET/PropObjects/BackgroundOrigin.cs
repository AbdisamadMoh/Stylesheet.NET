namespace Stylesheet.NET
{
    /// <summary>
    /// BackgroundOrigin sets the origin position of the background image. The origin can align with content-box, padding-box, or border-box.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundOrigin =  new BackgroundOrigin(...);</c>
    /// <br/>
    /// <c>BackgroundOrigin = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundOrigin = BackgroundOriginOptions.PaddingBox;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundOrigin = BackgroundOrigin;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundOrigin;</c>
    /// <br/>
    /// <c>BackgroundOriginOptions option = BackgroundOrigin;</c>
    /// </summary>
    public class BackgroundOrigin
    {
        static BackgroundOriginOptions Option = BackgroundOriginOptions.PaddingBox;
        static string Value = "padding-box";
        public BackgroundOrigin(BackgroundOriginOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundOrigin(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundOrigin(BackgroundOriginOptions option)
        {
            return new BackgroundOrigin(option);
        }

        public static implicit operator BackgroundOrigin(string value)
        {
            return new BackgroundOrigin(value);
        }

        public static implicit operator string(BackgroundOrigin conv)
        {
            return Value;
        }

        public static implicit operator BackgroundOriginOptions(BackgroundOrigin conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundOriginOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundOriginOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundOriginOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundOriginOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundOriginOptions)op;
        }
    }
}