namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderTopRightRadius sets the top right corner radius. This property gives the element a rounded border effect.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderTopRightRadius =  new BorderTopRightRadius(...);</c>
    /// <br/>
    /// <c>BorderTopRightRadius = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderTopRightRadius = BorderTopRightRadiusOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderTopRightRadius = BorderTopRightRadius;</c>
    /// <br/>
    /// <c>string cssValue = BorderTopRightRadius;</c>
    /// <br/>
    /// <c>BorderTopRightRadiusOptions option = BorderTopRightRadius;</c>
    /// </summary>
    public class BorderTopRightRadius
    {
        static BorderTopRightRadiusOptions Option = BorderTopRightRadiusOptions.Initial;
        static string Value = "initial";
        public BorderTopRightRadius(BorderTopRightRadiusOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderTopRightRadius(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderTopRightRadius(BorderTopRightRadiusOptions option)
        {
            return new BorderTopRightRadius(option);
        }

        public static implicit operator BorderTopRightRadius(string value)
        {
            return new BorderTopRightRadius(value);
        }

        public static implicit operator string(BorderTopRightRadius conv)
        {
            return Value;
        }

        public static implicit operator BorderTopRightRadiusOptions(BorderTopRightRadius conv)
        {
            return GetOption(Value);
        }
        string this[BorderTopRightRadiusOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderTopRightRadiusOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderTopRightRadiusOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderTopRightRadiusOptions>(val);
            if (op == null)
                return Option;
            return (BorderTopRightRadiusOptions)op;
        }
    }
}