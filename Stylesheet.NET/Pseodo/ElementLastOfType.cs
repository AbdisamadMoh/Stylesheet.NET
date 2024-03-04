namespace StylesheetNET
{
    public class ElementLastOfType : Pseudo
    {
        public ElementLastOfType() : base(PseudoType.LastOfType) { }
        public ElementLastOfType(string name) : base(name, PseudoType.LastOfType) { }
    }
}