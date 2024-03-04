namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridTemplateColumns"/>
    /// </summary>
    public enum GridTemplateColumnsOptions
    {
        /// <summary>
        ///Default, creates columns if needed
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Columns size is determined by the container size and on the size of the content of the items in the column
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Sets the column size depending on the largest column item
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'max-content'</c></list>
        /// </summary>
        MaxContent,
        /// <summary>
        ///Sets the column size depending on the smallest column item
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'min-content'</c></list>
        /// </summary>
        MinContent,
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