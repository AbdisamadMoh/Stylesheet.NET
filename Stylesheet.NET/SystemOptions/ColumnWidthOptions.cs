namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ColumnWidth"/>
    /// </summary>
    public enum ColumnWidthOptions
    {
        /// <summary>
        ///Default. Column width is determined by the browser
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