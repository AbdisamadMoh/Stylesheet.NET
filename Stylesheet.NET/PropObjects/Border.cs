namespace Stylesheet.NET
{
    /// <summary>
    /// The Border property adds a Border to an element. Borders can vary in width, line style, and color.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Border =  new Border(...);</c>
    /// <br/>
    /// <c>Border = "your css value(s) here";</c>
    /// <br/>
    /// <c>Border = BorderOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Border = Border;</c>
    /// <br/>
    /// <c>string cssValue = Border;</c>
    /// <br/>
    /// <c>BorderOptions option = Border;</c>
    /// </summary>
    public class Border
    {
        static BorderOptions Option = BorderOptions.Initial;
        static string Value = "initial";
        public Border(BorderOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Border(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Border(BorderOptions option)
        {
            return new Border(option);
        }

        public static implicit operator Border(string value)
        {
            return new Border(value);
        }

        public static implicit operator string(Border conv)
        {
            return Value;
        }

        public static implicit operator BorderOptions(Border conv)
        {
            return GetOption(Value);
        }
        string this[BorderOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderOptions>(val);
            if (op == null)
                return Option;
            return (BorderOptions)op;
        }
    }
}