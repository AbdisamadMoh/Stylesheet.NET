namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridAutoFlow"/>
    /// </summary>
    public enum GridAutoFlowOptions
    {
        /// <summary>
        ///Default. Fills the grid by Row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'row'</c></list>
        /// </summary>
        Row,
        /// <summary>
        ///Fills the grid by Column.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'column'</c></list>
        /// </summary>
        Column,
        /// <summary>
        ///Fill any holes in the grid.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'dense'</c></list>
        /// </summary>
        Dense
    }
}