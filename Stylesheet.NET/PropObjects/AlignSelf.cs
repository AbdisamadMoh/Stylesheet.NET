namespace StylesheetNET
{
    /// <summary>
    /// The AlignSelf property aligns an item in a flex container. This property overides the container‘s align-items value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AlignSelf =  new AlignSelf(...);</c>
    /// <br/>
    /// <c>AlignSelf = "your css value(s) here";</c>
    /// <br/>
    /// <c>AlignSelf = AlignSelfOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AlignSelf = AlignSelf;</c>
    /// <br/>
    /// <c>string cssValue = AlignSelf;</c>
    /// <br/>
    /// <c>AlignSelfOptions option = AlignSelf;</c>
    /// </summary>
    public class AlignSelf
    {
        static AlignSelfOptions Option = AlignSelfOptions.Auto;
        static string Value = "auto";
        public AlignSelf(AlignSelfOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AlignSelf(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AlignSelf(AlignSelfOptions option)
        {
            return new AlignSelf(option);
        }

        public static implicit operator AlignSelf(string value)
        {
            return new AlignSelf(value);
        }

        public static implicit operator string(AlignSelf conv)
        {
            return Value;
        }

        public static implicit operator AlignSelfOptions(AlignSelf conv)
        {
            return GetOption(Value);
        }
        string this[AlignSelfOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AlignSelfOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AlignSelfOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AlignSelfOptions>(val);
            if (op == null)
                return Option;
            return (AlignSelfOptions)op;
        }
    }
}