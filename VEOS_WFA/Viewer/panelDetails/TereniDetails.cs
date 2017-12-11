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
    public partial class TereniDetails : UserControl
    {   
        public TereniDetails()
        {
            InitializeComponent();
        }

        

        public String getLblValueOfSportovi()
        {
            return lblValueOfSportovi.Text.ToString();
        }

        public void setLblValueOfSportovi(String temp)
        {
            lblValueOfSportovi.Text = temp;
        }

        public String getLblValueOfGodOpr()
        {
            return lblValueOfGodOpr.Text.ToString();
        }

        public void setLblValueOfGodOpr(String temp)
        {
            lblValueOfGodOpr.Text = temp;
        }

        public String getLblValueOfKapacitet()
        {
            return lblValueOfKapacitet.Text.ToString();
        }

        public void setLblValueOfKapacitet(String temp)
        {
            lblValueOfKapacitet.Text = temp;
        }

        public string getGbTereniDetailsText()
        {
            return gbTereniDetails.Text;
        }

        public void setGbTereniDetailsText(string param)
        {
            gbTereniDetails.Text = "Podaci o " + param + ":";
        }
    }
}
