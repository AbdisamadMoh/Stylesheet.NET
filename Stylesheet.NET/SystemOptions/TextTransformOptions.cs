namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TextTransform"/>
    /// </summary>
    public enum TextTransformOptions
    {
        /// <summary>
        ///Default. Displays text as it is.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Each first letter of the word are Capitalized.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'capitalize'</c></list>
        /// </summary>
        Capitalize,
        /// <summary>
        ///All text are capitalized.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'uppercase'</c></list>
        /// </summary>
        Uppercase,
        /// <summary>
        ///All text are set to small letters.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'lowercase'</c></list>
        /// </summary>
        Lowercase,
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