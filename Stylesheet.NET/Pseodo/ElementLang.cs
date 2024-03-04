namespace StylesheetNET
{
    public class ElementLang : NthPseudo
    {
        public ElementLang(string language) : base("", language, PseudoType.Lang) { }
        public ElementLang(string name, string language) : base(name, language, PseudoType.Lang) { }
    }
}