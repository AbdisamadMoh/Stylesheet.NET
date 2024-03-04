namespace StylesheetNET
{
    /// <summary>
    /// The AlignItems property aligns, and evenly spaces, items. The items are arranged inside a flex container.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AlignItems =  new AlignItems(...);</c>
    /// <br/>
    /// <c>AlignItems = "your css value(s) here";</c>
    /// <br/>
    /// <c>AlignItems = AlignItemsOptions.Stretch;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AlignItems = AlignItems;</c>
    /// <br/>
    /// <c>string cssValue = AlignItems;</c>
    /// <br/>
    /// <c>AlignItemsOptions option = AlignItems;</c>
    /// </summary>
    public class AlignItems
    {
        static AlignItemsOptions Option = AlignItemsOptions.Stretch;
        static string Value = "stretch";
        public AlignItems(AlignItemsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AlignItems(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AlignItems(AlignItemsOptions option)
        {
            return new AlignItems(option);
        }

        public static implicit operator AlignItems(string value)
        {
            return new AlignItems(value);
        }

        public static implicit operator string(AlignItems conv)
        {
            return Value;
        }

        public static implicit operator AlignItemsOptions(AlignItems conv)
        {
            return GetOption(Value);
        }
        string this[AlignItemsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AlignItemsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AlignItemsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AlignItemsOptions>(val);
            if (op == null)
                return Option;
            return (AlignItemsOptions)op;
        }
    }
}