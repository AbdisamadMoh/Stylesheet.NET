namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="WordBreak"/>
    /// </summary>
    public enum WordBreakOptions
    {
        /// <summary>
        ///Default. Uses default line break rules.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Words don't wrap and are broken at any character when they reach the end of the line.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'break-all'</c></list>
        /// </summary>
        BreakAll,
        /// <summary>
        ///For Chinese, Japanese, and Korean text words are not broken. For other languages this is the same as normal.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'keep-all'</c></list>
        /// </summary>
        KeepAll,
        /// <summary>
        ///Words wrap and may be broken at arbitrary points, if necessary.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'break-word'</c></list>
        /// </summary>
        BreakWord,
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