namespace Stylesheet.NET
{
    public class ElementNthChild : NthPseudo
    {
        public ElementNthChild(int position) : this("", position.ToString()) { }
        public ElementNthChild(string name, string position) : base(name, position, PseudoType.NthChild) { }
    }
}