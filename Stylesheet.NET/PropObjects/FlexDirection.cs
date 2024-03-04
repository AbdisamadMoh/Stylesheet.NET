namespace StylesheetNET
{
    /// <summary>
    /// FlexDirection specifies the the pack direction of flex items. Items can be packed row-wise, column-wise, and in reverse order. By default, flex items are packed in rows.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>FlexDirection =  new FlexDirection(...);</c>
    /// <br/>
    /// <c>FlexDirection = "your css value(s) here";</c>
    /// <br/>
    /// <c>FlexDirection = FlexDirectionOptions.Row;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_FlexDirection = FlexDirection;</c>
    /// <br/>
    /// <c>string cssValue = FlexDirection;</c>
    /// <br/>
    /// <c>FlexDirectionOptions option = FlexDirection;</c>
    /// </summary>
    public class FlexDirection
    {
        static FlexDirectionOptions Option = FlexDirectionOptions.Row;
        static string Value = "row";
        public FlexDirection(FlexDirectionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public FlexDirection(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator FlexDirection(FlexDirectionOptions option)
        {
            return new FlexDirection(option);
        }

        public static implicit operator FlexDirection(string value)
        {
            return new FlexDirection(value);
        }

        public static implicit operator string(FlexDirection conv)
        {
            return Value;
        }

        public static implicit operator FlexDirectionOptions(FlexDirection conv)
        {
            return GetOption(Value);
        }
        string this[FlexDirectionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(FlexDirectionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static FlexDirectionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<FlexDirectionOptions>(val);
            if (op == null)
                return Option;
            return (FlexDirectionOptions)op;
        }
    }
}