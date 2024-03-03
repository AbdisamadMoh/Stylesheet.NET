namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="WhiteSpace"/>
    /// </summary>
    public enum WhiteSpaceOptions
    {
        /// <summary>
        ///Default. Collapses multiple whitespace characters into a single whitespace.Text will wrap when necessary.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Collapses multiple whitespace characters into a single whitespace.The text will never wrap to the next line. The text continues on the same line until a <br> tag is encountered
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'nowrap'</c></list>
        /// </summary>
        Nowrap,
        /// <summary>
        ///Browser Preserves whitespace.The text will only wrap on line breaks. Acts like the <Pre> tag in HTML
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'pre'</c></list>
        /// </summary>
        Pre,
        /// <summary>
        ///Collapses multiple whitespace characters into a single whitespace.The text will wrap when necessary, and on line breaks
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'pre-line'</c></list>
        /// </summary>
        PreLine,
        /// <summary>
        ///Browser preserves whitespace.The text will wrap when necessary, and on line breaks.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'pre-wrap'</c></list>
        /// </summary>
        PreWrap,
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