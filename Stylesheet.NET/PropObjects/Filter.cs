namespace StylesheetNET
{
    /// <summary>
    /// The Filter property adds visual effects to images. Filter effects include blur, color shift, grayscale, drop-shadow, etc. The Filter property can also be used for backgrounds and borders.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Filter =  new Filter(...);</c>
    /// <br/>
    /// <c>Filter = "your css value(s) here";</c>
    /// <br/>
    /// <c>Filter = FilterOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Filter = Filter;</c>
    /// <br/>
    /// <c>string cssValue = Filter;</c>
    /// <br/>
    /// <c>FilterOptions option = Filter;</c>
    /// </summary>
    public class Filter
    {
        static FilterOptions Option = FilterOptions.None;
        static string Value = "none";
        public Filter(FilterOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Filter(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Filter(FilterOptions option)
        {
            return new Filter(option);
        }

        public static implicit operator Filter(string value)
        {
            return new Filter(value);
        }

        public static implicit operator string(Filter conv)
        {
            return Value;
        }

        public static implicit operator FilterOptions(Filter conv)
        {
            return GetOption(Value);
        }
        string this[FilterOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FilterOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FilterOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FilterOptions>(val);
            if (op == null)
                return Option;
            return (FilterOptions)op;
        }
    }
}