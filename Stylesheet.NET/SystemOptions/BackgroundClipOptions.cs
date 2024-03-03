namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackgroundClip"/>
    /// </summary>
    public enum BackgroundClipOptions
    {
        /// <summary>
        ///Default. Extends background behind the border.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'border-box'</c></list>
        /// </summary>
        BorderBox,
        /// <summary>
        ///Extends background to include padding.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'padding-box'</c></list>
        /// </summary>
        PaddingBox,
        /// <summary>
        ///Extends background to the content edge.
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