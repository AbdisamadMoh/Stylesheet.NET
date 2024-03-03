namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="BackgroundRepeat"/>
    /// </summary>
    public enum BackgroundRepeatOptions
    {
        /// <summary>
        ///Default. Repeats background image vertically and horizontally
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'repeat'</c></list>
        /// </summary>
        Repeat,
        /// <summary>
        ///Repeats background image horizontally
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'repeat-x'</c></list>
        /// </summary>
        RepeatX,
        /// <summary>
        ///Repeats background image vertically
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'repeat-y'</c></list>
        /// </summary>
        RepeatY,
        /// <summary>
        ///Does not repeat background image
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'no-repeat'</c></list>
        /// </summary>
        NoRepeat,
        /// <summary>
        ///Repeats background image without clipping
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'space'</c></list>
        /// </summary>
        Space,
        /// <summary>
        ///Repeats backgRound image and scales them to fill the entire space
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'round'</c></list>
        /// </summary>
        Round,
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