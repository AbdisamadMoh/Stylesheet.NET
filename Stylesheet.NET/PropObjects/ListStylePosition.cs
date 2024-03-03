namespace Stylesheet.NET
{
    /// <summary>
    /// Markers are the bullets on a list with items. The ListStylePosition property specifies a marker position. They can be displayed inside or outside the list items.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ListStylePosition =  new ListStylePosition(...);</c>
    /// <br/>
    /// <c>ListStylePosition = "your css value(s) here";</c>
    /// <br/>
    /// <c>ListStylePosition = ListStylePositionOptions.Outside;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ListStylePosition = ListStylePosition;</c>
    /// <br/>
    /// <c>string cssValue = ListStylePosition;</c>
    /// <br/>
    /// <c>ListStylePositionOptions option = ListStylePosition;</c>
    /// </summary>
    public class ListStylePosition
    {
        static ListStylePositionOptions Option = ListStylePositionOptions.Outside;
        static string Value = "outside";
        public ListStylePosition(ListStylePositionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ListStylePosition(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ListStylePosition(ListStylePositionOptions option)
        {
            return new ListStylePosition(option);
        }

        public static implicit operator ListStylePosition(string value)
        {
            return new ListStylePosition(value);
        }

        public static implicit operator string(ListStylePosition conv)
        {
            return Value;
        }

        public static implicit operator ListStylePositionOptions(ListStylePosition conv)
        {
            return GetOption(Value);
        }
        string this[ListStylePositionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ListStylePositionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ListStylePositionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ListStylePositionOptions>(val);
            if (op == null)
                return Option;
            return (ListStylePositionOptions)op;
        }
    }
}