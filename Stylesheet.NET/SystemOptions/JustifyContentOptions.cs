namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="JustifyContent"/>
    /// </summary>
    public enum JustifyContentOptions
    {
        /// <summary>
        ///Default. Items align at the beginning of the container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-start'</c></list>
        /// </summary>
        FlexStart,
        /// <summary>
        ///Items align at the end of the container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-end'</c></list>
        /// </summary>
        FlexEnd,
        /// <summary>
        ///Items align at the Center of the container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'center'</c></list>
        /// </summary>
        Center,
        /// <summary>
        ///Items align with maximum space between them.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space-between'</c></list>
        /// </summary>
        SpaceBetween,
        /// <summary>
        ///Items align with equal space before and after each item.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space-around'</c></list>
        /// </summary>
        SpaceAround,
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