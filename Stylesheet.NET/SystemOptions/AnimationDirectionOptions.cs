namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AnimationDirection"/>
    /// </summary>
    public enum AnimationDirectionOptions
    {
        /// <summary>
        ///Default. Plays animation as Normal, i.e. forward
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Plays animation in the Reverse direction, i.e. backward
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'reverse'</c></list>
        /// </summary>
        Reverse,
        /// <summary>
        ///Plays animation forward first, then backward
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'alternate'</c></list>
        /// </summary>
        Alternate,
        /// <summary>
        ///Plays animation backward first, then forward
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'alternate-reverse'</c></list>
        /// </summary>
        AlternateReverse,
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