namespace Stylesheet.NET
{
    /// <summary>
    /// The UserSelect property sets whether text can be selected. This setting has no effect on the appearance of the element. Users commonly select and highlight text. Text that prevents this feels 'dead'.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>UserSelect =  new UserSelect(...);</c>
    /// <br/>
    /// <c>UserSelect = "your css value(s) here";</c>
    /// <br/>
    /// <c>UserSelect = UserSelectOptions.Auto;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_UserSelect = UserSelect;</c>
    /// <br/>
    /// <c>string cssValue = UserSelect;</c>
    /// <br/>
    /// <c>UserSelectOptions option = UserSelect;</c>
    /// </summary>
    public class UserSelect
    {
        static UserSelectOptions Option = UserSelectOptions.Auto;
        static string Value = "auto";
        public UserSelect(UserSelectOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public UserSelect(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator UserSelect(UserSelectOptions option)
        {
            return new UserSelect(option);
        }

        public static implicit operator UserSelect(string value)
        {
            return new UserSelect(value);
        }

        public static implicit operator string(UserSelect conv)
        {
            return Value;
        }

        public static implicit operator UserSelectOptions(UserSelect conv)
        {
            return GetOption(Value);
        }
        string this[UserSelectOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(UserSelectOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static UserSelectOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<UserSelectOptions>(val);
            if (op == null)
                return Option;
            return (UserSelectOptions)op;
        }
    }
}