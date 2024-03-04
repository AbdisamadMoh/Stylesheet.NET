namespace StylesheetNET
{
    public class ElementMarker : Pseudo
    {
        public ElementMarker() : base(PseudoType.Marker) { }
        public ElementMarker(string name) : base(name, PseudoType.Marker) { }
    }
}