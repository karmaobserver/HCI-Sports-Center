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
    public partial class DialogTimoviDetails : UserControl
    {
        public DialogTimoviDetails()
        {
            InitializeComponent();
        }

        private static DialogTimoviDetails instance;

        public static DialogTimoviDetails getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogTimoviDetails();
                }
                return instance;
            }

        }

        public string getLblValueOfBrSportista()
        {
            return lblValueOfBrSportista.Text.ToString();
        }

        public void setLblValueOfBrSportista(string temp)
        {
            lblValueOfBrSportista.Text = temp;
        }

        public string getLblValueOfSport()
        {
            return lblValueOfSport.Text.ToString();
        }

        public void setLblValueOfSport(string temp)
        {
            lblValueOfSport.Text = temp;
        }

        public string getLblValueOfTbKomentar()
        {
            return tbKomentar.Text.ToString();
        }

        public void setLblValueOfTbKomentar(string temp)
        {
            tbKomentar.Text = temp;
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
