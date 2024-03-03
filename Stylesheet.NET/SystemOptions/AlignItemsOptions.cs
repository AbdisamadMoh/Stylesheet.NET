namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AlignItems"/>
    /// </summary>
    public enum AlignItemsOptions
    {
        /// <summary>
        ///Default. Stretch items to fit the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'stretch'</c></list>
        /// </summary>
        Stretch,
        /// <summary>
        ///Position and space items at the Center of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'center'</c></list>
        /// </summary>
        Center,
        /// <summary>
        ///Position and space items at the beginning of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-start'</c></list>
        /// </summary>
        FlexStart,
        /// <summary>
        ///Position and space items at the end of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-end'</c></list>
        /// </summary>
        FlexEnd,
        /// <summary>
        ///Position and space items according their Baselines
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'baseline'</c></list>
        /// </summary>
        Baseline,
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