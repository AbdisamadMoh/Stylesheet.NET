namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderBottomRightRadius sets the bottom right corner radius. This property gives an element a rounded border effect.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderBottomRightRadius =  new BorderBottomRightRadius(...);</c>
    /// <br/>
    /// <c>BorderBottomRightRadius = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderBottomRightRadius = BorderBottomRightRadiusOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderBottomRightRadius = BorderBottomRightRadius;</c>
    /// <br/>
    /// <c>string cssValue = BorderBottomRightRadius;</c>
    /// <br/>
    /// <c>BorderBottomRightRadiusOptions option = BorderBottomRightRadius;</c>
    /// </summary>
    public class BorderBottomRightRadius
    {
        static BorderBottomRightRadiusOptions Option = BorderBottomRightRadiusOptions.Initial;
        static string Value = "initial";
        public BorderBottomRightRadius(BorderBottomRightRadiusOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderBottomRightRadius(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderBottomRightRadius(BorderBottomRightRadiusOptions option)
        {
            return new BorderBottomRightRadius(option);
        }

        public static implicit operator BorderBottomRightRadius(string value)
        {
            return new BorderBottomRightRadius(value);
        }

        public static implicit operator string(BorderBottomRightRadius conv)
        {
            return Value;
        }

        public static implicit operator BorderBottomRightRadiusOptions(BorderBottomRightRadius conv)
        {
            return GetOption(Value);
        }
        string this[BorderBottomRightRadiusOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderBottomRightRadiusOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderBottomRightRadiusOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderBottomRightRadiusOptions>(val);
            if (op == null)
                return Option;
            return (BorderBottomRightRadiusOptions)op;
        }
    }
}