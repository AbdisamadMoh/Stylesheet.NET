namespace Stylesheet.NET
{
    public class ElementFirstLetter : Pseudo
    {
        public ElementFirstLetter() : base(PseudoType.FirstLetter) { }
        public ElementFirstLetter(string name) : base(name, PseudoType.FirstLetter) { }
    }
}