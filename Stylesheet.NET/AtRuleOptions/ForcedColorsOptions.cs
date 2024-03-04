namespace StylesheetNET
{
    /// <summary>
    /// Gets Predefined options for <c>ForcedColors</c> media query feature.
    /// </summary>
    public enum ForcedColorsOptions
    {
        /// <summary>
        /// This indicates that forced colors mode is not enabled.
        /// </summary>
        None,
        /// <summary>
        /// This indicates that forced colors mode is enabled.
        /// <code>The browser provides CSS system color keywords and sets the <b>PrefersColorScheme</b> (CSS: <see langword="prefers-color-scheme"/>) media query value by considering the lightness of the Canvas system color, so that web developers can adapt their pages accordingly.</code>
        /// </summary>
        Active
    }
}