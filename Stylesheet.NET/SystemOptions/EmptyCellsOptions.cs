namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="EmptyCells"/>
    /// </summary>
    public enum EmptyCellsOptions
    {
        /// <summary>
        ///Default. Displays borders on empty cells
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'show'</c></list>
        /// </summary>
        Show,
        /// <summary>
        ///Hide borders on empty cells
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'hide'</c></list>
        /// </summary>
        Hide,
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