namespace Stylesheet.NET
{
    /// <summary>
    ///Gets predefined css keyword options for <see cref="Cursor"/>
    /// </summary>
    public enum CursorOptions
    {
        /// <summary>
        ///Cursor Alias
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'alias'</c></list>
        /// </summary>
        Alias,
        /// <summary>
        ///Scrolled in any direction
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'all-scroll'</c></list>
        /// </summary>
        AllScroll,
        /// <summary>
        ///Default, sets Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'auto'</c></list>
        /// </summary>
        Auto,
        /// <summary>
        ///Sndicates Cursor that a Cell (or set of Cells) may be selected
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'cell'</c></list>
        /// </summary>
        Cell,
        /// <summary>
        ///Sets Cursor that a ContextMenu is available
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'context-menu'</c></list>
        /// </summary>
        ContextMenu,
        /// <summary>
        ///Cursor sets that the column can be resized horizontally
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'col-resize'</c></list>
        /// </summary>
        ColResize,
        /// <summary>
        ///Cursor sets something is to be copied
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'copy'</c></list>
        /// </summary>
        Copy,
        /// <summary>
        ///Renders Cursor as a Crosshair
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'crosshair'</c></list>
        /// </summary>
        Crosshair,
        /// <summary>
        ///Default Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'default'</c></list>
        /// </summary>
        Default,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved right (east)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'e-resize'</c></list>
        /// </summary>
        EResize,
        /// <summary>
        ///Sets a bidirectional resize Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ew-resize'</c></list>
        /// </summary>
        EwResize,
        /// <summary>
        ///Cursor sets that something can be Grabbed
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'grab'</c></list>
        /// </summary>
        Grab,
        /// <summary>
        ///Cursor sets that something can be grabbed
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'grabbing'</c></list>
        /// </summary>
        Grabbing,
        /// <summary>
        ///Cursor sets that Help is available
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'help'</c></list>
        /// </summary>
        Help,
        /// <summary>
        ///Cursor sets that something is to be Moved
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'move'</c></list>
        /// </summary>
        Move,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved up (north)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'n-resize'</c></list>
        /// </summary>
        NResize,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved up and right (north/east)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ne-resize'</c></list>
        /// </summary>
        NeResize,
        /// <summary>
        ///Sets bidirectional resize Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'nesw-resize'</c></list>
        /// </summary>
        NeswResize,
        /// <summary>
        ///Sets bidirectional resize Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'ns-resize'</c></list>
        /// </summary>
        NsResize,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved up and left (north/west)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'nw-resize'</c></list>
        /// </summary>
        NwResize,
        /// <summary>
        ///Sets bidirectional resize Cursor
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'nwse-resize'</c></list>
        /// </summary>
        NwseResize,
        /// <summary>
        ///Cursor sets that the dragged item cannot be dropped here
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'no-drop'</c></list>
        /// </summary>
        NoDrop,
        /// <summary>
        ///No Cursor is rendered for the element
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'none'</c></list>
        /// </summary>
        None,
        /// <summary>
        ///Cursor sets that the requested action will not be executed
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'not-allowed'</c></list>
        /// </summary>
        NotAllowed,
        /// <summary>
        ///Cursor is set as Pointer and indicates a link
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'pointer'</c></list>
        /// </summary>
        Pointer,
        /// <summary>
        ///Cursor sets that the program is busy (in Progress)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'progress'</c></list>
        /// </summary>
        Progress,
        /// <summary>
        ///Cursor sets that the row can be resized vertically
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'row-resize'</c></list>
        /// </summary>
        RowResize,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved down (south)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'s-resize'</c></list>
        /// </summary>
        SResize,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved down and right (south/east)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'se-resize'</c></list>
        /// </summary>
        SeResize,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved down and left (south/west)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'sw-resize'</c></list>
        /// </summary>
        SwResize,
        /// <summary>
        ///Cursor sets Text that may be selected
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'text'</c></list>
        /// </summary>
        Text,
        /// <summary>
        ///Comma separated list of URLs to custom Cursors
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'URL'</c></list>
        /// </summary>
        URL,
        /// <summary>
        ///Cursor sets VerticalText that may be selected
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'vertical-text'</c></list>
        /// </summary>
        VerticalText,
        /// <summary>
        ///Cursor sets that an edge of a box is to be moved left (west)
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'w-resize'</c></list>
        /// </summary>
        WResize,
        /// <summary>
        ///Cursor sets that the program is busy
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'wait'</c></list>
        /// </summary>
        Wait,
        /// <summary>
        ///Cursor sets that something can be zoomed in
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'zoom-in'</c></list>
        /// </summary>
        ZoomIn,
        /// <summary>
        ///Cursor sets that something can be zoomed out
        ///<br/>
        ///<list type="bullet">It is equavalent to <c>'zoom-out'</c></list>
        /// </summary>
        ZoomOut,
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