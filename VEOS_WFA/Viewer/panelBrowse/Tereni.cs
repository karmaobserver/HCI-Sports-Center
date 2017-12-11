using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer;
using VEOS_WFA.model.entity;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.model.collection;
using VEOS_WFA.model;

namespace VEOS_WFA
{
    public partial class Tereni : UserControl
    {
        private bool[] panelStatus = new bool[12];

        private bool[] panelToBeShowBySearch = new bool[12];

        public bool[] PanelToBeShowBySearch
        {
            get { return panelToBeShowBySearch; }
            set { panelToBeShowBySearch = value; }
        }

        private void setDefaultBool()
        {
            for (int i = 0; i < panelToBeShowBySearch.Length; i++)
            {
                panelToBeShowBySearch[i] = false;
            }
        }

        private string[] imenaTerena = new string[12];

        public string[] ImenaTerena
        {
            get { return imenaTerena; }
            set { imenaTerena = value; }
        }

        private void setDefaultImenaTerena()
        {
            for (int i = 0; i < imenaTerena.Length; i++)
            {
                imenaTerena[i] = "";
            }
        }

        private int positionOfLinkedLabel;

        public int PositionOfLinkedLabel
        {
            get { return positionOfLinkedLabel; }
            set { positionOfLinkedLabel = value; }
        }

        private bool[] dragNDropped = new bool[12];

        private void setdragNDroppedFalse()
        {
            for (int i = 0; i < dragNDropped.Length; i++)
            {
                dragNDropped[i] = false;
            }
        }


        private int brTerena;


        public int BrTerena
        {
            get { return brTerena; }
            set { brTerena = value; }
        }

        private string imeTerena;

        public string ImeTerena
        {
            get { return imeTerena; }
            set { imeTerena = value; }
        }

        private string sifraTerena;

        public string SifraTerena
        {
            get { return sifraTerena; }
            set { sifraTerena = value; }
        }

  
        public Tereni()
        {
            InitializeComponent();
            setdragNDroppedFalse();
            setDefaultBool();
            setDefaultImenaTerena();
        }

        DialogZauzimanjaTerena dialogZauzimanjaTerena = new DialogZauzimanjaTerena();/*new DialogZauzimanjaTerena(new Guid(), new Guid());*/
        private void dimTheBackground()
        {
            Control activeForm = this.FindForm();
            Point location = new Point(((Form1)activeForm).Location.X + 2, ((Form1)activeForm).Location.Y + 25);
            Background.getInstance.Show();
            Background.getInstance.Location = location;
            //dialogZauzimanjaTerena.ShowDialog();
        }

        public void setTereniText(List<string> tereniIme, List<string> tereniSifra)
        {
            int i = 1;
            int j = 1;
            foreach (string ime in tereniIme)
            {
                switch (i)
                {
                    case 1: lblValueOfName1.Text = ime; imenaTerena[0] = ime; break;
                    case 2: lblValueOfName2.Text = ime; imenaTerena[1] = ime; break;
                    case 3: lblValueOfName3.Text = ime; imenaTerena[2] = ime; break;
                    case 4: lblValueOfName4.Text = ime; imenaTerena[3] = ime; break;
                    case 5: lblValueOfName5.Text = ime; imenaTerena[4] = ime; break;
                    case 6: lblValueOfName6.Text = ime; imenaTerena[5] = ime; break;
                    case 7: lblValueOfName7.Text = ime; imenaTerena[6] = ime; break;
                    case 8: lblValueOfName8.Text = ime; imenaTerena[7] = ime; break;
                    case 9: lblValueOfName9.Text = ime; imenaTerena[8] = ime; break;
                    case 10: lblValueOfName10.Text = ime; imenaTerena[9] = ime; break;
                    case 11: lblValueOfName11.Text = ime; imenaTerena[10] = ime; break;
                    case 12: lblValueOfName12.Text = ime; imenaTerena[11] = ime; break;
                }
                i++;
            }

            foreach (string sifra in tereniSifra)
            {
                switch (j)
                {
                    case 1: panelTeren1.Tag = sifra; break;
                    case 2: panelTeren2.Tag = sifra; break;
                    case 3: panelTeren3.Tag = sifra; break;
                    case 4: panelTeren4.Tag = sifra; break;
                    case 5: panelTeren5.Tag = sifra; break;
                    case 6: panelTeren6.Tag = sifra; break;
                    case 7: panelTeren7.Tag = sifra; break;
                    case 8: panelTeren8.Tag = sifra; break;
                    case 9: panelTeren9.Tag = sifra; break;
                    case 10: panelTeren10.Tag = sifra; break;
                    case 11: panelTeren11.Tag = sifra; break;
                    case 12: panelTeren12.Tag = sifra; break;
                }
                j++;
            }
        }

