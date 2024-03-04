namespace StylesheetNET
{
    /// <summary>
    /// AnimationFillMode defines a style for when the animation stops. This can be before or after the animation, or both.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationFillMode =  new AnimationFillMode(...);</c>
    /// <br/>
    /// <c>AnimationFillMode = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationFillMode = AnimationFillModeOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationFillMode = AnimationFillMode;</c>
    /// <br/>
    /// <c>string cssValue = AnimationFillMode;</c>
    /// <br/>
    /// <c>AnimationFillModeOptions option = AnimationFillMode;</c>
    /// </summary>
    public class AnimationFillMode
    {
        static AnimationFillModeOptions Option = AnimationFillModeOptions.None;
        static string Value = "none";
        public AnimationFillMode(AnimationFillModeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationFillMode(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationFillMode(AnimationFillModeOptions option)
        {
            return new AnimationFillMode(option);
        }

        public static implicit operator AnimationFillMode(string value)
        {
            return new AnimationFillMode(value);
        }

        public static implicit operator string(AnimationFillMode conv)
        {
            return Value;
        }

        public static implicit operator AnimationFillModeOptions(AnimationFillMode conv)
        {
            return GetOption(Value);
        }
        string this[AnimationFillModeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationFillModeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationFillModeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationFillModeOptions>(val);
            if (op == null)
                return Option;
            return (AnimationFillModeOptions)op;
        }
    }
}