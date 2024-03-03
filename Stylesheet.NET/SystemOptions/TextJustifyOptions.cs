namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TextJustify"/>
    /// </summary>
    public enum TextJustifyOptions
    {
        /// <summary>
        ///Browser sets the optimal justification algorithm
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Increases or decreases space between words
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inter-word'</c></list>
        /// </summary>
        InterWord,
        /// <summary>
        ///Increases or decreases space between characters
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inter-character'</c></list>
        /// </summary>
        InterCharacter,
        /// <summary>
        ///No justification methods
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Sets the value to its default value value.
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