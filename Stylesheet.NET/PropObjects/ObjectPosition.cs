namespace StylesheetNET
{
    /// <summary>
    /// The ObjectPosition defines an offset for an image or video. The effect is that the image appears offset in its own container. It accepts both positive and negative values.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ObjectPosition =  new ObjectPosition(...);</c>
    /// <br/>
    /// <c>ObjectPosition = "your css value(s) here";</c>
    /// <br/>
    /// <c>ObjectPosition = ObjectPositionOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ObjectPosition = ObjectPosition;</c>
    /// <br/>
    /// <c>string cssValue = ObjectPosition;</c>
    /// <br/>
    /// <c>ObjectPositionOptions option = ObjectPosition;</c>
    /// </summary>
    public class ObjectPosition
    {
        static ObjectPositionOptions Option = ObjectPositionOptions.Initial;
        static string Value = "initial";
        public ObjectPosition(ObjectPositionOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ObjectPosition(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ObjectPosition(ObjectPositionOptions option)
        {
            return new ObjectPosition(option);
        }

        public static implicit operator ObjectPosition(string value)
        {
            return new ObjectPosition(value);
        }

        public static implicit operator string(ObjectPosition conv)
        {
            return Value;
        }

        public static implicit operator ObjectPositionOptions(ObjectPosition conv)
        {
            return GetOption(Value);
        }
        string this[ObjectPositionOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ObjectPositionOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ObjectPositionOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ObjectPositionOptions>(val);
            if (op == null)
                return Option;
            return (ObjectPositionOptions)op;
        }
    }
}