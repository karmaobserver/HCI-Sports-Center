using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.entity;
using VEOS_WFA.model.collection;
using VEOS_WFA.Viewer.dialogDetails;
using VEOS_WFA.model;

namespace VEOS_WFA.Viewer.dialogUserControls
{
    public partial class ZauzimanjeTerena : UserControl
    {
        public ZauzimanjeTerena()
        {
            InitializeComponent();
        }

        string trenutniTeren = "";

        public string TrenutniTeren
        {
            get { return trenutniTeren; }
            set { trenutniTeren = value; }
        }

        private static ZauzimanjeTerena instance;

        public static ZauzimanjeTerena getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZauzimanjeTerena();
                }
                return instance;
            }
        }

        public void loadTableData(string param)
        {
            dgvZauzimanjeTerena.Rows.Clear();
            foreach (KeyValuePair<Guid, Zauzimanje> temp in Zauzimanje_Collection.getInstance.Zauzimanje_collection)
            {
                Teren teren = new Teren(null, null, null, false, null, -1, null);
                Tim tim = new Tim(null, null, null, null);
                Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(temp.Value.SifraTerena.ToString()), out teren);
                Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(temp.Value.SifraTima.ToString()), out tim);
                System.Diagnostics.Debug.WriteLine(tim.Ime.ToString() + " VS " + param);
                if (tim.Ime.ToString().Contains(param) || teren.Ime.ToString().Contains(param) || temp.Value.Status.ToString().Contains(param) || temp.Value.ZauzimanjeTerena.ToString().Contains(param) || temp.Value.OslobadanjeTerena.ToString().Contains(param) || temp.Value.Namena1.ToString().Contains(param) || temp.Value.Primedbe.ToString().Contains(param))
                {
                    dgvZauzimanjeTerena.Rows.Add(temp.Key, tim.Ime, teren.Ime, temp.Value.Status, temp.Value.ZauzimanjeTerena, temp.Value.OslobadanjeTerena, temp.Value.Namena1, temp.Value.Primedbe);
                }
            }
            dgvZauzimanjeTerena.ClearSelection();
            dgvZauzimanjeTerena.CurrentCell = null;
            lblValueOfRezultat.Text = dgvZauzimanjeTerena.Rows.Count.ToString();
        }

        private void ZauzimanjeTerena_Load(object sender, EventArgs e)
        {
            loadTableDataWithFilter(trenutniTeren);
            System.Diagnostics.Debug.WriteLine(trenutniTeren);
            tbSearchText.Text = trenutniTeren;
        }

        private void dgvZauzimanjeTerena_SelectionChanged(object sender, EventArgs e)
        {  
            if (dgvZauzimanjeTerena.SelectedRows.Count > 0)
            {
                DialogZauzimanjeTerenaDetails.getInstance.setLblValueOfTim(dgvZauzimanjeTerena.SelectedCells[1].Value.ToString());
                DialogZauzimanjeTerenaDetails.getInstance.setLblValueOfTeren(dgvZauzimanjeTerena.SelectedCells[2].Value.ToString());
                DialogZauzimanjeTerenaDetails.getInstance.setLblValueOfNamemaKoriscenja(dgvZauzimanjeTerena.SelectedCells[6].Value.ToString());
                DialogZauzimanjeTerenaDetails.getInstance.setTbValueOfPrimedbaZauzimanja(dgvZauzimanjeTerena.SelectedCells[7].Value.ToString());
            }
        }

        public void loadTableDataWithFilter(string param)
        {
            tbSearchText.Text = param;
            if (cbOslobadanje.Checked == true && cbZauzimanje.Checked == true)
            {
                loadTableData(param);
            }

            if (cbOslobadanje.Checked == true && cbZauzimanje.Checked == false)
            {
                dgvZauzimanjeTerena.Rows.Clear();
                foreach (KeyValuePair<Guid, Zauzimanje> temp in Zauzimanje_Collection.getInstance.Zauzimanje_collection)
                {
                    if (temp.Value.Status == Enumeration.Status.OSLOBADJANJE)
                    {
                        Teren teren = new Teren(null, null, null, false, null, -1, null);
                        Tim tim = new Tim(null, null, null, null);
                        Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(temp.Value.SifraTerena.ToString()), out teren);
                        Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(temp.Value.SifraTima.ToString()), out tim);
                        if (tim.Ime.Contains(param) || teren.Ime.Contains(param) || temp.Value.Status.ToString().Contains(param) || temp.Value.ZauzimanjeTerena.ToString().Contains(param) || temp.Value.OslobadanjeTerena.ToString().Contains(param) || temp.Value.Namena1.ToString().Contains(param) || temp.Value.Primedbe.ToString().Contains(param))
                        {
                            dgvZauzimanjeTerena.Rows.Add(temp.Key, tim.Ime, teren.Ime, temp.Value.Status, temp.Value.ZauzimanjeTerena, temp.Value.OslobadanjeTerena, temp.Value.Namena1, temp.Value.Primedbe);
                        }
                    }
                }
                dgvZauzimanjeTerena.ClearSelection();
                dgvZauzimanjeTerena.CurrentCell = null;
                lblValueOfRezultat.Text = dgvZauzimanjeTerena.Rows.Count.ToString();
            }

            if (cbOslobadanje.Checked == false && cbZauzimanje.Checked == true)
            {
                dgvZauzimanjeTerena.Rows.Clear();
                foreach (KeyValuePair<Guid, Zauzimanje> temp in Zauzimanje_Collection.getInstance.Zauzimanje_collection)
                {
                    if (temp.Value.Status == Enumeration.Status.ZAUZIMANJE)
                    {
                        Teren teren = new Teren(null, null, null, false, null, -1, null);
                        Tim tim = new Tim(null, null, null, null);
                        Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(temp.Value.SifraTerena.ToString()), out teren);
                        Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(temp.Value.SifraTima.ToString()), out tim);
                        if (tim.Ime.Contains(param) || teren.Ime.Contains(param) || temp.Value.Status.ToString().Contains(param) || temp.Value.ZauzimanjeTerena.ToString().Contains(param) || temp.Value.OslobadanjeTerena.ToString().Contains(param) || temp.Value.Namena1.ToString().Contains(param) || temp.Value.Primedbe.ToString().Contains(param))
                        {
                            dgvZauzimanjeTerena.Rows.Add(temp.Key, tim.Ime, teren.Ime, temp.Value.Status, temp.Value.ZauzimanjeTerena, temp.Value.OslobadanjeTerena, temp.Value.Namena1, temp.Value.Primedbe);
                        }
                    }
                }
                dgvZauzimanjeTerena.ClearSelection();
                dgvZauzimanjeTerena.CurrentCell = null;
                lblValueOfRezultat.Text = dgvZauzimanjeTerena.Rows.Count.ToString();
            }

            if (cbOslobadanje.Checked == false && cbZauzimanje.Checked == false)
            {
                dgvZauzimanjeTerena.Rows.Clear();
                dgvZauzimanjeTerena.ClearSelection();
                dgvZauzimanjeTerena.CurrentCell = null;
                lblValueOfRezultat.Text = dgvZauzimanjeTerena.Rows.Count.ToString();
            }
        }

        private void cbOslobadanje_CheckedChanged(object sender, EventArgs e)
        {
            loadTableDataWithFilter(tbSearchText.Text.ToString());
        }

        private void cbZauzimanje_CheckedChanged(object sender, EventArgs e)
        {
            loadTableDataWithFilter(tbSearchText.Text.ToString());
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            loadTableDataWithFilter(tbSearchText.Text.ToString());
        }

        private void tbSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadTableDataWithFilter(tbSearchText.Text.ToString());
            }
        }

        private void btnPretraga_MouseEnter(object sender, EventArgs e)
        {
            btnPretraga.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnPretraga_MouseLeave(object sender, EventArgs e)
        {
            btnPretraga.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }
    }
}
