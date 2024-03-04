namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="FontStyle"/>
    /// </summary>
    public enum FontStyleOptions
    {
        /// <summary>
        ///Default. Displays a Normal style
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Displays an Italic font style
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'italic'</c></list>
        /// </summary>
        Italic,
        /// <summary>
        ///Displays an Oblique font style
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'oblique'</c></list>
        /// </summary>
        Oblique,
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