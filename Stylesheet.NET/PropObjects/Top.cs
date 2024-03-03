namespace Stylesheet.NET
{
    /// <summary>
    /// The Top property specifies the vertical position of a positioned element. Positioned elements have a position, such as absolute, sticky and others. The effect of the Top setting depends on the position value.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Top =  new Top(...);</c>
    /// <br/>
    /// <c>Top = "your css value(s) here";</c>
    /// <br/>
    /// <c>Top = TopOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Top = Top;</c>
    /// <br/>
    /// <c>string cssValue = Top;</c>
    /// <br/>
    /// <c>TopOptions option = Top;</c>
    /// </summary>
    public class Top
    {
        static TopOptions Option = TopOptions.Auto;
        static string Value = "auto";
        public Top(TopOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Top(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Top(TopOptions option)
        {
            return new Top(option);
        }

        public static implicit operator Top(string value)
        {
            return new Top(value);
        }

        public static implicit operator string(Top conv)
        {
            return Value;
        }

        public static implicit operator TopOptions(Top conv)
        {
            return GetOption(Value);
        }
        string this[TopOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TopOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TopOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TopOptions>(val);
            if (op == null)
                return Option;
            return (TopOptions)op;
        }
    }
}