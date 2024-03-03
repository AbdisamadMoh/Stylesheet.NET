namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BoxShadow"/>
    /// </summary>
    public enum BoxShadowOptions
    {
        /// <summary>
        ///Default. No shadow
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Required, the horizontal offset of the shadow. A positive value puts the shadow on the right side of the box, a negative value puts the shadow on the left side of the box
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'h-offset'</c></list>
        /// </summary>
        HOffset,
        /// <summary>
        ///Required, the vertical offset of the shadow. A positive value puts the shadow below the box, a negative value puts the shadow above the box
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'v-offset'</c></list>
        /// </summary>
        VOffset,
        /// <summary>
        ///Optional, Blur radius. The higher the number, the more Blurred the shadow will be
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'blur'</c></list>
        /// </summary>
        Blur,
        /// <summary>
        ///Optional, Spread radius. A positive value increases the size of the shadow, a negative value decreases the size of the shadow
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'spread'</c></list>
        /// </summary>
        Spread,
        /// <summary>
        ///Optional changes the shadow from an outer shadow (outset) to an inner shadow
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inset'</c></list>
        /// </summary>
        Inset,
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