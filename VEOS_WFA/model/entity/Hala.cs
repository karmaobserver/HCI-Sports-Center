using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Hala
    {
        public Hala(string imeHale, int brTerena)
        {
             this.brTerena = brTerena;
             this.imeHale = imeHale;
             this.sifra = Guid.NewGuid();
        }

        private Guid sifra;

        public Guid Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
    
        private string imeHale;

        public string ImeHale
        {
            get { return imeHale; }
            set { imeHale = value; }
        }


        private int brTerena;

        public int BrTerena
        {
            get { return brTerena; }
            set { brTerena = value; }
        }

        public override string ToString()
        {
            System.Diagnostics.Debug.WriteLine(ImeHale);
            return "" + ImeHale.ToString();
        }

    }
}
