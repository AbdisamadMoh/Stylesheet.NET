namespace Stylesheet.NET
{
    /// <summary>
    /// The Right property specifies the horizontal position of a positioned element. Positioned elements have a position, such as absolute, sticky, etc. The effect of the Right setting depends on the position value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Right =  new Right(...);</c>
    /// <br/>
    /// <c>Right = "your css value(s) here";</c>
    /// <br/>
    /// <c>Right = RightOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Right = Right;</c>
    /// <br/>
    /// <c>string cssValue = Right;</c>
    /// <br/>
    /// <c>RightOptions option = Right;</c>
    /// </summary>
    public class Right
    {
        static RightOptions Option = RightOptions.Auto;
        static string Value = "auto";
        public Right(RightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Right(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Right(RightOptions option)
        {
            return new Right(option);
        }

        public static implicit operator Right(string value)
        {
            return new Right(value);
        }

        public static implicit operator string(Right conv)
        {
            return Value;
        }

        public static implicit operator RightOptions(Right conv)
        {
            return GetOption(Value);
        }
        string this[RightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(RightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static RightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<RightOptions>(val);
            if (op == null)
                return Option;
            return (RightOptions)op;
        }
    }
}