namespace StylesheetNET
{
    /// <summary>
    /// The BackgroundPosition sets the background image position. Possible values are left, right, center, percentage, pixels, and others. The default position is top left (0 0).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundPosition =  new BackgroundPosition(...);</c>
    /// <br/>
    /// <c>BackgroundPosition = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundPosition = BackgroundPositionOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundPosition = BackgroundPosition;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundPosition;</c>
    /// <br/>
    /// <c>BackgroundPositionOptions option = BackgroundPosition;</c>
    /// </summary>
    public class BackgroundPosition
    {
        static BackgroundPositionOptions Option = BackgroundPositionOptions.Initial;
        static string Value = "initial";
        public BackgroundPosition(BackgroundPositionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundPosition(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundPosition(BackgroundPositionOptions option)
        {
            return new BackgroundPosition(option);
        }

        public static implicit operator BackgroundPosition(string value)
        {
            return new BackgroundPosition(value);
        }

        public static implicit operator string(BackgroundPosition conv)
        {
            return Value;
        }

        public static implicit operator BackgroundPositionOptions(BackgroundPosition conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundPositionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundPositionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundPositionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundPositionOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundPositionOptions)op;
        }
    }
}