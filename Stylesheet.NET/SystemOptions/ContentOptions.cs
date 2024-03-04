namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Content"/>
    /// </summary>
    public enum ContentOptions
    {
        /// <summary>
        ///Default. Sets Content to "none" - which means no Content
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Sets Content to nothing
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Sets the Content as a Counter
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'counter'</c></list>
        /// </summary>
        Counter,
        /// <summary>
        ///Sets the Content to any specified text
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'string'</c></list>
        /// </summary>
        String,
        /// <summary>
        ///Sets the Content to be an opening quote
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'open-quote'</c></list>
        /// </summary>
        OpenQuote,
        /// <summary>
        ///Sets the Content to be a closing quote
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'close-quote'</c></list>
        /// </summary>
        CloseQuote,
        /// <summary>
        ///Removes the opening quote from the Content if specified
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'no-open-quote'</c></list>
        /// </summary>
        NoOpenQuote,
        /// <summary>
        ///Removes the closing quote from the Content if specified
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'no-close-quote'</c></list>
        /// </summary>
        NoCloseQuote,
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