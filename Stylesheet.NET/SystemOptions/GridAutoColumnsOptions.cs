namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridAutoColumns"/>
    /// </summary>
    public enum GridAutoColumnsOptions
    {
        /// <summary>
        ///Default. Columns size is determined by the size of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Sets column size depending on the largest item in the column
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'max-content'</c></list>
        /// </summary>
        MaxContent,
        /// <summary>
        ///Sets column size depending on the smallest item in the column
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'min-content'</c></list>
        /// </summary>
        MinContent
    }
}