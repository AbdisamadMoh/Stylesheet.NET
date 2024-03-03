namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundBlendMode property blends background layers together. This property may include multiple images to be blended. Background images can also blend with a background color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundBlendMode =  new BackgroundBlendMode(...);</c>
    /// <br/>
    /// <c>BackgroundBlendMode = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundBlendMode = BackgroundBlendModeOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundBlendMode = BackgroundBlendMode;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundBlendMode;</c>
    /// <br/>
    /// <c>BackgroundBlendModeOptions option = BackgroundBlendMode;</c>
    /// </summary>
    public class BackgroundBlendMode
    {
        static BackgroundBlendModeOptions Option = BackgroundBlendModeOptions.Normal;
        static string Value = "normal";
        public BackgroundBlendMode(BackgroundBlendModeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundBlendMode(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundBlendMode(BackgroundBlendModeOptions option)
        {
            return new BackgroundBlendMode(option);
        }

        public static implicit operator BackgroundBlendMode(string value)
        {
            return new BackgroundBlendMode(value);
        }

        public static implicit operator string(BackgroundBlendMode conv)
        {
            return Value;
        }

        public static implicit operator BackgroundBlendModeOptions(BackgroundBlendMode conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundBlendModeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundBlendModeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundBlendModeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundBlendModeOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundBlendModeOptions)op;
        }
    }
}