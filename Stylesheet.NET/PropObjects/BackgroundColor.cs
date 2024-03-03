namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundColor property specifies the background color. Background color values can be hex, rgb, hsl, rgba, hsla, or a color name. This property can also be set to transparent (no background).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundColor =  new BackgroundColor(...);</c>
    /// <br/>
    /// <c>BackgroundColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundColor = BackgroundColorOptions.Transparent;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundColor = BackgroundColor;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundColor;</c>
    /// <br/>
    /// <c>BackgroundColorOptions option = BackgroundColor;</c>
    /// </summary>
    public class BackgroundColor
    {
        static BackgroundColorOptions Option = BackgroundColorOptions.Transparent;
        static string Value = "transparent";
        public BackgroundColor(BackgroundColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundColor(BackgroundColorOptions option)
        {
            return new BackgroundColor(option);
        }

        public static implicit operator BackgroundColor(string value)
        {
            return new BackgroundColor(value);
        }

        public static implicit operator string(BackgroundColor conv)
        {
            return Value;
        }

        public static implicit operator BackgroundColorOptions(BackgroundColor conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundColorOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundColorOptions)op;
        }
    }
}