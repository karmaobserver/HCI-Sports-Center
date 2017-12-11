using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.model.collection;
using VEOS_WFA.model.entity;
using VEOS_WFA.Viewer.dialogDetails;
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA.Viewer.dialogUserControls
{
    public partial class DialogTimovi : UserControl
    {
        public DialogTimovi()
        {
            InitializeComponent();
        }

        private static DialogTimovi instance;

        public static DialogTimovi getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogTimovi();
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

        public void loadTableData(string sifra)
        {
            dgvTimovi.Rows.Clear();
            foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
            {
                dgvTimovi.Rows.Add(temp.Key, temp.Value.Ime, temp.Value.BrSportista, temp.Value.Sport.ImeSporta, temp.Value.Kommentar);
            }
            dgvTimovi.ClearSelection();
            dgvTimovi.CurrentCell = null;

            if (sifra != "")
            {
                for (int i = 0; i < dgvTimovi.Rows.Count; i++)
                {
                    if (dgvTimovi.Rows[i].Cells[0].Value.ToString().Equals(sifra))
                    {
                        dgvTimovi.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void DialogTimovi_Load(object sender, EventArgs e)
        {
            loadTableData("");
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            DodavanjeTimova dodavanjeTimova = new DodavanjeTimova();
            back = new Background();
            back.Show();
            back.Location = location;
            dodavanjeTimova.ShowDialog(); 
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

        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                DialogTimoviDetails.getInstance.setLblValueOfIme(dgvTimovi.SelectedCells[1].Value.ToString());
                DialogTimoviDetails.getInstance.setLblValueOfBrSportista(dgvTimovi.SelectedCells[2].Value.ToString());
                DialogTimoviDetails.getInstance.setLblValueOfSport(dgvTimovi.SelectedCells[3].Value.ToString());
                DialogTimoviDetails.getInstance.setLblValueOfTbKomentar(dgvTimovi.SelectedCells[4].Value.ToString());

                Tim temp = new Tim(null, null, null, null);
                Timovi_Collection.getInstance.Timovi_collection.TryGetValue(new Guid(dgvTimovi.SelectedCells[0].Value.ToString()), out temp);

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

            List<string> sportiste = new List<string>();
            Guid trenutnaSifra = new Guid(dgvTimovi.SelectedCells[0].Value.ToString());
            System.Diagnostics.Debug.WriteLine("trenutna sifra>" + trenutnaSifra.ToString());
            foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (temp.Key.Equals(trenutnaSifra) && temp.Value.Sportiste != null)
                {
                    foreach (KeyValuePair<Guid, Sportista> sportista in temp.Value.Sportiste)
                    {
                        sportiste.Add(sportista.Value.Ime.ToString());
                    }
                }
            }

            DodavanjeTimova dodavanjeTimova = new DodavanjeTimova(new Guid(dgvTimovi.SelectedCells[0].Value.ToString()), dgvTimovi.SelectedCells[1].Value.ToString(), dgvTimovi.SelectedCells[3].Value.ToString(), sportiste, dgvTimovi.SelectedCells[4].Value.ToString());
            dodavanjeTimova.ShowDialog();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            back = new Background();
            back.Show();
            back.Location = location;
            DeleteWarning deleteWarning = new DeleteWarning("Da li ste sigurni da hoćete da obrišete " + dgvTimovi.SelectedCells[1].Value.ToString() + "?");
            if (deleteWarning.ShowDialog() == DialogResult.Yes)
            {
                Timovi_Collection.getInstance.Timovi_collection.Remove(new Guid(dgvTimovi.SelectedCells[0].Value.ToString()));
                loadTableData("");
                back.Close();
            }
            else
            {
                back.Close();
            }
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
                        if (ctrl.Name == "btnBrisanje" && dgvTimovi.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Tim mora prvo da oslobodi teren", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnBrisanje" && !(dgvTimovi.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki tim u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && dgvTimovi.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Tim mora prvo da oslobodi teren", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && !(dgvTimovi.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki tim u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
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
