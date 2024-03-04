namespace StylesheetNET
{
    /// <summary>
    /// The Clear property removes the float effect. After Clearing the page flow will return back to normal.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Clear =  new Clear(...);</c>
    /// <br/>
    /// <c>Clear = "your css value(s) here";</c>
    /// <br/>
    /// <c>Clear = ClearOptions.None;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Clear = Clear;</c>
    /// <br/>
    /// <c>string cssValue = Clear;</c>
    /// <br/>
    /// <c>ClearOptions option = Clear;</c>
    /// </summary>
    public class Clear
    {
        static ClearOptions Option = ClearOptions.None;
        static string Value = "none";
        public Clear(ClearOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Clear(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Clear(ClearOptions option)
        {
            return new Clear(option);
        }

        public static implicit operator Clear(string value)
        {
            return new Clear(value);
        }

        public static implicit operator string(Clear conv)
        {
            return Value;
        }

        public static implicit operator ClearOptions(Clear conv)
        {
            return GetOption(Value);
        }
        string this[ClearOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ClearOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ClearOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ClearOptions>(val);
            if (op == null)
                return Option;
            return (ClearOptions)op;
        }
    }
}