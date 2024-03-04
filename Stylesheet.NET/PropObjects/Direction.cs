namespace StylesheetNET
{
    /// <summary>
    /// The Direction property specifies the text writing Direction. This property is useful for languages that are written right-to-left. These include Urdu, Arabic, Kurdish, Persian, and Hebrew.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Direction =  new Direction(...);</c>
    /// <br/>
    /// <c>Direction = "your css value(s) here";</c>
    /// <br/>
    /// <c>Direction = DirectionOptions.Ltr;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Direction = Direction;</c>
    /// <br/>
    /// <c>string cssValue = Direction;</c>
    /// <br/>
    /// <c>DirectionOptions option = Direction;</c>
    /// </summary>
    public class Direction
    {
        static DirectionOptions Option = DirectionOptions.Ltr;
        static string Value = "ltr";
        public Direction(DirectionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Direction(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Direction(DirectionOptions option)
        {
            return new Direction(option);
        }

        public static implicit operator Direction(string value)
        {
            return new Direction(value);
        }

        public static implicit operator string(Direction conv)
        {
            return Value;
        }

        public static implicit operator DirectionOptions(Direction conv)
        {
            return GetOption(Value);
        }
        string this[DirectionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(DirectionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static DirectionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<DirectionOptions>(val);
            if (op == null)
                return Option;
            return (DirectionOptions)op;
        }
    }
}