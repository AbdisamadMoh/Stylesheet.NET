namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderImageOutset property sets a border image outset. It specifies how far the image extends beyond the border. Values are specified in pixels or in numbers where 1 unit is equal to the border width.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImageOutset =  new BorderImageOutset(...);</c>
    /// <br/>
    /// <c>BorderImageOutset = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImageOutset = BorderImageOutsetOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImageOutset = BorderImageOutset;</c>
    /// <br/>
    /// <c>string cssValue = BorderImageOutset;</c>
    /// <br/>
    /// <c>BorderImageOutsetOptions option = BorderImageOutset;</c>
    /// </summary>
    public class BorderImageOutset
    {
        static BorderImageOutsetOptions Option = BorderImageOutsetOptions.Initial;
        static string Value = "initial";
        public BorderImageOutset(BorderImageOutsetOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImageOutset(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImageOutset(BorderImageOutsetOptions option)
        {
            return new BorderImageOutset(option);
        }

        public static implicit operator BorderImageOutset(string value)
        {
            return new BorderImageOutset(value);
        }

        public static implicit operator string(BorderImageOutset conv)
        {
            return Value;
        }

        public static implicit operator BorderImageOutsetOptions(BorderImageOutset conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageOutsetOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageOutsetOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageOutsetOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageOutsetOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageOutsetOptions)op;
        }
    }
}