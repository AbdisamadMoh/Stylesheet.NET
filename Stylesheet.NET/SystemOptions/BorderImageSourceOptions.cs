namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BorderImageSource"/>
    /// </summary>
    public enum BorderImageSourceOptions
    {
        /// <summary>
        ///No image will be used
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Path or URL of the Image to be used as a border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'image'</c></list>
        /// </summary>
        Image,
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