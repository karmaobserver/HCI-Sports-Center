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
    public partial class DodavanjeSportova : Form
    {
        public DodavanjeSportova()
        {
            InitializeComponent();
            stanjeDijaloga = StanjeDijaloga.DODAVANJE;
        }

        enum StanjeDijaloga { DODAVANJE, IZMENA };
        StanjeDijaloga stanjeDijaloga;
        Guid trenutnaSifra;
        int timerCount = 0;
        string trenutnoIme = "";

        public DodavanjeSportova(Guid sifra, string prefiks, string ime , string beleske)
        {
            trenutnoIme = ime;
            InitializeComponent();

            trenutnaSifra = sifra;
            tbPrefix.Text = prefiks;
            tbIme.Text = ime;
            tbBeleske.Text = beleske;
            stanjeDijaloga = StanjeDijaloga.IZMENA;
        }

        private void clearForm()
        {
            tbBeleske.Text = "";
            tbIme.Text = "";
            tbPrefix.Text = "";
            tbPrefix.Focus();
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
        //********************************IZCRTAVANJE DUGMETA**********************************//s

        private void DodavanjeSportova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            DialogSportovi.getInstace.Back.Close();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Sport> sport in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                if (sport.Value.ImeSporta.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same || tbIme.Text == "" || tbPrefix.Text == "")
            {
                tbIme_Validated(sender, e);
                tbPrefix_Validated(sender, e);
                tbPrefix.Focus();
            }
            else
            {
                Sport temp = new Sport(null, null, null);

                temp.BeleskeSporta = tbBeleske.Text;
                temp.ImeSporta = tbIme.Text;
                temp.PrefixSporta = tbPrefix.Text;

                if (stanjeDijaloga == StanjeDijaloga.DODAVANJE)
                {
                    timer1.Start();
                    Sportovi_Collection.getInstance.addSport(temp);
                    DialogSportovi.getInstace.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Sport " + temp.ImeSporta.ToString() + " je uspesno dodat!"; 
                    clearForm();
                }

                if (stanjeDijaloga == StanjeDijaloga.IZMENA)
                {
                    temp.Sifra = trenutnaSifra;
                    Sportovi_Collection.getInstance.modifySport(temp);

                    foreach (KeyValuePair<Guid, Sportista> sportista in Sportiste_Collection.getInstance.Sportiste_collection)
                    {
                        if (sportista.Value.Sport.Sifra.Equals(temp.Sifra))
                        {
                            Sportiste_Collection.getInstance.Sportiste_collection[sportista.Key].Sport = temp;
                        }
                    }

                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Sport.Sifra.Equals(temp.Sifra))
                        {
                            Timovi_Collection.getInstance.Timovi_collection[tim.Key].Sport = temp;
                        }
                    }

                    Guid selectedTeren = new Guid();
                    Guid selectedSport = new Guid();
                    foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                    {
                        foreach (KeyValuePair<Guid, Sport> sport in teren.Value.Sportovi)
                        {
                            if (sport.Key.Equals(temp.Sifra))
                            {
                                selectedTeren = teren.Key;
                                selectedSport = sport.Key;
                            }
                        }
                    }

                    if(selectedTeren != new Guid() && selectedSport != new Guid())
                        Tereni_Collection.getInstance.Teren_collection[selectedTeren].Sportovi[selectedSport] = temp;

                    DialogSportovi.getInstace.loadTableData(temp.Sifra.ToString());
                    lblStatus.Text = "Sport " + temp.ImeSporta.ToString() + " je uspesno izmenjen!";
                    clearForm();
                    DialogSportovi.getInstace.Back.Close();
                    this.Close();
                }
            }
        }

        private void tbPrefix_Validated(object sender, EventArgs e)
        {
            if (tbPrefix.Text == "")
            {
                error.SetError(tbPrefix, "Polje se obavezno popunjava");
            }
            else
            {
                error.SetError(tbPrefix, "");
            }
        }

        private void tbIme_Validated(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Sport> sport in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                if (sport.Value.ImeSporta.ToString().Equals(tbIme.Text.ToString()))
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
                error.SetError(tbIme, "Ovo ime sporta već postoji");
            }
            else
            {
                error.SetError(tbIme, "");
            }
        }

        private void tbPrefix_TextChanged(object sender, EventArgs e)
        {
            error.SetError(tbPrefix, "");
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            bool same = false;
            foreach (KeyValuePair<Guid, Sport> sport in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                if (sport.Value.ImeSporta.ToString().Equals(tbIme.Text.ToString()))
                {
                    if (!trenutnoIme.Equals(tbIme.Text))
                        same = true;
                }
            }

            if (same)
            {
                error.SetError(tbIme, "Ovo ime sporta već postoji");
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
    }
}
