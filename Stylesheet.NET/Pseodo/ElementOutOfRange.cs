namespace Stylesheet.NET
{
    public class ElementOutOfRange : Pseudo
    {
        public ElementOutOfRange() : base(PseudoType.OutOfRange) { }
        public ElementOutOfRange(string name) : base(name, PseudoType.OutOfRange) { }
    }
}