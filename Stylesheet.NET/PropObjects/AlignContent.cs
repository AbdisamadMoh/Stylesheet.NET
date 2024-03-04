namespace StylesheetNET
{
    /// <summary>
    /// The AlignContent property aligns items in a flex container. The alignment is along flex lines (horizontal virtual lines). A flex line works like a magnet, pulling items towards it.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>AlignContent =  new AlignContent(...);</c>
    /// <br/>
    /// <c>AlignContent = "your css value(s) here";</c>
    /// <br/>
    /// <c>AlignContent = AlignContentOptions.Stretch;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_AlignContent = AlignContent;</c>
    /// <br/>
    /// <c>string cssValue = AlignContent;</c>
    /// <br/>
    /// <c>AlignContentOptions option = AlignContent;</c>
    /// </summary>
    public class AlignContent
    {
        static AlignContentOptions Option = AlignContentOptions.Stretch;
        static string Value = "stretch";
        public AlignContent(AlignContentOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public AlignContent(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator AlignContent(AlignContentOptions option)
        {
            return new AlignContent(option);
        }

        public static implicit operator AlignContent(string value)
        {
            return new AlignContent(value);
        }

        public static implicit operator string(AlignContent conv)
        {
            return Value;
        }

        public static implicit operator AlignContentOptions(AlignContent conv)
        {
            return GetOption(Value);
        }
        string this[AlignContentOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(AlignContentOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static AlignContentOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<AlignContentOptions>(val);
            if (op == null)
                return Option;
            return (AlignContentOptions)op;
        }
    }
}