﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuTimovi
{
    public partial class DodavanjeTimova : Form
    {
        public DodavanjeTimova()
        {
            InitializeComponent();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
