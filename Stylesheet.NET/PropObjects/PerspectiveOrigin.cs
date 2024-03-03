namespace Stylesheet.NET
{
    /// <summary>
    /// The PerspectiveOrigin property sets the user position in 3D space. This position allows the browser to calculate the perpective of 3D elements. Only child elements will get the 3D effect when using this property.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>PerspectiveOrigin =  new PerspectiveOrigin(...);</c>
    /// <br/>
    /// <c>PerspectiveOrigin = "your css value(s) here";</c>
    /// <br/>
    /// <c>PerspectiveOrigin = PerspectiveOriginOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_PerspectiveOrigin = PerspectiveOrigin;</c>
    /// <br/>
    /// <c>string cssValue = PerspectiveOrigin;</c>
    /// <br/>
    /// <c>PerspectiveOriginOptions option = PerspectiveOrigin;</c>
    /// </summary>
    public class PerspectiveOrigin
    {
        static PerspectiveOriginOptions Option = PerspectiveOriginOptions.Initial;
        static string Value = "initial";
        public PerspectiveOrigin(PerspectiveOriginOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public PerspectiveOrigin(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator PerspectiveOrigin(PerspectiveOriginOptions option)
        {
            return new PerspectiveOrigin(option);
        }

        public static implicit operator PerspectiveOrigin(string value)
        {
            return new PerspectiveOrigin(value);
        }

        public static implicit operator string(PerspectiveOrigin conv)
        {
            return Value;
        }

        public static implicit operator PerspectiveOriginOptions(PerspectiveOrigin conv)
        {
            return GetOption(Value);
        }
        string this[PerspectiveOriginOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PerspectiveOriginOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PerspectiveOriginOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PerspectiveOriginOptions>(val);
            if (op == null)
                return Option;
            return (PerspectiveOriginOptions)op;
        }
    }
}