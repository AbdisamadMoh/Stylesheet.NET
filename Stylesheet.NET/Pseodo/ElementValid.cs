namespace Stylesheet.NET
{
    public class ElementValid : Pseudo
    {
        public ElementValid() : base(PseudoType.Valid) { }
        public ElementValid(string name) : base(name, PseudoType.Valid) { }
    }
}