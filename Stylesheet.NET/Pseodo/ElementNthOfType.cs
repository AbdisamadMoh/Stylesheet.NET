namespace StylesheetNET
{
    public class ElementNthOfType : NthPseudo
    {
        public ElementNthOfType(int position) : this("", position.ToString()) { }
        public ElementNthOfType(string name, string position) : base(name, position, PseudoType.NthOfType) { }
    }
}