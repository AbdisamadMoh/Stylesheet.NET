namespace StylesheetNET
{
    /// <summary>
    /// The AnimationDuration sets the timespan of an animation cycle. The value is defined in seconds (s) or milliseconds (ms).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationDuration =  new AnimationDuration(...);</c>
    /// <br/>
    /// <c>AnimationDuration = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationDuration = AnimationDurationOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationDuration = AnimationDuration;</c>
    /// <br/>
    /// <c>string cssValue = AnimationDuration;</c>
    /// <br/>
    /// <c>AnimationDurationOptions option = AnimationDuration;</c>
    /// </summary>
    public class AnimationDuration
    {
        static AnimationDurationOptions Option = AnimationDurationOptions.Initial;
        static string Value = "initial";
        public AnimationDuration(AnimationDurationOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationDuration(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationDuration(AnimationDurationOptions option)
        {
            return new AnimationDuration(option);
        }

        public static implicit operator AnimationDuration(string value)
        {
            return new AnimationDuration(value);
        }

        public static implicit operator string(AnimationDuration conv)
        {
            return Value;
        }

        public static implicit operator AnimationDurationOptions(AnimationDuration conv)
        {
            return GetOption(Value);
        }
        string this[AnimationDurationOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationDurationOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationDurationOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationDurationOptions>(val);
            if (op == null)
                return Option;
            return (AnimationDurationOptions)op;
        }
    }
}