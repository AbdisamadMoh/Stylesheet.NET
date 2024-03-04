namespace StylesheetNET
{
    /// <summary>
    /// Markers are the bullets on a list with items. The ListStyleImage property uses an image as marker. The image marker displays as is, and cannot be resized.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ListStyleImage =  new ListStyleImage(...);</c>
    /// <br/>
    /// <c>ListStyleImage = "your css value(s) here";</c>
    /// <br/>
    /// <c>ListStyleImage = ListStyleImageOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ListStyleImage = ListStyleImage;</c>
    /// <br/>
    /// <c>string cssValue = ListStyleImage;</c>
    /// <br/>
    /// <c>ListStyleImageOptions option = ListStyleImage;</c>
    /// </summary>
    public class ListStyleImage
    {
        static ListStyleImageOptions Option = ListStyleImageOptions.None;
        static string Value = "none";
        public ListStyleImage(ListStyleImageOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ListStyleImage(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ListStyleImage(ListStyleImageOptions option)
        {
            return new ListStyleImage(option);
        }

        public static implicit operator ListStyleImage(string value)
        {
            return new ListStyleImage(value);
        }

        public static implicit operator string(ListStyleImage conv)
        {
            return Value;
        }

        public static implicit operator ListStyleImageOptions(ListStyleImage conv)
        {
            return GetOption(Value);
        }
        string this[ListStyleImageOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ListStyleImageOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ListStyleImageOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ListStyleImageOptions>(val);
            if (op == null)
                return Option;
            return (ListStyleImageOptions)op;
        }
    }
}