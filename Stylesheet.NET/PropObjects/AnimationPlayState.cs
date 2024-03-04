namespace StylesheetNET
{
    /// <summary>
    /// The AnimationPlayState sets the animation play state. Possible values include paused and running. The default is running.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationPlayState =  new AnimationPlayState(...);</c>
    /// <br/>
    /// <c>AnimationPlayState = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationPlayState = AnimationPlayStateOptions.Running;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationPlayState = AnimationPlayState;</c>
    /// <br/>
    /// <c>string cssValue = AnimationPlayState;</c>
    /// <br/>
    /// <c>AnimationPlayStateOptions option = AnimationPlayState;</c>
    /// </summary>
    public class AnimationPlayState
    {
        static AnimationPlayStateOptions Option = AnimationPlayStateOptions.Running;
        static string Value = "running";
        public AnimationPlayState(AnimationPlayStateOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationPlayState(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationPlayState(AnimationPlayStateOptions option)
        {
            return new AnimationPlayState(option);
        }

        public static implicit operator AnimationPlayState(string value)
        {
            return new AnimationPlayState(value);
        }

        public static implicit operator string(AnimationPlayState conv)
        {
            return Value;
        }

        public static implicit operator AnimationPlayStateOptions(AnimationPlayState conv)
        {
            return GetOption(Value);
        }
        string this[AnimationPlayStateOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationPlayStateOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationPlayStateOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationPlayStateOptions>(val);
            if (op == null)
                return Option;
            return (AnimationPlayStateOptions)op;
        }
    }
}