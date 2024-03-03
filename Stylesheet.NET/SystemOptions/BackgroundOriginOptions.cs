namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackgroundOrigin"/>
    /// </summary>
    public enum BackgroundOriginOptions
    {
        /// <summary>
        ///Default. Background image starts from the upper left corner of the padding edge
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'padding-box'</c></list>
        /// </summary>
        PaddingBox,
        /// <summary>
        ///Background image starts from the upper left corner of the border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'border-box'</c></list>
        /// </summary>
        BorderBox,
        /// <summary>
        ///Background image starts from the upper left corner of the content
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'content-box'</c></list>
        /// </summary>
        ContentBox,
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