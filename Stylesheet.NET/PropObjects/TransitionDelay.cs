namespace StylesheetNET
{
    /// <summary>
    /// The TransitionDelay specifies a time delay before the transition starts. Transition delay can be set in seconds (s) or in milliseconds (ms). By default, transitions are played immediately, i.e. upon page load.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransitionDelay =  new TransitionDelay(...);</c>
    /// <br/>
    /// <c>TransitionDelay = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransitionDelay = TransitionDelayOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransitionDelay = TransitionDelay;</c>
    /// <br/>
    /// <c>string cssValue = TransitionDelay;</c>
    /// <br/>
    /// <c>TransitionDelayOptions option = TransitionDelay;</c>
    /// </summary>
    public class TransitionDelay
    {
        static TransitionDelayOptions Option = TransitionDelayOptions.Initial;
        static string Value = "initial";
        public TransitionDelay(TransitionDelayOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransitionDelay(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransitionDelay(TransitionDelayOptions option)
        {
            return new TransitionDelay(option);
        }

        public static implicit operator TransitionDelay(string value)
        {
            return new TransitionDelay(value);
        }

        public static implicit operator string(TransitionDelay conv)
        {
            return Value;
        }

        public static implicit operator TransitionDelayOptions(TransitionDelay conv)
        {
            return GetOption(Value);
        }
        string this[TransitionDelayOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransitionDelayOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransitionDelayOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransitionDelayOptions>(val);
            if (op == null)
                return Option;
            return (TransitionDelayOptions)op;
        }
    }
}