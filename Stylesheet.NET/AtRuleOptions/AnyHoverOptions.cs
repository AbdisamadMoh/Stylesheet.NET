namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>AnyHover</c> media query feature.
    /// </summary>
    public enum AnyHoverOptions
    {
        /// <summary>
        /// This value indicates that no pointing device is available that can hover over elements. 
        /// <br/>
        /// In other words, the user's device doesn't support hover interactions.
        /// </summary>
        None,
        /// <summary>
        /// This value indicates that there is a pointing device available that can hover over elements.
        /// <br/>
        /// This means the user's device supports hover interactions, such as a mouse or a stylus.
        /// </summary>
        Hover
    }
}