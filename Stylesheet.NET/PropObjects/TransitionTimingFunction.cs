namespace Stylesheet.NET
{
    /// <summary>
    /// The TransitionTimingFunction sets the transition speed curve. The speed curve specifies the speed and acceleration of a transition. Options include ease-in, steps, and bezier.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransitionTimingFunction =  new TransitionTimingFunction(...);</c>
    /// <br/>
    /// <c>TransitionTimingFunction = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransitionTimingFunction = TransitionTimingFunctionOptions.Ease;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransitionTimingFunction = TransitionTimingFunction;</c>
    /// <br/>
    /// <c>string cssValue = TransitionTimingFunction;</c>
    /// <br/>
    /// <c>TransitionTimingFunctionOptions option = TransitionTimingFunction;</c>
    /// </summary>
    public class TransitionTimingFunction
    {
        static TransitionTimingFunctionOptions Option = TransitionTimingFunctionOptions.Ease;
        static string Value = "ease";
        public TransitionTimingFunction(TransitionTimingFunctionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransitionTimingFunction(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransitionTimingFunction(TransitionTimingFunctionOptions option)
        {
            return new TransitionTimingFunction(option);
        }

        public static implicit operator TransitionTimingFunction(string value)
        {
            return new TransitionTimingFunction(value);
        }

        public static implicit operator string(TransitionTimingFunction conv)
        {
            return Value;
        }

        public static implicit operator TransitionTimingFunctionOptions(TransitionTimingFunction conv)
        {
            return GetOption(Value);
        }
        string this[TransitionTimingFunctionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransitionTimingFunctionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransitionTimingFunctionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransitionTimingFunctionOptions>(val);
            if (op == null)
                return Option;
            return (TransitionTimingFunctionOptions)op;
        }
    }
}