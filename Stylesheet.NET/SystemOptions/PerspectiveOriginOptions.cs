namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="PerspectiveOrigin"/>
    /// </summary>
    public enum PerspectiveOriginOptions
    {
        /// <summary>
        ///The default value is 50%. Specifies where the user is placed at the XAxis. Possible values: left center right length %
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'x-axis'</c></list>
        /// </summary>
        XAxis,
        /// <summary>
        ///The default value is 50%. Specifies where user is placed at the YAxis. Possible values: top center bottom length %
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'y-axis'</c></list>
        /// </summary>
        YAxis,
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