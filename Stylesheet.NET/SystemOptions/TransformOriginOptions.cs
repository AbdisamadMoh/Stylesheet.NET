namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TransformOrigin"/>
    /// </summary>
    public enum TransformOriginOptions
    {
        /// <summary>
        ///Sets the x value for the origin. Possible values are left, right, center, length, and %.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'x-axis'</c></list>
        /// </summary>
        XAxis,
        /// <summary>
        ///Sets the y value for the origin. Possible values are top, center, bottom, length or %.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'y-axis'</c></list>
        /// </summary>
        YAxis,
        /// <summary>
        ///Sets the z value for the origin in 3D transformations. Possible values are length or %.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'z-axis'</c></list>
        /// </summary>
        ZAxis,
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