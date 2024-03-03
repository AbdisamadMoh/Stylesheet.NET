namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>Update</c> media query feature.
    /// </summary>
    public enum RefreshUpdateOptions
    {
        /// <summary>
        /// The display is not updated. This value is typically used for printed documents.
        /// </summary>
        None,
        /// <summary>
        /// The display has a slow refresh rate. This is common on e-book readers or very slow devices.
        /// </summary>
        Slow,
        /// <summary>
        /// The display has a fast refresh rate. This allows the use of regularly updating elements like CSS Animations.
        /// </summary>
        Fast
    }
}