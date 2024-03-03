namespace Stylesheet.NET
{
    /// <summary>
    /// The Left property specifies the horizontal position of a positioned element. Positioned elements have a position, such as absolute, sticky, etc. The effect of the Left setting depends on the position value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Left =  new Left(...);</c>
    /// <br/>
    /// <c>Left = "your css value(s) here";</c>
    /// <br/>
    /// <c>Left = LeftOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Left = Left;</c>
    /// <br/>
    /// <c>string cssValue = Left;</c>
    /// <br/>
    /// <c>LeftOptions option = Left;</c>
    /// </summary>
    public class Left
    {
        static LeftOptions Option = LeftOptions.Auto;
        static string Value = "auto";
        public Left(LeftOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Left(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Left(LeftOptions option)
        {
            return new Left(option);
        }

        public static implicit operator Left(string value)
        {
            return new Left(value);
        }

        public static implicit operator string(Left conv)
        {
            return Value;
        }

        public static implicit operator LeftOptions(Left conv)
        {
            return GetOption(Value);
        }
        string this[LeftOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(LeftOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static LeftOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<LeftOptions>(val);
            if (op == null)
                return Option;
            return (LeftOptions)op;
        }
    }
}