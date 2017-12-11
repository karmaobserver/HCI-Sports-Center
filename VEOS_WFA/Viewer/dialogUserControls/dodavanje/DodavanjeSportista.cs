using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.entity;
using VEOS_WFA.model.collection;

namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    public partial class DodavanjeSportista : Form
    {
        public DodavanjeSportista()
        {
            InitializeComponent();
            stanjeDijaloga = StanjeDijaloga.DODAVANJE;
        }

        enum StanjeDijaloga { DODAVANJE, IZMENA };
        StanjeDijaloga stanjeDijaloga;
        string toBeSelectedKlasa;
        string toBeSelectedSport;
        Guid trenutnaSifra;
        int timerCount = 0;

        public DodavanjeSportista(Guid sifra, string prezime, string ime, string jmbg, string klasa, string sport, string godinaUpisa, Image slika)
        {
            InitializeComponent();
            trenutnaSifra = sifra;
            tbPrezime.Text = prezime;
            tbIme.Text = ime;
            tbJmbg.Text = jmbg;
            toBeSelectedKlasa = klasa;
            toBeSelectedSport = sport;
            tbGodinaUpisa.Text = godinaUpisa;
            pbSlika.Image = slika;
            stanjeDijaloga = StanjeDijaloga.IZMENA;
        }

        private void clearForm()
        {
            tbGodinaUpisa.Text = "";
            tbIme.Text = "";
            tbJmbg.Text = "";
            cbKlasa.SelectedItem = null;
            tbPrezime.Text = "";
            pbSlika.Image = null;
            cmbSport.SelectedItem = null;
            tbPrezime.Focus();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        //********************************IZCRTAVANJE DUGMETA**********************************//
        private void btnPotvrda_MouseEnter(object sender, EventArgs e)
        {
            btnPotvrda.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover_dialog));
        }

        private void btnPotvrda_MouseLeave(object sender, EventArgs e)
        {
            btnPotvrda.BackgroundImage = null;
        }

        private void btnOdustanak_MouseEnter(object sender, EventArgs e)
        {
            btnOdustanak.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover_dialog));
        }

        private void btnOdustanak_MouseLeave(object sender, EventArgs e)
        {
            btnOdustanak.BackgroundImage = null;
        }
        //********************************IZCRTAVANJE DUGMETA**********************************//

        private void DodavanjeSportista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            DialogSportisti.getInstance.Back.Close();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            if (tbPrezime.Text == "" || tbJmbg.Text == "" || tbJmbg.Text.Length < 13 || tbIme.Text == "" || tbGodinaUpisa.Text == "" || tbGodinaUpisa.Text.Length < 4 || cmbSport.SelectedItem == null || cbKlasa.SelectedItem == null)
            {
                tbGodinaUpisa_Validated(sender, e);
                tbIme_Validated(sender, e);
                tbJmbg_Validated(sender, e);
                tbPrezime_Validated(sender, e);
                cmbSport_Validated(sender, e);
                cbKlasa_Validated(sender, e);
            }
            else
            {
                Sportista temp = new Sportista(null, null, null, null, Sportista.Klasa.Amater, null, null);
                temp.GodinaUpisa = tbGodinaUpisa.Text;
                temp.Image = pbSlika.Image;
                temp.Ime = tbIme.Text;
                temp.Jmbg = tbJmbg.Text;
                temp.Klasa1 = (Sportista.Klasa)cbKlasa.SelectedItem;
                temp.Prezime = tbPrezime.Text;
                temp.Sport = (Sport)cmbSport.SelectedItem;

                if (stanjeDijaloga == StanjeDijaloga.DODAVANJE)
                {
                    timer1.Start();
                    Sportiste_Collection.getInstance.addSportista(temp);
                    DialogSportisti.getInstance.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Sportista " + temp.Ime.ToString() + " " + temp.Prezime.ToString() + " je uspesno dodata!"; 
                    clearForm();
                }

                if (stanjeDijaloga == StanjeDijaloga.IZMENA)
                {
                    temp.Sifra = trenutnaSifra;
                    Sportiste_Collection.getInstance.modifySportista(temp);
                    DialogSportisti.getInstance.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Sportista " + temp.Ime.ToString() + " " + temp.Prezime.ToString() + " je uspesno izmenjena!";
                    clearForm();
                    DialogSportisti.getInstance.Back.Close();
                    this.Close();
                }
            }
        }

        private void DodavanjeSportista_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Guid, Sport> temp in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                cmbSport.Items.Add(temp.Value);
            }

            cbKlasa.Items.Add(Sportista.Klasa.Amater);
            cbKlasa.Items.Add(Sportista.Klasa.Poluprofesionalac);
            cbKlasa.Items.Add(Sportista.Klasa.Profesionalac);

            for (int i = 0; i < cbKlasa.Items.Count; i++)
            {
                if (cbKlasa.Items[i].ToString().Equals(toBeSelectedKlasa))
                {
                    cbKlasa.SelectedItem = cbKlasa.Items[i];
                }
            }

            for (int i = 0; i < cmbSport.Items.Count; i++)
            {
                if (cmbSport.Items[i].ToString().Equals(toBeSelectedSport))
                {
                    cmbSport.SelectedItem = cmbSport.Items[i];
                }
            }
        }

        private void tbPrezime_Validated(object sender, EventArgs e)
        {
            if (tbPrezime.Text == "")
            {
                error.SetError(tbPrezime, "Polje se obavezno popunjava");
            }
            else
            {
                error.SetError(tbPrezime, "");
            }
        }

        private void tbIme_Validated(object sender, EventArgs e)
        {
            if (tbIme.Text == "")
            {
                error.SetError(tbIme, "Polje se obavezno popunjava");
            }
            else
            {
                error.SetError(tbIme, "");
            }
        }

        private void tbJmbg_Validated(object sender, EventArgs e)
        {
            if (tbJmbg.Text == "" || tbJmbg.Text.Length <13)
            {
                if(tbJmbg.Text == "")
                    error.SetError(tbJmbg, "Polje se obavezno popunjava");
                if(tbJmbg.Text.Length <13)
                    error.SetError(tbJmbg, "Polje mora imati 13 cifara");
            }
            else
            {
                error.SetError(tbJmbg, "");
            }
        }

        private void cmbSport_Validated(object sender, EventArgs e)
        {
            if (cmbSport.SelectedItem == null)
            {
                error.SetError(cmbSport, "Odaberite jedan sport");
            }
            else
            {
                error.SetError(cmbSport, "");
            }
        }

        private void tbGodinaUpisa_Validated(object sender, EventArgs e)
        {
            if (tbGodinaUpisa.Text == "" || tbGodinaUpisa.Text.Length < 4)
            {
                if(tbGodinaUpisa.Text == "")
                    error.SetError(tbGodinaUpisa, "Polje se obavezno popunjava");
                if (tbGodinaUpisa.Text.Length < 4)
                    error.SetError(tbGodinaUpisa, "Polje mora imati 4 cifara");
            }
            else
            {
                error.SetError(tbGodinaUpisa, "");
            }
        }

        private void pbSlika_Validated(object sender, EventArgs e)
        {
            if (pbSlika.Image == null)
            {
                error.SetError(pbSlika, "Odaberite jednu sliku");
            }
            else
            {
                error.SetError(pbSlika, "");
            }
        }

        private void cbKlasa_Validated(object sender, EventArgs e)
        {
            if (cbKlasa.Text == "")
            {
                error.SetError(cbKlasa, "Odaberite jednu klasu");
            }
            else
            {
                error.SetError(cbKlasa, "");
            }
        }

        private void tbJmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != 0x6D))
            {
                e.Handled = true;
            }
        }

        private void tbGodinaUpisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != 0x6D))
            {
                e.Handled = true;
            }
        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {
            error.SetError(tbPrezime, "");
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            error.SetError(tbIme, "");
        }

        private void tbJmbg_TextChanged(object sender, EventArgs e)
        {
            if (tbJmbg.Text.Length < 13)
            {
                error.SetError(tbJmbg, "Polje mora imati 13 cifara");
            }
            else
            {
                error.SetError(tbJmbg, "");
            }
        }

        private void cbKlasa_SelectedValueChanged(object sender, EventArgs e)
        {
            error.SetError(cbKlasa, "");
        }

        private void cmbSport_SelectedValueChanged(object sender, EventArgs e)
        {
            error.SetError(cmbSport, "");
        }

        private void tbGodinaUpisa_TextChanged(object sender, EventArgs e)
        {
            if (tbGodinaUpisa.Text.Length < 4)
            {
                error.SetError(tbGodinaUpisa, "Polje mora imati 4 cifara");
            }
            else
            {
                error.SetError(tbGodinaUpisa, "");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Show();
                timerCount++;
            }
            else
            {
                panel2.Hide();
                timerCount++;
            }
            if (timerCount == 6)
            {
                timerCount = 0;
                timer1.Stop();
            }
        }

        private void cmbSport_MouseHover(object sender, EventArgs e)
        {
            if (cmbSport.Items.Count == 0)
            {
                toolTip1.Show("Nije unesen ni jedan sport, morate prvo uneti bar jedan sport", cmbSport);
            }
            else
            {
                toolTip1.Show("Izaberite jedan od ponuđenih sportova", cmbSport);
            }
        }

        
    }
}
