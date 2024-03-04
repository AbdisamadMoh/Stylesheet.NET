namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Visibility"/>
    /// </summary>
    public enum VisibilityOptions
    {
        /// <summary>
        ///Default. The element is Visible
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'visible'</c></list>
        /// </summary>
        Visible,
        /// <summary>
        ///Element is Hidden but takes up space.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'hidden'</c></list>
        /// </summary>
        Hidden,
        /// <summary>
        ///Used for table rows, columns, row groups, and column groups. Removes a row or column but still retains the space being used. When used on other elements, it renders as hidden.
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