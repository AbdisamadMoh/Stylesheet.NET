namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TableLayout"/>
    /// </summary>
    public enum TableLayoutOptions
    {
        /// <summary>
        ///The default. Table and column widths are based on the content of the cells.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Column width is based on the first row of cells, or by assigned column widths. This method speeds up rendering because there are no further width calculations after the first row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'fixed'</c></list>
        /// </summary>
        Fixed,
        /// <summary>
        ///Sets the value to its default value value.
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