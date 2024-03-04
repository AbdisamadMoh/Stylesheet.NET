namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Resize"/>
    /// </summary>
    public enum ResizeOptions
    {
        /// <summary>
        ///	Default. The user cannot resize the element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///The user can resize both the height and width of the element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'both'</c></list>
        /// </summary>
        Both,
        /// <summary>
        ///The user can resize the width of the element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'horizontal'</c></list>
        /// </summary>
        Horizontal,
        /// <summary>
        ///The user can resize the height of the element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'vertical'</c></list>
        /// </summary>
        Vertical,
        /// <summary>
        ///Sets this property to its default value.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'initial'</c></list>
        /// </summary>
        Initial,
        /// <summary>
        ///Inherits this property from its parent element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inherit'</c></list>
        /// </summary>
        Inherit
    }
}