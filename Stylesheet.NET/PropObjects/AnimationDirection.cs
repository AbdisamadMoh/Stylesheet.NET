namespace Stylesheet.NET
{
    /// <summary>
    /// The AnimationDirection specifies the direction of the animation. Possible values are forward, backward, and alternate (back and forth).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AnimationDirection =  new AnimationDirection(...);</c>
    /// <br/>
    /// <c>AnimationDirection = "your css value(s) here";</c>
    /// <br/>
    /// <c>AnimationDirection = AnimationDirectionOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AnimationDirection = AnimationDirection;</c>
    /// <br/>
    /// <c>string cssValue = AnimationDirection;</c>
    /// <br/>
    /// <c>AnimationDirectionOptions option = AnimationDirection;</c>
    /// </summary>
    public class AnimationDirection
    {
        static AnimationDirectionOptions Option = AnimationDirectionOptions.Normal;
        static string Value = "normal";
        public AnimationDirection(AnimationDirectionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AnimationDirection(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AnimationDirection(AnimationDirectionOptions option)
        {
            return new AnimationDirection(option);
        }

        public static implicit operator AnimationDirection(string value)
        {
            return new AnimationDirection(value);
        }

        public static implicit operator string(AnimationDirection conv)
        {
            return Value;
        }

        public static implicit operator AnimationDirectionOptions(AnimationDirection conv)
        {
            return GetOption(Value);
        }
        string this[AnimationDirectionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationDirectionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationDirectionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationDirectionOptions>(val);
            if (op == null)
                return Option;
            return (AnimationDirectionOptions)op;
        }
    }
}