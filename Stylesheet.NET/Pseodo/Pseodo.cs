namespace StylesheetNET
{

    public abstract class Pseudo : Element
    {
        private Pseudo()
        {
        }
        private Pseudo(string name)
        {
        }

        internal Pseudo(string name, PseudoType type) : base(name)
        {
            Set(type);
        }
        internal Pseudo(PseudoType type) : base()
        {
            Set(type);
        }
        private void Set(PseudoType type)
        {
            base.PseudoSignature = Keywords.GetPseudoByType(type);
        }


    }
    public abstract class NthPseudo : Element
    {
        private NthPseudo()
        {
        }
        private NthPseudo(string name) : base(name)
        {
        }
        internal NthPseudo(string name, string value, PseudoType type)
        {
            this._Name = Keywords.GetPseudoByType(type) + $"({name})";
            Set(type, value);
        }
        internal NthPseudo(PseudoType type, string val)
        {
            Set(type, val);
        }
        private void Set(PseudoType type, string value)
        {
            base.PseudoSignatureValue = value;
            base.PseudoSignature = Keywords.GetPseudoByType(type) + $"({value})";
        }



    }


}
