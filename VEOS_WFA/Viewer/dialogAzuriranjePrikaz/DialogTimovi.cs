using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuTimovi;

namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
{
    public partial class DialogTimovi : Form
    {
        public DialogTimovi()
        {
            InitializeComponent();
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            DodavanjeTimova dodavanjeTimova = new DodavanjeTimova();
            dodavanjeTimova.ShowDialog();
        }
    }
}
