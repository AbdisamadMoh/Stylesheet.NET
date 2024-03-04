namespace StylesheetNET
{
    /// <summary>
    /// The OutlineColor property specifies the color of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OutlineColor =  new OutlineColor(...);</c>
    /// <br/>
    /// <c>OutlineColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>OutlineColor = OutlineColorOptions.Invert;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OutlineColor = OutlineColor;</c>
    /// <br/>
    /// <c>string cssValue = OutlineColor;</c>
    /// <br/>
    /// <c>OutlineColorOptions option = OutlineColor;</c>
    /// </summary>
    public class OutlineColor
    {
        static OutlineColorOptions Option = OutlineColorOptions.Invert;
        static string Value = "invert";
        public OutlineColor(OutlineColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OutlineColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OutlineColor(OutlineColorOptions option)
        {
            return new OutlineColor(option);
        }

        public static implicit operator OutlineColor(string value)
        {
            return new OutlineColor(value);
        }

        public static implicit operator string(OutlineColor conv)
        {
            return Value;
        }

        public static implicit operator OutlineColorOptions(OutlineColor conv)
        {
            return GetOption(Value);
        }
        string this[OutlineColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OutlineColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OutlineColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OutlineColorOptions>(val);
            if (op == null)
                return Option;
            return (OutlineColorOptions)op;
        }
    }
}