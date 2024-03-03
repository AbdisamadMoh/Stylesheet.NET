namespace Stylesheet.NET
{
    public class ElementFirstChild : Pseudo
    {
        public ElementFirstChild() : base(PseudoType.FirstChild) { }
        public ElementFirstChild(string name) : base(name, PseudoType.FirstChild) { }
    }
}