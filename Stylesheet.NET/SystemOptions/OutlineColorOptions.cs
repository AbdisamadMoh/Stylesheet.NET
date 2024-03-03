namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="OutlineColor"/>
    /// </summary>
    public enum OutlineColorOptions
    {
        /// <summary>
        ///Default, Inverts color making sure that it is visible regardless of the background color.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'invert'</c></list>
        /// </summary>
        Invert,
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