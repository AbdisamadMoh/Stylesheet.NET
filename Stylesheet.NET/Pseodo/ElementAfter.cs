namespace StylesheetNET
{
    public class ElementAfter : Pseudo
    {
        public ElementAfter() : base(PseudoType.After) { }
        public ElementAfter(string name) : base(name, PseudoType.After) { }
    }
}