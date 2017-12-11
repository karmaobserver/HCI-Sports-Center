using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuSportisti;

namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
{
    public partial class DialogSportisti : Form
    {
        public DialogSportisti()
        {
            InitializeComponent();
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
                DodavanjeSportista dodavanjeSportista = new DodavanjeSportista();
                dodavanjeSportista.ShowDialog();
        }
    }
}
