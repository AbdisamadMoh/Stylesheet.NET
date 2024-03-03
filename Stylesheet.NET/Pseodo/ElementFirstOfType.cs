namespace Stylesheet.NET
{
    public class ElementFirstOfType : Pseudo
    {
        public ElementFirstOfType() : base(PseudoType.FirstOfType) { }
        public ElementFirstOfType(string name) : base(name, PseudoType.FirstOfType) { }
    }
}