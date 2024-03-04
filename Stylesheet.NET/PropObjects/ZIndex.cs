namespace StylesheetNET
{
    /// <summary>
    /// The ZIndex property defines the element‘s vertical stack order. With overlapping elements, those with the highest value display in front. And those with lower values display behind the other elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ZIndex =  new ZIndex(...);</c>
    /// <br/>
    /// <c>ZIndex = "your css value(s) here";</c>
    /// <br/>
    /// <c>ZIndex = ZIndexOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ZIndex = ZIndex;</c>
    /// <br/>
    /// <c>string cssValue = ZIndex;</c>
    /// <br/>
    /// <c>ZIndexOptions option = ZIndex;</c>
    /// </summary>
    public class ZIndex
    {
        static ZIndexOptions Option = ZIndexOptions.Auto;
        static string Value = "auto";
        public ZIndex(ZIndexOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ZIndex(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ZIndex(ZIndexOptions option)
        {
            return new ZIndex(option);
        }

        public static implicit operator ZIndex(string value)
        {
            return new ZIndex(value);
        }

        public static implicit operator string(ZIndex conv)
        {
            return Value;
        }

        public static implicit operator ZIndexOptions(ZIndex conv)
        {
            return GetOption(Value);
        }
        string this[ZIndexOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ZIndexOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ZIndexOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ZIndexOptions>(val);
            if (op == null)
                return Option;
            return (ZIndexOptions)op;
        }
    }
}