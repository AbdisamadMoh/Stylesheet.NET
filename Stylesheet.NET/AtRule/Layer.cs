

namespace Stylesheet.NET
{
    /// <summary>
    /// Stylesheet layer object
    /// </summary>
    public class Layer : CSSSheet
    {
        //https://www.tutorialspoint.com/css/css_at_rules.htm
        /// <summary>
        /// The name of this layer
        /// </summary>
        public string LayerName
        {
            get; set;
        }
    }

}
