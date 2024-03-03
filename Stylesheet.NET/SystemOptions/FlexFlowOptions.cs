namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="FlexFlow"/>
    /// </summary>
    public enum FlexFlowOptions
    {
        /// <summary>
        ///Sets the packing direction of flex items. Possible values: row (default) row-reverse column column-reverse initial inherit
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-direction'</c></list>
        /// </summary>
        FlexDirection,
        /// <summary>
        ///Sets the wrapping of flex items. Possible values: nowrap (default) wrap wrap-reverse initial inherit
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-wrap'</c></list>
        /// </summary>
        FlexWrap,
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