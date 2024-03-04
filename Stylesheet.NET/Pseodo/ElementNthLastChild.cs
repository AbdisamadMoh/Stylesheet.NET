namespace StylesheetNET
{
    public class ElementNthLastChild : NthPseudo
    {
        public ElementNthLastChild(int position) : this("", position.ToString()) { }
        public ElementNthLastChild(string name, string position) : base(name, position, PseudoType.NthLastChild) { }
    }
}