namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BoxSizing"/>
    /// </summary>
    public enum BoxSizingOptions
    {
        /// <summary>
        ///Default. Excludes padding and border for width and height calculations.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'content-box'</c></list>
        /// </summary>
        ContentBox,
        /// <summary>
        ///Includes padding and border for width and height calculations.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'border-box'</c></list>
        /// </summary>
        BorderBox,
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