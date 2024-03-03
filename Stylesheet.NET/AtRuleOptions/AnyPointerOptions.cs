namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>AnyPointer</c> media query feature.
    /// </summary>
    public enum AnyPointerOptions
    {
        /// <summary>
        /// This value indicates that there is no pointing device available. 
        /// In other words, the user's device doesn't have any input mechanism for pointing.
        /// <para><c>Such devices are quite rare!</c></para>
        /// </summary>
        None,
        /// <summary>
        ///  This indicates that the device has at least one input mechanism capable of pointing to elements, but it might not be very accurate, such as a touchscreen. 
        /// <para> <c>Coarse devices typically lack the precision of a mouse or stylus.</c></para>
        /// </summary>
        Coarse,
        /// <summary>
        /// This value indicates that there is a pointing device available, and it is a fine device with higher precision, such as a mouse or stylus.
        /// </summary>
        Fine
    }
}