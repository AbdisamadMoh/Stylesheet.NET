namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="TransitionTimingFunction"/>
    /// </summary>
    public enum TransitionTimingFunctionOptions
    {
        /// <summary>
        ///Default. Sets a transition effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1))
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease'</c></list>
        /// </summary>
        Ease,
        /// <summary>
        ///Sets a transition effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1))
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'linear'</c></list>
        /// </summary>
        Linear,
        /// <summary>
        ///Sets a transition effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1))
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease-in'</c></list>
        /// </summary>
        EaseIn,
        /// <summary>
        ///Sets a transition effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1))
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease-out'</c></list>
        /// </summary>
        EaseOut,
        /// <summary>
        ///Sets a transition effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1))
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease-in-out'</c></list>
        /// </summary>
        EaseInOut,
        /// <summary>
        ///Equivalent to steps(1, start)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'step-start'</c></list>
        /// </summary>
        StepStart,
        /// <summary>
        ///Equivalent to steps(1, end)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'step-end'</c></list>
        /// </summary>
        StepEnd,
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