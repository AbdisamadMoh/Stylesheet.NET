namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AnimationPlayState"/>
    /// </summary>
    public enum AnimationPlayStateOptions
    {
        /// <summary>
        ///Pause the animation at start
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'paused'</c></list>
        /// </summary>
        Paused,
        /// <summary>
        ///Default. Plays the animation at start
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'running'</c></list>
        /// </summary>
        Running,
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