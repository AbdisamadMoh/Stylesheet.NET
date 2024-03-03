namespace Stylesheet.NET
{
    public class ElementInRange : Pseudo
    {
        public ElementInRange() : base(PseudoType.InRange) { }
        public ElementInRange(string name) : base(name, PseudoType.InRange) { }
    }
}