namespace Stylesheet.NET
{
    /// <summary>
    /// The BoxShadow property adds a shadow effect to an element. An element can have one or more box shadows.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BoxShadow =  new BoxShadow(...);</c>
    /// <br/>
    /// <c>BoxShadow = "your css value(s) here";</c>
    /// <br/>
    /// <c>BoxShadow = BoxShadowOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BoxShadow = BoxShadow;</c>
    /// <br/>
    /// <c>string cssValue = BoxShadow;</c>
    /// <br/>
    /// <c>BoxShadowOptions option = BoxShadow;</c>
    /// </summary>
    public class BoxShadow
    {
        static BoxShadowOptions Option = BoxShadowOptions.None;
        static string Value = "none";
        public BoxShadow(BoxShadowOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BoxShadow(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BoxShadow(BoxShadowOptions option)
        {
            return new BoxShadow(option);
        }

        public static implicit operator BoxShadow(string value)
        {
            return new BoxShadow(value);
        }

        public static implicit operator string(BoxShadow conv)
        {
            return Value;
        }

        public static implicit operator BoxShadowOptions(BoxShadow conv)
        {
            return GetOption(Value);
        }
        string this[BoxShadowOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BoxShadowOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BoxShadowOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BoxShadowOptions>(val);
            if (op == null)
                return Option;
            return (BoxShadowOptions)op;
        }
    }
}