namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="FlexWrap"/>
    /// </summary>
    public enum FlexWrapOptions
    {
        /// <summary>
        ///Default, flexible items will not wrap
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'nowrap'</c></list>
        /// </summary>
        Nowrap,
        /// <summary>
        ///Wraps flexible items if necessary
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'wrap'</c></list>
        /// </summary>
        Wrap,
        /// <summary>
        ///Flexible items will wrap, if necessary, in reverse order
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'wrap-reverse'</c></list>
        /// </summary>
        WrapReverse,
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