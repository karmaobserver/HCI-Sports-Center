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
    public partial class DialogZauzimanjeTerenaDetails : UserControl
    {
        public DialogZauzimanjeTerenaDetails()
        {
            InitializeComponent();
        }

        private static DialogZauzimanjeTerenaDetails instance;

        public static DialogZauzimanjeTerenaDetails getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogZauzimanjeTerenaDetails();
                }
                return instance;
            }
        }

        public void setLblValueOfTim(string param)
        {
            lblValueOfTim.Text = param;
        }

        public string getLblValueOfTim()
        {
            return lblValueOfTim.Text;
        }

        public void setLblValueOfTeren(string param)
        {
            lblValueOfTerena.Text = param;
        }

        public string getLblValueOfTeren()
        {
            return lblValueOfTerena.Text;
        }

        public void setLblValueOfNamemaKoriscenja(string param)
        {
            lblValueOfNamemaKoriscenja.Text = param;
        }

        public string getLblValueOfNamemaKoriscenja()
        {
            return lblValueOfNamemaKoriscenja.Text;
        }

        public void setTbValueOfPrimedbaZauzimanja(string param)
        {
            tbValueOfPrimedbaZauzimanja.Text = param;
        }

        public string getTbValueOfPrimedbaZauzimanja()
        {
            return tbValueOfPrimedbaZauzimanja.Text;
        }
    }
}
