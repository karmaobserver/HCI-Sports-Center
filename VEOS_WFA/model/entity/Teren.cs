using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Teren
    {
        public Teren(string ime, VEOS_WFA.model.entity.Hala lokacija, string godinaOpremljenja, bool otvoren, System.Collections.Generic.Dictionary<System.Guid, VEOS_WFA.model.entity.Sport> sportovi, int kapacitet, string kommentar)
        {
             this.kommentar = kommentar;
             this.kapacitet = kapacitet;
             this.sportovi = sportovi;
             this.otvoren = otvoren;
             this.godinaOpremljenja = godinaOpremljenja;
             this.lokacija = lokacija;
             this.ime = ime;
             this.sifra = Guid.NewGuid();
             this.slobodan = true;
        }
        
    
        private Guid sifra;

        public Guid Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private Hala lokacija;

        internal Hala Lokacija
        {
            get { return lokacija; }
            set { lokacija = value; }
        }

        private string godinaOpremljenja;

        public string GodinaOpremljenja
        {
            get { return godinaOpremljenja; }
            set { godinaOpremljenja = value; }
        }

        private bool otvoren;

        public bool Otvoren
        {
            get { return otvoren; }
            set { otvoren = value; }
        }

        private bool slobodan;

        public bool Slobodan
        {
            get { return slobodan; }
            set { slobodan = value; }
        }

        private string trenutniTim;

        public string TrenutniTim
        {
            get { return trenutniTim; }
            set { trenutniTim = value; }
        }

        
        private Dictionary<Guid, Sport> sportovi;

        internal Dictionary<Guid, Sport> Sportovi
        {
            get { return sportovi; }
            set { sportovi = value; }
        }

        private int kapacitet;

        public int Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        private string kommentar;

        public string Kommentar
        {
            get { return kommentar; }
            set { kommentar = value; }
        }

        public override string ToString()
        {
            return ime;
        }
    }
}
