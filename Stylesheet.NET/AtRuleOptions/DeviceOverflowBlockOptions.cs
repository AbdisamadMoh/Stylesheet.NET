namespace Stylesheet.NET
{
    /// <summary>
    /// Gets Predefined options for <c>OverFlowBlock</c> media query feature.
    /// </summary>
    public enum DeviceOverflowBlockOptions
    {
        /// <summary>
        /// The content that extends beyond the block axis is not visible.
        /// </summary>
        None,
        /// <summary>
        /// The content that extends beyond the block axis can be visible by scrolling.
        /// </summary>
        Scroll,
        /// <summary>
        /// Overflowing block axis content is scrollable, and manual page breaks (such as break-inside) can be used to display the following content on a new page.
        /// </summary>
        OptionalPaged,
        /// <summary>
        /// The content is divided into separate pages, and any overflow along the block axis extends to the subsequent page.
        /// </summary>
        Paged
    }
}