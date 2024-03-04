namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="FontKerning"/>
    /// </summary>
    public enum FontKerningOptions
    {
        /// <summary>
        ///Default. The browser determines whether FontKerning is beneficial or not.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Font-kerning is applied.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'normal'</c></list>
        /// </summary>
        Normal,
        /// <summary>
        ///Font-kerning is not applied.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None
    }
}