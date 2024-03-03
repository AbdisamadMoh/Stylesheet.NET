namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TransformStyle"/>
    /// </summary>
    public enum TransformStyleOptions
    {
        /// <summary>
        ///Default. Child elements do not preserve their 3D position and are displayed Flattened.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flat'</c></list>
        /// </summary>
        Flat,
        /// <summary>
        ///Child elements preserve their 3D positioning.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'preserve-3d'</c></list>
        /// </summary>
        Preserve3d,
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