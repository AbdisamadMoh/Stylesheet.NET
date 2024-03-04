namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TextOverflow"/>
    /// </summary>
    public enum TextOverflowOptions
    {
        /// <summary>
        ///Default. Clip the text and make the rest invisible.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'clip'</c></list>
        /// </summary>
        Clip,
        /// <summary>
        ///Add an Ellipsis (...) to the clipped text
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ellipsis'</c></list>
        /// </summary>
        Ellipsis,
        /// <summary>
        ///Adds a custom String to represent clipped text. Only supported by Firefox.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'string'</c></list>
        /// </summary>
        String,
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