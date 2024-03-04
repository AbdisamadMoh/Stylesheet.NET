namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="OutlineStyle"/>
    /// </summary>
    public enum OutlineStyleOptions
    {
        /// <summary>
        ///Default. No outline
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
        ///Dotted outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'dotted'</c></list>
        /// </summary>
        Dotted,
        /// <summary>
        ///Dashed outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'dashed'</c></list>
        /// </summary>
        Dashed,
        /// <summary>
        ///Solid outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'solid'</c></list>
        /// </summary>
        Solid,
        /// <summary>
        ///Double outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'double'</c></list>
        /// </summary>
        Double,
        /// <summary>
        ///3D Groove outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'groove'</c></list>
        /// </summary>
        Groove,
        /// <summary>
        ///3D Ridge outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ridge'</c></list>
        /// </summary>
        Ridge,
        /// <summary>
        ///3D Inset outline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inset'</c></list>
        /// </summary>
        Inset,
        /// <summary>
        ///3D Outset outline
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