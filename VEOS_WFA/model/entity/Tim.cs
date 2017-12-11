using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Tim
    {
        public Tim(string ime, System.Collections.Generic.Dictionary<System.Guid, VEOS_WFA.model.entity.Sportista> sportiste, VEOS_WFA.model.entity.Sport sport, string kommentar)
        {
             this.kommentar = kommentar;
             this.sport = sport;
             if (this.sportiste == null)
             {
                 this.brSportista = 0;
             }
             else
             {
                 this.brSportista = this.sportiste.Count;
             }
             this.sportiste = sportiste;
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

        private Dictionary<Guid, Sportista> sportiste;

        internal Dictionary<Guid, Sportista> Sportiste
        {
            get { return sportiste; }
            set { sportiste = value; }
        }

        private int brSportista;

        public int BrSportista
        {
            get { if(this.sportiste == null) return 0; else return sportiste.Count;}
            set { brSportista = value; }
        }

        private Sport sport;

        internal Sport Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        private string kommentar;

        public string Kommentar
        {
            get { return kommentar; }
            set { kommentar = value; }
        }

        private bool slobodan;

        public bool Slobodan
        {
            get { return slobodan; }
            set { slobodan = value; }
        }

        public override string ToString()
        {
            return ime;
        }
    }
}
