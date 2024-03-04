namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ScrollBehavior"/>
    /// </summary>
    public enum ScrollBehaviorOptions
    {
        /// <summary>
        ///Default. Allows a straight jump "scroll effect" between elements within the scrolling box.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Allows a Smooth animated "scroll effect" between elements within the scrolling box.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'smooth'</c></list>
        /// </summary>
        Smooth,
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