namespace StylesheetNET
{
    /// <summary>
    /// Gets Predefined options for <c>DisplayMode</c> feature.
    /// </summary>
    public enum DisplayModeOptions
    {
        /// <summary>
        ///  This value indicates that the web application is in full-screen mode. 
        ///  This mode typically hides the browser's user interface elements, giving more screen real estate to the web application.
        /// </summary>
        FullScreen,
        /// <summary>
        /// This value indicates that the web application is running in a standalone mode, 
        /// which is often used for web apps that have been added to the home screen or opened as separate applications. 
        /// It's usually presented without the browser's address bar and navigation controls.
        /// </summary>
        Standalone,
        /// <summary>
        ///  This value indicates that the web application is in minimal UI mode, where the browser's user interface is partially hidden, 
        ///  providing more space for the web app content. 
        ///  <code>This mode is less common and may not be supported by all browsers.</code>
        /// </summary>
        MinimalUI,
        /// <summary>
        ///  This value indicates that the web application is running in the default browser mode,
        ///  where it's displayed within the regular web browser interface with all of its controls and features.
        /// </summary>
        Browser,
        /// <summary>
        /// This value targets applications that are displayed in a 
        ///  separate window on the user's desktop, with the Window Controls Overlay feature turned on.
        /// </summary>
        WindowControlsOverlay
    }
}