namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridTemplateRows"/>
    /// </summary>
    public enum GridTemplateRowsOptions
    {
        /// <summary>
        ///Rows are created if needed
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Rows size is determined by the container size and on the size of the content of the items in the row
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Sets the row size depending on the largest row item
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'max-content'</c></list>
        /// </summary>
        MaxContent,
        /// <summary>
        ///Sets the row size depending on the smallest row item
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'min-content'</c></list>
        /// </summary>
        MinContent
    }
}