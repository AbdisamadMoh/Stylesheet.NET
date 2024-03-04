namespace StylesheetNET
{
    /// <summary>
    /// The Transform property adds a Transformation to an element. This property allows you to rotate, scale, move, or skew elements. It does this by modifying the coordinates of the elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Transform =  new Transform(...);</c>
    /// <br/>
    /// <c>Transform = "your css value(s) here";</c>
    /// <br/>
    /// <c>Transform = TransformOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Transform = Transform;</c>
    /// <br/>
    /// <c>string cssValue = Transform;</c>
    /// <br/>
    /// <c>TransformOptions option = Transform;</c>
    /// </summary>
    public class Transform
    {
        static TransformOptions Option = TransformOptions.None;
        static string Value = "none";
        public Transform(TransformOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Transform(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Transform(TransformOptions option)
        {
            return new Transform(option);
        }

        public static implicit operator Transform(string value)
        {
            return new Transform(value);
        }

        public static implicit operator string(Transform conv)
        {
            return Value;
        }

        public static implicit operator TransformOptions(Transform conv)
        {
            return GetOption(Value);
        }
        string this[TransformOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TransformOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TransformOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TransformOptions>(val);
            if (op == null)
                return Option;
            return (TransformOptions)op;
        }
    }
}