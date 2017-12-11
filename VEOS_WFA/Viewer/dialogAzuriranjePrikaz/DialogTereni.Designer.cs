namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTereni = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblValueOfKapacitet = new System.Windows.Forms.Label();
            this.lblValueOfSportovi = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblSportovi = new System.Windows.Forms.Label();
            this.lblValueOfGodinaOpremljenja = new System.Windows.Forms.Label();
            this.lblValueOfLokacija = new System.Windows.Forms.Label();
            this.lblValueOfSifra = new System.Windows.Forms.Label();
            this.lblGodinaOpremljenja = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGodinaOpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSportovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKommentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTereni
            // 
            this.dgvTereni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTereni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clLokacija,
            this.clGodinaOpr,
            this.clSportovi,
            this.clKapacitet,
            this.clKommentar});
            this.dgvTereni.Location = new System.Drawing.Point(12, 81);
            this.dgvTereni.Name = "dgvTereni";
            this.dgvTereni.ShowRowErrors = false;
            this.dgvTereni.Size = new System.Drawing.Size(710, 230);
            this.dgvTereni.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrisanje);
            this.panel1.Controls.Add(this.btnIzmena);
            this.panel1.Controls.Add(this.btnDodavanje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Enabled = false;
            this.btnBrisanje.Location = new System.Drawing.Point(266, 12);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(121, 51);
            this.btnBrisanje.TabIndex = 2;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Enabled = false;
            this.btnIzmena.Location = new System.Drawing.Point(139, 12);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(121, 51);
            this.btnIzmena.TabIndex = 1;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(12, 12);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(121, 51);
            this.btnDodavanje.TabIndex = 0;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbPodaci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 75);
            this.panel2.TabIndex = 2;
            // 
            // gbPodaci
            // 
            this.gbPodaci.Controls.Add(this.tbKomentar);
            this.gbPodaci.Controls.Add(this.lblKomentar);
            this.gbPodaci.Controls.Add(this.lblValueOfKapacitet);
            this.gbPodaci.Controls.Add(this.lblValueOfSportovi);
            this.gbPodaci.Controls.Add(this.lblKapacitet);
            this.gbPodaci.Controls.Add(this.lblSportovi);
            this.gbPodaci.Controls.Add(this.lblValueOfGodinaOpremljenja);
            this.gbPodaci.Controls.Add(this.lblValueOfLokacija);
            this.gbPodaci.Controls.Add(this.lblValueOfSifra);
            this.gbPodaci.Controls.Add(this.lblGodinaOpremljenja);
            this.gbPodaci.Controls.Add(this.lblLokacija);
            this.gbPodaci.Controls.Add(this.lblSifra);
            this.gbPodaci.Location = new System.Drawing.Point(12, 3);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gbPodaci.Size = new System.Drawing.Size(710, 69);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Podaci:";
            this.gbPodaci.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbKomentar
            // 
            this.tbKomentar.Enabled = false;
            this.tbKomentar.Location = new System.Drawing.Point(513, 13);
            this.tbKomentar.Multiline = true;
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(189, 47);
            this.tbKomentar.TabIndex = 12;
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(452, 47);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 11;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblValueOfKapacitet
            // 
            this.lblValueOfKapacitet.AutoSize = true;
            this.lblValueOfKapacitet.Location = new System.Drawing.Point(306, 26);
            this.lblValueOfKapacitet.Name = "lblValueOfKapacitet";
            this.lblValueOfKapacitet.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.lblValueOfKapacitet.Size = new System.Drawing.Size(29, 21);
            this.lblValueOfKapacitet.TabIndex = 10;
            this.lblValueOfKapacitet.Text = "text";
            // 
            // lblValueOfSportovi
            // 
            this.lblValueOfSportovi.AutoSize = true;
            this.lblValueOfSportovi.Location = new System.Drawing.Point(306, 13);
            this.lblValueOfSportovi.Name = "lblValueOfSportovi";
            this.lblValueOfSportovi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblValueOfSportovi.Size = new System.Drawing.Size(29, 13);
            this.lblValueOfSportovi.TabIndex = 9;
            this.lblValueOfSportovi.Text = "text";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(245, 26);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblKapacitet.Size = new System.Drawing.Size(55, 21);
            this.lblKapacitet.TabIndex = 7;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // lblSportovi
            // 
            this.lblSportovi.AutoSize = true;
            this.lblSportovi.Location = new System.Drawing.Point(251, 13);
            this.lblSportovi.Name = "lblSportovi";
            this.lblSportovi.Size = new System.Drawing.Size(49, 13);
            this.lblSportovi.TabIndex = 6;
            this.lblSportovi.Text = "Sportovi:";
            // 
            // lblValueOfGodinaOpremljenja
            // 
            this.lblValueOfGodinaOpremljenja.AutoSize = true;
            this.lblValueOfGodinaOpremljenja.Location = new System.Drawing.Point(127, 47);
            this.lblValueOfGodinaOpremljenja.Name = "lblValueOfGodinaOpremljenja";
            this.lblValueOfGodinaOpremljenja.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblValueOfGodinaOpremljenja.Size = new System.Drawing.Size(29, 13);
            this.lblValueOfGodinaOpremljenja.TabIndex = 5;
            this.lblValueOfGodinaOpremljenja.Text = "text";
            // 
            // lblValueOfLokacija
            // 
            this.lblValueOfLokacija.AutoSize = true;
            this.lblValueOfLokacija.Location = new System.Drawing.Point(127, 26);
            this.lblValueOfLokacija.Name = "lblValueOfLokacija";
            this.lblValueOfLokacija.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.lblValueOfLokacija.Size = new System.Drawing.Size(29, 21);
            this.lblValueOfLokacija.TabIndex = 4;
            this.lblValueOfLokacija.Text = "text";
            // 
            // lblValueOfSifra
            // 
            this.lblValueOfSifra.AutoSize = true;
            this.lblValueOfSifra.Location = new System.Drawing.Point(127, 13);
            this.lblValueOfSifra.Name = "lblValueOfSifra";
            this.lblValueOfSifra.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblValueOfSifra.Size = new System.Drawing.Size(29, 13);
            this.lblValueOfSifra.TabIndex = 3;
            this.lblValueOfSifra.Text = "text";
            // 
            // lblGodinaOpremljenja
            // 
            this.lblGodinaOpremljenja.AutoSize = true;
            this.lblGodinaOpremljenja.Location = new System.Drawing.Point(21, 47);
            this.lblGodinaOpremljenja.Name = "lblGodinaOpremljenja";
            this.lblGodinaOpremljenja.Size = new System.Drawing.Size(100, 13);
            this.lblGodinaOpremljenja.TabIndex = 2;
            this.lblGodinaOpremljenja.Text = "Godina opremljenja:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(71, 26);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblLokacija.Size = new System.Drawing.Size(50, 21);
            this.lblLokacija.TabIndex = 1;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(90, 13);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(31, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Sifra:";
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Sifra";
            this.clSifra.Name = "clSifra";
            // 
            // clLokacija
            // 
            this.clLokacija.HeaderText = "Lokacija";
            this.clLokacija.Name = "clLokacija";
            // 
            // clGodinaOpr
            // 
            this.clGodinaOpr.HeaderText = "Godina opremljenja";
            this.clGodinaOpr.Name = "clGodinaOpr";
            this.clGodinaOpr.Width = 150;
            // 
            // clSportovi
            // 
            this.clSportovi.HeaderText = "Sportovi";
            this.clSportovi.Name = "clSportovi";
            // 
            // clKapacitet
            // 
            this.clKapacitet.HeaderText = "Kapacitet";
            this.clKapacitet.Name = "clKapacitet";
            // 
            // clKommentar
            // 
            this.clKommentar.HeaderText = "Kommentar";
            this.clKommentar.Name = "clKommentar";
            // 
            // DialogTereni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTereni);
            this.Name = "DialogTereni";
            this.Text = "DialogTereni";
            this.Load += new System.EventHandler(this.DialogTereni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTereni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGodinaOpremljenja;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.Label lblValueOfGodinaOpremljenja;
        private System.Windows.Forms.Label lblValueOfLokacija;
        private System.Windows.Forms.Label lblValueOfSifra;
        private System.Windows.Forms.Label lblValueOfKapacitet;
        private System.Windows.Forms.Label lblValueOfSportovi;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblSportovi;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGodinaOpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSportovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKapacitet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKommentar;
    }
}