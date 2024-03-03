namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Direction"/>
    /// </summary>
    public enum DirectionOptions
    {
        /// <summary>
        ///Default. Text Direction goes from left-to-right.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ltr'</c></list>
        /// </summary>
        Ltr,
        /// <summary>
        ///Text Direction goes from right-to-left
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'rtl'</c></list>
        /// </summary>
        Rtl,
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