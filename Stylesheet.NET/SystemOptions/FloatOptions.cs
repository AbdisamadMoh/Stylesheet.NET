namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Float"/>
    /// </summary>
    public enum FloatOptions
    {
        /// <summary>
        ///Default. Does not Float element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Floats element to the Left of its container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'left'</c></list>
        /// </summary>
        Left,
        /// <summary>
        ///Floats element to the Right of its container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'right'</c></list>
        /// </summary>
        Right,
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