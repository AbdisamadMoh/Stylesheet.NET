namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AnimationFillMode"/>
    /// </summary>
    public enum AnimationFillModeOptions
    {
        /// <summary>
        ///Default. No styles will be applied to the element before or after the animation is executing
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Element will use the style values set by the last keyframe (depends on AnimationFillMode and animation-iteration-count)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'forwards'</c></list>
        /// </summary>
        Forwards,
        /// <summary>
        ///Element will use the style values that are set by the first keyframe (depends on AnimationFillMode), and retain this during the animation-delay period
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'backwards'</c></list>
        /// </summary>
        Backwards,
        /// <summary>
        ///The animation will follow the rules for Both forwards and backward, extending the animation properties in Both directions
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'both'</c></list>
        /// </summary>
        Both,
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