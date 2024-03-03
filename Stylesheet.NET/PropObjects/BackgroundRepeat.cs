namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundRepeat property repeats a background image. Options include: repeat horizontally, vertically, tiled, or never.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundRepeat =  new BackgroundRepeat(...);</c>
    /// <br/>
    /// <c>BackgroundRepeat = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundRepeat = BackgroundRepeatOptions.Repeat;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundRepeat = BackgroundRepeat;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundRepeat;</c>
    /// <br/>
    /// <c>BackgroundRepeatOptions option = BackgroundRepeat;</c>
    /// </summary>
    public class BackgroundRepeat
    {
        static BackgroundRepeatOptions Option = BackgroundRepeatOptions.Repeat;
        static string Value = "repeat";
        public BackgroundRepeat(BackgroundRepeatOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundRepeat(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundRepeat(BackgroundRepeatOptions option)
        {
            return new BackgroundRepeat(option);
        }

        public static implicit operator BackgroundRepeat(string value)
        {
            return new BackgroundRepeat(value);
        }

        public static implicit operator string(BackgroundRepeat conv)
        {
            return Value;
        }

        public static implicit operator BackgroundRepeatOptions(BackgroundRepeat conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundRepeatOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundRepeatOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundRepeatOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundRepeatOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundRepeatOptions)op;
        }
    }
}