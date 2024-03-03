namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ObjectFit"/>
    /// </summary>
    public enum ObjectFitOptions
    {
        /// <summary>
        ///Default. Resizes the image to Fill the content box. Aspect ratio is not maintained and image may appear stretched or compressed.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'fill'</c></list>
        /// </summary>
        Fill,
        /// <summary>
        ///Resizes image to fit inside the content box. Aspect ratio is maintained. If there is no perfect fit, some open areas will result.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'contain'</c></list>
        /// </summary>
        Contain,
        /// <summary>
        ///Resizes image to fill the content box. Excess content will be cropped. Aspect ratio is maintained. The entire content box will be Covered.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'cover'</c></list>
        /// </summary>
        Cover,
        /// <summary>
        ///Does not change the image size. The browser decides the best position.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///The image is resized as if none or contain were specified. The smallest image size will be used.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'scale-down'</c></list>
        /// </summary>
        ScaleDown,
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