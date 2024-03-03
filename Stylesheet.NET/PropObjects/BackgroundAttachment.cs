namespace Stylesheet.NET
{
    /// <summary>
    /// The BackgroundAttachment sets the background scroll behavior. Possible values include fixed or scroll. A fixed background stays at a fixed position, relative to the viewport. A scroll background scrolls with the page.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>BackgroundAttachment =  new BackgroundAttachment(...);</c>
    /// <br/>
    /// <c>BackgroundAttachment = "your css value(s) here";</c>
    /// <br/>
    /// <c>BackgroundAttachment = BackgroundAttachmentOptions.Scroll;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_BackgroundAttachment = BackgroundAttachment;</c>
    /// <br/>
    /// <c>string cssValue = BackgroundAttachment;</c>
    /// <br/>
    /// <c>BackgroundAttachmentOptions option = BackgroundAttachment;</c>
    /// </summary>
    public class BackgroundAttachment
    {
        static BackgroundAttachmentOptions Option = BackgroundAttachmentOptions.Scroll;
        static string Value = "scroll";
        public BackgroundAttachment(BackgroundAttachmentOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public BackgroundAttachment(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator BackgroundAttachment(BackgroundAttachmentOptions option)
        {
            return new BackgroundAttachment(option);
        }

        public static implicit operator BackgroundAttachment(string value)
        {
            return new BackgroundAttachment(value);
        }

        public static implicit operator string(BackgroundAttachment conv)
        {
            return Value;
        }

        public static implicit operator BackgroundAttachmentOptions(BackgroundAttachment conv)
        {
            return GetOption(Value);
        }
        string this[BackgroundAttachmentOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(BackgroundAttachmentOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static BackgroundAttachmentOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<BackgroundAttachmentOptions>(val);
            if (op == null)
                return Option;
            return (BackgroundAttachmentOptions)op;
        }
    }
}