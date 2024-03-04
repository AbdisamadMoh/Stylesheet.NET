namespace StylesheetNET
{
    public class ElementSelection : Pseudo
    {
        public ElementSelection() : base(PseudoType.Selection) { }
        public ElementSelection(string name) : base(name, PseudoType.Selection) { }
    }
}