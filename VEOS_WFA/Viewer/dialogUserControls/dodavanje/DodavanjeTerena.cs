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
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    public partial class DodavanjeTerena : Form
    {
        public DodavanjeTerena()
        {
            InitializeComponent();
            stanjeDijaloga = StanjeDijaloga.DODAVANJE;
        }

        enum StanjeDijaloga { DODAVANJE, IZMENA };
        StanjeDijaloga stanjeDijaloga;
        string[] toBeSelectedSport;
        string toBeSelectedHala;
        Guid trenutnaSifra;
        string trenutnoIme = "";
        int timerCount = 0;

        public DodavanjeTerena(Guid sifra,string ime, string hala, string godOpr, string kapacitet, string[] sportovi,string status, string komentar)
        {
            trenutnoIme = ime;
            InitializeComponent();

            trenutnaSifra = sifra;
            tbIme.Text = ime;
            toBeSelectedHala = hala;
            tbGodOpr.Text = godOpr;
            tbKapacitet.Text = kapacitet;
            toBeSelectedSport = sportovi;
            tbKommentar.Text = komentar;
            if (status.Equals("Otvoren"))
            {
                rbOtvoren.Checked = true;
            }
            if (status.Equals("Zatvoren"))
            {
                rbZatvoren.Checked = true;
            }
            stanjeDijaloga = StanjeDijaloga.IZMENA;
        }

        private void clearForm()
        {
            tbGodOpr.Text = "";
            tbIme.Text = "";
            tbKapacitet.Text = "";
            tbKommentar.Text = "";
            cbLokacija.SelectedItem = null;
            for (int i = 0; i < cbSportovi.Items.Count; i++)
            {
                cbSportovi.SetItemChecked(i, false);
            }
            tbIme.Focus();
        }

        public void setDialogResult()
        {
            btnPotvrda.DialogResult = DialogResult.OK;
        }

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

        private void DodavanjeTerena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            DialogTereni.getInstance.Back.Close();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same || tbIme.Text == "" || cbLokacija.SelectedItem == null || tbGodOpr.Text == "" || tbGodOpr.Text.Length < 4 || tbKapacitet.Text == "" || cbSportovi.CheckedItems.Count == 0)
            {
                tbGodOpr_Validated(sender, e);
                tbIme_Validated(sender, e);
                tbKapacitet_Validated(sender, e);
                cbLokacija_Validated(sender, e);
                cbSportovi_Validated(sender, e);
                tbIme.Focus();
            }
            else
            {
                Teren temp = new Teren(null, null, null, false, null, -1, null);
                Dictionary<Guid, Sport> colTemp = new Dictionary<Guid, Sport>();
                foreach (Sport sport in cbSportovi.CheckedItems)
                {
                    colTemp.Add(sport.Sifra, sport);
                    System.Diagnostics.Debug.WriteLine("hozzaadtunk 1 et");
                }
                temp.GodinaOpremljenja = tbGodOpr.Text;
                temp.Ime = tbIme.Text;
                temp.Kapacitet = Convert.ToInt32(tbKapacitet.Text);
                temp.Kommentar = tbKommentar.Text;
                temp.Lokacija = (Hala)cbLokacija.SelectedItem;
                if (stanjeDijaloga == StanjeDijaloga.DODAVANJE)
                {
                    temp.Lokacija.BrTerena++;
                }
                temp.Sportovi = colTemp;
                if (rbOtvoren.Checked == true)
                {
                    temp.Otvoren = true;
                }
                if (rbZatvoren.Checked == true)
                {
                    temp.Otvoren = false;
                }

                if (temp.Lokacija.BrTerena > 12)
                {
                    Point location = new Point(Form1.getInstance.Location.X + 2, Form1.getInstance.Location.Y + 25);
                    Background back = Background.getInstance;
                    back.Location = location;
                    back.Show();
                    MaxTerenWarning mtw = new MaxTerenWarning(temp.Lokacija.ImeHale + " nema više mesta za novi teren. Odaberite drugu halu!");
                    if (mtw.ShowDialog() == DialogResult.OK)
                    {
                        back.Hide();
                    }
                }
                else
                {
                    if (stanjeDijaloga == StanjeDijaloga.DODAVANJE)
                    {
                        timer1.Start();
                        //Teren teren = new Teren(temp.Ime, temp.Lokacija, temp.GodinaOpremljenja, temp.Otvoren, temp.Sportovi, temp.Kapacitet, temp.Kommentar);
                        Tereni_Collection.getInstance.addTeren(temp);
                        //System.Diagnostics.Debug.WriteLine(temp.Sifra.ToString());
                        DialogTereni.getInstance.loadTableData(temp.Sifra.ToString());
                        //DialogTereni.getInstance.setSelectedLastElement(temp.Sifra.ToString());
                        lblStatus.Text = "Teren " + temp.Ime.ToString() + " je uspesno dodat!"; 
                        clearForm();
                    }
                    if (stanjeDijaloga == StanjeDijaloga.IZMENA)
                    {
                        temp.Sifra = trenutnaSifra;
                        Tereni_Collection.getInstance.modifyTeren(temp);
                        DialogTereni.getInstance.loadTableData(temp.Sifra.ToString());
                        lblStatus.Text = "Teren " + temp.Ime.ToString() + " je uspesno izmenjen!";
                        clearForm();
                        DialogTereni.getInstance.Back.Close();
                        this.Close();
                    }
                }
            }
        }

        private void DodavanjeTerena_Load(object sender, EventArgs e)
        {

            foreach (KeyValuePair<Guid, Sport> temp in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                cbSportovi.Items.Add(temp.Value);
            }

            foreach (KeyValuePair<Guid, Hala> temp in Hale_Collection.getInstance.Hale_collection)
            {
                cbLokacija.Items.Add(temp.Value);
            }


            if (stanjeDijaloga == StanjeDijaloga.IZMENA)
            {
                for (int i = 0; i < cbSportovi.Items.Count; i++)
                {
                    for (int j = 0; j < toBeSelectedSport.Length; j++)
                    {
                        if (cbSportovi.Items[i].ToString().Equals(toBeSelectedSport[j].ToString()))
                        {
                            cbSportovi.SetItemChecked(i, true);
                        }
                    }
                }

                for (int i = 0; i < cbLokacija.Items.Count; i++)
                {
                    if (cbLokacija.Items[i].ToString().Equals(toBeSelectedHala))
                    {
                        cbLokacija.SelectedItem = cbLokacija.Items[i];
                    }
                }
            }
        }

        private void tbIme_Validated(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if(!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (tbIme.Text == "")
            {
                error.SetError(tbIme, "Polje se obavezno popunjava");
            }
            else if (same)
            {
                error.SetError(tbIme, "Ovo ime terena već postoji");
            }
            else
            {
                error.SetError(tbIme, "");
            }
        }

        private void cbLokacija_Validated(object sender, EventArgs e)
        {
            if (cbLokacija.SelectedItem == null)
            {
                error.SetError(cbLokacija, "Odaberite jednu lokaciju");
            }
            else
            {
                error.SetError(cbLokacija, "");
            }
        }

        private void tbGodOpr_Validated(object sender, EventArgs e)
        {
            if (tbGodOpr.Text == "" || tbGodOpr.Text.Length < 4)
            {
                if(tbGodOpr.Text == "")
                    error.SetError(tbGodOpr, "Polje se obavezno popunjava");
                if (tbGodOpr.Text.Length < 4)
                    error.SetError(tbGodOpr, "Godina mora da ima 4 cifre");
            }
            else
            {
                error.SetError(tbGodOpr, "");
            }

        }

        private void tbKapacitet_Validated(object sender, EventArgs e)
        {
            if (tbKapacitet.Text == "")
            {
                error.SetError(tbKapacitet, "Polje se obavezno popunjava");
            }
            else
            {
                error.SetError(tbKapacitet, "");
            }
        }

        private void cbSportovi_Validated(object sender, EventArgs e)
        {
            if (cbSportovi.SelectedItems.Count == 0)
            {
                error.SetError(cbSportovi, "Odaberite bar jedan sport");
            }
            else
            {
                error.SetError(cbSportovi, "");
            }
        }

        private void tbGodOpr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != 0x6D))
            {
                e.Handled = true;
            }

        }

        private void tbKapacitet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != 0x6D))
            {
                e.Handled = true;
            }
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same)
            {
                error.SetError(tbIme, "Ovo ime terena već postoji");
            }
            else
            {
                error.SetError(tbIme, "");
            }
        }

        private void tbGodOpr_TextChanged(object sender, EventArgs e)
        {
            if (tbGodOpr.Text.Length < 4)
            {
                error.SetError(tbGodOpr, "Godina mora da ima 4 cifre");
            }
            else
            {
                error.SetError(tbGodOpr, "");
            }
        }

        private void tbKapacitet_TextChanged(object sender, EventArgs e)
        {
            error.SetError(tbKapacitet, "");
        }

        private void cbLokacija_SelectedValueChanged(object sender, EventArgs e)
        {
            error.SetError(cbLokacija, "");
        }

        private void cbSportovi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            error.SetError(cbSportovi, "");
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

        private void cbSportovi_MouseHover(object sender, EventArgs e)
        {
            if (cbSportovi.Items.Count == 0)
            {
                toolTip1.Show("Nije unesen ni jedan sport, morate prvo uneti bar jedan sport", cbSportovi);
            }
            else
            {
                toolTip1.Show("Čekirajte sportove", cbSportovi);
            }
        }

        private void cbSportovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
