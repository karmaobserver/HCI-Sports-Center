namespace VEOS_WFA.Viewer.dialogUserControls
{
    partial class DialogSportisti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSportisti));
            this.dgvSportisti = new System.Windows.Forms.DataGridView();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clJmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGodinaUpisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSportisti = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportisti)).BeginInit();
            this.gbSportisti.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSportisti
            // 
            this.dgvSportisti.AllowUserToAddRows = false;
            this.dgvSportisti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportisti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clPrezime,
            this.clIme,
            this.clJmbg,
            this.clKlasa,
            this.clSport,
            this.clGodinaUpisa});
            this.dgvSportisti.Location = new System.Drawing.Point(6, 55);
            this.dgvSportisti.MultiSelect = false;
            this.dgvSportisti.Name = "dgvSportisti";
            this.dgvSportisti.ReadOnly = true;
            this.dgvSportisti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportisti.Size = new System.Drawing.Size(557, 234);
            this.dgvSportisti.TabIndex = 1;
            this.dgvSportisti.SelectionChanged += new System.EventHandler(this.dgvSportisti_SelectionChanged);
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Šifra";
            this.clSifra.Name = "clSifra";
            this.clSifra.ReadOnly = true;
            this.clSifra.Width = 40;
            // 
            // clPrezime
            // 
            this.clPrezime.HeaderText = "Prezime";
            this.clPrezime.Name = "clPrezime";
            this.clPrezime.ReadOnly = true;
            this.clPrezime.Width = 80;
            // 
            // clIme
            // 
            this.clIme.HeaderText = "Ime";
            this.clIme.Name = "clIme";
            this.clIme.ReadOnly = true;
            this.clIme.Width = 80;
            // 
            // clJmbg
            // 
            this.clJmbg.HeaderText = "JMBG";
            this.clJmbg.Name = "clJmbg";
            this.clJmbg.ReadOnly = true;
            // 
            // clKlasa
            // 
            this.clKlasa.HeaderText = "Klasa";
            this.clKlasa.Name = "clKlasa";
            this.clKlasa.ReadOnly = true;
            this.clKlasa.Width = 50;
            // 
            // clSport
            // 
            this.clSport.HeaderText = "Sport";
            this.clSport.Name = "clSport";
            this.clSport.ReadOnly = true;
            this.clSport.Width = 50;
            // 
            // clGodinaUpisa
            // 
            this.clGodinaUpisa.HeaderText = "Godina Upisa";
            this.clGodinaUpisa.Name = "clGodinaUpisa";
            this.clGodinaUpisa.ReadOnly = true;
            this.clGodinaUpisa.Width = 110;
            // 
            // gbSportisti
            // 
            this.gbSportisti.Controls.Add(this.panelButtons);
            this.gbSportisti.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSportisti.Location = new System.Drawing.Point(3, 3);
            this.gbSportisti.Name = "gbSportisti";
            this.gbSportisti.Size = new System.Drawing.Size(569, 307);
            this.gbSportisti.TabIndex = 9;
            this.gbSportisti.TabStop = false;
            this.gbSportisti.Text = "Sportisti";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDodavanje);
            this.panelButtons.Controls.Add(this.dgvSportisti);
            this.panelButtons.Controls.Add(this.btnBrisanje);
            this.panelButtons.Controls.Add(this.btnIzmena);
            this.helpProvider1.SetHelpKeyword(this.panelButtons, "Evidencija Sportista");
            this.helpProvider1.SetHelpNavigator(this.panelButtons, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panelButtons.Location = new System.Drawing.Point(0, 12);
            this.panelButtons.Name = "panelButtons";
            this.helpProvider1.SetShowHelp(this.panelButtons, true);
            this.panelButtons.Size = new System.Drawing.Size(569, 295);
            this.panelButtons.TabIndex = 9;
            this.panelButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButtons_MouseMove);
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodavanje.BackgroundImage")));
            this.btnDodavanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodavanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodavanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanje.Image = global::VEOS_WFA.Properties.Resources.dodavanje;
            this.btnDodavanje.Location = new System.Drawing.Point(6, 9);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(138, 40);
            this.btnDodavanje.TabIndex = 6;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDodavanje, "Dodavanje novog sportiste u tabelu");
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            this.btnDodavanje.MouseEnter += new System.EventHandler(this.btnDodavanje_MouseEnter);
            this.btnDodavanje.MouseLeave += new System.EventHandler(this.btnDodavanje_MouseLeave);
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
            this.btnBrisanje.TabIndex = 8;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBrisanje, "Brisanje selektovanog sportiste");
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            this.btnBrisanje.MouseEnter += new System.EventHandler(this.btnBrisanje_MouseEnter);
            this.btnBrisanje.MouseLeave += new System.EventHandler(this.btnBrisanje_MouseLeave);
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
            this.btnIzmena.TabIndex = 7;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnIzmena, "Izmena podataka o selektovanom  sportiste");
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            this.btnIzmena.MouseEnter += new System.EventHandler(this.btnIzmena_MouseEnter);
            this.btnIzmena.MouseLeave += new System.EventHandler(this.btnIzmena_MouseLeave);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DialogSportisti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSportisti);
            this.DoubleBuffered = true;
            this.Name = "DialogSportisti";
            this.Size = new System.Drawing.Size(575, 310);
            this.Load += new System.EventHandler(this.DialogSportisti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportisti)).EndInit();
            this.gbSportisti.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSportisti;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.GroupBox gbSportisti;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clJmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGodinaUpisa;
    }
}
