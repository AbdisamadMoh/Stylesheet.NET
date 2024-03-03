namespace Stylesheet.NET
{
    /// <summary>
    /// A BorderRadius adds rounded corners to an element. The BorderRadius can have one to four values, one for each corner.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderRadius =  new BorderRadius(...);</c>
    /// <br/>
    /// <c>BorderRadius = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderRadius = BorderRadiusOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderRadius = BorderRadius;</c>
    /// <br/>
    /// <c>string cssValue = BorderRadius;</c>
    /// <br/>
    /// <c>BorderRadiusOptions option = BorderRadius;</c>
    /// </summary>
    public class BorderRadius
    {
        static BorderRadiusOptions Option = BorderRadiusOptions.Initial;
        static string Value = "initial";
        public BorderRadius(BorderRadiusOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderRadius(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderRadius(BorderRadiusOptions option)
        {
            return new BorderRadius(option);
        }

        public static implicit operator BorderRadius(string value)
        {
            return new BorderRadius(value);
        }

        public static implicit operator string(BorderRadius conv)
        {
            return Value;
        }

        public static implicit operator BorderRadiusOptions(BorderRadius conv)
        {
            return GetOption(Value);
        }
        string this[BorderRadiusOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderRadiusOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderRadiusOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderRadiusOptions>(val);
            if (op == null)
                return Option;
            return (BorderRadiusOptions)op;
        }
    }
}