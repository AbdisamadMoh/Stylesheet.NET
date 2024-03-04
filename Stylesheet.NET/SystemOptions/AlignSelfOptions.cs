namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AlignSelf"/>
    /// </summary>
    public enum AlignSelfOptions
    {
        /// <summary>
        ///Default value. Inherits its parent container's align-items property, or "stretch" if not inheritable
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Stretch to fit the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'stretch'</c></list>
        /// </summary>
        Stretch,
        /// <summary>
        ///Position item at the Center of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'center'</c></list>
        /// </summary>
        Center,
        /// <summary>
        ///Position item at the beginning of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-start'</c></list>
        /// </summary>
        FlexStart,
        /// <summary>
        ///Position item at the end of the container
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex-end'</c></list>
        /// </summary>
        FlexEnd,
        /// <summary>
        ///Position item at the Baseline of the container
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