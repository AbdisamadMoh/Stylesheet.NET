namespace Stylesheet.NET
{
    /// <summary>
    /// The Position property specifies that an element is Positioned. Positioned elements do not participate in the standard page flow. Options are: static, relative, absolute, fixed, or sticky.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Position =  new Position(...);</c>
    /// <br/>
    /// <c>Position = "your css value(s) here";</c>
    /// <br/>
    /// <c>Position = PositionOptions.Static;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Position = Position;</c>
    /// <br/>
    /// <c>string cssValue = Position;</c>
    /// <br/>
    /// <c>PositionOptions option = Position;</c>
    /// </summary>
    public class Position
    {
        static PositionOptions Option = PositionOptions.Static;
        static string Value = "static";
        public Position(PositionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Position(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Position(PositionOptions option)
        {
            return new Position(option);
        }

        public static implicit operator Position(string value)
        {
            return new Position(value);
        }

        public static implicit operator string(Position conv)
        {
            return Value;
        }

        public static implicit operator PositionOptions(Position conv)
        {
            return GetOption(Value);
        }
        string this[PositionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PositionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PositionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PositionOptions>(val);
            if (op == null)
                return Option;
            return (PositionOptions)op;
        }
    }
}