namespace StylesheetNET
{
    public class ElementFirstLetter : Pseudo
    {
        public ElementFirstLetter() : base(PseudoType.FirstLetter) { }
        public ElementFirstLetter(string name) : base(name, PseudoType.FirstLetter) { }
    }
}