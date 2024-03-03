namespace Stylesheet.NET
{
    /// <summary>
    /// The OutlineOffset property specifies the space between border and outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>OutlineOffset =  new OutlineOffset(...);</c>
    /// <br/>
    /// <c>OutlineOffset = "your css value(s) here";</c>
    /// <br/>
    /// <c>OutlineOffset = OutlineOffsetOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_OutlineOffset = OutlineOffset;</c>
    /// <br/>
    /// <c>string cssValue = OutlineOffset;</c>
    /// <br/>
    /// <c>OutlineOffsetOptions option = OutlineOffset;</c>
    /// </summary>
    public class OutlineOffset
    {
        static OutlineOffsetOptions Option = OutlineOffsetOptions.Initial;
        static string Value = "initial";
        public OutlineOffset(OutlineOffsetOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public OutlineOffset(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator OutlineOffset(OutlineOffsetOptions option)
        {
            return new OutlineOffset(option);
        }

        public static implicit operator OutlineOffset(string value)
        {
            return new OutlineOffset(value);
        }

        public static implicit operator string(OutlineOffset conv)
        {
            return Value;
        }

        public static implicit operator OutlineOffsetOptions(OutlineOffset conv)
        {
            return GetOption(Value);
        }
        string this[OutlineOffsetOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OutlineOffsetOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OutlineOffsetOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OutlineOffsetOptions>(val);
            if (op == null)
                return Option;
            return (OutlineOffsetOptions)op;
        }
    }
}