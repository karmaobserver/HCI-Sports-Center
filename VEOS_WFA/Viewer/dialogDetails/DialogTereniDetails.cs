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
    public partial class DialogTereniDetails : UserControl
    {
        public DialogTereniDetails()
        {
            InitializeComponent();
        }

        private static DialogTereniDetails instance;

        public static DialogTereniDetails getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogTereniDetails();
                }
                return instance;
            }

        }

        public string getLblValueOfGodinaOpremljenja()
        {
            return lblValueOfGodinaOpremljenja.Text.ToString();
        }

        public void setLblValueOfGodinaOpremljenja(string temp)
        {
            lblValueOfGodinaOpremljenja.Text = temp;
        }

        public string getLblValueOfKapacitet()
        {
            return lblValueOfKapacitet.Text.ToString();
        }

        public void setLblValueOfKapacitet(string temp)
        {
            lblValueOfKapacitet.Text = temp;
        }

        public string getLblValueOfLokacija()
        {
            return lblValueOfLokacija.Text.ToString();
        }

        public void setLblValueOfLokacija(string temp)
        {
            lblValueOfLokacija.Text = temp;
        }

        public string getLblValueOfStatus()
        {
            return lblValueOfStatus.Text.ToString();
        }

        public void setLblValueOfStatus(string temp)
        {
            lblValueOfStatus.Text = temp;
        }

        public string getLblValueOfSportovi()
        {
            return lblValueOfSportovi.Text.ToString();
        }

        public void setLblValueOfSportovi(string temp)
        {
            lblValueOfSportovi.Text = temp;
        }

        public string getLblValueOfIme()
        {
            return lblValueOfIme.Text.ToString();
        }

        public void setLblValueOfIme(string temp)
        {
            lblValueOfIme.Text = temp;
        }
    }
}
