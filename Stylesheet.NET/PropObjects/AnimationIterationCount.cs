namespace StylesheetNET
{
    /// <summary>
    /// AnimationIterationCount sets the number of times an animation plays. To continually loop an animation, set the value to infinite. If no value is set, the animation will play only once.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationIterationCount =  new AnimationIterationCount(...);</c>
    /// <br/>
    /// <c>AnimationIterationCount = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationIterationCount = AnimationIterationCountOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationIterationCount = AnimationIterationCount;</c>
    /// <br/>
    /// <c>string cssValue = AnimationIterationCount;</c>
    /// <br/>
    /// <c>AnimationIterationCountOptions option = AnimationIterationCount;</c>
    /// </summary>
    public class AnimationIterationCount
    {
        static AnimationIterationCountOptions Option = AnimationIterationCountOptions.Initial;
        static string Value = "initial";
        public AnimationIterationCount(AnimationIterationCountOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationIterationCount(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationIterationCount(AnimationIterationCountOptions option)
        {
            return new AnimationIterationCount(option);
        }

        public static implicit operator AnimationIterationCount(string value)
        {
            return new AnimationIterationCount(value);
        }

        public static implicit operator string(AnimationIterationCount conv)
        {
            return Value;
        }

        public static implicit operator AnimationIterationCountOptions(AnimationIterationCount conv)
        {
            return GetOption(Value);
        }
        string this[AnimationIterationCountOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationIterationCountOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationIterationCountOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationIterationCountOptions>(val);
            if (op == null)
                return Option;
            return (AnimationIterationCountOptions)op;
        }
    }
}