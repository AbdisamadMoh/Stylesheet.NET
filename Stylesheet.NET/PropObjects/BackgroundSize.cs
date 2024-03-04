namespace StylesheetNET
{
    /// <summary>
    /// The BackgroundSize property sets the background image size. It accepts two values: width and height.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundSize =  new BackgroundSize(...);</c>
    /// <br/>
    /// <c>BackgroundSize = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundSize = BackgroundSizeOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundSize = BackgroundSize;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundSize;</c>
    /// <br/>
    /// <c>BackgroundSizeOptions option = BackgroundSize;</c>
    /// </summary>
    public class BackgroundSize
    {
        static BackgroundSizeOptions Option = BackgroundSizeOptions.Auto;
        static string Value = "auto";
        public BackgroundSize(BackgroundSizeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundSize(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundSize(BackgroundSizeOptions option)
        {
            return new BackgroundSize(option);
        }

        public static implicit operator BackgroundSize(string value)
        {
            return new BackgroundSize(value);
        }

        public static implicit operator string(BackgroundSize conv)
        {
            return Value;
        }

        public static implicit operator BackgroundSizeOptions(BackgroundSize conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundSizeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundSizeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundSizeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundSizeOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundSizeOptions)op;
        }
    }
}