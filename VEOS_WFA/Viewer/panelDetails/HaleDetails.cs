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
    public partial class HaleDetails : UserControl
    {
        public HaleDetails()
        {
            InitializeComponent();
        }

        public String getLblValueOfNameHale() 
        {
            
            return lblValueOfNameHale.Text.ToString();
        }

        public void setLblValueOfNameHale(String temp)
        {
            lblValueOfNameHale.Text = temp;
        }

        public String getLblValueOfBrojTerena()
        {
            return lblValueOfBrojTerena.Text.ToString();
        }

        public void setLblValueOfBrojTerena(String temp)
        {
            lblValueOfBrojTerena.Text = temp;
        }

    }
}
