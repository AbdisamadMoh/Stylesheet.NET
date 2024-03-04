namespace StylesheetNET
{
    /// <summary>
    /// The Outline property defines an Outline for an element. An Outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Outline =  new Outline(...);</c>
    /// <br/>
    /// <c>Outline = "your css value(s) here";</c>
    /// <br/>
    /// <c>Outline = OutlineOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Outline = Outline;</c>
    /// <br/>
    /// <c>string cssValue = Outline;</c>
    /// <br/>
    /// <c>OutlineOptions option = Outline;</c>
    /// </summary>
    public class Outline
    {
        static OutlineOptions Option = OutlineOptions.Initial;
        static string Value = "initial";
        public Outline(OutlineOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Outline(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Outline(OutlineOptions option)
        {
            return new Outline(option);
        }

        public static implicit operator Outline(string value)
        {
            return new Outline(value);
        }

        public static implicit operator string(Outline conv)
        {
            return Value;
        }

        public static implicit operator OutlineOptions(Outline conv)
        {
            return GetOption(Value);
        }
        string this[OutlineOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OutlineOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OutlineOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OutlineOptions>(val);
            if (op == null)
                return Option;
            return (OutlineOptions)op;
        }
    }
}