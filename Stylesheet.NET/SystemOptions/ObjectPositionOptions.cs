namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="ObjectPosition"/>
    /// </summary>
    public enum ObjectPositionOptions
    {
        /// <summary>
        ///Sets the image or video Position inside its content box. Use keyword values: left, right, and center, or any other CSS length value, such as, px, %, em, and others. Negative values are accepted.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'position'</c></list>
        /// </summary>
        Position,
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