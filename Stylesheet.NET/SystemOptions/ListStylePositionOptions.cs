namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ListStylePosition"/>
    /// </summary>
    public enum ListStylePositionOptions
    {
        /// <summary>
        ///Markers display Inside the list items.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inside'</c></list>
        /// </summary>
        Inside,
        /// <summary>
        ///Default. Markers display Outside (further to the left).
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'outside'</c></list>
        /// </summary>
        Outside,
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