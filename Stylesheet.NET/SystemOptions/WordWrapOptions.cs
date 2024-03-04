namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="WordWrap"/>
    /// </summary>
    public enum WordWrapOptions
    {
        /// <summary>
        ///The default. Break words only at allowed break points.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Forces unbreakable words to be broken.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'break-word'</c></list>
        /// </summary>
        BreakWord,
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