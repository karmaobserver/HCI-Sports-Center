namespace VEOS_WFA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSportovi = new System.Windows.Forms.Button();
            this.btnSportisti = new System.Windows.Forms.Button();
            this.btnTimovi = new System.Windows.Forms.Button();
            this.btnTereni = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIstorija = new System.Windows.Forms.Button();
            this.panelSplitContainer2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gbPregledTimova = new System.Windows.Forms.GroupBox();
            this.cbSportovi = new System.Windows.Forms.ComboBox();
            this.lbTimovi = new System.Windows.Forms.ListBox();
            this.panelDialog = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.panelSomeInformation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTerenSlobodan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTerenZauzet = new System.Windows.Forms.Label();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.panelTimoviDetails = new System.Windows.Forms.Panel();
            this.panelDialogDetail = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.panelSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.gbPregledTimova.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            this.panelSomeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelSplitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panelDialog);
            this.splitContainer1.Size = new System.Drawing.Size(734, 310);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 100;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnHelp);
            this.gbMenu.Controls.Add(this.btnSportovi);
            this.gbMenu.Controls.Add(this.btnSportisti);
            this.gbMenu.Controls.Add(this.btnTimovi);
            this.gbMenu.Controls.Add(this.btnTereni);
            this.gbMenu.Controls.Add(this.btnNazad);
            this.gbMenu.Controls.Add(this.btnIstorija);
            this.gbMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.Location = new System.Drawing.Point(3, 3);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(150, 307);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Meni:";
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::VEOS_WFA.Properties.Resources.button;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::VEOS_WFA.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(77, 253);
            this.btnHelp.Name = "btnHelp";
            this.helpProvider1.SetShowHelp(this.btnHelp, true);
            this.btnHelp.Size = new System.Drawing.Size(67, 40);
            this.btnHelp.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnHelp, "Pomoć");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.btnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            // 
            // btnSportovi
            // 
            this.btnSportovi.BackColor = System.Drawing.Color.Transparent;
            this.btnSportovi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSportovi.BackgroundImage")));
            this.btnSportovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSportovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSportovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSportovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnSportovi, "Evidencija sportova");
            this.helpProvider1.SetHelpNavigator(this.btnSportovi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnSportovi.Image = global::VEOS_WFA.Properties.Resources.sport2;
            this.btnSportovi.Location = new System.Drawing.Point(6, 207);
            this.btnSportovi.Name = "btnSportovi";
            this.helpProvider1.SetShowHelp(this.btnSportovi, true);
            this.btnSportovi.Size = new System.Drawing.Size(138, 40);
            this.btnSportovi.TabIndex = 5;
            this.btnSportovi.Text = "Sportovi";
            this.btnSportovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSportovi, "Evidencija sportova");
            this.btnSportovi.UseVisualStyleBackColor = false;
            this.btnSportovi.Click += new System.EventHandler(this.btnSportovi_Click);
            this.btnSportovi.MouseEnter += new System.EventHandler(this.btnSportovi_MouseEnter);
            this.btnSportovi.MouseLeave += new System.EventHandler(this.btnSportovi_MouseLeave);
            // 
            // btnSportisti
            // 
            this.btnSportisti.BackColor = System.Drawing.Color.Transparent;
            this.btnSportisti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSportisti.BackgroundImage")));
            this.btnSportisti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSportisti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSportisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSportisti.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnSportisti, "Evidencija Sportista");
            this.helpProvider1.SetHelpNavigator(this.btnSportisti, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnSportisti.Image = global::VEOS_WFA.Properties.Resources.sportisti;
            this.btnSportisti.Location = new System.Drawing.Point(6, 161);
            this.btnSportisti.Name = "btnSportisti";
            this.helpProvider1.SetShowHelp(this.btnSportisti, true);
            this.btnSportisti.Size = new System.Drawing.Size(138, 40);
            this.btnSportisti.TabIndex = 4;
            this.btnSportisti.Text = "Sportisti";
            this.btnSportisti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSportisti, "Evidencija sportista");
            this.btnSportisti.UseVisualStyleBackColor = false;
            this.btnSportisti.Click += new System.EventHandler(this.btnSportisti_Click);
            this.btnSportisti.MouseEnter += new System.EventHandler(this.btnSportisti_MouseEnter);
            this.btnSportisti.MouseLeave += new System.EventHandler(this.btnSportisti_MouseLeave);
            // 
            // btnTimovi
            // 
            this.btnTimovi.BackColor = System.Drawing.Color.Transparent;
            this.btnTimovi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimovi.BackgroundImage")));
            this.btnTimovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTimovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnTimovi, "Evidencija timova");
            this.helpProvider1.SetHelpNavigator(this.btnTimovi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnTimovi.Image = global::VEOS_WFA.Properties.Resources.tim2;
            this.btnTimovi.Location = new System.Drawing.Point(6, 115);
            this.btnTimovi.Name = "btnTimovi";
            this.helpProvider1.SetShowHelp(this.btnTimovi, true);
            this.btnTimovi.Size = new System.Drawing.Size(138, 40);
            this.btnTimovi.TabIndex = 3;
            this.btnTimovi.Text = "Timovi";
            this.btnTimovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnTimovi, "Evidencija timova");
            this.btnTimovi.UseVisualStyleBackColor = false;
            this.btnTimovi.Click += new System.EventHandler(this.btnTimovi_Click);
            this.btnTimovi.MouseEnter += new System.EventHandler(this.btnTimovi_MouseEnter);
            this.btnTimovi.MouseLeave += new System.EventHandler(this.btnTimovi_MouseLeave);
            // 
            // btnTereni
            // 
            this.btnTereni.BackColor = System.Drawing.Color.Transparent;
            this.btnTereni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTereni.BackgroundImage")));
            this.btnTereni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTereni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTereni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTereni.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnTereni, "Evidencija terena");
            this.helpProvider1.SetHelpNavigator(this.btnTereni, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnTereni.Image = global::VEOS_WFA.Properties.Resources.terenGlav2;
            this.btnTereni.Location = new System.Drawing.Point(6, 69);
            this.btnTereni.Name = "btnTereni";
            this.helpProvider1.SetShowHelp(this.btnTereni, true);
            this.btnTereni.Size = new System.Drawing.Size(138, 40);
            this.btnTereni.TabIndex = 2;
            this.btnTereni.Text = "Tereni";
            this.btnTereni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnTereni, "Evidencija terena");
            this.btnTereni.UseVisualStyleBackColor = false;
            this.btnTereni.Click += new System.EventHandler(this.btnTereni_Click);
            this.btnTereni.MouseEnter += new System.EventHandler(this.btnTereni_MouseEnter);
            this.btnTereni.MouseLeave += new System.EventHandler(this.btnTereni_MouseLeave);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Transparent;
            this.btnNazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNazad.BackgroundImage")));
            this.btnNazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnNazad, "");
            this.helpProvider1.SetHelpNavigator(this.btnNazad, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnNazad.Image = global::VEOS_WFA.Properties.Resources.start;
            this.btnNazad.Location = new System.Drawing.Point(6, 21);
            this.btnNazad.Name = "btnNazad";
            this.helpProvider1.SetShowHelp(this.btnNazad, true);
            this.btnNazad.Size = new System.Drawing.Size(138, 40);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Start";
            this.btnNazad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNazad, "Pregled i evidencija zauzetosti terena");
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            this.btnNazad.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnNazad_HelpRequested);
            this.btnNazad.MouseEnter += new System.EventHandler(this.btnNazad_MouseEnter);
            this.btnNazad.MouseLeave += new System.EventHandler(this.btnNazad_MouseLeave);
            // 
            // btnIstorija
            // 
            this.btnIstorija.BackColor = System.Drawing.Color.Transparent;
            this.btnIstorija.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIstorija.BackgroundImage")));
            this.btnIstorija.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIstorija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIstorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstorija.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.btnIstorija, "Istorija Zauzetosti");
            this.helpProvider1.SetHelpNavigator(this.btnIstorija, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnIstorija.Image = global::VEOS_WFA.Properties.Resources.history;
            this.btnIstorija.Location = new System.Drawing.Point(6, 253);
            this.btnIstorija.Name = "btnIstorija";
            this.helpProvider1.SetShowHelp(this.btnIstorija, true);
            this.btnIstorija.Size = new System.Drawing.Size(65, 40);
            this.btnIstorija.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnIstorija, "Istorija zauzetosti terena");
            this.btnIstorija.UseVisualStyleBackColor = false;
            this.btnIstorija.Click += new System.EventHandler(this.btnIstorija_Click);
            this.btnIstorija.MouseEnter += new System.EventHandler(this.btnIstorija_MouseEnter);
            this.btnIstorija.MouseLeave += new System.EventHandler(this.btnIstorija_MouseLeave);
            // 
            // panelSplitContainer2
            // 
            this.panelSplitContainer2.Controls.Add(this.splitContainer2);
            this.panelSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.panelSplitContainer2.Name = "panelSplitContainer2";
            this.panelSplitContainer2.Size = new System.Drawing.Size(575, 310);
            this.panelSplitContainer2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelCenter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelLeft);
            this.splitContainer2.Size = new System.Drawing.Size(575, 310);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 100;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.lblPretraga);
            this.panelCenter.Controls.Add(this.lblStatus);
            this.panelCenter.Controls.Add(this.tbPretraga);
            this.panelCenter.Controls.Add(this.panelView);
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(376, 310);
            this.panelCenter.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(205, 5);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(57, 15);
            this.lblPretraga.TabIndex = 3;
            this.lblPretraga.Text = "Pretraga:";
            this.toolTip1.SetToolTip(this.lblPretraga, "Filtriranje po imenu hale ili terena u zavisnosti sta je prikazano");
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Sportski centar >";
            this.toolTip1.SetToolTip(this.lblStatus, "Prikaz putanje gde se trenutno nalazite");
            // 
            // tbPretraga
            // 
            this.tbPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this.tbPretraga, "Glavni prozor aplikacije");
            this.helpProvider1.SetHelpNavigator(this.tbPretraga, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tbPretraga.Location = new System.Drawing.Point(268, 4);
            this.tbPretraga.Name = "tbPretraga";
            this.helpProvider1.SetShowHelp(this.tbPretraga, true);
            this.tbPretraga.Size = new System.Drawing.Size(100, 20);
            this.tbPretraga.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbPretraga, "Unesite ime po kom zelite da filtrirate");
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            this.tbPretraga.MouseEnter += new System.EventHandler(this.tbPretraga_MouseEnter);
            this.tbPretraga.MouseLeave += new System.EventHandler(this.tbPretraga_MouseLeave);
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(3, 27);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(369, 277);
            this.panelView.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.gbPregledTimova);
            this.panelLeft.Location = new System.Drawing.Point(-1, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(197, 310);
            this.panelLeft.TabIndex = 1;
            // 
            // gbPregledTimova
            // 
            this.gbPregledTimova.Controls.Add(this.cbSportovi);
            this.gbPregledTimova.Controls.Add(this.lbTimovi);
            this.gbPregledTimova.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPregledTimova.Location = new System.Drawing.Point(3, 3);
            this.gbPregledTimova.Name = "gbPregledTimova";
            this.gbPregledTimova.Size = new System.Drawing.Size(189, 307);
            this.gbPregledTimova.TabIndex = 0;
            this.gbPregledTimova.TabStop = false;
            this.gbPregledTimova.Text = "Pregled slobodnih timova:";
            // 
            // cbSportovi
            // 
            this.cbSportovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSportovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSportovi.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.cbSportovi, "Zauzimanje terena");
            this.helpProvider1.SetHelpNavigator(this.cbSportovi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.cbSportovi.Location = new System.Drawing.Point(6, 21);
            this.cbSportovi.Name = "cbSportovi";
            this.helpProvider1.SetShowHelp(this.cbSportovi, true);
            this.cbSportovi.Size = new System.Drawing.Size(175, 23);
            this.cbSportovi.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cbSportovi, "Filtriranje timova prema odabranom sportu");
            this.cbSportovi.SelectedValueChanged += new System.EventHandler(this.cbSportovi_SelectedValueChanged);
            // 
            // lbTimovi
            // 
            this.lbTimovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimovi.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.lbTimovi, "Zauzimanje terena");
            this.helpProvider1.SetHelpNavigator(this.lbTimovi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.lbTimovi.ItemHeight = 15;
            this.lbTimovi.Location = new System.Drawing.Point(6, 51);
            this.lbTimovi.Name = "lbTimovi";
            this.helpProvider1.SetShowHelp(this.lbTimovi, true);
            this.lbTimovi.Size = new System.Drawing.Size(175, 244);
            this.lbTimovi.TabIndex = 10;
            this.toolTip1.SetToolTip(this.lbTimovi, "Selektujte tim, zatim ga prevucite na slobodan teren koji želite da zauzmete");
            this.lbTimovi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTimovi_MouseDown);
            // 
            // panelDialog
            // 
            this.panelDialog.Location = new System.Drawing.Point(0, 0);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new System.Drawing.Size(575, 310);
            this.panelDialog.TabIndex = 2;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelDetail.Location = new System.Drawing.Point(0, 310);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(367, 64);
            this.panelDetail.TabIndex = 1;
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.BackColor = System.Drawing.Color.Transparent;
            this.panelStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatusBar.Controls.Add(this.panelSomeInformation);
            this.panelStatusBar.Controls.Add(this.lblStatusBar);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusBar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStatusBar.Location = new System.Drawing.Point(0, 373);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(734, 19);
            this.panelStatusBar.TabIndex = 2;
            // 
            // panelSomeInformation
            // 
            this.panelSomeInformation.Controls.Add(this.panel1);
            this.panelSomeInformation.Controls.Add(this.lblTerenSlobodan);
            this.panelSomeInformation.Controls.Add(this.panel2);
            this.panelSomeInformation.Controls.Add(this.lblTerenZauzet);
            this.panelSomeInformation.Location = new System.Drawing.Point(450, -2);
            this.panelSomeInformation.Name = "panelSomeInformation";
            this.panelSomeInformation.Size = new System.Drawing.Size(283, 21);
            this.panelSomeInformation.TabIndex = 5;
            this.panelSomeInformation.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VEOS_WFA.Properties.Resources.panelSlobodan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.panel1, "Ako je okvir terena zelene boje, teren je slobodan");
            // 
            // lblTerenSlobodan
            // 
            this.lblTerenSlobodan.AutoSize = true;
            this.lblTerenSlobodan.Location = new System.Drawing.Point(24, 3);
            this.lblTerenSlobodan.Name = "lblTerenSlobodan";
            this.lblTerenSlobodan.Size = new System.Drawing.Size(110, 15);
            this.lblTerenSlobodan.TabIndex = 4;
            this.lblTerenSlobodan.Text = "- teren je slobodan";
            this.toolTip1.SetToolTip(this.lblTerenSlobodan, "Ako je okvir terena zelene boje, teren je slobodan");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::VEOS_WFA.Properties.Resources.panelZauzet;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(168, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.panel2, "Ako je okvir terena crvene boje, teren je zauzet");
            // 
            // lblTerenZauzet
            // 
            this.lblTerenZauzet.AutoSize = true;
            this.lblTerenZauzet.Location = new System.Drawing.Point(189, 3);
            this.lblTerenZauzet.Name = "lblTerenZauzet";
            this.lblTerenZauzet.Size = new System.Drawing.Size(92, 15);
            this.lblTerenZauzet.TabIndex = 3;
            this.lblTerenZauzet.Text = "- teren je zauzet";
            this.toolTip1.SetToolTip(this.lblTerenZauzet, "Ako je okvir terena crvene boje, teren je zauzet");
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(5, 1);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(40, 15);
            this.lblStatusBar.TabIndex = 0;
            this.lblStatusBar.Text = "Ready";
            // 
            // panelTimoviDetails
            // 
            this.panelTimoviDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelTimoviDetails.Location = new System.Drawing.Point(367, 310);
            this.panelTimoviDetails.Name = "panelTimoviDetails";
            this.panelTimoviDetails.Size = new System.Drawing.Size(367, 64);
            this.panelTimoviDetails.TabIndex = 2;
            // 
            // panelDialogDetail
            // 
            this.panelDialogDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelDialogDetail.Location = new System.Drawing.Point(0, 310);
            this.panelDialogDetail.Name = "panelDialogDetail";
            this.panelDialogDetail.Size = new System.Drawing.Size(734, 64);
            this.panelDialogDetail.TabIndex = 2;
            this.panelDialogDetail.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VEOS_WFA.Properties.Resources.home_screen_2_jpg;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.panelStatusBar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelDialogDetail);
            this.Controls.Add(this.panelTimoviDetails);
            this.Controls.Add(this.panelDetail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sportski Centar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.panelSplitContainer2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.gbPregledTimova.ResumeLayout(false);
            this.panelStatusBar.ResumeLayout(false);
            this.panelStatusBar.PerformLayout();
            this.panelSomeInformation.ResumeLayout(false);
            this.panelSomeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnIstorija;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbPregledTimova;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnSportovi;
        private System.Windows.Forms.Button btnSportisti;
        private System.Windows.Forms.Button btnTimovi;
        private System.Windows.Forms.Button btnTereni;
        private System.Windows.Forms.ListBox lbTimovi;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSplitContainer2;
        private System.Windows.Forms.Panel panelDialog;
        private System.Windows.Forms.Panel panelStatusBar;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.Panel panelTimoviDetails;
        private System.Windows.Forms.Panel panelDialogDetail;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTerenSlobodan;
        private System.Windows.Forms.Label lblTerenZauzet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSomeInformation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cbSportovi;
        private System.Windows.Forms.HelpProvider helpProvider1;



    }
}

