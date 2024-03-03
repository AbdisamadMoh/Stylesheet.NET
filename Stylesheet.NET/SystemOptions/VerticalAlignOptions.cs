namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="VerticalAlign"/>
    /// </summary>
    public enum VerticalAlignOptions
    {
        /// <summary>
        ///Default. Aligned with the parent's Baseline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'baseline'</c></list>
        /// </summary>
        Baseline,
        /// <summary>
        ///Align with the parent's Subscript baseline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'sub'</c></list>
        /// </summary>
        Sub,
        /// <summary>
        ///Align with the parent's Superscript baseline
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'super'</c></list>
        /// </summary>
        Super,
        /// <summary>
        ///Align with the Top of the entire line. The highest point.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'top'</c></list>
        /// </summary>
        Top,
        /// <summary>
        ///Align with the top of the parent element's font.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'text-top'</c></list>
        /// </summary>
        TextTop,
        /// <summary>
        ///Align with the Middle of the parent
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'middle'</c></list>
        /// </summary>
        Middle,
        /// <summary>
        ///Align with the Bottom of the entire line. The lowest point.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'bottom'</c></list>
        /// </summary>
        Bottom,
        /// <summary>
        ///Align with the bottom of the parent element's font.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'text-bottom'</c></list>
        /// </summary>
        TextBottom,
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