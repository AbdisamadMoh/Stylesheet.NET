namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AnimationName"/>
    /// </summary>
    public enum AnimationNameOptions
    {
        /// <summary>
        ///Default. No animation (can be used to override animations coming from the cascade)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
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