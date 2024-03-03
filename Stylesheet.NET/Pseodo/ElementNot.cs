namespace Stylesheet.NET
{
    public class ElementNot : NthPseudo
    {
        public ElementNot(string element) : base("", element, PseudoType.Not) { }
        public ElementNot(string name, string element) : base(name, element, PseudoType.Not) { }
    }
}