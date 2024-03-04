namespace StylesheetNET
{
    /// <summary>
    /// The Color property specifies the text Color of an element. Text decorations, such as underlines inherit the same Color. Color values can be hex, rgb, hsl, rgba, hsla, or a Color name.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Color =  new Color(...);</c>
    /// <br/>
    /// <c>Color = "your css value(s) here";</c>
    /// <br/>
    /// <c>Color = ColorOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Color = Color;</c>
    /// <br/>
    /// <c>string cssValue = Color;</c>
    /// <br/>
    /// <c>ColorOptions option = Color;</c>
    /// </summary>
    public class Color
    {
        static ColorOptions Option = ColorOptions.Initial;
        static string Value = "initial";
        public Color(ColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Color(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Color(ColorOptions option)
        {
            return new Color(option);
        }

        public static implicit operator Color(string value)
        {
            return new Color(value);
        }

        public static implicit operator string(Color conv)
        {
            return Value;
        }

        public static implicit operator ColorOptions(Color conv)
        {
            return GetOption(Value);
        }
        string this[ColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColorOptions>(val);
            if (op == null)
                return Option;
            return (ColorOptions)op;
        }
    }
}