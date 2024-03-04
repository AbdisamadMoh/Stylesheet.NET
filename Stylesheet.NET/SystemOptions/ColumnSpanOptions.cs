namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ColumnSpan"/>
    /// </summary>
    public enum ColumnSpanOptions
    {
        /// <summary>
        ///Default, spans element across one column
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Spans element across All columns
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'all'</c></list>
        /// </summary>
        All,
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