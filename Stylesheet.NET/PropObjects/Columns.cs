namespace Stylesheet.NET
{
    /// <summary>
    /// The Columns property divides an element into Columns. Its value includes a min column width and a number of Columns.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Columns =  new Columns(...);</c>
    /// <br/>
    /// <c>Columns = "your css value(s) here";</c>
    /// <br/>
    /// <c>Columns = ColumnsOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Columns = Columns;</c>
    /// <br/>
    /// <c>string cssValue = Columns;</c>
    /// <br/>
    /// <c>ColumnsOptions option = Columns;</c>
    /// </summary>
    public class Columns
    {
        static ColumnsOptions Option = ColumnsOptions.Initial;
        static string Value = "initial";
        public Columns(ColumnsOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Columns(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Columns(ColumnsOptions option)
        {
            return new Columns(option);
        }

        public static implicit operator Columns(string value)
        {
            return new Columns(value);
        }

        public static implicit operator string(Columns conv)
        {
            return Value;
        }

        public static implicit operator ColumnsOptions(Columns conv)
        {
            return GetOption(Value);
        }
        string this[ColumnsOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ColumnsOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ColumnsOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ColumnsOptions>(val);
            if (op == null)
                return Option;
            return (ColumnsOptions)op;
        }
    }
}