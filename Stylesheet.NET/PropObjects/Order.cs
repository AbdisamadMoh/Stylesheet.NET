namespace StylesheetNET
{
    /// <summary>
    /// Flex is a layout system that arranges items in rows and columns. The position of each item can be specified with the Order property. It sets the item Order relative to the other items inside the container.
    /// <br/>
    /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
    /// <br/>
    /// <br/>
    /// <c>Order =  new Order(...);</c>
    /// <br/>
    /// <c>Order = "your css value(s) here";</c>
    /// <br/>
    /// <c>Order = OrderOptions.Initial;</c>
    /// <br/>
    /// <br/>
    /// <list type="bullet"> <c>Also</c> </list>
    /// <c>_Order = Order;</c>
    /// <br/>
    /// <c>string cssValue = Order;</c>
    /// <br/>
    /// <c>OrderOptions option = Order;</c>
    /// </summary>
    public class Order
    {
        static OrderOptions Option = OrderOptions.Initial;
        static string Value = "initial";
        public Order(OrderOptions opt)
        {
            Option = opt;
            Value = this[opt];
        }
        public Order(string CssValue)
        {
            Value = CssValue;
        }
        public static implicit operator Order(OrderOptions option)
        {
            return new Order(option);
        }

        public static implicit operator Order(string value)
        {
            return new Order(value);
        }

        public static implicit operator string(Order conv)
        {
            return Value;
        }

        public static implicit operator OrderOptions(Order conv)
        {
            return GetOption(Value);
        }
        string this[OrderOptions options]
        {
            get
            {
                return GetCssEquavalence(options);
            }
        }
        private static string GetCssEquavalence(OrderOptions options)
        {
            return Keywords.GetKeywordByOption(options);
        }
        private static OrderOptions GetOption(string val)
        {
            var op = Keywords.GetOptionByKeyword<OrderOptions>(val);
            if (op == null)
                return Option;
            return (OrderOptions)op;
        }
    }
}