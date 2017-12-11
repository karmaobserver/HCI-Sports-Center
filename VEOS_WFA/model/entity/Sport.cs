using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Sport
    {
        public Sport(string imeSporta, string prefixSporta, string beleskeSporta)
        {
             this.beleskeSporta = beleskeSporta;
             this.prefixSporta = prefixSporta;
             this.imeSporta = imeSporta;
             this.sifra = Guid.NewGuid();
        }
    
        private Guid sifra;

        public Guid Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        private string imeSporta;

        public string ImeSporta
        {
            get { return imeSporta; }
            set { imeSporta = value; }
        }
        private string prefixSporta;

        public string PrefixSporta
        {
            get { return prefixSporta; }
            set { prefixSporta = value; }
        }
        private string beleskeSporta;

        public string BeleskeSporta
        {
            get { return beleskeSporta; }
            set { beleskeSporta = value; }
        }

        public override string ToString()
        {
            return ImeSporta;
        }
    }
}
