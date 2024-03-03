namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="UserSelect"/>
    /// </summary>
    public enum UserSelectOptions
    {
        /// <summary>
        ///Default. Enables text selection as decided by the browser.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Disables text selection.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Enables Text selection.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'text'</c></list>
        /// </summary>
        Text,
        /// <summary>
        ///A single click will select the entire text.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'all'</c></list>
        /// </summary>
        All
    }
}