namespace StylesheetNET
{
    /// <summary>
    /// BorderImageRepeat specifies how a border image displays. Possible values are repeat, round, stretch, etc.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImageRepeat =  new BorderImageRepeat(...);</c>
    /// <br/>
    /// <c>BorderImageRepeat = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImageRepeat = BorderImageRepeatOptions.Stretch;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImageRepeat = BorderImageRepeat;</c>
    /// <br/>
    /// <c>string cssValue = BorderImageRepeat;</c>
    /// <br/>
    /// <c>BorderImageRepeatOptions option = BorderImageRepeat;</c>
    /// </summary>
    public class BorderImageRepeat
    {
        static BorderImageRepeatOptions Option = BorderImageRepeatOptions.Stretch;
        static string Value = "stretch";
        public BorderImageRepeat(BorderImageRepeatOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImageRepeat(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImageRepeat(BorderImageRepeatOptions option)
        {
            return new BorderImageRepeat(option);
        }

        public static implicit operator BorderImageRepeat(string value)
        {
            return new BorderImageRepeat(value);
        }

        public static implicit operator string(BorderImageRepeat conv)
        {
            return Value;
        }

        public static implicit operator BorderImageRepeatOptions(BorderImageRepeat conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageRepeatOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageRepeatOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageRepeatOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageRepeatOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageRepeatOptions)op;
        }
    }
}