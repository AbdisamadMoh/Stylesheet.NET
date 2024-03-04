namespace StylesheetNET
{
    /// <summary>
    /// The AnimationTimingFunction sets the animation speed curve. Options include: linear, ease, steps, and cubic-bezier. These functions describe the transition from one state to another.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationTimingFunction =  new AnimationTimingFunction(...);</c>
    /// <br/>
    /// <c>AnimationTimingFunction = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationTimingFunction = AnimationTimingFunctionOptions.Ease;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationTimingFunction = AnimationTimingFunction;</c>
    /// <br/>
    /// <c>string cssValue = AnimationTimingFunction;</c>
    /// <br/>
    /// <c>AnimationTimingFunctionOptions option = AnimationTimingFunction;</c>
    /// </summary>
    public class AnimationTimingFunction
    {
        static AnimationTimingFunctionOptions Option = AnimationTimingFunctionOptions.Ease;
        static string Value = "ease";
        public AnimationTimingFunction(AnimationTimingFunctionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationTimingFunction(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationTimingFunction(AnimationTimingFunctionOptions option)
        {
            return new AnimationTimingFunction(option);
        }

        public static implicit operator AnimationTimingFunction(string value)
        {
            return new AnimationTimingFunction(value);
        }

        public static implicit operator string(AnimationTimingFunction conv)
        {
            return Value;
        }

        public static implicit operator AnimationTimingFunctionOptions(AnimationTimingFunction conv)
        {
            return GetOption(Value);
        }
        string this[AnimationTimingFunctionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationTimingFunctionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationTimingFunctionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationTimingFunctionOptions>(val);
            if (op == null)
                return Option;
            return (AnimationTimingFunctionOptions)op;
        }
    }
}