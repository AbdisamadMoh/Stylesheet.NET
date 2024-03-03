namespace Stylesheet.NET
{
    /// <summary>
    /// The ObjectFit property specifies how an image fits its container. The image may be scaled down, shown fully, or cropped to make it fit. The object-position property is often used to set the image position.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>ObjectFit =  new ObjectFit(...);</c>
    /// <br/>
    /// <c>ObjectFit = "your css value(s) here";</c>
    /// <br/>
    /// <c>ObjectFit = ObjectFitOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_ObjectFit = ObjectFit;</c>
    /// <br/>
    /// <c>string cssValue = ObjectFit;</c>
    /// <br/>
    /// <c>ObjectFitOptions option = ObjectFit;</c>
    /// </summary>
    public class ObjectFit
    {
        static ObjectFitOptions Option = ObjectFitOptions.Initial;
        static string Value = "initial";
        public ObjectFit(ObjectFitOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public ObjectFit(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator ObjectFit(ObjectFitOptions option)
        {
            return new ObjectFit(option);
        }

        public static implicit operator ObjectFit(string value)
        {
            return new ObjectFit(value);
        }

        public static implicit operator string(ObjectFit conv)
        {
            return Value;
        }

        public static implicit operator ObjectFitOptions(ObjectFit conv)
        {
            return GetOption(Value);
        }
        string this[ObjectFitOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(ObjectFitOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static ObjectFitOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<ObjectFitOptions>(val);
            if (op == null)
                return Option;
            return (ObjectFitOptions)op;
        }
    }
}