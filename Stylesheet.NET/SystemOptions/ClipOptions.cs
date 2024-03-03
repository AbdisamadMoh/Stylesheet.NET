namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Clip"/>
    /// </summary>
    public enum ClipOptions
    {
        /// <summary>
        ///Default. No Clipping will be made.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Clips an element and only has one valid value: rect (top, right, bottom, left)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'shape'</c></list>
        /// </summary>
        Shape,
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