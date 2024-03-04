namespace StylesheetNET
{
    public class ElementInvalid : Pseudo
    {
        public ElementInvalid() : base(PseudoType.Invalid) { }
        public ElementInvalid(string name) : base(name, PseudoType.Invalid) { }
    }
}