namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BoxDecorationBreak"/>
    /// </summary>
    public enum BoxDecorationBreakOptions
    {
        /// <summary>
        ///Default. Box decorations apply to the entire element and break (Slice) at the fragment edges
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'slice'</c></list>
        /// </summary>
        Slice,
        /// <summary>
        ///Box decorations apply to each fragment and the styles are completely Cloned.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'clone'</c></list>
        /// </summary>
        Clone,
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