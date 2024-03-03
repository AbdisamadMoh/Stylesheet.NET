namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderBottomLeftRadius sets the bottom left corner radius. This property gives an element a rounded border effect.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottomLeftRadius =  new BorderBottomLeftRadius(...);</c>
    /// <br/>
    /// <c>BorderBottomLeftRadius = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottomLeftRadius = BorderBottomLeftRadiusOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottomLeftRadius = BorderBottomLeftRadius;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottomLeftRadius;</c>
    /// <br/>
    /// <c>BorderBottomLeftRadiusOptions option = BorderBottomLeftRadius;</c>
    /// </summary>
    public class BorderBottomLeftRadius
    {
        static BorderBottomLeftRadiusOptions Option = BorderBottomLeftRadiusOptions.Initial;
        static string Value = "initial";
        public BorderBottomLeftRadius(BorderBottomLeftRadiusOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottomLeftRadius(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottomLeftRadius(BorderBottomLeftRadiusOptions option)
        {
            return new BorderBottomLeftRadius(option);
        }

        public static implicit operator BorderBottomLeftRadius(string value)
        {
            return new BorderBottomLeftRadius(value);
        }

        public static implicit operator string(BorderBottomLeftRadius conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomLeftRadiusOptions(BorderBottomLeftRadius conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomLeftRadiusOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomLeftRadiusOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomLeftRadiusOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomLeftRadiusOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomLeftRadiusOptions)op;
        }
    }
}