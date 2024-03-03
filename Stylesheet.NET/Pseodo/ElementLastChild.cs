namespace Stylesheet.NET
{
    public class ElementLastChild : Pseudo
    {
        public ElementLastChild() : base(PseudoType.LastChild) { }
        public ElementLastChild(string name) : base(name, PseudoType.LastChild) { }
    }
}