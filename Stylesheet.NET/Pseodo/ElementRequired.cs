namespace Stylesheet.NET
{
    public class ElementRequired : Pseudo
    {
        public ElementRequired() : base(PseudoType.Required) { }
        public ElementRequired(string name) : base(name, PseudoType.Required) { }
    }
}