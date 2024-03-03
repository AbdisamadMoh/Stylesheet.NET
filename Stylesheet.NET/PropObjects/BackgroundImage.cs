namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundImage property sets the element's background image. By default, the image repeats vertically and horizontally. This property can also specify a color gradient.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundImage =  new BackgroundImage(...);</c>
    /// <br/>
    /// <c>BackgroundImage = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundImage = BackgroundImageOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundImage = BackgroundImage;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundImage;</c>
    /// <br/>
    /// <c>BackgroundImageOptions option = BackgroundImage;</c>
    /// </summary>
    public class BackgroundImage
    {
        static BackgroundImageOptions Option = BackgroundImageOptions.None;
        static string Value = "none";
        public BackgroundImage(BackgroundImageOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundImage(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundImage(BackgroundImageOptions option)
        {
            return new BackgroundImage(option);
        }

        public static implicit operator BackgroundImage(string value)
        {
            return new BackgroundImage(value);
        }

        public static implicit operator string(BackgroundImage conv)
        {
            return Value;
        }

        public static implicit operator BackgroundImageOptions(BackgroundImage conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundImageOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundImageOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundImageOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundImageOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundImageOptions)op;
        }
    }
}