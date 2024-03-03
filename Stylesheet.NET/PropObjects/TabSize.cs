namespace Stylesheet.NET
{
    /// <summary>
    /// The TabSize property specifies the width of a tab character. Default is 8.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>TabSize =  new TabSize(...);</c>
    /// <br/>
    /// <c>TabSize = "your css value(s) here";</c>
    /// <br/>
    /// <c>TabSize = TabSizeOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_TabSize = TabSize;</c>
    /// <br/>
    /// <c>string cssValue = TabSize;</c>
    /// <br/>
    /// <c>TabSizeOptions option = TabSize;</c>
    /// </summary>
    public class TabSize
    {
        static TabSizeOptions Option = TabSizeOptions.Initial;
        static string Value = "initial";
        public TabSize(TabSizeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public TabSize(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator TabSize(TabSizeOptions option)
        {
            return new TabSize(option);
        }

        public static implicit operator TabSize(string value)
        {
            return new TabSize(value);
        }

        public static implicit operator string(TabSize conv)
        {
            return Value;
        }

        public static implicit operator TabSizeOptions(TabSize conv)
        {
            return GetOption(Value);
        }
        string this[TabSizeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(TabSizeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static TabSizeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<TabSizeOptions>(val);
            if (op == null)
                return Option;
            return (TabSizeOptions)op;
        }
    }
}