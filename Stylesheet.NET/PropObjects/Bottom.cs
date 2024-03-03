namespace Stylesheet.NET
{
    /// <summary>
    /// The Bottom property specifies the vertical position of a positioned element. Positioned elements are positioned as absolute, sticky, etc. The effect of the Bottom setting depends on the position value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Bottom =  new Bottom(...);</c>
    /// <br/>
    /// <c>Bottom = "your css value(s) here";</c>
    /// <br/>
    /// <c>Bottom = BottomOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Bottom = Bottom;</c>
    /// <br/>
    /// <c>string cssValue = Bottom;</c>
    /// <br/>
    /// <c>BottomOptions option = Bottom;</c>
    /// </summary>
    public class Bottom
    {
        static BottomOptions Option = BottomOptions.Auto;
        static string Value = "auto";
        public Bottom(BottomOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Bottom(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Bottom(BottomOptions option)
        {
            return new Bottom(option);
        }

        public static implicit operator Bottom(string value)
        {
            return new Bottom(value);
        }

        public static implicit operator string(Bottom conv)
        {
            return Value;
        }

        public static implicit operator BottomOptions(Bottom conv)
        {
            return GetOption(Value);
        }
        string this[BottomOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BottomOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BottomOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BottomOptions>(val);
            if (op == null)
                return Option;
            return (BottomOptions)op;
        }
    }
}