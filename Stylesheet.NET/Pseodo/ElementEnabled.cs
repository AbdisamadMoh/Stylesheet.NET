namespace StylesheetNET
{
    public class ElementEnabled : Pseudo
    {
        public ElementEnabled() : base(PseudoType.Enabled) { }
        public ElementEnabled(string name) : base(name, PseudoType.Enabled) { }
    }
}