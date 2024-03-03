namespace Stylesheet.NET
{
    public class ElementBefore : Pseudo
    {
        public ElementBefore() : base(PseudoType.Before) { }
        public ElementBefore(string name) : base(name, PseudoType.Before) { }
    }
}