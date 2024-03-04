namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ColumnFill"/>
    /// </summary>
    public enum ColumnFillOptions
    {
        /// <summary>
        ///Default. Distibutes column equally
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'balance'</c></list>
        /// </summary>
        Balance,
        /// <summary>
        ///Distribute column to fill container height first
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