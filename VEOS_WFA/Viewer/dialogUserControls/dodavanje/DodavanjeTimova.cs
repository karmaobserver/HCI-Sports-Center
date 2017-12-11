using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.collection;
using VEOS_WFA.model.entity;

namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    public partial class DodavanjeTimova : Form
    {
        public DodavanjeTimova()
        {
            InitializeComponent();
            stanjeDijaloga = StanjeDijaloga.DODAVANJE;
        }

        enum StanjeDijaloga { DODAVANJE, IZMENA };
        StanjeDijaloga stanjeDijaloga;
        string toBeSelectedSport;
        List<string> toBeSelectedSportisti;
        Guid trenutnaSifra;
        int timerCount = 0;
        string trenutnoIme = "";

        public DodavanjeTimova(Guid sifra, string ime, string sport, List<string> sportisti, string komentar)
        {
            trenutnoIme = ime;
            InitializeComponent();

            trenutnaSifra = sifra;
            tbIme.Text = ime;
            toBeSelectedSport = sport;
            toBeSelectedSportisti = sportisti;
            tbKomentar.Text = komentar;
            stanjeDijaloga = StanjeDijaloga.IZMENA;
        }

        private void clearForm()
        {
            tbIme.Text = "";
            for (int i = 0; i < cbSportisti.Items.Count; i++)
            {
                cbSportisti.Items.RemoveAt(i);
            }
            tbKomentar.Text = "";
            cbSportovi.SelectedItem = null;
            tbIme.Focus();
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

        private void DodavanjeTimova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            DialogTimovi.getInstance.Back.Close();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same || tbIme.Text == "" || cbSportovi.SelectedItem == null)
            {
                tbIme_Validated(sender, e);
                cbSportovi_Validated(sender, e);
                tbIme.Focus();
            }
            else
            {
                int brSportista = 0;
                Tim temp = new Tim(null, null, null, null);
                temp.Ime = tbIme.Text;
                Dictionary<Guid, Sportista> colTemp = new Dictionary<Guid, Sportista>();
                foreach (Sportista sportista in cbSportisti.CheckedItems)
                {
                    colTemp.Add(sportista.Sifra, sportista);
                    brSportista++;
                }
                temp.Sportiste = colTemp;
                temp.Kommentar = tbKomentar.Text;
                temp.BrSportista = brSportista; 
                temp.Sport = (Sport)cbSportovi.SelectedItem;

                if (stanjeDijaloga == StanjeDijaloga.DODAVANJE)
                {
                    timer1.Start();
                    Timovi_Collection.getInstance.addTim(temp);
                    DialogTimovi.getInstance.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Tim " + temp.Ime.ToString() + " je uspesno dodat!"; 
                    clearForm();
                }
                if (stanjeDijaloga == StanjeDijaloga.IZMENA)
                {
                    temp.Sifra = trenutnaSifra;
                    Timovi_Collection.getInstance.modifyTim(temp);
                    DialogTimovi.getInstance.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Tim " + temp.Ime.ToString() + " je uspesno izmenjen!";
                    clearForm();
                    DialogTimovi.getInstance.Back.Close();
                    this.Close();
                }
            }

        }

        private void DodavanjeTimova_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Guid, Sport> temp in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                cbSportovi.Items.Add(temp.Value);
            }

            if (stanjeDijaloga == StanjeDijaloga.IZMENA)
            {
                for (int i = 0; i < cbSportovi.Items.Count; i++)
                {
                    if (cbSportovi.Items[i].ToString().Equals(toBeSelectedSport))
                    {
                        cbSportovi.SelectedItem = cbSportovi.Items[i];
                    }
                   // if (cbSportovi.Items.Count == 0)
                  //  {
                       
                        toolTip1.SetToolTip(cbSportovi, "Ne postoje sportisti u sportu");
                        
                        toolTip1.ShowAlways.ToString();
                   // }
                   
                }

                for (int i = 0; i < cbSportisti.Items.Count; i++)
                {
                    for (int j = 0; j < toBeSelectedSportisti.Count; j++)
                    {
                        if (cbSportisti.Items[i].ToString().Equals(toBeSelectedSportisti[j].ToString()))
                        {
                            cbSportisti.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void cbSportovi_SelectedValueChanged(object sender, EventArgs e)
        {
            error.SetError(cbSportovi, "");

            if (cbSportovi.SelectedItem != null)
            {
                cbSportisti.ClearSelected();
                cbSportisti.Items.Clear();

                foreach (KeyValuePair<Guid, Sportista> temp in Sportiste_Collection.getInstance.Sportiste_collection)
                {
                    Sport sport = new Sport(null, null, null);
                    sport = (Sport)cbSportovi.SelectedItem;
                    if (temp.Value.Sport.Sifra.Equals(sport.Sifra))
                    {
                        cbSportisti.Items.Add(temp.Value);
                    }
                }

                if (stanjeDijaloga == StanjeDijaloga.IZMENA)
                {
                    Tim tim = new Tim(null, null, null, null);
                    Timovi_Collection.getInstance.Timovi_collection.TryGetValue(trenutnaSifra, out tim);
                    if (tim.Sportiste != null)
                    {
                        foreach (KeyValuePair<Guid, Sportista> temp in tim.Sportiste)
                        {
                            for (int i = 0; i < cbSportisti.Items.Count; i++)
                            {
                                System.Diagnostics.Debug.WriteLine(temp.ToString() + " VS " + cbSportisti.Items[i].ToString());
                                if (temp.Value.ToString().Equals(cbSportisti.Items[i].ToString()))
                                {
                                    cbSportisti.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cbSportovi_Validated(object sender, EventArgs e)
        {
            if (cbSportovi.SelectedItem == null)
            {
                error.SetError(cbSportovi, "Odaberite jednan sport");
            }
            else
            {
                error.SetError(cbSportovi, "");
            }
        }

        private void tbBrojSportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != 0x6D))
            {
                e.Handled = true;
            }
        }

        private void tbIme_Validated(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (tbIme.Text == "")
            {
                error.SetError(tbIme, "Polje se obavezno popunjava");
            }
            else if (same)
            {
                error.SetError(tbIme, "Ovo ime tima već postoji");
            }
            else
            {
                error.SetError(tbIme, "");
            }
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same)
            {
                error.SetError(tbIme, "Ovo ime tima već postoji");
            }
            else
            {
                error.SetError(tbIme, "");
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

        private void cbSportisti_MouseHover(object sender, EventArgs e)
        {
            if (cbSportovi.SelectedItem == null)
            {
                toolTip1.Hide(cbSportisti);
                toolTip2.Hide(cbSportisti);
                toolTip3.Show("Prvo izaberite sport", cbSportisti);
            }
            else

                if (cbSportisti.Items.Count == 0 && cbSportovi.SelectedItem != null)
                {
                    toolTip1.Show(cbSportovi.SelectedItem.ToString() + " ne sadrži sportiste", cbSportisti);
                    toolTip2.Hide(cbSportisti);
                    toolTip3.Hide(cbSportisti);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(cbSportovi.SelectedItem.ToString());
                    toolTip1.Hide(cbSportisti);
                    toolTip2.Show("Čekirajte sportiste", cbSportisti);
                    toolTip3.Hide(cbSportisti);
                }
        }

        private void cbSportisti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
