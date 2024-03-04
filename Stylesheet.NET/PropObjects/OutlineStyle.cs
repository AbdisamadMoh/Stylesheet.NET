namespace StylesheetNET
{
    /// <summary>
    /// The OutlineStyle property specifies the style of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OutlineStyle =  new OutlineStyle(...);</c>
    /// <br/>
    /// <c>OutlineStyle = "your css value(s) here";</c>
    /// <br/>
    /// <c>OutlineStyle = OutlineStyleOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OutlineStyle = OutlineStyle;</c>
    /// <br/>
    /// <c>string cssValue = OutlineStyle;</c>
    /// <br/>
    /// <c>OutlineStyleOptions option = OutlineStyle;</c>
    /// </summary>
    public class OutlineStyle
    {
        static OutlineStyleOptions Option = OutlineStyleOptions.None;
        static string Value = "none";
        public OutlineStyle(OutlineStyleOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OutlineStyle(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OutlineStyle(OutlineStyleOptions option)
        {
            return new OutlineStyle(option);
        }

        public static implicit operator OutlineStyle(string value)
        {
            return new OutlineStyle(value);
        }

        public static implicit operator string(OutlineStyle conv)
        {
            return Value;
        }

        public static implicit operator OutlineStyleOptions(OutlineStyle conv)
        {
            return GetOption(Value);
        }
        string this[OutlineStyleOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OutlineStyleOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OutlineStyleOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OutlineStyleOptions>(val);
            if (op == null)
                return Option;
            return (OutlineStyleOptions)op;
        }
    }
}