namespace Stylesheet.NET
{
    /// <summary>
    /// The Visibility property specifies whether an element is visible or hidden. When hidden the element still occupies the same space on the page.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Visibility =  new Visibility(...);</c>
    /// <br/>
    /// <c>Visibility = "your css value(s) here";</c>
    /// <br/>
    /// <c>Visibility = VisibilityOptions.Visible;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Visibility = Visibility;</c>
    /// <br/>
    /// <c>string cssValue = Visibility;</c>
    /// <br/>
    /// <c>VisibilityOptions option = Visibility;</c>
    /// </summary>
    public class Visibility
    {
        static VisibilityOptions Option = VisibilityOptions.Visible;
        static string Value = "visible";
        public Visibility(VisibilityOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Visibility(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Visibility(VisibilityOptions option)
        {
            return new Visibility(option);
        }

        public static implicit operator Visibility(string value)
        {
            return new Visibility(value);
        }

        public static implicit operator string(Visibility conv)
        {
            return Value;
        }

        public static implicit operator VisibilityOptions(Visibility conv)
        {
            return GetOption(Value);
        }
        string this[VisibilityOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(VisibilityOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static VisibilityOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<VisibilityOptions>(val);
            if (op == null)
                return Option;
            return (VisibilityOptions)op;
        }
    }
}