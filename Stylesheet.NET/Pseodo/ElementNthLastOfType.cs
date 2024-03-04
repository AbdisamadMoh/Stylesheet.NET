namespace StylesheetNET
{
    public class ElementNthLastOfType : NthPseudo
    {
        public ElementNthLastOfType(int position) : this("", position.ToString()) { }
        public ElementNthLastOfType(string name, string position) : base(name, position, PseudoType.NthLastOfType) { }
    }
}