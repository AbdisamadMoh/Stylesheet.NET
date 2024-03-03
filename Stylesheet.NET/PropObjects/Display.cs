namespace Stylesheet.NET
{
    /// <summary>
    /// The Display property sets an element's Display behavior. Common values include block, inline, flex, and grid. Its value determines how the element participates in the page flow.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Display =  new Display(...);</c>
    /// <br/>
    /// <c>Display = "your css value(s) here";</c>
    /// <br/>
    /// <c>Display = DisplayOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Display = Display;</c>
    /// <br/>
    /// <c>string cssValue = Display;</c>
    /// <br/>
    /// <c>DisplayOptions option = Display;</c>
    /// </summary>
    public class Display
    {
        static DisplayOptions Option = DisplayOptions.Initial;
        static string Value = "initial";
        public Display(DisplayOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Display(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Display(DisplayOptions option)
        {
            return new Display(option);
        }

        public static implicit operator Display(string value)
        {
            return new Display(value);
        }

        public static implicit operator string(Display conv)
        {
            return Value;
        }

        public static implicit operator DisplayOptions(Display conv)
        {
            return GetOption(Value);
        }
        string this[DisplayOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(DisplayOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static DisplayOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<DisplayOptions>(val);
            if (op == null)
                return Option;
            return (DisplayOptions)op;
        }
    }
}