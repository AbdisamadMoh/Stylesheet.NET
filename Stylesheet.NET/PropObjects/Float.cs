namespace StylesheetNET
{
    /// <summary>
    /// The Float property aligns an element in a container. An element can align (Float) to the left or the right. This property is useful for images with wrapped text.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Float =  new Float(...);</c>
    /// <br/>
    /// <c>Float = "your css value(s) here";</c>
    /// <br/>
    /// <c>Float = FloatOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Float = Float;</c>
    /// <br/>
    /// <c>string cssValue = Float;</c>
    /// <br/>
    /// <c>FloatOptions option = Float;</c>
    /// </summary>
    public class Float
    {
        static FloatOptions Option = FloatOptions.None;
        static string Value = "none";
        public Float(FloatOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Float(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Float(FloatOptions option)
        {
            return new Float(option);
        }

        public static implicit operator Float(string value)
        {
            return new Float(value);
        }

        public static implicit operator string(Float conv)
        {
            return Value;
        }

        public static implicit operator FloatOptions(Float conv)
        {
            return GetOption(Value);
        }
        string this[FloatOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FloatOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FloatOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FloatOptions>(val);
            if (op == null)
                return Option;
            return (FloatOptions)op;
        }
    }
}