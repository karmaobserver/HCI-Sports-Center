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
    public partial class SportistiDetails : UserControl
    {
        public SportistiDetails()
        {
            InitializeComponent();
        }

        public String getLblNameOfButton()
        {
            return lblNameOfButton.Text.ToString();
        }

        public void setLblNameOfButton(String temp)
        {
            lblNameOfButton.Text = temp;
        }

    }
}
