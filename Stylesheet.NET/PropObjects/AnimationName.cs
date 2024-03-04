namespace StylesheetNET
{
    /// <summary>
    /// The AnimationName references a keyframes name. @keyframes rules specify the animation conditions. This is the animation that will play.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationName =  new AnimationName(...);</c>
    /// <br/>
    /// <c>AnimationName = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationName = AnimationNameOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationName = AnimationName;</c>
    /// <br/>
    /// <c>string cssValue = AnimationName;</c>
    /// <br/>
    /// <c>AnimationNameOptions option = AnimationName;</c>
    /// </summary>
    public class AnimationName
    {
        static AnimationNameOptions Option = AnimationNameOptions.None;
        static string Value = "none";
        public AnimationName(AnimationNameOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationName(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationName(AnimationNameOptions option)
        {
            return new AnimationName(option);
        }

        public static implicit operator AnimationName(string value)
        {
            return new AnimationName(value);
        }

        public static implicit operator string(AnimationName conv)
        {
            return Value;
        }

        public static implicit operator AnimationNameOptions(AnimationName conv)
        {
            return GetOption(Value);
        }
        string this[AnimationNameOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationNameOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationNameOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationNameOptions>(val);
            if (op == null)
                return Option;
            return (AnimationNameOptions)op;
        }
    }
}