namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ListStyleImage"/>
    /// </summary>
    public enum ListStyleImageOptions
    {
        /// <summary>
        ///Default. No image will display. The element uses the list-style-type property instead.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Image path or URL.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'url'</c></list>
        /// </summary>
        Url,
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