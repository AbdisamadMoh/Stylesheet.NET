namespace Stylesheet.NET
{
    /// <summary>
    /// The TransitionProperty property specifies the property to animate. Multiple properties can be specified with a comma separated list. If no property is specified, all animatable properties will transition.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransitionProperty =  new TransitionProperty(...);</c>
    /// <br/>
    /// <c>TransitionProperty = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransitionProperty = TransitionPropertyOptions.All;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransitionProperty = TransitionProperty;</c>
    /// <br/>
    /// <c>string cssValue = TransitionProperty;</c>
    /// <br/>
    /// <c>TransitionPropertyOptions option = TransitionProperty;</c>
    /// </summary>
    public class TransitionProperty
    {
        static TransitionPropertyOptions Option = TransitionPropertyOptions.All;
        static string Value = "all";
        public TransitionProperty(TransitionPropertyOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransitionProperty(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransitionProperty(TransitionPropertyOptions option)
        {
            return new TransitionProperty(option);
        }

        public static implicit operator TransitionProperty(string value)
        {
            return new TransitionProperty(value);
        }

        public static implicit operator string(TransitionProperty conv)
        {
            return Value;
        }

        public static implicit operator TransitionPropertyOptions(TransitionProperty conv)
        {
            return GetOption(Value);
        }
        string this[TransitionPropertyOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransitionPropertyOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransitionPropertyOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransitionPropertyOptions>(val);
            if (op == null)
                return Option;
            return (TransitionPropertyOptions)op;
        }
    }
}