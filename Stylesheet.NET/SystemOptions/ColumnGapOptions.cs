namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ColumnGap"/>
    /// </summary>
    public enum ColumnGapOptions
    {
        /// <summary>
        ///Default. Sets a Normal column gap, which is 1em.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
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