namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>ColorGamut</c> media query feature.
    /// </summary>
    public enum ColorGamutOptions
    {
        /// <summary>
        /// This value targets devices that can display the standard sRGB color gamut, which is a standard color space used in most consumer displays. 
        /// sRGB represents a somewhat limited range of colors, and it's common on many devices.
        /// </summary>
        Srgb,
        /// <summary>
        /// This value indicates that a device can display at least as many colors as the Display P3 color space, 
        /// and possibly more. The Display P3 color space is a wider gamut than sRGB, it can display more colors. 
        /// It is commonly found in devices like some modern iPhones and high-quality displays.
        /// </summary>
        P3,
        /// <summary>
        /// This device can display at least as many colors as the ITU-R Recommendation BT.2020 color space, 
        /// which is a wider range of colors than the P3 gamut. It's often associated with high-end displays and media production.
        /// </summary>
        Rec2020
    }
}