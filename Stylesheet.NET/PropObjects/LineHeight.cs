namespace Stylesheet.NET
{
    /// <summary>
    /// The LineHeight property specifies the height of a line of text. Higher values create text with more space between the lines. And lower values create lines that are closer to each other.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>LineHeight =  new LineHeight(...);</c>
    /// <br/>
    /// <c>LineHeight = "your css value(s) here";</c>
    /// <br/>
    /// <c>LineHeight = LineHeightOptions.Normal;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_LineHeight = LineHeight;</c>
    /// <br/>
    /// <c>string cssValue = LineHeight;</c>
    /// <br/>
    /// <c>LineHeightOptions option = LineHeight;</c>
    /// </summary>
    public class LineHeight
    {
        static LineHeightOptions Option = LineHeightOptions.Normal;
        static string Value = "normal";
        public LineHeight(LineHeightOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public LineHeight(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator LineHeight(LineHeightOptions option)
        {
            return new LineHeight(option);
        }

        public static implicit operator LineHeight(string value)
        {
            return new LineHeight(value);
        }

        public static implicit operator string(LineHeight conv)
        {
            return Value;
        }

        public static implicit operator LineHeightOptions(LineHeight conv)
        {
            return GetOption(Value);
        }
        string this[LineHeightOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(LineHeightOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static LineHeightOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<LineHeightOptions>(val);
            if (op == null)
                return Option;
            return (LineHeightOptions)op;
        }
    }
}