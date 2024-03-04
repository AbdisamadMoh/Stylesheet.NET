namespace StylesheetNET
{
    /// <summary>
    /// Gets Predefined options for <c>PrefersReducedMotion</c> media query feature.
    /// </summary>
    public enum PrefersReducedMotionOptions
    {
        /// <summary>
        /// This value denotes that the user has not indicated any specific preferences on their device. 
        /// <br/>
        /// The keyword value is considered as <see langword="false"/>, in other words user has not reduced or changed their preferences setting.
        /// </summary>
        NoPreference,
        /// <summary>
        /// This value denotes that the user has activated the reduce motion setting on their device. The keyword value is considered as <see langword="true"/>.
        /// </summary>
        Reduce
    }
}