namespace StylesheetNET
{
    /// <summary>
    /// The OutlineWidth property specifies the width of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OutlineWidth =  new OutlineWidth(...);</c>
    /// <br/>
    /// <c>OutlineWidth = "your css value(s) here";</c>
    /// <br/>
    /// <c>OutlineWidth = OutlineWidthOptions.Medium;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OutlineWidth = OutlineWidth;</c>
    /// <br/>
    /// <c>string cssValue = OutlineWidth;</c>
    /// <br/>
    /// <c>OutlineWidthOptions option = OutlineWidth;</c>
    /// </summary>
    public class OutlineWidth
    {
        static OutlineWidthOptions Option = OutlineWidthOptions.Medium;
        static string Value = "medium";
        public OutlineWidth(OutlineWidthOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OutlineWidth(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OutlineWidth(OutlineWidthOptions option)
        {
            return new OutlineWidth(option);
        }

        public static implicit operator OutlineWidth(string value)
        {
            return new OutlineWidth(value);
        }

        public static implicit operator string(OutlineWidth conv)
        {
            return Value;
        }

        public static implicit operator OutlineWidthOptions(OutlineWidth conv)
        {
            return GetOption(Value);
        }
        string this[OutlineWidthOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OutlineWidthOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OutlineWidthOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OutlineWidthOptions>(val);
            if (op == null)
                return Option;
            return (OutlineWidthOptions)op;
        }
    }
}