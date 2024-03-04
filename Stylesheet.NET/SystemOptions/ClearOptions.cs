namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Clear"/>
    /// </summary>
    public enum ClearOptions
    {
        /// <summary>
        ///Default. Allows floating elements on either side.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Left side won't allow floating elements
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'left'</c></list>
        /// </summary>
        Left,
        /// <summary>
        ///Right side won't allow floating elements
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'right'</c></list>
        /// </summary>
        Right,
        /// <summary>
        ///Both left and right sides won't allow floating elements
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'both'</c></list>
        /// </summary>
        Both,
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