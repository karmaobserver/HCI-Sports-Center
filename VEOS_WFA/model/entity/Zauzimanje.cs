using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Zauzimanje
    {
        public enum Namena { Turnir, Mec, Trening, Drugo };

        public Zauzimanje(System.Guid sifraTima, System.Guid sifraTerena, System.DateTime zauzimanjeTerena, System.DateTime oslobadanjeTerena, Namena namena, string primedbe, Enumeration.Status status)
        {
             this.primedbe = primedbe;
             this.namena = namena;
             this.oslobadanjeTerena = oslobadanjeTerena;
             this.zauzimanjeTerena = zauzimanjeTerena;
             this.sifraTerena = sifraTerena;
             this.sifraTima = sifraTima;
             this.status = status;
             this.sifra = Guid.NewGuid();
        }
        

        private Guid sifra;

        public Guid Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }



        private Guid sifraTima;

        public Guid SifraTima
        {
            get { return sifraTima; }
            set { sifraTima = value; }
        }

        private Guid sifraTerena;

        public Guid SifraTerena
        {
            get { return sifraTerena; }
            set { sifraTerena = value; }
        }

       
        private DateTime zauzimanjeTerena;

        public DateTime ZauzimanjeTerena
        {
            get { return zauzimanjeTerena; }
            set { zauzimanjeTerena = value; }
        }
        private DateTime oslobadanjeTerena;

        public DateTime OslobadanjeTerena
        {
            get { return oslobadanjeTerena; }
            set { oslobadanjeTerena = value; }
        }
        private Namena namena;

        internal Namena Namena1
        {
            get { return namena; }
            set { namena = value; }
        }

        private Enumeration.Status status;

        public Enumeration.Status Status
        {
            get { return status; }
            set { status = value; }
        }

        private string primedbe;

        public string Primedbe
        {
            get { return primedbe; }
            set { primedbe = value; }
        }
    }
}
