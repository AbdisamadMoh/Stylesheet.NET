namespace StylesheetNET
{
    /// <summary>
    /// BorderImageSlice sets how a border image is sliced. There are 9 slices: four corners, four edges, and the middle.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BorderImageSlice =  new BorderImageSlice(...);</c>
    /// <br/>
    /// <c>BorderImageSlice = "your css value(s) here";</c>
    /// <br/>
    /// <c>BorderImageSlice = BorderImageSliceOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BorderImageSlice = BorderImageSlice;</c>
    /// <br/>
    /// <c>string cssValue = BorderImageSlice;</c>
    /// <br/>
    /// <c>BorderImageSliceOptions option = BorderImageSlice;</c>
    /// </summary>
    public class BorderImageSlice
    {
        static BorderImageSliceOptions Option = BorderImageSliceOptions.Initial;
        static string Value = "initial";
        public BorderImageSlice(BorderImageSliceOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BorderImageSlice(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BorderImageSlice(BorderImageSliceOptions option)
        {
            return new BorderImageSlice(option);
        }

        public static implicit operator BorderImageSlice(string value)
        {
            return new BorderImageSlice(value);
        }

        public static implicit operator string(BorderImageSlice conv)
        {
            return Value;
        }

        public static implicit operator BorderImageSliceOptions(BorderImageSlice conv)
        {
            return GetOption(Value);
        }
        string this[BorderImageSliceOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BorderImageSliceOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BorderImageSliceOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BorderImageSliceOptions>(val);
            if (op == null)
                return Option;
            return (BorderImageSliceOptions)op;
        }
    }
}