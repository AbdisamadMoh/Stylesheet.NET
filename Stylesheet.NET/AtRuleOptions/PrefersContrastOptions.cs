namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>PrefersContrast</c> media query feature.
    /// </summary>
    public enum PrefersContrastOptions
    {
        /// <summary>
        /// The user hasn't specified a contrast preference
        /// </summary>
        NoPreference,
        /// <summary>
        /// The user prefers a higher contrast interface.
        /// </summary>
        More,
        /// <summary>
        /// The user prefers a lower contrast interface.
        /// </summary>
        Less,
        /// <summary>
        /// The user specified specific colors, and the contrast level doesn't match more or less. 
        /// <code>This is often used with <see langword="forced-colors: active"/> settings.</code>
        /// </summary>
        Custom
    }
}