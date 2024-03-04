namespace StylesheetNET
{
    public class ElementHover : Pseudo
    {
        public ElementHover() : base(PseudoType.Hover) { }
        public ElementHover(string name) : base(name, PseudoType.Hover) { }
    }
}