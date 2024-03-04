namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BorderTopStyle"/>
    /// </summary>
    public enum BorderTopStyleOptions
    {
        /// <summary>
        ///Default. No border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Same as none except for table, it conflicts on the resolution
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'hidden'</c></list>
        /// </summary>
        Hidden,
        /// <summary>
        ///Dotted border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'dotted'</c></list>
        /// </summary>
        Dotted,
        /// <summary>
        ///Dashed border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'dashed'</c></list>
        /// </summary>
        Dashed,
        /// <summary>
        ///Solid border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'solid'</c></list>
        /// </summary>
        Solid,
        /// <summary>
        ///Double border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'double'</c></list>
        /// </summary>
        Double,
        /// <summary>
        ///3D Groove border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'groove'</c></list>
        /// </summary>
        Groove,
        /// <summary>
        ///3D Ridge border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ridge'</c></list>
        /// </summary>
        Ridge,
        /// <summary>
        ///3D Inset border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inset'</c></list>
        /// </summary>
        Inset,
        /// <summary>
        ///3D Outset border
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'outset'</c></list>
        /// </summary>
        Outset,
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