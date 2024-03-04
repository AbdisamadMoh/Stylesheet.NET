namespace StylesheetNET
{
    /// <summary>
    /// The BorderImageSource property sets the border image URL. The URL can be relative or absolute.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImageSource =  new BorderImageSource(...);</c>
    /// <br/>
    /// <c>BorderImageSource = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImageSource = BorderImageSourceOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImageSource = BorderImageSource;</c>
    /// <br/>
    /// <c>string cssValue = BorderImageSource;</c>
    /// <br/>
    /// <c>BorderImageSourceOptions option = BorderImageSource;</c>
    /// </summary>
    public class BorderImageSource
    {
        static BorderImageSourceOptions Option = BorderImageSourceOptions.None;
        static string Value = "none";
        public BorderImageSource(BorderImageSourceOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImageSource(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImageSource(BorderImageSourceOptions option)
        {
            return new BorderImageSource(option);
        }

        public static implicit operator BorderImageSource(string value)
        {
            return new BorderImageSource(value);
        }

        public static implicit operator string(BorderImageSource conv)
        {
            return Value;
        }

        public static implicit operator BorderImageSourceOptions(BorderImageSource conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageSourceOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageSourceOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageSourceOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageSourceOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageSourceOptions)op;
        }
    }
}