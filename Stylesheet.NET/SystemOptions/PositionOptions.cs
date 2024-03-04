namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Position"/>
    /// </summary>
    public enum PositionOptions
    {
        /// <summary>
        ///Default. The element renders in the order as they appear in the document flow
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'static'</c></list>
        /// </summary>
        Static,
        /// <summary>
        ///The element is Positioned relative to a Positioned (not static) parent element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'absolute'</c></list>
        /// </summary>
        Absolute,
        /// <summary>
        ///The element is Positioned relative to the browser window
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'fixed'</c></list>
        /// </summary>
        Fixed,
        /// <summary>
        ///The element is Positioned Relative to its normal Position
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'relative'</c></list>
        /// </summary>
        Relative,
        /// <summary>
        ///The element is Positioned based on the scrolling Position of a parent element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'sticky'</c></list>
        /// </summary>
        Sticky,
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