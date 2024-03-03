namespace Stylesheet.NET
{
    /// <summary>
    /// The MinHeight property sets the minimum height of an element. It prevents an element from becoming any smaller than the specified value. This property is used when the content is smaller than MinHeight, otherwise it has no effect.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>MinHeight =  new MinHeight(...);</c>
    /// <br/>
    /// <c>MinHeight = "your css value(s) here";</c>
    /// <br/>
    /// <c>MinHeight = MinHeightOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_MinHeight = MinHeight;</c>
    /// <br/>
    /// <c>string cssValue = MinHeight;</c>
    /// <br/>
    /// <c>MinHeightOptions option = MinHeight;</c>
    /// </summary>
    public class MinHeight
    {
        static MinHeightOptions Option = MinHeightOptions.Initial;
        static string Value = "initial";
        public MinHeight(MinHeightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public MinHeight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator MinHeight(MinHeightOptions option)
        {
            return new MinHeight(option);
        }

        public static implicit operator MinHeight(string value)
        {
            return new MinHeight(value);
        }

        public static implicit operator string(MinHeight conv)
        {
            return Value;
        }

        public static implicit operator MinHeightOptions(MinHeight conv)
        {
            return GetOption(Value);
        }
        string this[MinHeightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(MinHeightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static MinHeightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<MinHeightOptions>(val);
            if (op == null)
                return Option;
            return (MinHeightOptions)op;
        }
    }
}