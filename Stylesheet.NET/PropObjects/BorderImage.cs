namespace Stylesheet.NET
{
    /// <summary>
    /// The BorderImage property specifies an image as border. Instead of a solid color, the border is drawn with an image.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImage =  new BorderImage(...);</c>
    /// <br/>
    /// <c>BorderImage = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImage = BorderImageOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImage = BorderImage;</c>
    /// <br/>
    /// <c>string cssValue = BorderImage;</c>
    /// <br/>
    /// <c>BorderImageOptions option = BorderImage;</c>
    /// </summary>
    public class BorderImage
    {
        static BorderImageOptions Option = BorderImageOptions.Initial;
        static string Value = "initial";
        public BorderImage(BorderImageOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImage(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImage(BorderImageOptions option)
        {
            return new BorderImage(option);
        }

        public static implicit operator BorderImage(string value)
        {
            return new BorderImage(value);
        }

        public static implicit operator string(BorderImage conv)
        {
            return Value;
        }

        public static implicit operator BorderImageOptions(BorderImage conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageOptions)op;
        }
    }
}