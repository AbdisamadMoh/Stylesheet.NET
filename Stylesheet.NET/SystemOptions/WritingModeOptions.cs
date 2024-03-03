namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="WritingMode"/>
    /// </summary>
    public enum WritingModeOptions
    {
        /// <summary>
        ///Text flow is left-to-right (horizontal), then top-to-bottom. This is used with languages using the Roman alphabet.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'horizontal-tb'</c></list>
        /// </summary>
        HorizontalTb,
        /// <summary>
        ///Text flow is top-to-bottom (vertical), then right-to-left.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'vertical-rl'</c></list>
        /// </summary>
        VerticalRl,
        /// <summary>
        ///Text flow is top-to-bottom (vertical), then left-to-right.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'vertical-lr'</c></list>
        /// </summary>
        VerticalLr
    }
}