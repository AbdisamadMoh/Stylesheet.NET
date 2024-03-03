namespace Stylesheet.NET
{
    public class ElementVisited : Pseudo
    {
        public ElementVisited() : base(PseudoType.Visited) { }
        public ElementVisited(string name) : base(name, PseudoType.Visited) { }
    }
}