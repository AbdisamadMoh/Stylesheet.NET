namespace Stylesheet.NET
{
    /// <summary>
    /// The ColumnCount property partitions an element into columns. This property is used to create columns for long text content. Examples include articles, news, blogs, essays, and more.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ColumnCount =  new ColumnCount(...);</c>
    /// <br/>
    /// <c>ColumnCount = "your css value(s) here";</c>
    /// <br/>
    /// <c>ColumnCount = ColumnCountOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ColumnCount = ColumnCount;</c>
    /// <br/>
    /// <c>string cssValue = ColumnCount;</c>
    /// <br/>
    /// <c>ColumnCountOptions option = ColumnCount;</c>
    /// </summary>
    public class ColumnCount
    {
        static ColumnCountOptions Option = ColumnCountOptions.Auto;
        static string Value = "auto";
        public ColumnCount(ColumnCountOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ColumnCount(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ColumnCount(ColumnCountOptions option)
        {
            return new ColumnCount(option);
        }

        public static implicit operator ColumnCount(string value)
        {
            return new ColumnCount(value);
        }

        public static implicit operator string(ColumnCount conv)
        {
            return Value;
        }

        public static implicit operator ColumnCountOptions(ColumnCount conv)
        {
            return GetOption(Value);
        }
        string this[ColumnCountOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnCountOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnCountOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnCountOptions>(val);
            if (op == null)
                return Option;
            return (ColumnCountOptions)op;
        }
    }
}