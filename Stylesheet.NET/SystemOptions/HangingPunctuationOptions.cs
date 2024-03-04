namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="HangingPunctuation"/>
    /// </summary>
    public enum HangingPunctuationOptions
    {
        /// <summary>
        ///Default. No punctuation mark may be placed outside the line box at the start or at the end of a full line of text.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Punctuation may hang outside the start edge of the first line.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'first'</c></list>
        /// </summary>
        First,
        /// <summary>
        ///	Punctuation may hang outside the end edge of the last line.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'last'</c></list>
        /// </summary>
        Last,
        /// <summary>
        ///Punctuation may hang outside the end edge of all lines if the punctuation does not otherwise fit prior to justification.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'allow-end'</c></list>
        /// </summary>
        AllowEnd,
        /// <summary>
        ///Punctuation may hang outside the end edge of all lines. If justification is enabled on this line, then it will force the punctuation to hang.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'force-end'</c></list>
        /// </summary>
        ForceEnd,
        /// <summary>
        ///Sets this property to its default value.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///	Inherits this property from its parent element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}