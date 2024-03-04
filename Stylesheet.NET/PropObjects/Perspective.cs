namespace StylesheetNET
{
    /// <summary>
    /// The Perspective property gives 3D elements a Perspective view. Perspective defines how far away the object is from the user. This property is assigned to a parent element. Only child elements will get a Perspective view.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Perspective =  new Perspective(...);</c>
    /// <br/>
    /// <c>Perspective = "your css value(s) here";</c>
    /// <br/>
    /// <c>Perspective = PerspectiveOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Perspective = Perspective;</c>
    /// <br/>
    /// <c>string cssValue = Perspective;</c>
    /// <br/>
    /// <c>PerspectiveOptions option = Perspective;</c>
    /// </summary>
    public class Perspective
    {
        static PerspectiveOptions Option = PerspectiveOptions.None;
        static string Value = "none";
        public Perspective(PerspectiveOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Perspective(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Perspective(PerspectiveOptions option)
        {
            return new Perspective(option);
        }

        public static implicit operator Perspective(string value)
        {
            return new Perspective(value);
        }

        public static implicit operator string(Perspective conv)
        {
            return Value;
        }

        public static implicit operator PerspectiveOptions(Perspective conv)
        {
            return GetOption(Value);
        }
        string this[PerspectiveOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(PerspectiveOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static PerspectiveOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<PerspectiveOptions>(val);
            if (op == null)
                return Option;
            return (PerspectiveOptions)op;
        }
    }
}