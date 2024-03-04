namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="All"/>
    /// </summary>
    public enum AllOptions
    {
        /// <summary>
        ///Resets to the Initial value
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits the parent's value
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit,
        /// <summary>
        ///Inherits All possible values from the parent. If no inheritable value is available for the property, the initial value is used.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'unset'</c></list>
        /// </summary>
        Unset
    }
}