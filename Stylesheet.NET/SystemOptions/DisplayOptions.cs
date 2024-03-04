namespace StylesheetNET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Display"/>
    /// </summary>
    public enum DisplayOptions
    {
        /// <summary>
        ///The element Displays as an Inline element (like <span>). Height and width properties has no effect.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inline'</c></list>
        /// </summary>
        Inline,
        /// <summary>
        ///The element Displays as a Block element (like <div>). It starts on a new line, and takes up the whole width.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'block'</c></list>
        /// </summary>
        Block,
        /// <summary>
        ///The container element disappears. The child elements become children of the element the next level up in the DOM.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'contents'</c></list>
        /// </summary>
        Contents,
        /// <summary>
        ///Displays as a block-level Flex container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'flex'</c></list>
        /// </summary>
        Flex,
        /// <summary>
        ///Displays as a block-level Grid container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'grid'</c></list>
        /// </summary>
        Grid,
        /// <summary>
        ///Displays as an inline-level block container. The element itself behaves as an inline element, but height and width values can be applied.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inline-block'</c></list>
        /// </summary>
        InlineBlock,
        /// <summary>
        ///Displays as an inline-level flex container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inline-flex'</c></list>
        /// </summary>
        InlineFlex,
        /// <summary>
        ///Displays as an inline-level grid container.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inline-grid'</c></list>
        /// </summary>
        InlineGrid,
        /// <summary>
        ///Displays as an inline-level table.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'inline-table'</c></list>
        /// </summary>
        InlineTable,
        /// <summary>
        ///Sets the element to behave like a <li> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'list-item'</c></list>
        /// </summary>
        ListItem,
        /// <summary>
        ///Displays as either block or inline, depending on the context.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'run-in'</c></list>
        /// </summary>
        RunIn,
        /// <summary>
        ///Sets the element to behave like a <Table> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table'</c></list>
        /// </summary>
        Table,
        /// <summary>
        ///Sets the element to behave like a <caption> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-caption'</c></list>
        /// </summary>
        TableCaption,
        /// <summary>
        ///Sets the element to behave like a <colgroup> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-column-group'</c></list>
        /// </summary>
        TableColumnGroup,
        /// <summary>
        ///Sets the element to behave like a <thead> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-header-group'</c></list>
        /// </summary>
        TableHeaderGroup,
        /// <summary>
        ///Sets the element to behave like a <tfoot> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-footer-group'</c></list>
        /// </summary>
        TableFooterGroup,
        /// <summary>
        ///Sets the element to behave like a <tbody> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-row-group'</c></list>
        /// </summary>
        TableRowGroup,
        /// <summary>
        ///Sets the element to behave like a <td> element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-cell'</c></list>
        /// </summary>
        TableCell,
        /// <summary>
        ///Sets the element to behave like a <col> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-column'</c></list>
        /// </summary>
        TableColumn,
        /// <summary>
        ///Sets the element to behave like a <tr> element.
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'table-row'</c></list>
        /// </summary>
        TableRow,
        /// <summary>
        ///Removes, i.e. hides, the element.
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