using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VEOS_WFA.model.entity
{
    [Serializable]
    class Sportista
    {
        public enum Klasa { Amater, Poluprofesionalac, Profesionalac };

        public Sportista(string jmbg, string ime, string prezime, string godinaUpisa, Klasa klasa, VEOS_WFA.model.entity.Sport sport, Image image)
        {
             this.sport = sport;
             this.klasa = klasa;
             this.godinaUpisa = godinaUpisa;
             this.prezime = prezime;
             this.ime = ime;
             this.jmbg = jmbg;
             this.sifra = Guid.NewGuid();
             this.image = image;
        }
    
        private Guid sifra;

        public Guid Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private string jmbg;

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string godinaUpisa;

        public string GodinaUpisa
        {
            get { return godinaUpisa; }
            set { godinaUpisa = value; }
        }

        private Klasa klasa;

        public Klasa Klasa1
        {
            get { return klasa; }
            set { klasa = value; }
        }

        private Sport sport;

        internal Sport Sport
        {
            get { return sport; }
            set { sport = value; }
        }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }
    }
}
