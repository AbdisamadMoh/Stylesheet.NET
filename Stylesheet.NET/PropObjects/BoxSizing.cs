namespace Stylesheet.NET
{
    /// <summary>
    /// The BoxSizing property specifies how width and height are calculated. By default, padding and borders are excluded from these calculations. Element sizes may be calculated with or without padding and border values.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BoxSizing =  new BoxSizing(...);</c>
    /// <br/>
    /// <c>BoxSizing = "your css value(s) here";</c>
    /// <br/>
    /// <c>BoxSizing = BoxSizingOptions.ContentBox;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BoxSizing = BoxSizing;</c>
    /// <br/>
    /// <c>string cssValue = BoxSizing;</c>
    /// <br/>
    /// <c>BoxSizingOptions option = BoxSizing;</c>
    /// </summary>
    public class BoxSizing
    {
        static BoxSizingOptions Option = BoxSizingOptions.ContentBox;
        static string Value = "content-box";
        public BoxSizing(BoxSizingOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BoxSizing(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BoxSizing(BoxSizingOptions option)
        {
            return new BoxSizing(option);
        }

        public static implicit operator BoxSizing(string value)
        {
            return new BoxSizing(value);
        }

        public static implicit operator string(BoxSizing conv)
        {
            return Value;
        }

        public static implicit operator BoxSizingOptions(BoxSizing conv)
        {
            return GetOption(Value);
        }
        string this[BoxSizingOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BoxSizingOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BoxSizingOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BoxSizingOptions>(val);
            if (op == null)
                return Option;
            return (BoxSizingOptions)op;
        }
    }
}