        public void setTereniTextToDefault()
        {
            lblOtvZatv1.Text = ""; panelTeren1.Tag = ""; lblValueOfName1.Text = ""; lblValueOfStatus1.Text = ""; lblValueOfTim1.Text = ""; panelStatus[0] = false;
            lblOtvZatv2.Text = ""; panelTeren2.Tag = ""; lblValueOfName2.Text = ""; lblValueOfStatus2.Text = ""; lblValueOfTim2.Text = ""; panelStatus[1] = false;
            lblOtvZatv3.Text = ""; panelTeren3.Tag = ""; lblValueOfName3.Text = ""; lblValueOfStatus3.Text = ""; lblValueOfTim3.Text = ""; panelStatus[2] = false;
            lblOtvZatv4.Text = ""; panelTeren4.Tag = ""; lblValueOfName4.Text = ""; lblValueOfStatus4.Text = ""; lblValueOfTim4.Text = ""; panelStatus[3] = false;
            lblOtvZatv5.Text = ""; panelTeren5.Tag = ""; lblValueOfName5.Text = ""; lblValueOfStatus5.Text = ""; lblValueOfTim5.Text = ""; panelStatus[4] = false;
            lblOtvZatv6.Text = ""; panelTeren6.Tag = ""; lblValueOfName6.Text = ""; lblValueOfStatus6.Text = ""; lblValueOfTim6.Text = ""; panelStatus[5] = false;
            lblOtvZatv7.Text = ""; panelTeren7.Tag = ""; lblValueOfName7.Text = ""; lblValueOfStatus7.Text = ""; lblValueOfTim7.Text = ""; panelStatus[6] = false;
            lblOtvZatv8.Text = ""; panelTeren8.Tag = ""; lblValueOfName8.Text = ""; lblValueOfStatus8.Text = ""; lblValueOfTim8.Text = ""; panelStatus[7] = false;
            lblOtvZatv9.Text = ""; panelTeren9.Tag = ""; lblValueOfName9.Text = ""; lblValueOfStatus9.Text = ""; lblValueOfTim9.Text = ""; panelStatus[8] = false;
            lblOtvZatv10.Text = ""; panelTeren10.Tag = ""; lblValueOfName10.Text = ""; lblValueOfStatus10.Text = ""; lblValueOfTim10.Text = ""; panelStatus[9] = false;
            lblOtvZatv11.Text = ""; panelTeren11.Tag = ""; lblValueOfName11.Text = ""; lblValueOfStatus11.Text = ""; lblValueOfTim11.Text = ""; panelStatus[10] = false;
            lblOtvZatv12.Text = ""; panelTeren12.Tag = ""; lblValueOfName12.Text = ""; lblValueOfStatus12.Text = ""; lblValueOfTim12.Text = ""; panelStatus[11] = false;
        }

