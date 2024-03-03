namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackgroundSize"/>
    /// </summary>
    public enum BackgroundSizeOptions
    {
        /// <summary>
        ///Default. Displays background image original size.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Sets width (first value) and height (second value) of background image in percent. If the second value is not given, it will be set to auto.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'percentage'</c></list>
        /// </summary>
        Percentage,
        /// <summary>
        ///Stretch or crop background image to Cover the entire container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'cover'</c></list>
        /// </summary>
        Cover,
        /// <summary>
        ///Resize background image to make it fully visible.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'contain'</c></list>
        /// </summary>
        Contain,
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