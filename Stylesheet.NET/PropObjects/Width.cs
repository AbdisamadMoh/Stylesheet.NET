namespace StylesheetNET
{
    /// <summary>
    /// The Width property sets an element's Width. Element Width is calculated without the padding, margin, or border. This property accepts any valid CSS length value (e.g. px, %, cm)
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Width =  new Width(...);</c>
    /// <br/>
    /// <c>Width = "your css value(s) here";</c>
    /// <br/>
    /// <c>Width = WidthOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Width = Width;</c>
    /// <br/>
    /// <c>string cssValue = Width;</c>
    /// <br/>
    /// <c>WidthOptions option = Width;</c>
    /// </summary>
    public class Width
    {
        static WidthOptions Option = WidthOptions.Auto;
        static string Value = "auto";
        public Width(WidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Width(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Width(WidthOptions option)
        {
            return new Width(option);
        }

        public static implicit operator Width(string value)
        {
            return new Width(value);
        }

        public static implicit operator string(Width conv)
        {
            return Value;
        }

        public static implicit operator WidthOptions(Width conv)
        {
            return GetOption(Value);
        }
        string this[WidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(WidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static WidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<WidthOptions>(val);
            if (op == null)
                return Option;
            return (WidthOptions)op;
        }
    }
}