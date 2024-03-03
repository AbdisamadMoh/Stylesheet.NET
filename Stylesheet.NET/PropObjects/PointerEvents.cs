namespace Stylesheet.NET
{
    /// <summary>
    /// The PointerEvents property sets whether an element responds to pointer events. Pointer events includes hover or active states, clicking events, touching events, etc. Most PointerEvents values are relevant for SVG images only.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PointerEvents =  new PointerEvents(...);</c>
    /// <br/>
    /// <c>PointerEvents = "your css value(s) here";</c>
    /// <br/>
    /// <c>PointerEvents = PointerEventsOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PointerEvents = PointerEvents;</c>
    /// <br/>
    /// <c>string cssValue = PointerEvents;</c>
    /// <br/>
    /// <c>PointerEventsOptions option = PointerEvents;</c>
    /// </summary>
    public class PointerEvents
    {
        static PointerEventsOptions Option = PointerEventsOptions.Auto;
        static string Value = "auto";
        public PointerEvents(PointerEventsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PointerEvents(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PointerEvents(PointerEventsOptions option)
        {
            return new PointerEvents(option);
        }

        public static implicit operator PointerEvents(string value)
        {
            return new PointerEvents(value);
        }

        public static implicit operator string(PointerEvents conv)
        {
            return Value;
        }

        public static implicit operator PointerEventsOptions(PointerEvents conv)
        {
            return GetOption(Value);
        }
        string this[PointerEventsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PointerEventsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PointerEventsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PointerEventsOptions>(val);
            if (op == null)
                return Option;
            return (PointerEventsOptions)op;
        }
    }
}