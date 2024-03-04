namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TransitionProperty"/>
    /// </summary>
    public enum TransitionPropertyOptions
    {
        /// <summary>
        ///No property will get a transition effect
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Default. All properties will get a transition effect
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'all'</c></list>
        /// </summary>
        All,
        /// <summary>
        ///Sets the value to its default value.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits the property from its parent element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}