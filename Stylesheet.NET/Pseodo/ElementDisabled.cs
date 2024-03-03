namespace Stylesheet.NET
{
    public class ElementDisabled : Pseudo
    {
        public ElementDisabled() : base(PseudoType.Disabled) { }
        public ElementDisabled(string name) : base(name, PseudoType.Disabled) { }
    }
}