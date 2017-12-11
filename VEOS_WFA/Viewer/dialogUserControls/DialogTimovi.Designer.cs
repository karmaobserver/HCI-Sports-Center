namespace VEOS_WFA.Viewer.dialogUserControls
{
    partial class DialogTimovi
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
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBrojSportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKomentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.gbTimovi = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.gbTimovi.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clIme,
            this.clBrojSportista,
            this.clSport,
            this.clKomentar});
            this.dgvTimovi.Location = new System.Drawing.Point(6, 55);
            this.dgvTimovi.MultiSelect = false;
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.ReadOnly = true;
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(557, 234);
            this.dgvTimovi.TabIndex = 1;
            this.dgvTimovi.SelectionChanged += new System.EventHandler(this.dgvTimovi_SelectionChanged);
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Šifra";
            this.clSifra.Name = "clSifra";
            this.clSifra.ReadOnly = true;
            // 
            // clIme
            // 
            this.clIme.HeaderText = "Ime";
            this.clIme.Name = "clIme";
            this.clIme.ReadOnly = true;
            // 
            // clBrojSportista
            // 
            this.clBrojSportista.HeaderText = "Broj Sportista";
            this.clBrojSportista.Name = "clBrojSportista";
            this.clBrojSportista.ReadOnly = true;
            this.clBrojSportista.Width = 150;
            // 
            // clSport
            // 
            this.clSport.HeaderText = "Sport";
            this.clSport.Name = "clSport";
            this.clSport.ReadOnly = true;
            // 
            // clKomentar
            // 
            this.clKomentar.HeaderText = "Komentar";
            this.clKomentar.Name = "clKomentar";
            this.clKomentar.ReadOnly = true;
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
            this.toolTip1.SetToolTip(this.btnBrisanje, "Brisanje selektovanog tima");
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
            this.btnDodavanje.TabIndex = 6;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDodavanje, "Dodavanje novog tima u tabelu");
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            this.btnDodavanje.MouseEnter += new System.EventHandler(this.btnDodavanje_MouseEnter);
            this.btnDodavanje.MouseLeave += new System.EventHandler(this.btnDodavanje_MouseLeave);
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
            this.toolTip1.SetToolTip(this.btnIzmena, "Izmena podataka o selektovanom  timu");
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            this.btnIzmena.MouseEnter += new System.EventHandler(this.btnIzmena_MouseEnter);
            this.btnIzmena.MouseLeave += new System.EventHandler(this.btnIzmena_MouseLeave);
            // 
            // gbTimovi
            // 
            this.gbTimovi.Controls.Add(this.panelButtons);
            this.gbTimovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimovi.Location = new System.Drawing.Point(3, 3);
            this.gbTimovi.Name = "gbTimovi";
            this.gbTimovi.Size = new System.Drawing.Size(569, 307);
            this.gbTimovi.TabIndex = 9;
            this.gbTimovi.TabStop = false;
            this.gbTimovi.Text = "Timovi";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnDodavanje);
            this.panelButtons.Controls.Add(this.dgvTimovi);
            this.panelButtons.Controls.Add(this.btnBrisanje);
            this.panelButtons.Controls.Add(this.btnIzmena);
            this.helpProvider1.SetHelpKeyword(this.panelButtons, "Evidencija timova");
            this.helpProvider1.SetHelpNavigator(this.panelButtons, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panelButtons.Location = new System.Drawing.Point(0, 12);
            this.panelButtons.Name = "panelButtons";
            this.helpProvider1.SetShowHelp(this.panelButtons, true);
            this.panelButtons.Size = new System.Drawing.Size(569, 295);
            this.panelButtons.TabIndex = 9;
            this.panelButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButtons_MouseMove);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DialogTimovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTimovi);
            this.DoubleBuffered = true;
            this.Name = "DialogTimovi";
            this.Size = new System.Drawing.Size(575, 310);
            this.Load += new System.EventHandler(this.DialogTimovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.gbTimovi.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.GroupBox gbTimovi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojSportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKomentar;
    }
}
