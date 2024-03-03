namespace Stylesheet.NET
{
    /// <summary>
    /// The TransitionDuration property specifies the time a transition takes. The duration is specified in seconds (s) or in milliseconds (ms). With a value of 0, no transition will occur.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransitionDuration =  new TransitionDuration(...);</c>
    /// <br/>
    /// <c>TransitionDuration = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransitionDuration = TransitionDurationOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransitionDuration = TransitionDuration;</c>
    /// <br/>
    /// <c>string cssValue = TransitionDuration;</c>
    /// <br/>
    /// <c>TransitionDurationOptions option = TransitionDuration;</c>
    /// </summary>
    public class TransitionDuration
    {
        static TransitionDurationOptions Option = TransitionDurationOptions.Initial;
        static string Value = "initial";
        public TransitionDuration(TransitionDurationOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransitionDuration(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransitionDuration(TransitionDurationOptions option)
        {
            return new TransitionDuration(option);
        }

        public static implicit operator TransitionDuration(string value)
        {
            return new TransitionDuration(value);
        }

        public static implicit operator string(TransitionDuration conv)
        {
            return Value;
        }

        public static implicit operator TransitionDurationOptions(TransitionDuration conv)
        {
            return GetOption(Value);
        }
        string this[TransitionDurationOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransitionDurationOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransitionDurationOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransitionDurationOptions>(val);
            if (op == null)
                return Option;
            return (TransitionDurationOptions)op;
        }
    }
}