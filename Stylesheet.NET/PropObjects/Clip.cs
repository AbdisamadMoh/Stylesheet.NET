namespace Stylesheet.NET
{
    /// <summary>
    /// The Clip property defines the visible region of an image. It does this by Clipping (or cropping) the element. This only works with position:absolute or position:fixed settings.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Clip =  new Clip(...);</c>
    /// <br/>
    /// <c>Clip = "your css value(s) here";</c>
    /// <br/>
    /// <c>Clip = ClipOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Clip = Clip;</c>
    /// <br/>
    /// <c>string cssValue = Clip;</c>
    /// <br/>
    /// <c>ClipOptions option = Clip;</c>
    /// </summary>
    public class Clip
    {
        static ClipOptions Option = ClipOptions.Auto;
        static string Value = "auto";
        public Clip(ClipOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Clip(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Clip(ClipOptions option)
        {
            return new Clip(option);
        }

        public static implicit operator Clip(string value)
        {
            return new Clip(value);
        }

        public static implicit operator string(Clip conv)
        {
            return Value;
        }

        public static implicit operator ClipOptions(Clip conv)
        {
            return GetOption(Value);
        }
        string this[ClipOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ClipOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ClipOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ClipOptions>(val);
            if (op == null)
                return Option;
            return (ClipOptions)op;
        }
    }
}