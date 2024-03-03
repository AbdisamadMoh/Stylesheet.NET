namespace Stylesheet.NET
{
    public class ElementLink : Pseudo
    {
        public ElementLink() : base(PseudoType.Link) { }
        public ElementLink(string name) : base(name, PseudoType.Link) { }
    }
}