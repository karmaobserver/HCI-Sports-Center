using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.model.collection;
using VEOS_WFA.model.entity;
using VEOS_WFA.Viewer.dialogUserControls;
using VEOS_WFA.model;
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA.Viewer
{
    public partial class DialogZauzimanjaTerena : Form
    {
        public DialogZauzimanjaTerena()
        {
            InitializeComponent();
        }

        public Enumeration.Status status;

        bool isCorrect = false;

        public bool IsCorrect
        {
            get { return isCorrect; }
            set { isCorrect = value; }
        }

        Guid trenutnaSifraTima;
        Guid trenutnaSifraTerena;
        string trenutnoImeTerena;
        string trenutnoImeTima;

        public DialogZauzimanjaTerena(Guid sifraTima, Guid sifraTerena, Enumeration.Status paramStatus)
        {
            InitializeComponent();
            tbSifraTima.Text = sifraTima.ToString();
            trenutnaSifraTima = sifraTima;
            tbSifraTerena.Text = sifraTerena.ToString();
            trenutnaSifraTerena = sifraTerena;
            status = paramStatus;
        }

        private bool checkSportOfTerenAndTim()
        {
            List<Guid> terenSportovi = new List<Guid>();
            bool izlaz = false;
            Teren teren = new Teren(null, null, null, false, null, -1, null);
            Tereni_Collection.getInstance.Teren_collection.TryGetValue(trenutnaSifraTerena, out teren);
            trenutnoImeTerena = teren.Ime;
            Tim tim = new Tim(null, null, null, null);
            Timovi_Collection.getInstance.Timovi_collection.TryGetValue(trenutnaSifraTima, out tim);
            trenutnoImeTima = tim.Ime;

            foreach (KeyValuePair<Guid, Sport> temp in teren.Sportovi)
            {
                if (temp.Key.Equals(tim.Sport.Sifra))
                {
                    izlaz = true;
                    break;
                }
            }
            return izlaz;
        }

        private bool checkKapacitetTerenAndTim()
        {
            bool izlaz = false;
            Teren teren = new Teren(null, null, null, false, null, -1, null);
            Tereni_Collection.getInstance.Teren_collection.TryGetValue(trenutnaSifraTerena, out teren);
            Tim tim = new Tim(null, null, null, null);
            Timovi_Collection.getInstance.Timovi_collection.TryGetValue(trenutnaSifraTima, out tim);
            if (tim.BrSportista <= teren.Kapacitet)
            {
                izlaz = true;
            }
            return izlaz;
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            if (cbNamena.SelectedItem == null)
            {
                cbNamena_Validated(sender, e);
                cbNamena.Focus();
                isCorrect = false;
            }
            else
            {
                if (!checkSportOfTerenAndTim())
                {
                        Point location = new Point(Form1.getInstance.Location.X + 2, Form1.getInstance.Location.Y + 25);
                        Background back = new Background();
                        back.Location = location;
                        back.Show();
                        MaxTerenWarning mtw = new MaxTerenWarning(trenutnoImeTerena + " ne podrzava sport koji igra " + trenutnoImeTima + " !");
                        if (mtw.ShowDialog() == DialogResult.OK)
                        {
                            back.Hide();
                        }
                }
                else
                {
                    Zauzimanje temp = new Zauzimanje(new Guid(tbSifraTima.Text), new Guid(tbSifraTerena.Text), dtpZauzimanjeTerena.Value.Date, dtpOslobadanjeTerena.Value.Date, Zauzimanje.Namena.Drugo, null, status);
                    temp.Namena1 = (Zauzimanje.Namena)cbNamena.SelectedItem;
                    temp.Primedbe = tbPrimedbe.Text;

                    if (status == Enumeration.Status.OSLOBADJANJE)
                    {
                        Teren teren = new Teren(null, null, null, false, null, -1, null);
                        Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(tbSifraTerena.Text), out teren);
                        Tim tim = new Tim(null, null, null, null);
                        Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(tbSifraTima.Text), out tim);
                        Form1.getInstance.setLblStatusBar(teren.Ime + " je oslobođen od tima " + tim.Ime + "!");
                    }
                    if (status == Enumeration.Status.ZAUZIMANJE)
                    {
                        Teren teren = new Teren(null, null, null, false, null, -1, null);
                        Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(tbSifraTerena.Text), out teren);
                        Tim tim = new Tim(null, null, null, null);
                        Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(tbSifraTima.Text), out tim);
                        Form1.getInstance.setLblStatusBar(tim.Ime + " je zauzeo teren " + teren.Ime + "!");
                    }

                    Zauzimanje_Collection.getInstance.addZauzimanje(temp);
                    ZauzimanjeTerena.getInstance.loadTableData("");
                    Background.getInstance.Visible = false;
                    isCorrect = true;
                    this.Close();
                }
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

        private void DialogZauzimanjaTerena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnOdustanak_Click(object sender, EventArgs e)
        {
            Background.getInstance.Visible = false;
        }

        private void cbNamena_Validated(object sender, EventArgs e)
        {
            if (cbNamena.SelectedItem == null)
            {
                error.SetError(cbNamena, "Odaberite namenu!");
            }
            else
            {
                error.SetError(cbNamena, "");
            }
        }

        private void DialogZauzimanjaTerena_Load(object sender, EventArgs e)
        {
            dtpZauzimanjeTerena.Enabled = true;
            cbNamena.Enabled = true;
            cbNamena.Items.Add(Zauzimanje.Namena.Drugo);
            cbNamena.Items.Add(Zauzimanje.Namena.Mec);
            cbNamena.Items.Add(Zauzimanje.Namena.Trening);
            cbNamena.Items.Add(Zauzimanje.Namena.Turnir);
            if (status == Enumeration.Status.OSLOBADJANJE)
            {
                dtpZauzimanjeTerena.Enabled = false;
                cbNamena.Enabled = false;
                foreach (KeyValuePair<Guid, Zauzimanje> temp in Zauzimanje_Collection.getInstance.Zauzimanje_collection)
                {
                    if (tbSifraTerena.Text.Equals(temp.Value.SifraTerena.ToString()) && tbSifraTima.Text.Equals(temp.Value.SifraTima.ToString()))
                    {
                        cbNamena.SelectedItem = temp.Value.Namena1;
                        tbPrimedbe.Text = temp.Value.Primedbe;
                    }
                }
            }
        }

        private void panel1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (status == Enumeration.Status.ZAUZIMANJE)
            {
                System.Diagnostics.Debug.WriteLine("ZAUZIMANJE");
                Help.ShowHelp(this, "..\\..\\help\\help.chm", HelpNavigator.KeywordIndex, "Zauzimanje terena");
            }
            if (status == Enumeration.Status.OSLOBADJANJE)
            {
                System.Diagnostics.Debug.WriteLine("OSLOBADJANJE");
                Help.ShowHelp(this, "..\\..\\help\\help.chm", HelpNavigator.KeywordIndex, "Oslobadjanje terena");
            }
        }
    }
}