        public void changeTereniPanelVisibleTrue()
        {
            for (int i = 12; i >= 1/*brTerena*/; i--)
            {
                switch (i)
                {
                    case 1:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName1.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv1.Text = "Otvoren";
                                        panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv1.Text = "Zatvoren";
                                        panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus1.Text = "Slobodan";
                                        dragNDropped[0] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus1.Text = "Zauzet";
                                        lblValueOfTim1.Text = temp.Value.TrenutniTim;
                                        panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose1.Show();
                                        dragNDropped[0] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren1.Visible = false;
                            }
                            else
                            {
                                panelTeren1.Visible = true;
                            }
                            break;
                        }
                    case 2:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName2.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv2.Text = "Otvoren";
                                        panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv2.Text = "Zatvoren";
                                        panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus2.Text = "Slobodan";
                                        dragNDropped[1] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus2.Text = "Zauzet";
                                        lblValueOfTim2.Text = temp.Value.TrenutniTim;
                                        panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose2.Show();
                                        dragNDropped[1] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren2.Visible = false;
                            }
                            else
                            {
                                panelTeren2.Visible = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName3.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv3.Text = "Otvoren";
                                        panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                        
                                    }
                                    else
                                    {
                                        lblOtvZatv3.Text = "Zatvoren";
                                        panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus3.Text = "Slobodan";
                                        dragNDropped[2] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus3.Text = "Zauzet";
                                        lblValueOfTim3.Text = temp.Value.TrenutniTim;
                                        panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose3.Show();
                                        dragNDropped[2] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren3.Visible = false;
                            }
                            else
                            {
                                panelTeren3.Visible = true;
                            }
                            break;
                        }
                    case 4:
                        {
                            System.Diagnostics.Debug.WriteLine("CASE4");
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName4.Text))
                                {
                                    System.Diagnostics.Debug.WriteLine("4 es a nevek megegyeztek");
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv4.Text = "Otvoren";
                                        panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv4.Text = "Zatvoren";
                                        panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus4.Text = "Slobodan";
                                        dragNDropped[3] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus4.Text = "Zauzet";
                                        lblValueOfTim4.Text = temp.Value.TrenutniTim;
                                        panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose4.Show();
                                        dragNDropped[3] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren4.Visible = false;
                            }
                            else
                            {
                                panelTeren4.Visible = true;
                            }
                            break;
                        }
                    case 5:
                        {
                            
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName5.Text))
                                {
                                    System.Diagnostics.Debug.WriteLine("5 es a nevek megegyeztek");
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        System.Diagnostics.Debug.WriteLine("5 os A TEREN OTVOREN");
                                        lblOtvZatv5.Text = "Otvoren";
                                        panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv5.Text = "Zatvoren";
                                        panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus5.Text = "Slobodan";
                                        dragNDropped[4] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus5.Text = "Zauzet";
                                        lblValueOfTim5.Text = temp.Value.TrenutniTim;
                                        panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose5.Show();
                                        dragNDropped[4] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren5.Visible = false;
                            }
                            else
                            {
                                panelTeren5.Visible = true;
                            }
                            break;
                        }
                    case 6:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName6.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv6.Text = "Otvoren";
                                        panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv6.Text = "Zatvoren";
                                        panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus6.Text = "Slobodan";
                                        dragNDropped[5] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus6.Text = "Zauzet";
                                        lblValueOfTim6.Text = temp.Value.TrenutniTim;
                                        panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose6.Show();
                                        dragNDropped[5] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren6.Visible = false;
                            }
                            else
                            {
                                panelTeren6.Visible = true;
                            }
                            break;
                        }
                    case 7: 
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName7.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv7.Text = "Otvoren";
                                        panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv7.Text = "Zatvoren";
                                        panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus7.Text = "Slobodan";
                                        dragNDropped[6] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus7.Text = "Zauzet";
                                        lblValueOfTim7.Text = temp.Value.TrenutniTim;
                                        panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose7.Show();
                                        dragNDropped[6] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren7.Visible = false;
                            }
                            else
                            {
                                panelTeren7.Visible = true;
                            }
                            break;
                        }
                    case 8:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName8.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv8.Text = "Otvoren";
                                        panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv8.Text = "Zatvoren";
                                        panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus8.Text = "Slobodan";
                                        dragNDropped[7] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus8.Text = "Zauzet";
                                        lblValueOfTim8.Text = temp.Value.TrenutniTim;
                                        panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose8.Show();
                                        dragNDropped[7] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren8.Visible = false;
                            }
                            else
                            {
                                panelTeren8.Visible = true;
                            }
                            break;
                        }
                    case 9:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName9.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv9.Text = "Otvoren";
                                        panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv9.Text = "Zatvoren";
                                        panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus9.Text = "Slobodan";
                                        dragNDropped[8] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus9.Text = "Zauzet";
                                        lblValueOfTim9.Text = temp.Value.TrenutniTim;
                                        panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose9.Show();
                                        dragNDropped[8] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren9.Visible = false;
                            }
                            else
                            {
                                panelTeren9.Visible = true;
                            }
                            break;
                        }
                    case 10:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName10.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv10.Text = "Otvoren";
                                        panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv10.Text = "Zatvoren";
                                        panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus10.Text = "Slobodan";
                                        dragNDropped[9] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus10.Text = "Zauzet";
                                        lblValueOfTim10.Text = temp.Value.TrenutniTim;
                                        panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose10.Show();
                                        dragNDropped[9] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren10.Visible = false;
                            }
                            else
                            {
                                panelTeren10.Visible = true;
                            }
                            break;
                        }
                    case 11:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName11.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv11.Text = "Otvoren";
                                        panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv11.Text = "Zatvoren";
                                        panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus11.Text = "Slobodan";
                                        dragNDropped[10] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus11.Text = "Zauzet";
                                        lblValueOfTim11.Text = temp.Value.TrenutniTim;
                                        panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose11.Show();
                                        dragNDropped[10] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren11.Visible = false;
                            }
                            else
                            {
                                panelTeren11.Visible = true;
                            }
                            break;
                        }
                    case 12:
                        {
                            bool matched = false;
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (temp.Value.Ime.ToString().Equals(lblValueOfName12.Text))
                                {
                                    matched = true;
                                    if (temp.Value.Otvoren)
                                    {
                                        lblOtvZatv12.Text = "Otvoren";
                                        panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                                        panelStatus[i - 1] = true;
                                    }
                                    else
                                    {
                                        lblOtvZatv12.Text = "Zatvoren";
                                        panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));
                                        panelStatus[i - 1] = false;
                                    }
                                    if (temp.Value.Slobodan)
                                    {
                                        lblValueOfStatus12.Text = "Slobodan";
                                        dragNDropped[11] = false;
                                    }
                                    else
                                    {
                                        lblValueOfStatus12.Text = "Zauzet";
                                        lblValueOfTim12.Text = temp.Value.TrenutniTim;
                                        panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                                        pbClose12.Show();
                                        dragNDropped[11] = true;
                                    }
                                }
                            }
                            if (matched == false)
                            {
                                panelTeren12.Visible = false;
                            }
                            else
                            {
                                panelTeren12.Visible = true;
                            }
                            break;
                        }
                }
            }
        }

        public void searchTereni()
        {
            for (int i = 0; i <= panelToBeShowBySearch.Length - 1; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName1.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren1.Visible = panelToBeShowBySearch[i]; 
                                }
                            }
                            break;
                        }
                    case 1:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName2.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren2.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName3.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren3.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName4.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren4.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName5.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren5.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName6.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren6.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName7.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren7.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName8.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren8.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 8:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName9.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren9.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 9:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName10.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren10.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 10:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName11.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren11.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                    case 11:
                        {
                            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                            {
                                if (lblValueOfName12.Text.Equals(temp.Value.Ime.ToString()))
                                {
                                    panelTeren12.Visible = panelToBeShowBySearch[i];
                                }
                            }
                            break;
                        }
                }
            }
        }

        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////
        private void panelTeren1_MouseEnter(object sender, EventArgs e)
        {
            if(panelStatus[0])
                if(!dragNDropped[0])
                    panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren1.Tag != null)
            {
                sifraTerena = panelTeren1.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName1.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName1.Text);
        }

        private void panelTeren1_MouseLeave(object sender, EventArgs e)
        {
            if(panelStatus[0])
                if (!dragNDropped[0])
                    panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren2_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[1])
                if (!dragNDropped[1])
                    panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren2.Tag != null)
            {
                sifraTerena = panelTeren2.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName2.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName2.Text);
        }

        private void panelTeren2_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[1])
                if (!dragNDropped[1])
                    panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren3_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[2])
                if (!dragNDropped[2])
                    panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren3.Tag != null)
            {
                sifraTerena = panelTeren3.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName3.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName3.Text);
        }

        private void panelTeren3_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[2])
                if (!dragNDropped[2])
                    panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren4_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[3])
                if (!dragNDropped[3])
                    panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren4.Tag != null)
            {
                sifraTerena = panelTeren4.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName4.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName4.Text);
        }

        private void panelTeren4_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[3])
                if (!dragNDropped[3])
                    panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren5_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[4])
                if (!dragNDropped[4])
                    panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren5.Tag != null)
            {
                sifraTerena = panelTeren5.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName5.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName5.Text);
        }

        private void panelTeren5_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[4])
                if (!dragNDropped[4])
                    panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren6_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[5])
                if (!dragNDropped[5])
                    panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren6.Tag != null)
            {
                sifraTerena = panelTeren6.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName6.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName6.Text);
        }

        private void panelTeren6_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[5])
                if (!dragNDropped[5])
                    panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren7_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[6])
                if (!dragNDropped[6])
                    panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren7.Tag != null)
            {
                sifraTerena = panelTeren7.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName7.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName7.Text);
        }

        private void panelTeren7_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[6])
                if (!dragNDropped[6])
                    panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren8_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[7])
                if (!dragNDropped[7])
                    panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren8.Tag != null)
            {
                sifraTerena = panelTeren8.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName8.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName8.Text);
        }

        private void panelTeren8_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[7])
                if (!dragNDropped[7])
                    panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren9_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[8])
                if (!dragNDropped[8])
                    panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren9.Tag != null)
            {
                sifraTerena = panelTeren9.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName9.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName9.Text);
        }

        private void panelTeren9_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[8])
                if (!dragNDropped[8])
                    panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren10_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[9])
                if (!dragNDropped[9])
                    panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren10.Tag != null)
            {
                sifraTerena = panelTeren10.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName10.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName10.Text);
        }

        private void panelTeren10_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[9])
                if (!dragNDropped[9])
                    panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren11_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[10])
                if (!dragNDropped[10])
                    panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren11.Tag != null)
            {
                sifraTerena = panelTeren11.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName11.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName11.Text);
        }

        private void panelTeren11_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[10])
                if (!dragNDropped[10])
                    panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }

        private void panelTeren12_MouseEnter(object sender, EventArgs e)
        {
            if (panelStatus[11])
                if (!dragNDropped[11])
                    panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover));
                else
                    panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_hover_locked));
            else
                panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren_hover));

            if (panelTeren12.Tag != null)
            {
                sifraTerena = panelTeren12.Tag.ToString();
                Control activeForm = this.FindForm();
                ((Form1)activeForm).paintDetailsTereni(lblValueOfName12.Text);
            }

            Form1.getInstance.setLblStatusBar(lblValueOfName12.Text);
        }

        private void panelTeren12_MouseLeave(object sender, EventArgs e)
        {
            if (panelStatus[11])
                if (!dragNDropped[11])
                    panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                else
                    panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
            else
                panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_zatvoren));

            Form1.getInstance.setLblStatusBar("");
        }
        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////

        private bool checkSportOfTeren(string paramTeren, string paramTim)
        {
            bool doIt = false;
            Sport trenutniSport = new Sport(null, null, null);

            foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (temp.Value.Ime.ToString().Equals(paramTim))
                {
                    trenutniSport = temp.Value.Sport;
                }
            }

            foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
            {
                if (temp.Value.Ime.ToString().Equals(paramTeren))
                {
                    foreach (KeyValuePair<Guid, Sport> sport in temp.Value.Sportovi)
                    {
                        System.Diagnostics.Debug.WriteLine(trenutniSport.ImeSporta + " VS " + sport.Value.ImeSporta);
                        if (sport.Value.ImeSporta.ToString().Equals(trenutniSport.ImeSporta))
                        {
                            doIt = true;
                        }
                    }
                }
            }
            return doIt;
        }

        //******************DO DRAD & DROP****************************************////////////////


        private void panelTeren1_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren1);
            toolTip3.Hide(panelTeren1);
            toolTip4.Hide(panelTeren1);
        }

        private void panelTeren2_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren2);
            toolTip3.Hide(panelTeren2);
            toolTip4.Hide(panelTeren2);
        }

        private void panelTeren3_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren3);
            toolTip3.Hide(panelTeren3);
            toolTip4.Hide(panelTeren3);
        }

        private void panelTeren4_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren4);
            toolTip3.Hide(panelTeren4);
            toolTip4.Hide(panelTeren4);
        }

        private void panelTeren5_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren5);
            toolTip3.Hide(panelTeren5);
            toolTip4.Hide(panelTeren5);
        }

        private void panelTeren6_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren6);
            toolTip3.Hide(panelTeren6);
            toolTip4.Hide(panelTeren6);
        }

        private void panelTeren7_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren7);
            toolTip3.Hide(panelTeren7);
            toolTip4.Hide(panelTeren7);
        }

        private void panelTeren8_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren8);
            toolTip3.Hide(panelTeren8);
            toolTip4.Hide(panelTeren8);
        }

        private void panelTeren9_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren9);
            toolTip3.Hide(panelTeren9);
            toolTip4.Hide(panelTeren9);
        }

        private void panelTeren10_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren10);
            toolTip3.Hide(panelTeren10);
            toolTip4.Hide(panelTeren10);
        }

        private void panelTeren11_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren11);
            toolTip3.Hide(panelTeren11);
            toolTip4.Hide(panelTeren11);
        }

        private void panelTeren12_DragLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(panelTeren12);
            toolTip3.Hide(panelTeren12);
            toolTip4.Hide(panelTeren12);
        }

        private void panelTeren1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[0] && !dragNDropped[0] && checkSportOfTeren(lblValueOfName1.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren1.Location.X, panelTeren1.Location.Y);
                toolTip3.Show("", this, panelTeren1.Location.X, panelTeren1.Location.Y);
                toolTip4.Show("", this, panelTeren1.Location.X, panelTeren1.Location.Y);
                if (!panelStatus[0])
                    toolTip2.Show(lblValueOfName1.Text + " je zatvoren", this, panelTeren1.Location.X, panelTeren1.Location.Y);
                else if (dragNDropped[0])
                    toolTip3.Show(lblValueOfName1.Text + " je već zauzet", this, panelTeren1.Location.X, panelTeren1.Location.Y);
                else if(!checkSportOfTeren(lblValueOfName1.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName1.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren1.Location.X, panelTeren1.Location.Y);
                
            }
        }

        private void panelTeren1_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();
            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName1.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new  DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim1.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus1.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName1.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[0] = true;
                pbClose1.Show();
                panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim1.Text.ToString());

            }
        }

        private void panelTeren2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[1] && !dragNDropped[1] && checkSportOfTeren(lblValueOfName2.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                toolTip1.Hide(panelTeren2);
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren2.Location.X, panelTeren2.Location.Y);
                toolTip3.Show("", this, panelTeren2.Location.X, panelTeren2.Location.Y);
                toolTip4.Show("", this, panelTeren2.Location.X, panelTeren2.Location.Y);
                if (!panelStatus[1])
                {
                    toolTip2.Show(lblValueOfName2.Text + " je zatvoren", this, panelTeren2.Location.X, panelTeren2.Location.Y);
                } else
                if (dragNDropped[1])
                {
                    toolTip3.Show(lblValueOfName2.Text + " je već zauzet", this, panelTeren2.Location.X, panelTeren2.Location.Y);
                } else
                if (!checkSportOfTeren(lblValueOfName2.Text, e.Data.GetData(DataFormats.Text).ToString()))
                {
                    toolTip4.Show(lblValueOfName2.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren2.Location.X, panelTeren2.Location.Y);

                }
            }
        }

        private void panelTeren2_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName2.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim2.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus2.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName2.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[1] = true;
                pbClose2.Show();
                panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim2.Text.ToString());

            }
        }

        private void panelTeren3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[2] && !dragNDropped[2] && checkSportOfTeren(lblValueOfName3.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren3.Location.X, panelTeren3.Location.Y);
                toolTip3.Show("", this, panelTeren3.Location.X, panelTeren3.Location.Y);
                toolTip4.Show("", this, panelTeren3.Location.X, panelTeren3.Location.Y);
                if (!panelStatus[2])
                    toolTip2.Show(lblValueOfName3.Text + " je zatvoren", this, panelTeren3.Location.X, panelTeren3.Location.Y);
                else if (dragNDropped[2])
                    toolTip3.Show(lblValueOfName3.Text + " je već zauzet", this, panelTeren3.Location.X, panelTeren3.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName3.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName3.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren3.Location.X, panelTeren3.Location.Y);
                
            }
        }

        private void panelTeren3_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName3.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim3.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus3.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName3.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[2] = true;
                pbClose3.Show();
                panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim3.Text.ToString());
            }
        }

        private void panelTeren4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[3] && !dragNDropped[3] && checkSportOfTeren(lblValueOfName4.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren4.Location.X, panelTeren4.Location.Y);
                toolTip3.Show("", this, panelTeren4.Location.X, panelTeren4.Location.Y);
                toolTip4.Show("", this, panelTeren4.Location.X, panelTeren4.Location.Y);
                if (!panelStatus[3])
                    toolTip2.Show(lblValueOfName4.Text + " je zatvoren", this, panelTeren4.Location.X, panelTeren4.Location.Y);
                else if (dragNDropped[3])
                    toolTip3.Show(lblValueOfName4.Text + " je već zauzet", this, panelTeren4.Location.X, panelTeren4.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName4.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName4.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren4.Location.X, panelTeren4.Location.Y);
                
            }
        }

        private void panelTeren4_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName4.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim4.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus4.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName4.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[3] = true;
                pbClose4.Show();
                panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim4.Text.ToString());
            }
        }

        private void panelTeren5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[4] && !dragNDropped[4] && checkSportOfTeren(lblValueOfName5.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren5.Location.X, panelTeren5.Location.Y);
                toolTip3.Show("", this, panelTeren5.Location.X, panelTeren5.Location.Y);
                toolTip4.Show("", this, panelTeren5.Location.X, panelTeren5.Location.Y);
                if (!panelStatus[4])
                    toolTip2.Show(lblValueOfName5.Text + " je zatvoren", this, panelTeren5.Location.X, panelTeren5.Location.Y);
                else if (dragNDropped[4])
                    toolTip3.Show(lblValueOfName5.Text + " je već zauzet", this, panelTeren5.Location.X, panelTeren5.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName5.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName5.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren5.Location.X, panelTeren5.Location.Y);
                
            }
        }

        private void panelTeren5_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName5.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim5.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus5.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName5.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[4] = true;
                pbClose5.Show();
                panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim5.Text.ToString());
            }
        }

        private void panelTeren6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[5] && !dragNDropped[5] && checkSportOfTeren(lblValueOfName6.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren6.Location.X, panelTeren6.Location.Y);
                toolTip3.Show("", this, panelTeren6.Location.X, panelTeren6.Location.Y);
                toolTip4.Show("", this, panelTeren6.Location.X, panelTeren6.Location.Y);
                if (!panelStatus[5])
                    toolTip2.Show(lblValueOfName6.Text + " je zatvoren", this, panelTeren6.Location.X, panelTeren6.Location.Y);
                else if (dragNDropped[5])
                    toolTip3.Show(lblValueOfName6.Text + " je već zauzet", this, panelTeren6.Location.X, panelTeren6.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName6.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName6.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren6.Location.X, panelTeren6.Location.Y);
                
            }
        }

        private void panelTeren6_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName6.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim6.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus6.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName6.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[5] = true;
                pbClose6.Show();
                panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim6.Text.ToString());
            }
        }

        private void panelTeren7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[6] && !dragNDropped[6] && checkSportOfTeren(lblValueOfName7.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren7.Location.X, panelTeren7.Location.Y);
                toolTip3.Show("", this, panelTeren7.Location.X, panelTeren7.Location.Y);
                toolTip4.Show("", this, panelTeren7.Location.X, panelTeren7.Location.Y);
                if (!panelStatus[6])
                    toolTip2.Show(lblValueOfName7.Text + " je zatvoren", this, panelTeren7.Location.X, panelTeren7.Location.Y);
                else if (dragNDropped[6])
                    toolTip3.Show(lblValueOfName7.Text + " je već zauzet", this, panelTeren7.Location.X, panelTeren7.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName7.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName7.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren7.Location.X, panelTeren7.Location.Y);
                
            }
        }

        private void panelTeren7_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName7.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim7.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus7.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName7.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[6] = true;
                pbClose7.Show();
                panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim7.Text.ToString());
            }
        }

        private void panelTeren8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[7] && !dragNDropped[7] && checkSportOfTeren(lblValueOfName8.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren8.Location.X, panelTeren8.Location.Y);
                toolTip3.Show("", this, panelTeren8.Location.X, panelTeren8.Location.Y);
                toolTip4.Show("", this, panelTeren8.Location.X, panelTeren8.Location.Y);
                if (!panelStatus[7])
                    toolTip2.Show(lblValueOfName8.Text + " je zatvoren", this, panelTeren8.Location.X, panelTeren8.Location.Y);
                else if (dragNDropped[7])
                    toolTip3.Show(lblValueOfName8.Text + " je već zauzet", this, panelTeren8.Location.X, panelTeren8.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName8.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName8.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren8.Location.X, panelTeren8.Location.Y);
                
            }
        }

        private void panelTeren8_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName8.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim8.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus8.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName8.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[7] = true;
                pbClose8.Show();
                panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim8.Text.ToString());
            }
        }

        private void panelTeren9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[8] && !dragNDropped[8] && checkSportOfTeren(lblValueOfName9.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren9.Location.X, panelTeren9.Location.Y);
                toolTip3.Show("", this, panelTeren9.Location.X, panelTeren9.Location.Y);
                toolTip4.Show("", this, panelTeren9.Location.X, panelTeren9.Location.Y);
                if (!panelStatus[8])
                    toolTip2.Show(lblValueOfName9.Text + " je zatvoren", this, panelTeren9.Location.X, panelTeren9.Location.Y);
                else if (dragNDropped[8])
                    toolTip3.Show(lblValueOfName9.Text + " je već zauzet", this, panelTeren9.Location.X, panelTeren9.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName9.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName9.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren9.Location.X, panelTeren9.Location.Y);
                
            }
        }

        private void panelTeren9_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName9.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim9.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus9.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName9.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[8] = true;
                pbClose9.Show();
                panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim9.Text.ToString());
            }
        }

        private void panelTeren10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[9] && !dragNDropped[9] && checkSportOfTeren(lblValueOfName10.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren10.Location.X, panelTeren10.Location.Y);
                toolTip3.Show("", this, panelTeren10.Location.X, panelTeren10.Location.Y);
                toolTip4.Show("", this, panelTeren10.Location.X, panelTeren10.Location.Y);
                if (!panelStatus[9])
                    toolTip2.Show(lblValueOfName10.Text + " je zatvoren", this, panelTeren10.Location.X, panelTeren10.Location.Y);
                else if (dragNDropped[9])
                    toolTip3.Show(lblValueOfName10.Text + " je već zauzet", this, panelTeren10.Location.X, panelTeren10.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName10.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName10.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren10.Location.X, panelTeren10.Location.Y);
                
            }
        }

        private void panelTeren10_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName10.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim10.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus10.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName10.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[9] = true;
                pbClose10.Show();
                panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim10.Text.ToString());
            }
        }

        private void panelTeren11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[10] && !dragNDropped[10] && checkSportOfTeren(lblValueOfName11.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren11.Location.X, panelTeren11.Location.Y);
                toolTip3.Show("", this, panelTeren11.Location.X, panelTeren11.Location.Y);
                toolTip4.Show("", this, panelTeren11.Location.X, panelTeren11.Location.Y);
                if (!panelStatus[10])
                    toolTip2.Show(lblValueOfName11.Text + " je zatvoren", this, panelTeren11.Location.X, panelTeren11.Location.Y);
                else if (dragNDropped[10])
                    toolTip3.Show(lblValueOfName11.Text + " je već zauzet", this, panelTeren11.Location.X, panelTeren11.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName11.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName11.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren11.Location.X, panelTeren11.Location.Y);
                
            }
        }

        private void panelTeren11_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName11.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim11.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus11.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName11.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[10] = true;
                pbClose11.Show();
                panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim11.Text.ToString());
            }
        }

        private void panelTeren12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && panelStatus[11] && !dragNDropped[11] && checkSportOfTeren(lblValueOfName12.Text, e.Data.GetData(DataFormats.Text).ToString()))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                toolTip2.Show("", this, panelTeren12.Location.X, panelTeren12.Location.Y);
                toolTip3.Show("", this, panelTeren12.Location.X, panelTeren12.Location.Y);
                toolTip4.Show("", this, panelTeren12.Location.X, panelTeren12.Location.Y);
                if (!panelStatus[11])
                    toolTip2.Show(lblValueOfName12.Text + " je zatvoren", this, panelTeren12.Location.X, panelTeren12.Location.Y);
                else if (dragNDropped[11])
                    toolTip3.Show(lblValueOfName12.Text + " je već zauzet", this, panelTeren12.Location.X, panelTeren12.Location.Y);
                else if (!checkSportOfTeren(lblValueOfName12.Text, e.Data.GetData(DataFormats.Text).ToString()))
                    toolTip4.Show(lblValueOfName12.Text + " ne podržava sport koji koristi " + e.Data.GetData(DataFormats.Text).ToString(), this, panelTeren12.Location.X, panelTeren12.Location.Y);
                
            }
        }

        private void panelTeren12_DragDrop(object sender, DragEventArgs e)
        {
            dimTheBackground();

            Guid trenutniTim = new Guid();
            Guid trenutniTeren = new Guid();

            foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
            {
                if (tim.Value.Ime.Equals(e.Data.GetData(DataFormats.Text).ToString()))
                {
                    trenutniTim = tim.Key;
                }
            }

            foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Ime.Equals(lblValueOfName12.Text))
                {
                    trenutniTeren = teren.Key;
                }
            }

            DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.ZAUZIMANJE);
            temporary.ShowDialog();

            if (temporary.IsCorrect)
            {
                lblValueOfTim12.Text = e.Data.GetData(DataFormats.Text).ToString();
                lblValueOfStatus12.Text = "Zauzet";

                foreach (KeyValuePair<Guid, Teren> temp in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(lblValueOfName12.Text))
                    {
                        temp.Value.Slobodan = false;
                        temp.Value.TrenutniTim = e.Data.GetData(DataFormats.Text).ToString();
                    }
                }
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Ime.ToString().Equals(e.Data.GetData(DataFormats.Text).ToString()))
                    {
                        temp.Value.Slobodan = false;
                    }
                }
                Form1.getInstance.addToListBox();

                dragNDropped[11] = true;
                pbClose12.Show();
                panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren_locked));
                Control activeForm = this.FindForm();
                ((Form1)activeForm).removeListBoxItem(lblValueOfTim12.Text.ToString());
            }
        }
        //******************DO DRAD & DROP****************************************////////////////


        //******************IZCRTAVANJE INFORMACIJA DA DETAILS PANELU*****************////////////
        private void panelTeren1_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren1.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName1.Text);
            }
        }

        private void panelTeren2_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren2.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName2.Text);
            }
        }

        private void panelTeren3_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren3.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName3.Text);
            }
        }

        private void panelTeren4_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren4.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName4.Text);
            }
        }

        private void panelTeren5_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren5.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName5.Text);
            }
        }

        private void panelTeren6_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren6.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName6.Text);
            }
        }

        private void panelTeren7_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren7.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName7.Text);
            }
        }

        private void panelTeren8_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren8.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName8.Text);
            }
        }

        private void panelTeren9_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren9.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName9.Text);
            }
        }

        private void panelTeren10_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren10.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName10.Text);
            }
        }

        private void panelTeren11_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren11.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName11.Text);
            }
        }

        private void panelTeren12_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelTeren12.Tag != null)
            {
                Form1.getInstance.paintIstorijaZauzetosti(lblValueOfName12.Text);
            }
        }
        //******************IZCRTAVANJE INFORMACIJA DA DETAILS PANELU*****************////////////


        //************************OSLOBADANJE TERENA****************************///////////////
        private void pbClose1_Click(object sender, EventArgs e)
        {
            if (dragNDropped[0] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim1.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName1.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim1.Text.ToString());
                    Teren temp;
                    //Form1.getInstance.TereniCollection.Teren_collection.TryGetValue(new Guid(panelTeren1.Tag.ToString()), out temp);
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren1.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim1.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim1.Text = "/";
                    lblValueOfStatus1.Text = "Slobodan";
                    panelTeren1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[0] = false;
                    pbClose1.Hide();
                }
            }
        }

        private void pbClose2_Click(object sender, EventArgs e)
        {
            if (dragNDropped[1] == true)
            {
                dimTheBackground();
                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim2.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName2.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim2.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren2.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim2.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim2.Text = "/";
                    lblValueOfStatus2.Text = "Slobodan";
                    panelTeren2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[1] = false;
                    pbClose2.Hide();
                }
            }
        }

        private void pbClose3_Click(object sender, EventArgs e)
        {
            if (dragNDropped[2] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim3.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName3.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim3.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren3.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim3.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim3.Text = "/";
                    lblValueOfStatus3.Text = "Slobodan";
                    panelTeren3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[2] = false;
                    pbClose3.Hide();
                }
            }
        }

        private void pbClose4_Click(object sender, EventArgs e)
        {
            if (dragNDropped[3] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim4.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName4.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim4.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren4.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim4.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim4.Text = "/";
                    lblValueOfStatus4.Text = "Slobodan";
                    panelTeren4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[3] = false;
                    pbClose4.Hide();
                }
            }
        }

        private void pbClose5_Click(object sender, EventArgs e)
        {
            if (dragNDropped[4] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim5.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName5.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim5.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren5.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim5.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim5.Text = "/";
                    lblValueOfStatus5.Text = "Slobodan";
                    panelTeren5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[4] = false;
                    pbClose5.Hide();
                }
            }
        }

        private void pbClose6_Click(object sender, EventArgs e)
        {
            if (dragNDropped[5] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim6.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName6.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim6.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren6.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim6.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim6.Text = "/";
                    lblValueOfStatus6.Text = "Slobodan";
                    panelTeren6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[5] = false;
                    pbClose6.Hide();
                }
            }
        }

        private void pbClose7_Click(object sender, EventArgs e)
        {
            if (dragNDropped[6] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim7.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName7.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim7.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren7.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim7.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim7.Text = "/";
                    lblValueOfStatus7.Text = "Slobodan";
                    panelTeren7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[6] = false;
                    pbClose7.Hide();
                }
            }
        }

        private void pbClose8_Click(object sender, EventArgs e)
        {
            if (dragNDropped[7] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim8.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName8.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim8.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren8.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim8.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim8.Text = "/";
                    lblValueOfStatus8.Text = "Slobodan";
                    panelTeren8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[7] = false;
                    pbClose8.Hide();
                }
            }
        }

        private void pbClose9_Click(object sender, EventArgs e)
        {
            if (dragNDropped[8] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim9.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName9.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim9.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren9.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim9.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim9.Text = "/";
                    lblValueOfStatus9.Text = "Slobodan";
                    panelTeren9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[8] = false;
                    pbClose9.Hide();
                }
            }
        }

        private void pbClose10_Click(object sender, EventArgs e)
        {
            if (dragNDropped[9] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim10.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName10.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim10.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren10.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim10.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim10.Text = "/";
                    lblValueOfStatus10.Text = "Slobodan";
                    panelTeren10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[9] = false;
                    pbClose10.Hide();
                }
            }
        }

        private void pbClose11_Click(object sender, EventArgs e)
        {
            if (dragNDropped[10] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim11.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName11.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim11.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren11.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim11.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim11.Text = "/";
                    lblValueOfStatus11.Text = "Slobodan";
                    panelTeren11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[10] = false;
                    pbClose11.Hide();
                }
            }
        }

        private void pbClose12_Click(object sender, EventArgs e)
        {
            if (dragNDropped[11] == true)
            {
                dimTheBackground();

                Guid trenutniTim = new Guid();
                Guid trenutniTeren = new Guid();

                foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (tim.Value.Ime.Equals(lblValueOfTim12.Text))
                    {
                        trenutniTim = tim.Key;
                    }
                }

                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Ime.Equals(lblValueOfName12.Text))
                    {
                        trenutniTeren = teren.Key;
                    }
                }

                DialogZauzimanjaTerena temporary = new DialogZauzimanjaTerena(trenutniTim, trenutniTeren, Enumeration.Status.OSLOBADJANJE);
                temporary.ShowDialog();

                if (temporary.IsCorrect)
                {
                    Control activeForm = this.FindForm();
                    ((Form1)activeForm).setListBox(lblValueOfTim12.Text.ToString());
                    Teren temp;
                    Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(panelTeren12.Tag.ToString()), out temp);

                    temp.TrenutniTim = "/";
                    temp.Slobodan = true;
                    foreach (KeyValuePair<Guid, Tim> tim in Timovi_Collection.getInstance.Timovi_collection)
                    {
                        if (tim.Value.Ime.ToString().Equals(lblValueOfTim12.Text))
                        {
                            tim.Value.Slobodan = true;
                        }
                    }

                    lblValueOfTim12.Text = "/";
                    lblValueOfStatus12.Text = "Slobodan";
                    panelTeren12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelTeren));
                    dragNDropped[11] = false;
                    pbClose12.Hide();
                }
            }
        }

        //************************OSLOBADANJE TERENA****************************///////////////


        //************************IZCRTAVANJE CLOSE SLIKA************************/////////////
        private void pbClose1_MouseEnter(object sender, EventArgs e)
        {
            pbClose1.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose1_MouseLeave(object sender, EventArgs e)
        {
            pbClose1.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose2_MouseEnter(object sender, EventArgs e)
        {
            pbClose2.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose2_MouseLeave(object sender, EventArgs e)
        {
            pbClose2.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose3_MouseEnter(object sender, EventArgs e)
        {
            pbClose3.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose3_MouseLeave(object sender, EventArgs e)
        {
            pbClose3.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose4_MouseEnter(object sender, EventArgs e)
        {
            pbClose4.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose4_MouseLeave(object sender, EventArgs e)
        {
            pbClose4.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose5_MouseEnter(object sender, EventArgs e)
        {
            pbClose5.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose5_MouseLeave(object sender, EventArgs e)
        {
            pbClose5.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose6_MouseEnter(object sender, EventArgs e)
        {
            pbClose6.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose6_MouseLeave(object sender, EventArgs e)
        {
            pbClose6.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose7_MouseEnter(object sender, EventArgs e)
        {
            pbClose7.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose7_MouseLeave(object sender, EventArgs e)
        {
            pbClose7.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose8_MouseEnter(object sender, EventArgs e)
        {
            pbClose8.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose8_MouseLeave(object sender, EventArgs e)
        {
            pbClose8.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose9_MouseEnter(object sender, EventArgs e)
        {
            pbClose9.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose9_MouseLeave(object sender, EventArgs e)
        {
            pbClose9.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose10_MouseEnter(object sender, EventArgs e)
        {
            pbClose10.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose10_MouseLeave(object sender, EventArgs e)
        {
            pbClose10.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose11_MouseEnter(object sender, EventArgs e)
        {
            pbClose11.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose11_MouseLeave(object sender, EventArgs e)
        {
            pbClose11.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        private void pbClose12_MouseEnter(object sender, EventArgs e)
        {
            pbClose12.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren_hover));
        }

        private void pbClose12_MouseLeave(object sender, EventArgs e)
        {
            pbClose12.Image = ((System.Drawing.Image)(Properties.Resources.releaseTeren));
        }

        //************************IZCRTAVANJE CLOSE SLIKA************************/////////////
    }
}
