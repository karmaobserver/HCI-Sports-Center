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
    public partial class DialogSportoviDetails : UserControl
    {
        public DialogSportoviDetails()
        {
            InitializeComponent();
        }

        private static DialogSportoviDetails instance;

        public static DialogSportoviDetails getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogSportoviDetails();
                }
                return instance;
            }

        }

        public string getLblValueOfIme()
        {
            return lblValueOfIme.Text.ToString();
        }

        public void setLblValueOfIme(string temp)
        {
            lblValueOfIme.Text = temp;
        }

        public string getLblValueOfPrefiks()
        {
            return lblValueOfPrefiks.Text.ToString();
        }

        public void setLblValueOfPrefiks(string temp)
        {
            lblValueOfPrefiks.Text = temp;
        }

        public string getTbBeleske()
        {
            return tbBeleske.Text.ToString();
        }

        public void setTbBeleske(string temp)
        {
            tbBeleske.Text = temp;
        }
    }
}
