namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Overflow"/>
    /// </summary>
    public enum OverflowOptions
    {
        /// <summary>
        ///Default. Does not clip Overflowing content.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'visible'</c></list>
        /// </summary>
        Visible,
        /// <summary>
        ///Hides (clips) Overflowing content.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'hidden'</c></list>
        /// </summary>
        Hidden,
        /// <summary>
        ///Clips Overflowing content and shows Scrollbars all the time.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'scroll'</c></list>
        /// </summary>
        Scroll,
        /// <summary>
        ///If there is Overflowing content it shows a scrollbar.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
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