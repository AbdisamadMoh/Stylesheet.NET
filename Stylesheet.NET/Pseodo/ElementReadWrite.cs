namespace Stylesheet.NET
{
    public class ElementReadWrite : Pseudo
    {
        public ElementReadWrite() : base(PseudoType.ReadWrite) { }
        public ElementReadWrite(string name) : base(name, PseudoType.ReadWrite) { }
    }
}