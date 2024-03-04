namespace StylesheetNET
{
    /// <summary>
    /// The AnimationDelay property delays the animation before it starts. Its value is defined in seconds (s) or milliseconds (ms).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationDelay =  new AnimationDelay(...);</c>
    /// <br/>
    /// <c>AnimationDelay = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationDelay = AnimationDelayOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationDelay = AnimationDelay;</c>
    /// <br/>
    /// <c>string cssValue = AnimationDelay;</c>
    /// <br/>
    /// <c>AnimationDelayOptions option = AnimationDelay;</c>
    /// </summary>
    public class AnimationDelay
    {
        static AnimationDelayOptions Option = AnimationDelayOptions.Initial;
        static string Value = "initial";
        public AnimationDelay(AnimationDelayOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationDelay(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationDelay(AnimationDelayOptions option)
        {
            return new AnimationDelay(option);
        }

        public static implicit operator AnimationDelay(string value)
        {
            return new AnimationDelay(value);
        }

        public static implicit operator string(AnimationDelay conv)
        {
            return Value;
        }

        public static implicit operator AnimationDelayOptions(AnimationDelay conv)
        {
            return GetOption(Value);
        }
        string this[AnimationDelayOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationDelayOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationDelayOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationDelayOptions>(val);
            if (op == null)
                return Option;
            return (AnimationDelayOptions)op;
        }
    }
}