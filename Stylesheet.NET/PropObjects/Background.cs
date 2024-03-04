namespace StylesheetNET
{
    /// <summary>
    /// The Background property defines the Background of an element. This can include a color, an image, a color gradient, and more.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Background =  new Background(...);</c>
    /// <br/>
    /// <c>Background = "your css value(s) here";</c>
    /// <br/>
    /// <c>Background = BackgroundOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Background = Background;</c>
    /// <br/>
    /// <c>string cssValue = Background;</c>
    /// <br/>
    /// <c>BackgroundOptions option = Background;</c>
    /// </summary>
    public class Background
    {
        static BackgroundOptions Option = BackgroundOptions.Initial;
        static string Value = "initial";
        public Background(BackgroundOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Background(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Background(BackgroundOptions option)
        {
            return new Background(option);
        }

        public static implicit operator Background(string value)
        {
            return new Background(value);
        }

        public static implicit operator string(Background conv)
        {
            return Value;
        }

        public static implicit operator BackgroundOptions(Background conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundOptions)op;
        }
    }
}