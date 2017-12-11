namespace VEOS_WFA.Viewer.dialogUserControls
{
    partial class DialogTereni
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTereni = new System.Windows.Forms.DataGridView();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGodinaOpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSportovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clZauzetost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKommentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTereni = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).BeginInit();
            this.gbTereni.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTereni
            // 
            this.dgvTereni.AllowUserToAddRows = false;
            this.dgvTereni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTereni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clIme,
            this.clLokacija,
            this.clGodinaOpr,
            this.clSportovi,
            this.clKapacitet,
            this.clStatus,
            this.clZauzetost,
            this.clKommentar});
            this.dgvTereni.Location = new System.Drawing.Point(6, 55);
            this.dgvTereni.MultiSelect = false;
            this.dgvTereni.Name = "dgvTereni";
            this.dgvTereni.ReadOnly = true;
            this.dgvTereni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTereni.Size = new System.Drawing.Size(557, 234);
            this.dgvTereni.TabIndex = 1;
            this.dgvTereni.SelectionChanged += new System.EventHandler(this.dgvTereni_SelectionChanged);
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Šifra";
            this.clSifra.Name = "clSifra";
            this.clSifra.ReadOnly = true;
            this.clSifra.Width = 40;
            // 
            // clIme
            // 
            this.clIme.HeaderText = "Ime";
            this.clIme.Name = "clIme";
            this.clIme.ReadOnly = true;
            this.clIme.Width = 60;
            // 
            // clLokacija
            // 
            this.clLokacija.HeaderText = "Lokacija";
            this.clLokacija.Name = "clLokacija";
            this.clLokacija.ReadOnly = true;
            this.clLokacija.Width = 70;
            // 
            // clGodinaOpr
            // 
            this.clGodinaOpr.HeaderText = "Godina opremljenja";
            this.clGodinaOpr.Name = "clGodinaOpr";
            this.clGodinaOpr.ReadOnly = true;
            this.clGodinaOpr.Width = 60;
            // 
            // clSportovi
            // 
            this.clSportovi.HeaderText = "Sportovi";
            this.clSportovi.Name = "clSportovi";
            this.clSportovi.ReadOnly = true;
            // 
            // clKapacitet
            // 
            this.clKapacitet.HeaderText = "Kapacitet";
            this.clKapacitet.Name = "clKapacitet";
            this.clKapacitet.ReadOnly = true;
            this.clKapacitet.Width = 50;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Status";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            this.clStatus.Width = 50;
            // 
            // clZauzetost
            // 
            this.clZauzetost.HeaderText = "Zauzetost";
            this.clZauzetost.Name = "clZauzetost";
            this.clZauzetost.ReadOnly = true;
            // 
            // clKommentar
            // 
            this.clKommentar.HeaderText = "Kommentar";
            this.clKommentar.Name = "clKommentar";
            this.clKommentar.ReadOnly = true;
            this.clKommentar.Width = 80;
            // 
            // gbTereni
            // 
            this.gbTereni.Controls.Add(this.panelButtons);
            this.gbTereni.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTereni.Location = new System.Drawing.Point(3, 3);
            this.gbTereni.Name = "gbTereni";
            this.gbTereni.Size = new System.Drawing.Size(569, 307);
            this.gbTereni.TabIndex = 6;
            this.gbTereni.TabStop = false;
            this.gbTereni.Text = "Tereni";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnIzmena);
            this.panelButtons.Controls.Add(this.dgvTereni);
            this.panelButtons.Controls.Add(this.btnBrisanje);
            this.panelButtons.Controls.Add(this.btnDodavanje);
            this.helpProvider1.SetHelpKeyword(this.panelButtons, "Evidencija terena");
            this.helpProvider1.SetHelpNavigator(this.panelButtons, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panelButtons.Location = new System.Drawing.Point(0, 12);
            this.panelButtons.Name = "panelButtons";
            this.helpProvider1.SetShowHelp(this.panelButtons, true);
            this.panelButtons.Size = new System.Drawing.Size(569, 295);
            this.panelButtons.TabIndex = 6;
            this.panelButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButtons_MouseMove);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Enabled = false;
            this.btnIzmena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzmena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmena.Image = global::VEOS_WFA.Properties.Resources.table_refresh;
            this.btnIzmena.Location = new System.Drawing.Point(150, 9);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(138, 40);
            this.btnIzmena.TabIndex = 4;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnIzmena, "Izmena podataka o selektovanom  terenu");
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            this.btnIzmena.MouseEnter += new System.EventHandler(this.btnIzmena_MouseEnter);
            this.btnIzmena.MouseLeave += new System.EventHandler(this.btnIzmena_MouseLeave);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Enabled = false;
            this.btnBrisanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrisanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanje.Image = global::VEOS_WFA.Properties.Resources.brisanje;
            this.btnBrisanje.Location = new System.Drawing.Point(294, 9);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(138, 40);
            this.btnBrisanje.TabIndex = 5;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBrisanje, "Brisanje selektovanog terena");
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            this.btnBrisanje.MouseEnter += new System.EventHandler(this.btnBrisanje_MouseEnter);
            this.btnBrisanje.MouseLeave += new System.EventHandler(this.btnBrisanje_MouseLeave);
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.BackgroundImage = global::VEOS_WFA.Properties.Resources.button;
            this.btnDodavanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodavanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodavanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanje.Image = global::VEOS_WFA.Properties.Resources.dodavanje;
            this.btnDodavanje.Location = new System.Drawing.Point(6, 9);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(138, 40);
            this.btnDodavanje.TabIndex = 3;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDodavanje, "Dodavanje novog terena u tabelu");
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            this.btnDodavanje.MouseEnter += new System.EventHandler(this.btnDodavanje_MouseEnter);
            this.btnDodavanje.MouseLeave += new System.EventHandler(this.btnDodavanje_MouseLeave);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DialogTereni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTereni);
            this.DoubleBuffered = true;
            this.Name = "DialogTereni";
            this.Size = new System.Drawing.Size(575, 310);
            this.Load += new System.EventHandler(this.DialogTereni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).EndInit();
            this.gbTereni.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTereni;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.GroupBox gbTereni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGodinaOpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSportovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKapacitet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clZauzetost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKommentar;
    }
}
