namespace Stylesheet.NET
{
    /// <summary>
    /// The FontWeight property specifies the thickness of the text. Text can be displayed in light, normal, bold, bolder, etc. Values can be built-in names, or a number from 100 - 900.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FontWeight =  new FontWeight(...);</c>
    /// <br/>
    /// <c>FontWeight = "your css value(s) here";</c>
    /// <br/>
    /// <c>FontWeight = FontWeightOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FontWeight = FontWeight;</c>
    /// <br/>
    /// <c>string cssValue = FontWeight;</c>
    /// <br/>
    /// <c>FontWeightOptions option = FontWeight;</c>
    /// </summary>
    public class FontWeight
    {
        static FontWeightOptions Option = FontWeightOptions.Normal;
        static string Value = "normal";
        public FontWeight(FontWeightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FontWeight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FontWeight(FontWeightOptions option)
        {
            return new FontWeight(option);
        }

        public static implicit operator FontWeight(string value)
        {
            return new FontWeight(value);
        }

        public static implicit operator string(FontWeight conv)
        {
            return Value;
        }

        public static implicit operator FontWeightOptions(FontWeight conv)
        {
            return GetOption(Value);
        }
        string this[FontWeightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FontWeightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FontWeightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FontWeightOptions>(val);
            if (op == null)
                return Option;
            return (FontWeightOptions)op;
        }
    }
}