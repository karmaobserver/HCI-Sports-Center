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
    public partial class DialogSportovi : UserControl
    {
        public DialogSportovi()
        {
            InitializeComponent();
        }

        private static DialogSportovi instance;

        public static DialogSportovi getInstace
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogSportovi();
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

        public bool checkToDelete(Guid param)
        {
            bool izlaz = true;
            foreach (KeyValuePair<Guid, Sportista> sportista in Sportiste_Collection.getInstance.Sportiste_collection)
            {
                if (sportista.Value.Sport.Sifra.Equals(param))
                {
                    izlaz = false;
                }
            }

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Sport.Sifra.Equals(param))
                {
                    izlaz = false;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                foreach (KeyValuePair<Guid, Sport> sport in teren.Value.Sportovi)
                {
                    if (sport.Key.Equals(param))
                    {
                        izlaz = false;
                    }
                }
            }

            return izlaz;
        }

        public void loadTableData(string sifra)
        {
            dgvSportovi.Rows.Clear();
            foreach (KeyValuePair<Guid, Sport> temp in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                dgvSportovi.Rows.Add(temp.Key, temp.Value.PrefixSporta, temp.Value.ImeSporta, temp.Value.BeleskeSporta);
            }
            dgvSportovi.ClearSelection();
            dgvSportovi.CurrentCell = null;

            if (sifra != "")
            {
                for (int i = 0; i < dgvSportovi.Rows.Count; i++)
                {
                    if (dgvSportovi.Rows[i].Cells[0].Value.ToString().Equals(sifra))
                    {
                        dgvSportovi.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void DialogSportovi_Load(object sender, EventArgs e)
        {
            loadTableData("");
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            DodavanjeSportova dodavanjeSportova = new DodavanjeSportova();
            back = new Background();
            back.Show();
            back.Location = location;
            dodavanjeSportova.ShowDialog();
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
            {
                btnIzmena.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            }
        }

        private void btnIzmena_MouseLeave(object sender, EventArgs e)
        {
            if (btnIzmena.Enabled == true)
            {
                btnIzmena.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            }
        }

        private void btnBrisanje_MouseEnter(object sender, EventArgs e)
        {
            if (btnBrisanje.Enabled == true)
            {
                btnBrisanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            }
        }

        private void btnBrisanje_MouseLeave(object sender, EventArgs e)
        {
            if (btnBrisanje.Enabled == true)
            {
                btnBrisanje.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            }
        }
        //***************************IZCRTAVANJE DUGMETA*******************////////////////

        private void dgvSportovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSportovi.SelectedRows.Count > 0)
            {
                DialogSportoviDetails.getInstance.setLblValueOfIme(dgvSportovi.SelectedCells[2].Value.ToString());
                DialogSportoviDetails.getInstance.setLblValueOfPrefiks(dgvSportovi.SelectedCells[1].Value.ToString());
                DialogSportoviDetails.getInstance.setTbBeleske(dgvSportovi.SelectedCells[3].Value.ToString());

               

                if (checkToDelete(new Guid(dgvSportovi.SelectedCells[0].Value.ToString())))
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

            DodavanjeSportova dodavanjeSportova = new DodavanjeSportova(new Guid(dgvSportovi.SelectedCells[0].Value.ToString()), dgvSportovi.SelectedCells[1].Value.ToString(), dgvSportovi.SelectedCells[2].Value.ToString(), dgvSportovi.SelectedCells[3].Value.ToString());
            dodavanjeSportova.ShowDialog();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            back = new Background();
            back.Show();
            back.Location = location;
            DeleteWarning deleteWarning = new DeleteWarning("Da li ste sigurni da hoćete da obrišete " + dgvSportovi.SelectedCells[2].Value.ToString() + "?");
            if (deleteWarning.ShowDialog() == DialogResult.Yes)
            {
                Sportovi_Collection.getInstance.Sportovi_collection.Remove(new Guid(dgvSportovi.SelectedCells[0].Value.ToString()));
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
                        if (ctrl.Name == "btnBrisanje" && dgvSportovi.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Sport ne sme biti korićen od strane terena, tima ili sportiste, da bi se moglo obrisati", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnBrisanje" && !(dgvSportovi.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki sport u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && dgvSportovi.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("Sport ne sme biti korićen od strane terena, tima ili sportiste, da bi se moglo izmeniti", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && !(dgvSportovi.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte neki sport u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
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
