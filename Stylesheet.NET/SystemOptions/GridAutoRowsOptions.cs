namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridAutoRows"/>
    /// </summary>
    public enum GridAutoRowsOptions
    {
        /// <summary>
        ///Default. Row height is determined by the height of the largest grid item in the row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Row height depends on the largest item in the row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'max-content'</c></list>
        /// </summary>
        MaxContent,
        /// <summary>
        ///Row height depends on the smallest item in the row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'min-content'</c></list>
        /// </summary>
        MinContent
    }
}