namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Hyphens"/>
    /// </summary>
    public enum HyphensOptions
    {
        /// <summary>
        ///Does not hyphen words.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Default. Hyphen words only at &hyphen; (-) or &shy; ()* positions.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'manual'</c></list>
        /// </summary>
        Manual,
        /// <summary>
        ///Hyphen words with the browser deciding the best break points.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
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