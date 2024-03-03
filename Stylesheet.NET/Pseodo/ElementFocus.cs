namespace Stylesheet.NET
{
    public class ElementFocus : Pseudo
    {
        public ElementFocus() : base(PseudoType.Focus) { }
        public ElementFocus(string name) : base(name, PseudoType.Focus) { }
    }
}