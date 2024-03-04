namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AlignContent"/>
    /// </summary>
    public enum AlignContentOptions
    {
        /// <summary>
        ///Default. Stretches items to take up maximum space
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'stretch'</c></list>
        /// </summary>
        Stretch,
        /// <summary>
        ///Groups items along a flex line in the Center
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'center'</c></list>
        /// </summary>
        Center,
        /// <summary>
        ///Groups items along a flex line at the top
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-start'</c></list>
        /// </summary>
        FlexStart,
        /// <summary>
        ///Groups items along a flex line at the bottom
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-end'</c></list>
        /// </summary>
        FlexEnd,
        /// <summary>
        ///Distributes items with maximum space between elements
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space-between'</c></list>
        /// </summary>
        SpaceBetween,
        /// <summary>
        ///Distributes items with maximumn space around elements
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space-around'</c></list>
        /// </summary>
        SpaceAround,
        /// <summary>
        ///Sets the value to its Initial value
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits the value from the parent element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}