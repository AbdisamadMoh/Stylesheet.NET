namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="PageBreakAfter"/>
    /// </summary>
    public enum PageBreakAfterOptions
    {
        /// <summary>
        ///Default. Automatic page-break
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Insert a page-break after the element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'always'</c></list>
        /// </summary>
        Always,
        /// <summary>
        ///Avoid a page-break after the element, if possible
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'avoid'</c></list>
        /// </summary>
        Avoid,
        /// <summary>
        ///Insert a page-break before the element so that the next page is formatted as a Left page
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'left'</c></list>
        /// </summary>
        Left,
        /// <summary>
        ///Insert a page-break after the element so that the next page is formatted as a Right page
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'right'</c></list>
        /// </summary>
        Right,
        /// <summary>
        ///Sets the value to its default value
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits the value from its parent element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}