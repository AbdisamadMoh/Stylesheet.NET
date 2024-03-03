namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundClip property extends the background inside the element. The clipping can extend to the content-box, padding-box, or border-box.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundClip =  new BackgroundClip(...);</c>
    /// <br/>
    /// <c>BackgroundClip = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundClip = BackgroundClipOptions.BorderBox;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundClip = BackgroundClip;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundClip;</c>
    /// <br/>
    /// <c>BackgroundClipOptions option = BackgroundClip;</c>
    /// </summary>
    public class BackgroundClip
    {
        static BackgroundClipOptions Option = BackgroundClipOptions.BorderBox;
        static string Value = "border-box";
        public BackgroundClip(BackgroundClipOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundClip(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundClip(BackgroundClipOptions option)
        {
            return new BackgroundClip(option);
        }

        public static implicit operator BackgroundClip(string value)
        {
            return new BackgroundClip(value);
        }

        public static implicit operator string(BackgroundClip conv)
        {
            return Value;
        }

        public static implicit operator BackgroundClipOptions(BackgroundClip conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundClipOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundClipOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundClipOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundClipOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundClipOptions)op;
        }
    }
}