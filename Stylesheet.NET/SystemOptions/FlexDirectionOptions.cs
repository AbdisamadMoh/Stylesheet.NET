namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="FlexDirection"/>
    /// </summary>
    public enum FlexDirectionOptions
    {
        /// <summary>
        ///Default. Flex items are placed horizontally in a Row.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'row'</c></list>
        /// </summary>
        Row,
        /// <summary>
        ///Same as row, but in reverse order.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'row-reverse'</c></list>
        /// </summary>
        RowReverse,
        /// <summary>
        ///Flex items are placed vertically in a Column.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'column'</c></list>
        /// </summary>
        Column,
        /// <summary>
        ///Same as column, but in reverse order.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'column-reverse'</c></list>
        /// </summary>
        ColumnReverse,
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