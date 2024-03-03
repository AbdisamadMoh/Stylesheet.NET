namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BorderImageRepeat"/>
    /// </summary>
    public enum BorderImageRepeatOptions
    {
        /// <summary>
        ///Default. Stretch the image to fill the area
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'stretch'</c></list>
        /// </summary>
        Stretch,
        /// <summary>
        ///Image is tiled (Repeated) to fill the area
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'repeat'</c></list>
        /// </summary>
        Repeat,
        /// <summary>
        ///The image is tiled (repeated) to fill the area while rescaling it.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'round'</c></list>
        /// </summary>
        Round,
        /// <summary>
        ///The image is tiled (repeated) to fill the area while adding whiteSpaces around it.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space'</c></list>
        /// </summary>
        Space,
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