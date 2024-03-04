namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TextDecorationLine"/>
    /// </summary>
    public enum TextDecorationLineOptions
    {
        /// <summary>
        ///Default. No line
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Line under the text
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'underline'</c></list>
        /// </summary>
        Underline,
        /// <summary>
        ///Line over the text
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'overline'</c></list>
        /// </summary>
        Overline,
        /// <summary>
        ///Line through the text
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'line-through'</c></list>
        /// </summary>
        LineThrough,
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