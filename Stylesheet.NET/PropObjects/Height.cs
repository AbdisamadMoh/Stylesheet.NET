namespace Stylesheet.NET
{
    /// <summary>
    /// The Height property specifies the Height of an element. Height is calculated without the padding, margin, or border. This property accepts any length value (e.g. px, %, cm)
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Height =  new Height(...);</c>
    /// <br/>
    /// <c>Height = "your css value(s) here";</c>
    /// <br/>
    /// <c>Height = HeightOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Height = Height;</c>
    /// <br/>
    /// <c>string cssValue = Height;</c>
    /// <br/>
    /// <c>HeightOptions option = Height;</c>
    /// </summary>
    public class Height
    {
        static HeightOptions Option = HeightOptions.Auto;
        static string Value = "auto";
        public Height(HeightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Height(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Height(HeightOptions option)
        {
            return new Height(option);
        }

        public static implicit operator Height(string value)
        {
            return new Height(value);
        }

        public static implicit operator string(Height conv)
        {
            return Value;
        }

        public static implicit operator HeightOptions(Height conv)
        {
            return GetOption(Value);
        }
        string this[HeightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(HeightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static HeightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<HeightOptions>(val);
            if (op == null)
                return Option;
            return (HeightOptions)op;
        }
    }
}