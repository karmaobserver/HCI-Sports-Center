using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.model.entity;
using VEOS_WFA.model.collection;
using VEOS_WFA.Viewer.dialogDetails;
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA.Viewer.dialogUserControls
{
    public partial class DialogTereni : UserControl
    {
        public DialogTereni()
        {
            InitializeComponent();
        }

        private static DialogTereni instance;

        public static DialogTereni getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogTereni();
                }
                return instance;
            }
        }

        Background back = new Background();

        public Background Back
        {
            get { return back; }
            set { back = value; }
        }

        public void setSelectedLastElement(string sifra)
        {
            
        }

        public void loadTableData(string sifra)
        {
            dgvTereni.Rows.Clear();
            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
            {
                string sportovi = "";
                string status = "";
                string sloZatv = "";
                foreach (KeyValuePair<Guid,Sport> sport in temp.Value.Sportovi)
                {
                    sportovi += sport.Value.ImeSporta + ", ";
                }
                sportovi= sportovi.Substring(0,sportovi.Length -2);
                if (temp.Value.Otvoren)
                {
                    status = "Otvoren";
                }
                else
                {
                    status = "Zatvoren";
                }
                if (temp.Value.Slobodan)
                {
                    sloZatv = "Slobodan";
                }
                else
                {
                    sloZatv = "Zatvoren";
                }
                dgvTereni.Rows.Add(temp.Key,temp.Value.Ime, temp.Value.Lokacija.ImeHale, temp.Value.GodinaOpremljenja, sportovi, temp.Value.Kapacitet, status, sloZatv, temp.Value.Kommentar);
            }

            dgvTereni.ClearSelection();
            dgvTereni.CurrentCell = null;

            if (sifra != "")
            {
                for (int i = 0; i < dgvTereni.Rows.Count; i++)
                {
                    if (dgvTereni.Rows[i].Cells[0].Value.ToString().Equals(sifra))
                    {
                        dgvTereni.Rows[i].Selected = true;
                    }
                }
            }
            
        }

        private void DialogTereni_Load(object sender, EventArgs e)
        {
            loadTableData("");
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X+2, ((Form1)activeForm).Location.Y+25);
            DodavanjeTerena dodavanjeTerena = new DodavanjeTerena();
            //Background back = Background.getInstance;
            back = new Background();
            back.Show();
            back.Location = location;
            dodavanjeTerena.ShowDialog();
        }



        //***************************IZCRTAVANJE DUGMETA*******************////////////////
        private void btnDodavanje_MouseEnter(object sender, EventArgs e)
        {
            btnDodavanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnDodavanje_MouseLeave(object sender, EventArgs e)
        {
            btnDodavanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }

        private void btnIzmena_MouseEnter(object sender, EventArgs e)
        {
            if (btnIzmena.Enabled == true)
                btnIzmena.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnIzmena_MouseLeave(object sender, EventArgs e)
        {
            if (btnIzmena.Enabled == true)
                btnIzmena.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }

        private void btnBrisanje_MouseEnter(object sender, EventArgs e)
        {
            if (btnBrisanje.Enabled == true)
                btnBrisanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnBrisanje_MouseLeave(object sender, EventArgs e)
        {
            if(btnBrisanje.Enabled == true)
                btnBrisanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }
        //***************************IZCRTAVANJE DUGMETA*******************////////////////

        private void dgvTereni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTereni.SelectedRows.Count > 0)
            {
                DialogTereniDetails.getInstance.setLblValueOfIme(dgvTereni.SelectedCells[1].Value.ToString());
                DialogTereniDetails.getInstance.setLblValueOfLokacija(dgvTereni.SelectedCells[2].Value.ToString());
                DialogTereniDetails.getInstance.setLblValueOfGodinaOpremljenja(dgvTereni.SelectedCells[3].Value.ToString());
                DialogTereniDetails.getInstance.setLblValueOfSportovi(dgvTereni.SelectedCells[4].Value.ToString());
                DialogTereniDetails.getInstance.setLblValueOfKapacitet(dgvTereni.SelectedCells[5].Value.ToString());

                DialogTereniDetails.getInstance.setLblValueOfStatus(dgvTereni.SelectedCells[6].Value.ToString());


                Teren temp = new Teren(null, null, null, false, null, -1, null);
                Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(dgvTereni.SelectedCells[0].Value.ToString()), out temp);
                if (temp.Slobodan)
                {
                    btnBrisanje.Enabled = true;
                    btnBrisanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
                    btnIzmena.Enabled = true;
                    btnIzmena.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
                }
                else
                {
                    btnBrisanje.Enabled = false;
                    btnBrisanje.BackgroundImage = null;
                    btnIzmena.Enabled = false;
                    btnIzmena.BackgroundImage = null;
                }
            }
            else
            {
                btnBrisanje.Enabled = false;
                btnBrisanje.BackgroundImage = null;
                btnIzmena.Enabled = false;
                btnIzmena.BackgroundImage = null;
            }
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            back = new Background();
            back.Show();
            back.Location = location;

            string temp = dgvTereni.SelectedCells[4].Value.ToString();
            string[] sportovi = temp.Split(',');
            for (int i = 0; i < sportovi.Length; i++)
            {   
                if (sportovi[i].StartsWith(" "))
                {
                    sportovi[i] = sportovi[i].Substring(1, sportovi[i].Length - 1);
                }
                System.Diagnostics.Debug.WriteLine(sportovi[i]);
            }
            DodavanjeTerena dodavanjeTerena = new DodavanjeTerena(new Guid(dgvTereni.SelectedCells[0].Value.ToString()), dgvTereni.SelectedCells[1].Value.ToString(), dgvTereni.SelectedCells[2].Value.ToString(), dgvTereni.SelectedCells[3].Value.ToString(), dgvTereni.SelectedCells[5].Value.ToString(), sportovi, dgvTereni.SelectedCells[6].Value.ToString(), dgvTereni.SelectedCells[7].Value.ToString());
            dodavanjeTerena.ShowDialog();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            bool brisanje = true;
            Teren trenutniTeren = new Teren(null, null, null, false, null, -1, null);

            Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(dgvTereni.SelectedCells[0].Value.ToString()), out trenutniTeren);

            foreach (KeyValuePair<Guid, Hala> hala in Hale_Collection.getInstance.Hale_collection)
            {
                
                if (hala.Value.ImeHale.ToString().Equals(trenutniTeren.Lokacija.ImeHale.ToString()))
                {
                    System.Diagnostics.Debug.WriteLine(hala.Value.BrTerena);
                    if (hala.Value.BrTerena < 2)
                    {
                        brisanje = false;
                    }
                }
            }

            if (brisanje)
            {
                Control activeForm = this.FindForm();
                Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
                back = new Background();
                back.Show();
                back.Location = location;
                DeleteWarning deleteWarning = new DeleteWarning("Da li ste sigurni da hoćete da obrišete " + dgvTereni.SelectedCells[1].Value.ToString() + "?");
                if (deleteWarning.ShowDialog() == DialogResult.Yes)
                {
                    Guid trenutnaHala = new Guid();
                    foreach (KeyValuePair<Guid, Hala> hala in Hale_Collection.getInstance.Hale_collection)
                    {
                        if (hala.Value.ImeHale.ToString().Equals(dgvTereni.SelectedCells[2].Value.ToString()))
                        {
                            trenutnaHala = hala.Key;
                        }
                    }

                    Hale_Collection.getInstance.Hale_collection[trenutnaHala].BrTerena--;

                    Tereni_Collection.getInstance.Teren_collection.Remove(new Guid(dgvTereni.SelectedCells[0].Value.ToString()));
                    loadTableData("");
                    back.Close();
                }
                else
                {
                    back.Close();
                }
            }
            else
            {
                Point location = new Point(Form1.getInstance.Location.X + 2, Form1.getInstance.Location.Y + 25);
                Background back = new Background();
                back.Location = location;
                back.Show();
                MaxTerenWarning mtw = new MaxTerenWarning(dgvTereni.SelectedCells[1].Value.ToString() + " je poslednji teren u hali" + dgvTereni.SelectedCells[2].Value.ToString() + " !");
                if (mtw.ShowDialog() == DialogResult.OK)
                {
                    back.Hide();
                }
            }
            brisanje = true;
        }





        bool toolTipShown = false;
        private void panelButtons_MouseMove(object sender, MouseEventArgs e)
        {
            var parent = sender as Control;
            if (parent == null)
            {
                return;
            }

            var ctrl = parent.GetChildAtPoint(e.Location);

            if (ctrl != null)
            {
                if (ctrl.Visible && toolTip1.Tag == null && !ctrl.Enabled)
                {
                    if (!toolTipShown)
                    {
                        if (ctrl.Name == "btnBrisanje" && dgvTereni.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Teren mora prvo da se oslobodi", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnBrisanje" && !(dgvTereni.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki teren u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && dgvTereni.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Teren mora prvo da se oslobodi", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && !(dgvTereni.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki teren u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                    }
                }
            }
            else
            {
                ctrl = toolTip1.Tag as Control;
                if (ctrl != null)
                {
                    toolTip1.Hide(ctrl);
                    toolTip1.Tag = null;
                    toolTipShown = false;
                }
            }
        }
    }
}
