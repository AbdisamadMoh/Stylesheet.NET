namespace Stylesheet.NET
{
    /// <summary>
    /// The Transition property creates animations. It does this by changing property values over a period of time. Transition is a shorthand for several other Transition properties.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Transition =  new Transition(...);</c>
    /// <br/>
    /// <c>Transition = "your css value(s) here";</c>
    /// <br/>
    /// <c>Transition = TransitionOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Transition = Transition;</c>
    /// <br/>
    /// <c>string cssValue = Transition;</c>
    /// <br/>
    /// <c>TransitionOptions option = Transition;</c>
    /// </summary>
    public class Transition
    {
        static TransitionOptions Option = TransitionOptions.Initial;
        static string Value = "initial";
        public Transition(TransitionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Transition(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Transition(TransitionOptions option)
        {
            return new Transition(option);
        }

        public static implicit operator Transition(string value)
        {
            return new Transition(value);
        }

        public static implicit operator string(Transition conv)
        {
            return Value;
        }

        public static implicit operator TransitionOptions(Transition conv)
        {
            return GetOption(Value);
        }
        string this[TransitionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransitionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransitionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransitionOptions>(val);
            if (op == null)
                return Option;
            return (TransitionOptions)op;
        }
    }
}