namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="PageBreakInside"/>
    /// </summary>
    public enum PageBreakInsideOptions
    {
        /// <summary>
        ///Default. Automatic page-break
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Avoid a page-break after the element (if possible)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'avoid'</c></list>
        /// </summary>
        Avoid,
        /// <summary>
        ///Sets the value to its default value.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits the value from its parent element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}