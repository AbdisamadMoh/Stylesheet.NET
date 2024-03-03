namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackfaceVisibility"/>
    /// </summary>
    public enum BackfaceVisibilityOptions
    {
        /// <summary>
        ///Default. Shows backside
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'visible'</c></list>
        /// </summary>
        Visible,
        /// <summary>
        ///Hides the backside
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'hidden'</c></list>
        /// </summary>
        Hidden,
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