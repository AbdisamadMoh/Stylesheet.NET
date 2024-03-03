namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="GridTemplate"/>
    /// </summary>
    public enum GridTemplateOptions
    {
        /// <summary>
        ///Default. Rows and columns are not positioned or resized.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
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