using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEOS_WFA.Viewer.dialogDetails
{
    public partial class DialogSportistiDetails : UserControl
    {
        public DialogSportistiDetails()
        {
            InitializeComponent();
        }

        private static DialogSportistiDetails instance;

        public static DialogSportistiDetails getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogSportistiDetails();
                }
                return instance;
            }

        }

        public string getLblValueOfGodinaUpisa()
        {
            return lblValueOfGodinaUpisa.Text.ToString();
        }

        public void setLblValueOfGodinaUpisa(string temp)
        {
            lblValueOfGodinaUpisa.Text = temp;
        }

        public string getLblValueOfIme()
        {
            return lblValueOfIme.Text.ToString();
        }

        public void setLblValueOfIme(string temp)
        {
            lblValueOfIme.Text = temp;
        }

        public string getLblValueOfJmbg()
        {
            return lblValueOfJmbg.Text.ToString();
        }

        public void setLblValueOfJmbg(string temp)
        {
            lblValueOfJmbg.Text = temp;
        }

        public string getLblValueOfKlasa()
        {
            return lblValueOfKlasa.Text.ToString();
        }

        public void setLblValueOfKlasa(string temp)
        {
            lblValueOfKlasa.Text = temp;
        }

        public string getLblValueOfPrezime()
        {
            return lblValueOfPrezime.Text.ToString();
        }

        public void setLblValueOfPrezime(string temp)
        {
            lblValueOfPrezime.Text = temp;
        }

        public string getLblValueOfSport()
        {
            return lblValueOfSport.Text.ToString();
        }

        public void setLblValueOfSport(string temp)
        {
            lblValueOfSport.Text = temp;
        }

   
    }
}
