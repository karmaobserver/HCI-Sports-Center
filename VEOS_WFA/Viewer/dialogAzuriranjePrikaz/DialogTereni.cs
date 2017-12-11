using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.collection;
using VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuTereni;

namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
{
    public partial class DialogTereni : Form
    {
        public DialogTereni()
        {
            InitializeComponent();
        }

        private void DialogTereni_Load(object sender, EventArgs e)
        {
            Hale_Collection haleCollection = Hale_Collection.getInstance;
            //dgvTereni.
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            DodavanjeTerena dodavanjeTerena = new DodavanjeTerena();
            dodavanjeTerena.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
