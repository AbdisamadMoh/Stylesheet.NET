namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="UnicodeBidi"/>
    /// </summary>
    public enum UnicodeBidiOptions
    {
        /// <summary>
        ///	Default. The element does not open an additional level of embedding.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///For inline elements, this value opens an additional level of embedding.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'embed'</c></list>
        /// </summary>
        Embed,
        /// <summary>
        ///For inline elements, this creates an override. For block elements, this creates an override for inline-level descendants not within another block element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'bidi-override'</c></list>
        /// </summary>
        BidiOverride,
        /// <summary>
        ///The element is isolated from its siblings.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'isolate'</c></list>
        /// </summary>
        Isolate,
        /// <summary>
        ///Applies the isolation behavior to the surrounding content and the override behavior to the inner content.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'isolate-override'</c></list>
        /// </summary>
        IsolateOverride,
        /// <summary>
        ///This value behaves as isolate value but the directionality is calculated using the P2 and P3 rules of the Unicode Bidirectional Algorithm.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'plaintext'</c></list>
        /// </summary>
        Plaintext,
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