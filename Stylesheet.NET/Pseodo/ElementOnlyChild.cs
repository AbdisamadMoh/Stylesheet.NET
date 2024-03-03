namespace Stylesheet.NET
{
    public class ElementOnlyChild : Pseudo
    {
        public ElementOnlyChild() : base(PseudoType.OnlyChild) { }
        public ElementOnlyChild(string name) : base(name, PseudoType.OnlyChild) { }
    }
}