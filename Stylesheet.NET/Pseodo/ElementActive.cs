namespace Stylesheet.NET
{
    public class ElementActive : Pseudo
    {
        public ElementActive() : base(PseudoType.Active) { }
        public ElementActive(string name) : base(name, PseudoType.Active) { }
    }
}