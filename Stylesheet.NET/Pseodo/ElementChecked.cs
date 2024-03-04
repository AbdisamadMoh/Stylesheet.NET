namespace StylesheetNET
{
    public class ElementChecked : Pseudo
    {
        public ElementChecked() : base(PseudoType.Checked) { }
        public ElementChecked(string name) : base(name, PseudoType.Checked) { }
    }
}