namespace StylesheetNET
{
    public class ElementEmpty : Pseudo
    {
        public ElementEmpty() : base(PseudoType.Empty) { }
        public ElementEmpty(string name) : base(name, PseudoType.Empty) { }
    }
}