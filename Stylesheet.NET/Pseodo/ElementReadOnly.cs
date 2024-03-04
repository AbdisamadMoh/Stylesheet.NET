namespace StylesheetNET
{
    public class ElementReadOnly : Pseudo
    {
        public ElementReadOnly() : base(PseudoType.ReadOnly) { }
        public ElementReadOnly(string name) : base(name, PseudoType.ReadOnly) { }
    }
}