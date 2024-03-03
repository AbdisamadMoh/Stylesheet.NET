namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderTopLeftRadius sets the top left corner radius. This property gives an element a rounded border effect.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTopLeftRadius =  new BorderTopLeftRadius(...);</c>
    /// <br/>
    /// <c>BorderTopLeftRadius = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTopLeftRadius = BorderTopLeftRadiusOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTopLeftRadius = BorderTopLeftRadius;</c>
    /// <br/>
    /// <c>string cssValue = BorderTopLeftRadius;</c>
    /// <br/>
    /// <c>BorderTopLeftRadiusOptions option = BorderTopLeftRadius;</c>
    /// </summary>
    public class BorderTopLeftRadius
    {
        static BorderTopLeftRadiusOptions Option = BorderTopLeftRadiusOptions.Initial;
        static string Value = "initial";
        public BorderTopLeftRadius(BorderTopLeftRadiusOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTopLeftRadius(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTopLeftRadius(BorderTopLeftRadiusOptions option)
        {
            return new BorderTopLeftRadius(option);
        }

        public static implicit operator BorderTopLeftRadius(string value)
        {
            return new BorderTopLeftRadius(value);
        }

        public static implicit operator string(BorderTopLeftRadius conv)
        {
            return Value;
        }

        public static implicit operator BorderTopLeftRadiusOptions(BorderTopLeftRadius conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopLeftRadiusOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopLeftRadiusOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopLeftRadiusOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopLeftRadiusOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopLeftRadiusOptions)op;
        }
    }
}