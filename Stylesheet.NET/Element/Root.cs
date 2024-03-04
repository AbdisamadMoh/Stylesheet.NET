namespace StylesheetNET
{
    /// <summary>
    /// The Root matches the document's root element. In HTML, the root element is always the html element.
    /// </summary>
    public class Root : Element
    {
        public Root() : base(":root") { }
        protected Root(string name) : base(name) { }
    }
}
