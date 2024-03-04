namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BorderCollapse"/>
    /// </summary>
    public enum BorderCollapseOptions
    {
        /// <summary>
        ///Default. Separated borders and each cell having its own border.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'separate'</c></list>
        /// </summary>
        Separate,
        /// <summary>
        ///Collapses border into a single border when possible (border-spacing and empty-cells properties have no effect)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'collapse'</c></list>
        /// </summary>
        Collapse,
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