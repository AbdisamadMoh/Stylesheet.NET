namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="AnimationTimingFunction"/>
    /// </summary>
    public enum AnimationTimingFunctionOptions
    {
        /// <summary>
        ///Plays animation the same speed from start to end
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'linear'</c></list>
        /// </summary>
        Linear,
        /// <summary>
        ///Default. Plays animation from the slow start, then fast, before it ends slowly
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease'</c></list>
        /// </summary>
        Ease,
        /// <summary>
        ///Plays animation on the slow start
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease-in'</c></list>
        /// </summary>
        EaseIn,
        /// <summary>
        ///Plays animation on the slow end
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ease-out'</c></list>
        /// </summary>
        EaseOut,
        /// <summary>
        ///Plays animation on both slow start and slow end
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