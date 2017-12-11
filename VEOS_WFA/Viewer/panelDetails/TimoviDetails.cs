using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEOS_WFA
{
    public partial class TimoviDetails : UserControl
    {
        public TimoviDetails()
        {
            InitializeComponent();
        }

        public String getLblValueOfBrSportista()
        {
            return lblValueOfBrSportista.Text.ToString();
        }

        public void seLblValueOfBrSportista(String temp)
        {
            lblValueOfBrSportista.Text = temp;
        }

        public String getLblValueOfSport()
        {
            return lblValueOfSport.Text.ToString();
        }

        public void setLblValueOfSport(String temp)
        {
            lblValueOfSport.Text = temp;
        }

        public String getTbKommentar()
        {
            return tbKomentar.Text.ToString();
        }

        public void setTbKommentar(String temp)
        {
            tbKomentar.Text = temp;
        }
    }
}
