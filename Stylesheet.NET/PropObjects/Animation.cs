namespace Stylesheet.NET
{
    /// <summary>
    /// The Animation property defines an Animation. It is a shorthand property for several Animation properties. These include <see cref="AnimationDuration"/>, <see cref="AnimationDirection"/>, and others.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Animation =  new Animation(...);</c>
    /// <br/>
    /// <c>Animation = "your css value(s) here";</c>
    /// <br/>
    /// <c>Animation = AnimationOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Animation = Animation;</c>
    /// <br/>
    /// <c>string cssValue = Animation;</c>
    /// <br/>
    /// <c>AnimationOptions option = Animation;</c>
    /// </summary>
    public class Animation
    {
        static AnimationOptions Option = AnimationOptions.Initial;
        static string Value = "initial";
        public Animation(AnimationOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Animation(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Animation(AnimationOptions option)
        {
            return new Animation(option);
        }

        public static implicit operator Animation(string value)
        {
            return new Animation(value);
        }

        public static implicit operator string(Animation conv)
        {
            return Value;
        }

        public static implicit operator AnimationOptions(Animation conv)
        {
            return GetOption(Value);
        }
        string this[AnimationOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AnimationOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AnimationOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AnimationOptions>(val);
            if (op == null)
                return Option;
            return (AnimationOptions)op;
        }
    }
}