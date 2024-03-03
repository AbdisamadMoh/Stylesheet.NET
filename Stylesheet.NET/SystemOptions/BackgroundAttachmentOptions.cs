namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackgroundAttachment"/>
    /// </summary>
    public enum BackgroundAttachmentOptions
    {
        /// <summary>
        ///Default. Scrolls background with the rest of the page.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'scroll'</c></list>
        /// </summary>
        Scroll,
        /// <summary>
        ///Background image will be positioned Fixed.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'fixed'</c></list>
        /// </summary>
        Fixed,
        /// <summary>
        ///Background image will scroll with the element's content.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'local'</c></list>
        /// </summary>
        Local,
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