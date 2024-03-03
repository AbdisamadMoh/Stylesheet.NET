namespace Stylesheet.NET
{
    /// <summary>
    /// The MixBlendMode property specifies how an element's content should blend with its direct parent background.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MixBlendMode =  new MixBlendMode(...);</c>
    /// <br/>
    /// <c>MixBlendMode = "your css value(s) here";</c>
    /// <br/>
    /// <c>MixBlendMode = MixBlendModeOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MixBlendMode = MixBlendMode;</c>
    /// <br/>
    /// <c>string cssValue = MixBlendMode;</c>
    /// <br/>
    /// <c>MixBlendModeOptions option = MixBlendMode;</c>
    /// </summary>
    public class MixBlendMode
    {
        static MixBlendModeOptions Option = MixBlendModeOptions.Normal;
        static string Value = "normal";
        public MixBlendMode(MixBlendModeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MixBlendMode(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MixBlendMode(MixBlendModeOptions option)
        {
            return new MixBlendMode(option);
        }

        public static implicit operator MixBlendMode(string value)
        {
            return new MixBlendMode(value);
        }

        public static implicit operator string(MixBlendMode conv)
        {
            return Value;
        }

        public static implicit operator MixBlendModeOptions(MixBlendMode conv)
        {
            return GetOption(Value);
        }
        string this[MixBlendModeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MixBlendModeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MixBlendModeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MixBlendModeOptions>(val);
            if (op == null)
                return Option;
            return (MixBlendModeOptions)op;
        }
    }
}