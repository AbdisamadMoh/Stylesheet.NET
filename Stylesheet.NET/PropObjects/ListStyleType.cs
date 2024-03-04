namespace StylesheetNET
{
    /// <summary>
    /// Markers are the bullets or numeric values on a list with items. The ListStyleType property defines the type of marker.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ListStyleType =  new ListStyleType(...);</c>
    /// <br/>
    /// <c>ListStyleType = "your css value(s) here";</c>
    /// <br/>
    /// <c>ListStyleType = ListStyleTypeOptions.Disc;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ListStyleType = ListStyleType;</c>
    /// <br/>
    /// <c>string cssValue = ListStyleType;</c>
    /// <br/>
    /// <c>ListStyleTypeOptions option = ListStyleType;</c>
    /// </summary>
    public class ListStyleType
    {
        static ListStyleTypeOptions Option = ListStyleTypeOptions.Disc;
        static string Value = "disc";
        public ListStyleType(ListStyleTypeOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ListStyleType(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ListStyleType(ListStyleTypeOptions option)
        {
            return new ListStyleType(option);
        }

        public static implicit operator ListStyleType(string value)
        {
            return new ListStyleType(value);
        }

        public static implicit operator string(ListStyleType conv)
        {
            return Value;
        }

        public static implicit operator ListStyleTypeOptions(ListStyleType conv)
        {
            return GetOption(Value);
        }
        string this[ListStyleTypeOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ListStyleTypeOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ListStyleTypeOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ListStyleTypeOptions>(val);
            if (op == null)
                return Option;
            return (ListStyleTypeOptions)op;
        }
    }
}