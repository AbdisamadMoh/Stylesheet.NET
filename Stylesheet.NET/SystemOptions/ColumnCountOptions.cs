namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ColumnCount"/>
    /// </summary>
    public enum ColumnCountOptions
    {
        /// <summary>
        ///Default. Column count is determined by column-width and others
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