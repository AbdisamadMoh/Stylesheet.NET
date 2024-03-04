namespace StylesheetNET
{
    /// <summary>
    /// The JustifyContent property aligns items in a flex container. This property only has effect when space is available. The grid layout system can also use this property.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>JustifyContent =  new JustifyContent(...);</c>
    /// <br/>
    /// <c>JustifyContent = "your css value(s) here";</c>
    /// <br/>
    /// <c>JustifyContent = JustifyContentOptions.FlexStart;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_JustifyContent = JustifyContent;</c>
    /// <br/>
    /// <c>string cssValue = JustifyContent;</c>
    /// <br/>
    /// <c>JustifyContentOptions option = JustifyContent;</c>
    /// </summary>
    public class JustifyContent
    {
        static JustifyContentOptions Option = JustifyContentOptions.FlexStart;
        static string Value = "flex-start";
        public JustifyContent(JustifyContentOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public JustifyContent(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator JustifyContent(JustifyContentOptions option)
        {
            return new JustifyContent(option);
        }

        public static implicit operator JustifyContent(string value)
        {
            return new JustifyContent(value);
        }

        public static implicit operator string(JustifyContent conv)
        {
            return Value;
        }

        public static implicit operator JustifyContentOptions(JustifyContent conv)
        {
            return GetOption(Value);
        }
        string this[JustifyContentOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(JustifyContentOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static JustifyContentOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<JustifyContentOptions>(val);
            if (op == null)
                return Option;
            return (JustifyContentOptions)op;
        }
    }
}