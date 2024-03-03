namespace Stylesheet.NET
{
    /// <summary>
    /// A backface is a reversed mirror image of the element's front side. The BackfaceVisibility shows the element's back face to the user. This property is used with rotated elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackfaceVisibility =  new BackfaceVisibility(...);</c>
    /// <br/>
    /// <c>BackfaceVisibility = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackfaceVisibility = BackfaceVisibilityOptions.Visible;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackfaceVisibility = BackfaceVisibility;</c>
    /// <br/>
    /// <c>string cssValue = BackfaceVisibility;</c>
    /// <br/>
    /// <c>BackfaceVisibilityOptions option = BackfaceVisibility;</c>
    /// </summary>
    public class BackfaceVisibility
    {
        static BackfaceVisibilityOptions Option = BackfaceVisibilityOptions.Visible;
        static string Value = "visible";
        public BackfaceVisibility(BackfaceVisibilityOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackfaceVisibility(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackfaceVisibility(BackfaceVisibilityOptions option)
        {
            return new BackfaceVisibility(option);
        }

        public static implicit operator BackfaceVisibility(string value)
        {
            return new BackfaceVisibility(value);
        }

        public static implicit operator string(BackfaceVisibility conv)
        {
            return Value;
        }

        public static implicit operator BackfaceVisibilityOptions(BackfaceVisibility conv)
        {
            return GetOption(Value);
        }
        string this[BackfaceVisibilityOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackfaceVisibilityOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackfaceVisibilityOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackfaceVisibilityOptions>(val);
            if (op == null)
                return Option;
            return (BackfaceVisibilityOptions)op;
        }
    }
}