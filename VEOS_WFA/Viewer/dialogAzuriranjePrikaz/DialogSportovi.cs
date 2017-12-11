using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuSportovi;

namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
{
    public partial class DialogSportovi : Form
    {
        public DialogSportovi()
        {
            InitializeComponent();
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            DodavanjeSportova dodavanjeSportova = new DodavanjeSportova();
            dodavanjeSportova.ShowDialog();
        }
    }
}
