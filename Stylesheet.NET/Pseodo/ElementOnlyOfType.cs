namespace Stylesheet.NET
{
    public class ElementOnlyOfType : Pseudo
    {
        public ElementOnlyOfType() : base(PseudoType.OnlyOfType) { }
        public ElementOnlyOfType(string name) : base(name, PseudoType.OnlyOfType) { }
    }
}