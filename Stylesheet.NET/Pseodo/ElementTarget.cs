namespace Stylesheet.NET
{
    public class ElementTarget : Pseudo
    {
        public ElementTarget() : base(PseudoType.Target) { }
        public ElementTarget(string name) : base(name, PseudoType.Target) { }
    }
}