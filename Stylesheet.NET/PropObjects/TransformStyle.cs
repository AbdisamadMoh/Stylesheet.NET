namespace StylesheetNET
{
    /// <summary>
    /// The TransformStyle defines how child elements are rendered in 3D space. Child elements can be positioned in 3D space or they can be flattened. This setting only applies to elements that take part in 3D transformations.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransformStyle =  new TransformStyle(...);</c>
    /// <br/>
    /// <c>TransformStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransformStyle = TransformStyleOptions.Flat;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransformStyle = TransformStyle;</c>
    /// <br/>
    /// <c>string cssValue = TransformStyle;</c>
    /// <br/>
    /// <c>TransformStyleOptions option = TransformStyle;</c>
    /// </summary>
    public class TransformStyle
    {
        static TransformStyleOptions Option = TransformStyleOptions.Flat;
        static string Value = "flat";
        public TransformStyle(TransformStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransformStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransformStyle(TransformStyleOptions option)
        {
            return new TransformStyle(option);
        }

        public static implicit operator TransformStyle(string value)
        {
            return new TransformStyle(value);
        }

        public static implicit operator string(TransformStyle conv)
        {
            return Value;
        }

        public static implicit operator TransformStyleOptions(TransformStyle conv)
        {
            return GetOption(Value);
        }
        string this[TransformStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransformStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransformStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransformStyleOptions>(val);
            if (op == null)
                return Option;
            return (TransformStyleOptions)op;
        }
    }
}