namespace VEOS_WFA.Viewer.dialogUserControls
{
    partial class DialogSportovi
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
            this.dgvSportovi = new System.Windows.Forms.DataGridView();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrefiks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBeleske = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.gbSportovi = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).BeginInit();
            this.gbSportovi.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSportovi
            // 
            this.dgvSportovi.AllowUserToAddRows = false;
            this.dgvSportovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clPrefiks,
            this.clIme,
            this.clBeleske});
            this.dgvSportovi.Location = new System.Drawing.Point(6, 55);
            this.dgvSportovi.MultiSelect = false;
            this.dgvSportovi.Name = "dgvSportovi";
            this.dgvSportovi.ReadOnly = true;
            this.dgvSportovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportovi.Size = new System.Drawing.Size(557, 234);
            this.dgvSportovi.TabIndex = 1;
            this.dgvSportovi.SelectionChanged += new System.EventHandler(this.dgvSportovi_SelectionChanged);
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Šifra";
            this.clSifra.Name = "clSifra";
            this.clSifra.ReadOnly = true;
            // 
            // clPrefiks
            // 
            this.clPrefiks.HeaderText = "Prefiks";
            this.clPrefiks.Name = "clPrefiks";
            this.clPrefiks.ReadOnly = true;
            // 
            // clIme
            // 
            this.clIme.HeaderText = "Ime";
            this.clIme.Name = "clIme";
            this.clIme.ReadOnly = true;
            // 
            // clBeleske
            // 
            this.clBeleske.HeaderText = "Beleške";
            this.clBeleske.Name = "clBeleske";
            this.clBeleske.ReadOnly = true;
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
            this.toolTip1.SetToolTip(this.btnBrisanje, "Brisanje selektovanog sporta");
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
            this.toolTip1.SetToolTip(this.btnIzmena, "Izmena podataka o selektovanom  sportu");
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            this.btnIzmena.MouseEnter += new System.EventHandler(this.btnIzmena_MouseEnter);
            this.btnIzmena.MouseLeave += new System.EventHandler(this.btnIzmena_MouseLeave);
            // 
            // gbSportovi
            // 
            this.gbSportovi.Controls.Add(this.panelButtons);
            this.gbSportovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSportovi.Location = new System.Drawing.Point(3, 3);
            this.gbSportovi.Name = "gbSportovi";
            this.gbSportovi.Size = new System.Drawing.Size(569, 307);
            this.gbSportovi.TabIndex = 9;
            this.gbSportovi.TabStop = false;
            this.gbSportovi.Text = "Sportovi";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnDodavanje);
            this.panelButtons.Controls.Add(this.dgvSportovi);
            this.panelButtons.Controls.Add(this.btnBrisanje);
            this.panelButtons.Controls.Add(this.btnIzmena);
            this.helpProvider1.SetHelpKeyword(this.panelButtons, "Evidencija sportova");
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
            this.toolTip1.SetToolTip(this.btnDodavanje, "Dodavanje novog sporta u tabelu");
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            this.btnDodavanje.MouseEnter += new System.EventHandler(this.btnDodavanje_MouseEnter);
            this.btnDodavanje.MouseLeave += new System.EventHandler(this.btnDodavanje_MouseLeave);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DialogSportovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSportovi);
            this.DoubleBuffered = true;
            this.Name = "DialogSportovi";
            this.Size = new System.Drawing.Size(575, 310);
            this.Load += new System.EventHandler(this.DialogSportovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).EndInit();
            this.gbSportovi.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSportovi;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.GroupBox gbSportovi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrefiks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBeleske;
    }
}
