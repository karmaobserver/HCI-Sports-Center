using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.Viewer.panelBrowse;
using VEOS_WFA.model.entity;
using VEOS_WFA.model.collection;
using VEOS_WFA.Viewer.dialogUserControls;
using VEOS_WFA.Viewer.dialogDetails;
using VEOS_WFA.Viewer;
using VEOS_WFA.Viewer.dialogUserControls.dodavanje;
using VEOS_WFA.Viewer.messageBoxes;

namespace VEOS_WFA
{
    public partial class Form1 : Form
    {
        private static Form1 instance;

        public static Form1 getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }

                return instance;
            }
        }

        enum Stanje { UCHALE, UCTERENI, DSPORTISTI, DSPORTOVI, DTERENI, DTIMOVI, DISTORIJAZAUZIMANJA };

        Stanje stanje;

        Background background = Background.getInstance;
        TimMembers timMembers = TimMembers.getInstance;

        //BROWSE USER CONTROLS
        Hale UserControlHale = new Hale();
        List<Tereni> UserControlTereni = new List<Tereni>();

        //BROWSE DETAILS USER CONTROLS (STATUS BAR)
        HaleDetails haleDetails = new HaleDetails();
        TereniDetails tereniDetails = new TereniDetails();
        TimoviDetails timoviDetails = new TimoviDetails();
        
        //DIALOG USER CONTROLS
        DialogSportisti dialogSportisti = DialogSportisti.getInstance;
        DialogSportovi dialogSportovi = DialogSportovi.getInstace;
        DialogTereni dialogTereni = DialogTereni.getInstance;
        DialogTimovi dialogTimovi = DialogTimovi.getInstance;
        ZauzimanjeTerena dialogZauzimanjeTerena = ZauzimanjeTerena.getInstance;

        //DIALOG DETAILS USER CONTROLS
        DialogTereniDetails dialogTereniDetails = DialogTereniDetails.getInstance;
        DialogTimoviDetails dialogTimoviDetails = DialogTimoviDetails.getInstance;
        DialogSportistiDetails dialogSportistidetails = DialogSportistiDetails.getInstance;
        DialogSportoviDetails dialogSportoviDetails = DialogSportoviDetails.getInstance;
        DialogZauzimanjeTerenaDetails dialogZauzimanjeDetails = DialogZauzimanjeTerenaDetails.getInstance;

        //COLLECTIONS
        Hale_Collection haleCollection = Hale_Collection.getInstance;

        internal Hale_Collection HaleCollection
        {
            get { return haleCollection; }
            set { haleCollection = value; }
        }
        Tereni_Collection tereniCollection = Tereni_Collection.getInstance;
        internal Tereni_Collection TereniCollection
        {
            get { return tereniCollection; }
            set { tereniCollection = value; }
        }
        Timovi_Collection timoviCollection = Timovi_Collection.getInstance;

        internal Timovi_Collection TimoviCollection
        {
            get { return timoviCollection; }
            set { timoviCollection = value; }
        }
        Sportiste_Collection sportisteCollection = Sportiste_Collection.getInstance;

        internal Sportiste_Collection SportisteCollection
        {
            get { return sportisteCollection; }
            set { sportisteCollection = value; }
        }

        Sportovi_Collection sportoviCollection = Sportovi_Collection.getInstance;

        internal Sportovi_Collection SportoviCollection
        {
            get { return sportoviCollection; }
            set { sportoviCollection = value; }
        }

        Zauzimanje_Collection zauzimanjeCollection = Zauzimanje_Collection.getInstance;

        internal Zauzimanje_Collection ZauzimanjeCollection
        {
            get { return zauzimanjeCollection; }
            set { zauzimanjeCollection = value; }
        }

        int currentHala = -1;

        public int CurrentHala
        {
            get { return currentHala; }
            set { currentHala = value; }
        }

        public void createUserControlTereni()
        {
            UserControlTereni.Add(new Tereni());
            UserControlTereni.Add(new Tereni());
            UserControlTereni.Add(new Tereni());
            UserControlTereni.Add(new Tereni());
        }

        public void loadHale()
        {
            Hala hala1 = new Hala("Centralna hala", 1);
            Hala hala2 = new Hala("Olimpijska hala", 2);
            Hala hala3 = new Hala("Hala Novak", 3);
            Hala hala4 = new Hala("Pomoćna hala", 4);
            haleCollection.addHala(hala1);
            haleCollection.addHala(hala2);
            haleCollection.addHala(hala3);
            haleCollection.addHala(hala4);
            Sport sport1 = new Sport("sport1", "prefiks1", "beleske1");
            Sport sport2 = new Sport("sport2", "prefiks2", "beleske2");
            Sport sport3 = new Sport("sport3", "prefiks3", "beleske3");
            sportoviCollection.addSport(sport1);
            sportoviCollection.addSport(sport2);
            sportoviCollection.addSport(sport3);
            Sportista sportista1 = new Sportista("123", "ime1", "prezime1", "2010", Sportista.Klasa.Amater, sport1, null);
            Sportista sportista2 = new Sportista("456", "ime2", "prezime2", "2011", Sportista.Klasa.Poluprofesionalac, sport2, null);
            Sportista sportista3 = new Sportista("789", "ime3", "prezime3", "2012", Sportista.Klasa.Profesionalac, sport3, null);
            sportisteCollection.addSportista(sportista1);
            sportisteCollection.addSportista(sportista2);
            sportisteCollection.addSportista(sportista3);
            Tim tim1 = new Tim("tim1", null, sport1, "kommentar1");
            Tim tim2 = new Tim("tim2", null, sport2, "kommentar2");
            Tim tim3 = new Tim("tim3", null, sport3, "kommentar3");
            timoviCollection.addTim(tim1);
            timoviCollection.addTim(tim2);
            timoviCollection.addTim(tim3);
            Teren teren1 = new Teren("teren1", hala1, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "kommentar");
            Teren teren2 = new Teren("teren2", hala2, "2012", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "kommentar");
            Teren teren3 = new Teren("teren3", hala3, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "kommentar");
            Teren teren4 = new Teren("teren4", hala4, "2011", false, Sportovi_Collection.getInstance.Sportovi_collection, 23, "kommentar");
            Teren teren5 = new Teren("teren5", hala1, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "kommentar");
            tereniCollection.addTeren(teren1);
            tereniCollection.addTeren(teren2);
            tereniCollection.addTeren(teren3);
            tereniCollection.addTeren(teren4);
            tereniCollection.addTeren(teren5);
            System.Diagnostics.Debug.WriteLine(tereniCollection.Teren_collection.Count());
        }

        public void loadHaleBaza()
        {
            Hala hala1 = new Hala("Spens", 1);
            Hala hala2 = new Hala("Pionir", 2);
            Hala hala3 = new Hala("Arena", 3);
            Hala hala4 = new Hala("Hala Sportova", 4);
            haleCollection.addHala(hala1);
            haleCollection.addHala(hala2);
            haleCollection.addHala(hala3);
            haleCollection.addHala(hala4);
            Sport sport1 = new Sport("Fudbal", "F", "U poslednje vreme najviše se igra fudbal");
            Sport sport2 = new Sport("Kosarka", "K", "Igrači su manje zainteresovani");
            Sport sport3 = new Sport("Rukomet", "R", "Igra se grubo u poslednje vreme");
            Sport sport4 = new Sport("Odbojka", "O", "Igrači su druželjubivi");
            sportoviCollection.addSport(sport1);
            sportoviCollection.addSport(sport2);
            sportoviCollection.addSport(sport3);
            sportoviCollection.addSport(sport4);
            Sportista sportista1 = new Sportista("1824923891242", "Filip", "Knezević", "2010", Sportista.Klasa.Amater, sport1, null);
            Sportista sportista2 = new Sportista("5478958241945", "Petar", "Petrović", "2011", Sportista.Klasa.Poluprofesionalac, sport2, null);
            Sportista sportista3 = new Sportista("9754863512700", "Luka", "Kovač", "2012", Sportista.Klasa.Profesionalac, sport3, null);
            Sportista sportista4 = new Sportista("1984567285020", "Sanja", "Kovačević", "2010", Sportista.Klasa.Profesionalac, sport2, null);
            Sportista sportista5 = new Sportista("1845558759848", "Vesna", "Petrović", "2012", Sportista.Klasa.Profesionalac, sport1, null);
            Sportista sportista6 = new Sportista("1845558759848", "Suzana", "Tosić", "2013", Sportista.Klasa.Amater, sport1, null);
            Sportista sportista7 = new Sportista("1845558759848", "Nemanja", "Knezić", "2013", Sportista.Klasa.Amater, sport4, null);
            sportisteCollection.addSportista(sportista1);
            sportisteCollection.addSportista(sportista2);
            sportisteCollection.addSportista(sportista3);
            sportisteCollection.addSportista(sportista4);
            sportisteCollection.addSportista(sportista5);
            sportisteCollection.addSportista(sportista6);
            sportisteCollection.addSportista(sportista7);
            Tim tim1 = new Tim("Zvezda", null, sport1, "Nezadovoljstvo u timu");
            Tim tim2 = new Tim("Rusin", null, sport2, "Entuzijazam uvećan");
            Tim tim3 = new Tim("Hajduk", null, sport3, "Prijatnost tima");
            Tim tim4 = new Tim("Partizan", null, sport4, "Svadje u timu");
            Tim tim5 = new Tim("Vojvodina", null, sport1, "Napredak opažen");
            timoviCollection.addTim(tim1);
            timoviCollection.addTim(tim2);
            timoviCollection.addTim(tim3);
            timoviCollection.addTim(tim4);
            timoviCollection.addTim(tim5);
            Teren teren1 = new Teren("Platini", hala1, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Nov teren");
            Teren teren2 = new Teren("Pehar", hala1, "2012", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Takmičarski teren");
            Teren teren3 = new Teren("Pustoš", hala1, "2011", false, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Blratnjav teren");
            Teren teren4 = new Teren("Putnik", hala1, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Veštačka trava");
            Teren teren5 = new Teren("Rusin", hala2, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Mali teren");
            Teren teren6 = new Teren("Air", hala2, "2011", false, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Veliki teren");
            Teren teren7 = new Teren("Patuljak", hala3, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Mali teren");
            Teren teren8 = new Teren("Breza", hala4, "2011", true, Sportovi_Collection.getInstance.Sportovi_collection, 23, "Okružen biljkama");
            tereniCollection.addTeren(teren1);
            tereniCollection.addTeren(teren2);
            tereniCollection.addTeren(teren3);
            tereniCollection.addTeren(teren4);
            tereniCollection.addTeren(teren5);
            tereniCollection.addTeren(teren6);
            tereniCollection.addTeren(teren7);
            tereniCollection.addTeren(teren8);
        }

        public Form1()
        {
            InitializeComponent();
        }


        ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////
        /*private void lbTimovi_MouseEnter(object sender, EventArgs e)
        {
            timMembers.Visible = true;
        }
        ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////
        private void lbTimovi_SelectedValueChanged(object sender, EventArgs e)
        {
         * ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////
            System.Diagnostics.Debug.WriteLine("selectedValueChange");
            TimMembers.getInstance.deleteAllLabel();
            if (lbTimovi.SelectedItem != null)
            {
                System.Diagnostics.Debug.WriteLine("bele mentunk az ifbe");
                Tim tim = (Tim)lbTimovi.SelectedItem;
                foreach (KeyValuePair<Guid, Sportista> sportista in tim.Sportiste)
                {
                    System.Diagnostics.Debug.WriteLine(sportista.Value.Ime.ToString());
                    TimMembers.getInstance.createLabel(sportista.Value.Ime.ToString());
                }
            }
            TimMembers.getInstance.makeItVisible();
         * ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////
        }
        ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////
        private void lbTimovi_MouseLeave(object sender, EventArgs e)
        {
            timMembers.Visible = false;
        }*/
        ///////!!!!!!!!!!!!!!!!!****** EVENTI SU IZBRISANI IZ DIZAJNERA!!!!!!!!!!!!!!!!<<<<<<<<<<<<<<<<<<<<<</////////////////


        private void loadCbSportovi()
        {
            cbSportovi.Items.Clear();
            foreach (KeyValuePair<Guid, Sport> temp in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                cbSportovi.Items.Add(temp.Value);
            }
            cbSportovi.Items.Add("Svi sportovi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadHaleBaza();
            //loadHale();
            loadCbSportovi();
            paintHale();
            addToListBox();
            createUserControlTereni();
            this.Icon = VEOS_WFA.Properties.Resources.icon;
        }

        private void cbSportovi_SelectedValueChanged(object sender, EventArgs e)
        {
            lbTimovi.Items.Clear();

            Guid trenutniSport = new Guid();
            foreach (KeyValuePair<Guid, Sport> sport in Sportovi_Collection.getInstance.Sportovi_collection)
            {
                if (cbSportovi.SelectedItem.ToString().Equals(sport.Value.ImeSporta.ToString()))
                {
                    trenutniSport = sport.Key;
                }
            }

            if (cbSportovi.SelectedItem.Equals("Svi sportovi"))
            {
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    lbTimovi.Items.Add(temp.Value);
                }
            }
            else
            {
                foreach (KeyValuePair<Guid, Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
                {
                    if (temp.Value.Sport.Sifra.Equals(trenutniSport))
                    {
                        lbTimovi.Items.Add(temp.Value);
                    }
                }
            }
        }

        public void addToListBox()
        {
            lbTimovi.Items.Clear();

            foreach(KeyValuePair<Guid,Tim> temp in Timovi_Collection.getInstance.Timovi_collection)
            {
                if(temp.Value.Slobodan)
                    lbTimovi.Items.Add(temp.Value);
            }
        }

        public void paintHale()
        {
            //button1.Text = collectionHale.size().ToString();

            stanje = Stanje.UCHALE;

            Dictionary<Guid, Teren> temp = new Dictionary<Guid, Teren>();
            panelView.Controls.Clear();
            foreach (KeyValuePair<Guid, Hala> hala in Hale_Collection.getInstance.Hale_collection)
            {
                hala.Value.BrTerena = 0;
                foreach (KeyValuePair<Guid, Teren> teren in Tereni_Collection.getInstance.Teren_collection)
                {
                    if (teren.Value.Lokacija.ImeHale.Equals(hala.Value.ImeHale))
                    {
                        hala.Value.BrTerena++;
                    }
                }
            }

            List<int> brojTerena = new List<int>();
            List<string> imeHale = new List<string>();
            foreach (KeyValuePair<Guid, Hala> hala in Hale_Collection.getInstance.Hale_collection)
            {
                imeHale.Add(hala.Value.ImeHale);
                brojTerena.Add(hala.Value.BrTerena);
            }

            UserControlHale.BrHale = HaleCollection.size();
            UserControlHale.setHaleText(imeHale, brojTerena);
            panelView.Controls.Add(UserControlHale);
            
        }

        public void paintTereni()
        {
            stanje = Stanje.UCTERENI;

            int brTerena = 0;
            Dictionary<Guid,Teren> temp = new Dictionary<Guid,Teren>();
            panelView.Controls.Clear();

            foreach(KeyValuePair<Guid,Teren> teren in Tereni_Collection.getInstance.Teren_collection)
            {
                if (teren.Value.Lokacija.ImeHale.Equals(UserControlHale.ImeHale))
                {
                    brTerena++;
                    temp.Add(teren.Key, teren.Value);
                    System.Diagnostics.Debug.WriteLine(teren.Value.Ime + "|" +  brTerena);
                }
            }

            List<string> imeTerena = new List<string>();
            List<string> sifraTerena = new List<string>();
            foreach (KeyValuePair<Guid, Teren> teren in temp)
            {
                imeTerena.Add(teren.Value.Ime);
                sifraTerena.Add(teren.Value.Sifra.ToString());
            }

            UserControlTereni[currentHala].setTereniTextToDefault();
            UserControlTereni[currentHala].BrTerena = temp.Count;
            UserControlTereni[currentHala].setTereniText(imeTerena, sifraTerena);
            panelView.Controls.Add(UserControlTereni[currentHala]);
            UserControlTereni[currentHala].changeTereniPanelVisibleTrue();
            setHaleDetails(UserControlHale.ImeHale, brTerena.ToString());
            lblStatus.Text = "Sportski centar > " + UserControlHale.ImeHale;
            panelDetail.Controls.Add(haleDetails);
            panelSomeInformation.Visible = true;
        }

        public void paintDetailsTereni(string imeTerena)
        {
            panelDetail.Controls.Clear();
            Teren temp;
            Tereni_Collection.getInstance.Teren_collection.TryGetValue(new Guid(UserControlTereni[currentHala].SifraTerena),out temp);
            string sportovi = "";
            foreach (KeyValuePair<Guid, Sport> sport in temp.Sportovi)
            {
                sportovi += sport.Value.ImeSporta + ", ";
            }
            sportovi = sportovi.Substring(0, sportovi.Length - 2);
            setTereniDetails(imeTerena, sportovi, temp.GodinaOpremljenja, temp.Kapacitet.ToString(), temp.Kommentar);
            //lblStatus.Text = "Sportski centar > " + UserControlHale.ImeHale + " > " + temp.Ime;
            panelDetail.Controls.Add(tereniDetails);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            loadCbSportovi();
            cbSportovi.SelectedItem = "Svi sportovi";
            addToListBox();
            //if (panelView.Controls.Contains(UserControlTereni)) 
            if (stanje == Stanje.UCTERENI)
            {
                panelView.Controls.Clear();
                panelDetail.Controls.Clear();
                panelDialogDetail.Visible = false;
                paintHale();
                lblStatus.Text = "Sportski centar > ";
                stanje = Stanje.UCHALE;
                panelSomeInformation.Visible = false;
            }

            if (stanje == Stanje.DSPORTISTI || stanje == Stanje.DSPORTOVI || stanje == Stanje.DTERENI || stanje == Stanje.DTIMOVI || stanje == Stanje.DISTORIJAZAUZIMANJA)
            {
                panelView.Controls.Clear();
                panelDetail.Controls.Clear();
                panelDialog.Controls.Clear();
                panelDialog.Visible = false;
                panelSplitContainer2.Visible = true;
                panelDialogDetail.Visible = false;
                paintHale();
                //UserControlTereni.changeTereniPanelVisibleFalse();
                lblStatus.Text = "Sportski centar > ";
                stanje = Stanje.UCHALE;
                panelSomeInformation.Visible = false;
            }
            
            //UserControlTereni.changeTereniPanelVisibleFalse();
        }

        public void setHaleDetails(String name, String number)
        {
            haleDetails.setLblValueOfNameHale(name);
            haleDetails.setLblValueOfBrojTerena(number);
        }

        public void setTereniDetails(string imeTerena,string sportovi, String godOpr, String kapacitet, String kommentar)
        {
            tereniDetails.setLblValueOfSportovi(sportovi);
            tereniDetails.setLblValueOfGodOpr(godOpr);
            tereniDetails.setLblValueOfKapacitet(kapacitet);
            tereniDetails.setGbTereniDetailsText(imeTerena);
        }

        private void btnTereni_Click(object sender, EventArgs e)
        {
            stanje = Stanje.DTERENI;
            panelSplitContainer2.Visible = false;
            panelDialog.Visible = true;
            panelDialog.Controls.Clear();
            panelDialog.Controls.Add(dialogTereni);
            panelDialogDetail.Visible = true;
            panelDialogDetail.Controls.Clear();
            panelDialogDetail.Controls.Add(dialogTereniDetails);
            dialogTereni.loadTableData("");
            panelSomeInformation.Visible = false;
        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            stanje = Stanje.DTIMOVI;
            panelSplitContainer2.Visible = false;
            panelDialog.Visible = true;
            panelDialog.Controls.Clear();
            panelDialog.Controls.Add(dialogTimovi);
            panelDialogDetail.Visible = true;
            panelDialogDetail.Controls.Clear();
            panelDialogDetail.Controls.Add(dialogTimoviDetails);
            dialogTimovi.loadTableData("");
            panelSomeInformation.Visible = false;
        }

        private void btnSportisti_Click(object sender, EventArgs e)
        {
            stanje = Stanje.DSPORTISTI;
            panelSplitContainer2.Visible = false;
            panelDialog.Visible = true;
            panelDialog.Controls.Clear();
            panelDialog.Controls.Add(dialogSportisti);
            panelDialogDetail.Visible = true;
            panelDialogDetail.Controls.Clear();
            panelDialogDetail.Controls.Add(dialogSportistidetails);
            dialogSportisti.loadTableData("");
            panelSomeInformation.Visible = false;
        }

        private void btnSportovi_Click(object sender, EventArgs e)
        {
            stanje = Stanje.DSPORTOVI;
            panelSplitContainer2.Visible = false;
            panelDialog.Visible = true;
            panelDialog.Controls.Clear();
            panelDialog.Controls.Add(dialogSportovi);
            panelDialogDetail.Visible = true;
            panelDialogDetail.Controls.Clear();
            panelDialogDetail.Controls.Add(dialogSportoviDetails);
            dialogSportovi.loadTableData("");
            panelSomeInformation.Visible = false;
        }

        private void btnIstorija_Click(object sender, EventArgs e)
        {
            paintIstorijaZauzetosti("");
        }

        public void paintIstorijaZauzetosti(string teren)
        {
            ZauzimanjeTerena.getInstance.loadTableDataWithFilter(teren);
            dialogZauzimanjeTerena.TrenutniTeren = teren;
            stanje = Stanje.DISTORIJAZAUZIMANJA;
            panelSplitContainer2.Visible = false;
            panelDialog.Visible = true;
            panelDialog.Controls.Clear();
            panelDialog.Controls.Add(dialogZauzimanjeTerena);
            System.Diagnostics.Debug.WriteLine(teren);
            panelDialogDetail.Visible = true;
            panelDialogDetail.Controls.Clear();
            panelDialogDetail.Controls.Add(dialogZauzimanjeDetails);
            panelSomeInformation.Visible = false;
        }

        private void lbTimovi_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbTimovi.Items.Count > 0 && lbTimovi.SelectedItems.Count > 0)
            {
                lbTimovi.DoDragDrop(lbTimovi.SelectedItem.ToString(), DragDropEffects.Move);

                panelTimoviDetails.Controls.Clear();
                panelTimoviDetails.Controls.Add(timoviDetails);
                //Tim temp;
                foreach (KeyValuePair<Guid, Tim> temp in TimoviCollection.Timovi_collection)
                {
                    if (lbTimovi.SelectedItem != null)
                    {
                        if (temp.Value.Ime.Equals(lbTimovi.SelectedItem.ToString()))
                        {
                            timoviDetails.setLblValueOfSport(temp.Value.Sport.ImeSporta.ToString());
                            timoviDetails.seLblValueOfBrSportista(temp.Value.BrSportista.ToString());
                            timoviDetails.setTbKommentar(temp.Value.Kommentar.ToString());
                        }
                    }
                }
            }
        }

        public void setListBox(String temp)
        {
            lbTimovi.Items.Add(temp.ToString());
        }

        public void removeListBoxItem(String temp)
        {
            lbTimovi.Items.Remove(temp);
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            if (stanje == Stanje.UCHALE)
            {
                for (int i = UserControlHale.ImenaHale.Length -1; i >= 0; i--)
                {
                    System.Diagnostics.Debug.WriteLine(i);
                    if (UserControlHale.ImenaHale[i].Contains(tbPretraga.Text))
                    {
                        UserControlHale.PanelToBeShowBySearch[i] = true;
                    }
                    else
                    {
                        UserControlHale.PanelToBeShowBySearch[i] = false;
                    }
                }
                UserControlHale.searchHale();
            }
            if (stanje == Stanje.UCTERENI)
            {
                for (int i = UserControlTereni[currentHala].ImenaTerena.Length-1; i >= 0; i--)
                {
                    if (UserControlTereni[currentHala].ImenaTerena[i].Contains(tbPretraga.Text))
                    {
                        UserControlTereni[currentHala].PanelToBeShowBySearch[i] = true;
                    }
                    else
                    {
                        UserControlTereni[currentHala].PanelToBeShowBySearch[i] = false;
                    }
                }
                UserControlTereni[currentHala].searchTereni();

            }
        }


        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////
        private void btnNazad_MouseEnter(object sender, EventArgs e)
        {
            btnNazad.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Pregled i eviedencija zauzetosti terena";
        }

        private void btnNazad_MouseLeave(object sender, EventArgs e)
        {
            btnNazad.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnTereni_MouseEnter(object sender, EventArgs e)
        {
            btnTereni.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Dodavanje, izmena i brisanje terena";
        }

        private void btnTereni_MouseLeave(object sender, EventArgs e)
        {
            btnTereni.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnTimovi_MouseEnter(object sender, EventArgs e)
        {
            btnTimovi.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Dodavanje, izmena i brisanje timova";
        }

        private void btnTimovi_MouseLeave(object sender, EventArgs e)
        {
            btnTimovi.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnSportisti_MouseEnter(object sender, EventArgs e)
        {
            btnSportisti.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Dodavanje, izmena i brisanje sportista";
        }

        private void btnSportisti_MouseLeave(object sender, EventArgs e)
        {
            btnSportisti.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnSportovi_MouseEnter(object sender, EventArgs e)
        {
            btnSportovi.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Dodavanje, izmena i brisanje sportova";
        }

        private void btnSportovi_MouseLeave(object sender, EventArgs e)
        {
            btnSportovi.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnIstorija_MouseEnter(object sender, EventArgs e)
        {
            btnIstorija.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Pregled istorije zauzetosti terena";
        }

        private void btnIstorija_MouseLeave(object sender, EventArgs e)
        {
            btnIstorija.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void btnHelp_MouseEnter(object sender, EventArgs e)
        {
            btnHelp.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
            lblStatusBar.Text = "Pomoćna dokumentacija";
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
            lblStatusBar.Text = "";
        }

        private void tbPretraga_MouseEnter(object sender, EventArgs e)
        {
            if(stanje == Stanje.UCHALE)
                lblStatusBar.Text = "Pretraga hale";
            if (stanje == Stanje.UCTERENI)
                lblStatusBar.Text = "Pretraga terena";
        }

        private void tbPretraga_MouseLeave(object sender, EventArgs e)
        {
            lblStatusBar.Text = "";
        }
        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////


        public void setLblStatusBar(string param)
        {
            lblStatusBar.Text = param;
        }

        public string getLblStatusBar()
        {
            return lblStatusBar.Text;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hale_Collection.getInstance.save();
            Sportiste_Collection.getInstance.save();
            Sportovi_Collection.getInstance.save();
            Tereni_Collection.getInstance.save();
            Timovi_Collection.getInstance.save();

            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\help\\help.chm");
        }

        private void btnNazad_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (panelView.Controls.Contains(UserControlHale))
            {
                Help.ShowHelp(this, "..\\..\\help\\help.chm", HelpNavigator.KeywordIndex, "Glavni prozor aplikacije");
            }
            if (panelView.Controls.Contains(UserControlTereni[currentHala]))
            {
                Help.ShowHelp(this, "..\\..\\help\\help.chm", HelpNavigator.KeywordIndex, "Hala");
            }
        }
    }
}
