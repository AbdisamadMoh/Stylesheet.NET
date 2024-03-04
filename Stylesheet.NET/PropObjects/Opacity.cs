namespace StylesheetNET
{
    /// <summary>
    /// The Opacity property defines the transparency of an element. It specifies how much of the background is visible through the element. Opacity values range from 0 (transparent) to 1 (opaque).
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Opacity =  new Opacity(...);</c>
    /// <br/>
    /// <c>Opacity = "your css value(s) here";</c>
    /// <br/>
    /// <c>Opacity = OpacityOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Opacity = Opacity;</c>
    /// <br/>
    /// <c>string cssValue = Opacity;</c>
    /// <br/>
    /// <c>OpacityOptions option = Opacity;</c>
    /// </summary>
    public class Opacity
    {
        static OpacityOptions Option = OpacityOptions.Initial;
        static string Value = "initial";
        public Opacity(OpacityOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Opacity(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Opacity(OpacityOptions option)
        {
            return new Opacity(option);
        }

        public static implicit operator Opacity(string value)
        {
            return new Opacity(value);
        }

        public static implicit operator string(Opacity conv)
        {
            return Value;
        }

        public static implicit operator OpacityOptions(Opacity conv)
        {
            return GetOption(Value);
        }
        string this[OpacityOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OpacityOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OpacityOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OpacityOptions>(val);
            if (op == null)
                return Option;
            return (OpacityOptions)op;
        }
    }
}