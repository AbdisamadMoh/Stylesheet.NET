namespace Stylesheet.NET
{
    /// <summary>
    /// The caret is the blinking indicator in input elements. The CaretColor property sets the color of the caret. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>CaretColor =  new CaretColor(...);</c>
    /// <br/>
    /// <c>CaretColor = "your css value(s) here";</c>
    /// <br/>
    /// <c>CaretColor = CaretColorOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_CaretColor = CaretColor;</c>
    /// <br/>
    /// <c>string cssValue = CaretColor;</c>
    /// <br/>
    /// <c>CaretColorOptions option = CaretColor;</c>
    /// </summary>
    public class CaretColor
    {
        static CaretColorOptions Option = CaretColorOptions.Auto;
        static string Value = "auto";
        public CaretColor(CaretColorOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public CaretColor(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator CaretColor(CaretColorOptions option)
        {
            return new CaretColor(option);
        }

        public static implicit operator CaretColor(string value)
        {
            return new CaretColor(value);
        }

        public static implicit operator string(CaretColor conv)
        {
            return Value;
        }

        public static implicit operator CaretColorOptions(CaretColor conv)
        {
            return GetOption(Value);
        }
        string this[CaretColorOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(CaretColorOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static CaretColorOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<CaretColorOptions>(val);
            if (op == null)
                return Option;
            return (CaretColorOptions)op;
        }
    }
}