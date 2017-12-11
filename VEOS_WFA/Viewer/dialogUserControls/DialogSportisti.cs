using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.dialogUserControls;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.model.collection;
using VEOS_WFA.model.entity;
using VEOS_WFA.Viewer.dialogDetails;
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA.Viewer.dialogUserControls
{
    public partial class DialogSportisti : UserControl
    {
        public DialogSportisti()
        {
            InitializeComponent();
        }

        private static DialogSportisti instance;

        public static DialogSportisti getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogSportisti();
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
            dgvSportisti.Rows.Clear();
            foreach (KeyValuePair<Guid, Sportista> temp in Sportiste_Collection.getInstance.Sportiste_collection)
            {
                dgvSportisti.Rows.Add(temp.Key, temp.Value.Prezime, temp.Value.Ime, temp.Value.Jmbg, temp.Value.Klasa1, temp.Value.Sport.ImeSporta, temp.Value.GodinaUpisa);
            }
            dgvSportisti.ClearSelection();
            dgvSportisti.CurrentCell = null;

            if (sifra != "")
            {
                for (int i = 0; i < dgvSportisti.Rows.Count; i++)
                {
                    if (dgvSportisti.Rows[i].Cells[0].Value.ToString().Equals(sifra))
                    {
                        dgvSportisti.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void DialogSportisti_Load(object sender, EventArgs e)
        {
            loadTableData("");
        }

        private void btnDodavanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            DodavanjeSportista dodavanjeSportista = new DodavanjeSportista();
            back = new Background();
            back.Show();
            back.Location = location;
            dodavanjeSportista.ShowDialog();
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

        private void dgvSportisti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSportisti.SelectedRows.Count > 0)
            {
                DialogSportistiDetails.getInstance.setLblValueOfPrezime(dgvSportisti.SelectedCells[1].Value.ToString());
                DialogSportistiDetails.getInstance.setLblValueOfIme(dgvSportisti.SelectedCells[2].Value.ToString());
                DialogSportistiDetails.getInstance.setLblValueOfJmbg(dgvSportisti.SelectedCells[3].Value.ToString());
                DialogSportistiDetails.getInstance.setLblValueOfKlasa(dgvSportisti.SelectedCells[4].Value.ToString());
                DialogSportistiDetails.getInstance.setLblValueOfSport(dgvSportisti.SelectedCells[5].Value.ToString());
                DialogSportistiDetails.getInstance.setLblValueOfGodinaUpisa(dgvSportisti.SelectedCells[6].Value.ToString());
                Sportista temp;
                Sportiste_Collection.getInstance.Sportiste_collection.TryGetValue(new Guid(dgvSportisti.SelectedCells[0].Value.ToString()), out temp);
               

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

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            back = new Background();
            back.Show();
            back.Location = location;

            Image image = new Bitmap(222, 121);
            Sportiste_Collection.getInstance.Sportiste_collection.ContainsKey(new Guid(dgvSportisti.SelectedCells[0].Value.ToString()));
            foreach (KeyValuePair<Guid, Sportista> sportista in Sportiste_Collection.getInstance.Sportiste_collection)
            {
                if (sportista.Key.Equals(new Guid(dgvSportisti.SelectedCells[0].Value.ToString())))
                {
                    if (sportista.Value.Image != null)
                    {
                        image = new Bitmap(sportista.Value.Image);
                    }
                }
            }
            
            DodavanjeSportista dodavanjeSportista = new DodavanjeSportista(new Guid(dgvSportisti.SelectedCells[0].Value.ToString()), dgvSportisti.SelectedCells[1].Value.ToString(), dgvSportisti.SelectedCells[2].Value.ToString(), dgvSportisti.SelectedCells[3].Value.ToString(), dgvSportisti.SelectedCells[4].Value.ToString(), dgvSportisti.SelectedCells[5].Value.ToString(), dgvSportisti.SelectedCells[6].Value.ToString(), image);
            dodavanjeSportista.ShowDialog();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            back = new Background();
            back.Show();
            back.Location = location;
            DeleteWarning deleteWarning = new DeleteWarning("Da li ste sigurni da hoćete da obrišete " + dgvSportisti.SelectedCells[2].Value.ToString() + " " + dgvSportisti.SelectedCells[1].Value.ToString() + "?");
            

            if (deleteWarning.ShowDialog() == DialogResult.Yes)
            {
                Sportiste_Collection.getInstance.Sportiste_collection.Remove(new Guid(dgvSportisti.SelectedCells[0].Value.ToString()));
                List<Guid> sportistiUTimu = new List<Guid>();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Sportiste != null)
                    {
                        foreach (KeyValuePair<Guid, Sportista> sportista in tim.Value.Sportiste)
                        {
                            if (dgvSportisti.SelectedCells[0].Value.ToString().Equals(sportista.Key.ToString()))
                            {
                                sportistiUTimu.Add(sportista.Key);
                            }
                        }
                        foreach (Guid temp in sportistiUTimu)
                        {
                            Timovi_Collection.getInstance.Timovi_collection[tim.Key].Sportiste.Remove(temp);
                        }
                    }
                }

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
                        if (ctrl.Name == "btnBrisanje" && dgvSportisti.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("123asdasd", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnBrisanje" && !(dgvSportisti.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte nekog sportistu u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && dgvSportisti.SelectedRows.Count > 0)
                        {
                            toolTip1.Show("", ctrl, ctrl.Width / 2, ctrl.Height / 2);
                            toolTip1.Tag = ctrl;
                            toolTipShown = true;
                        }
                        if (ctrl.Name == "btnIzmena" && !(dgvSportisti.SelectedRows.Count > 0))
                        {
                            toolTip1.Show("Prvo selektujte nekog sportistu u tabeli", ctrl, ctrl.Width / 2, ctrl.Height / 2);
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
