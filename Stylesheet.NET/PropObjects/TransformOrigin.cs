namespace StylesheetNET
{
    /// <summary>
    /// The TransformOrigin property defines the origin of the transformation. The origin is the reference point for the transformation calculations. By default, the origin is located at (0,0), or (0,0,0) for 3D transformations.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TransformOrigin =  new TransformOrigin(...);</c>
    /// <br/>
    /// <c>TransformOrigin = "your css value(s) here";</c>
    /// <br/>
    /// <c>TransformOrigin = TransformOriginOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TransformOrigin = TransformOrigin;</c>
    /// <br/>
    /// <c>string cssValue = TransformOrigin;</c>
    /// <br/>
    /// <c>TransformOriginOptions option = TransformOrigin;</c>
    /// </summary>
    public class TransformOrigin
    {
        static TransformOriginOptions Option = TransformOriginOptions.Initial;
        static string Value = "initial";
        public TransformOrigin(TransformOriginOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TransformOrigin(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TransformOrigin(TransformOriginOptions option)
        {
            return new TransformOrigin(option);
        }

        public static implicit operator TransformOrigin(string value)
        {
            return new TransformOrigin(value);
        }

        public static implicit operator string(TransformOrigin conv)
        {
            return Value;
        }

        public static implicit operator TransformOriginOptions(TransformOrigin conv)
        {
            return GetOption(Value);
        }
        string this[TransformOriginOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransformOriginOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransformOriginOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransformOriginOptions>(val);
            if (op == null)
                return Option;
            return (TransformOriginOptions)op;
        }
    }
}