namespace Stylesheet.NET
{
    public class ElementFirstLine : Pseudo
    {
        public ElementFirstLine() : base(PseudoType.FirstLine) { }
        public ElementFirstLine(string name) : base(name, PseudoType.FirstLine) { }
    }
}