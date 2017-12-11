namespace VEOS_WFA.Viewer.dialogUserControls
{
    partial class ZauzimanjeTerena
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
            this.gbZauzimanjeTerena = new System.Windows.Forms.GroupBox();
            this.lblValueOfRezultat = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.cbZauzimanje = new System.Windows.Forms.CheckBox();
            this.cbOslobadanje = new System.Windows.Forms.CheckBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.dgvZauzimanjeTerena = new System.Windows.Forms.DataGridView();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTeren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDatumZauzimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDatumOslobadanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrimedbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbZauzimanjeTerena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZauzimanjeTerena)).BeginInit();
            this.SuspendLayout();
            // 
            // gbZauzimanjeTerena
            // 
            this.gbZauzimanjeTerena.Controls.Add(this.lblValueOfRezultat);
            this.gbZauzimanjeTerena.Controls.Add(this.lblRezultat);
            this.gbZauzimanjeTerena.Controls.Add(this.lblPretraga);
            this.gbZauzimanjeTerena.Controls.Add(this.cbZauzimanje);
            this.gbZauzimanjeTerena.Controls.Add(this.cbOslobadanje);
            this.gbZauzimanjeTerena.Controls.Add(this.btnPretraga);
            this.gbZauzimanjeTerena.Controls.Add(this.tbSearchText);
            this.gbZauzimanjeTerena.Controls.Add(this.dgvZauzimanjeTerena);
            this.helpProvider1.SetHelpKeyword(this.gbZauzimanjeTerena, "Istorija zauzetosti");
            this.helpProvider1.SetHelpNavigator(this.gbZauzimanjeTerena, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.gbZauzimanjeTerena.Location = new System.Drawing.Point(3, 3);
            this.gbZauzimanjeTerena.Name = "gbZauzimanjeTerena";
            this.helpProvider1.SetShowHelp(this.gbZauzimanjeTerena, true);
            this.gbZauzimanjeTerena.Size = new System.Drawing.Size(569, 307);
            this.gbZauzimanjeTerena.TabIndex = 0;
            this.gbZauzimanjeTerena.TabStop = false;
            this.gbZauzimanjeTerena.Text = "Istorija zauzetosti";
            // 
            // lblValueOfRezultat
            // 
            this.lblValueOfRezultat.AutoSize = true;
            this.lblValueOfRezultat.Location = new System.Drawing.Point(158, 47);
            this.lblValueOfRezultat.Name = "lblValueOfRezultat";
            this.lblValueOfRezultat.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfRezultat.TabIndex = 8;
            this.lblValueOfRezultat.Text = "/";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(6, 47);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(146, 15);
            this.lblRezultat.TabIndex = 7;
            this.lblRezultat.Text = "Broj pronađenih sloga je:";
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(6, 24);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(72, 15);
            this.lblPretraga.TabIndex = 5;
            this.lblPretraga.Text = "Pretraga za:";
            this.toolTip1.SetToolTip(this.lblPretraga, "Unesite ime tima ili terena prema kojem želite da pretražujete, zatim kliknite na" +
                    " Pretraga");
            // 
            // cbZauzimanje
            // 
            this.cbZauzimanje.AutoSize = true;
            this.cbZauzimanje.Checked = true;
            this.cbZauzimanje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZauzimanje.Location = new System.Drawing.Point(330, 47);
            this.cbZauzimanje.Name = "cbZauzimanje";
            this.cbZauzimanje.Size = new System.Drawing.Size(80, 17);
            this.cbZauzimanje.TabIndex = 4;
            this.cbZauzimanje.Text = "Zauzimanje";
            this.toolTip1.SetToolTip(this.cbZauzimanje, "Pretraživanje prema zauzetima terenima");
            this.cbZauzimanje.UseVisualStyleBackColor = true;
            this.cbZauzimanje.CheckedChanged += new System.EventHandler(this.cbZauzimanje_CheckedChanged);
            // 
            // cbOslobadanje
            // 
            this.cbOslobadanje.AutoSize = true;
            this.cbOslobadanje.Checked = true;
            this.cbOslobadanje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOslobadanje.Location = new System.Drawing.Point(227, 47);
            this.cbOslobadanje.Name = "cbOslobadanje";
            this.cbOslobadanje.Size = new System.Drawing.Size(86, 17);
            this.cbOslobadanje.TabIndex = 3;
            this.cbOslobadanje.Text = "Oslobađanje";
            this.toolTip1.SetToolTip(this.cbOslobadanje, "Pretraživanje prema oslobođenim terenima");
            this.cbOslobadanje.UseVisualStyleBackColor = true;
            this.cbOslobadanje.CheckedChanged += new System.EventHandler(this.cbOslobadanje_CheckedChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackgroundImage = global::VEOS_WFA.Properties.Resources.button;
            this.btnPretraga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.Image = global::VEOS_WFA.Properties.Resources.search;
            this.btnPretraga.Location = new System.Drawing.Point(425, 21);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(138, 40);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPretraga, "Pretraživanje prema zadatom imenu terena ili tima");
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            this.btnPretraga.MouseEnter += new System.EventHandler(this.btnPretraga_MouseEnter);
            this.btnPretraga.MouseLeave += new System.EventHandler(this.btnPretraga_MouseLeave);
            // 
            // tbSearchText
            // 
            this.tbSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchText.Location = new System.Drawing.Point(84, 21);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(335, 23);
            this.tbSearchText.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbSearchText, "Unesite ime tima ili terena prema kojem želite da pretražujete, zatim kliknite na" +
                    " Pretraga");
            this.tbSearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchText_KeyPress);
            // 
            // dgvZauzimanjeTerena
            // 
            this.dgvZauzimanjeTerena.AllowUserToAddRows = false;
            this.dgvZauzimanjeTerena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZauzimanjeTerena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clTim,
            this.clTeren,
            this.clStatus,
            this.clDatumZauzimanja,
            this.clDatumOslobadanja,
            this.clNamena,
            this.clPrimedbe});
            this.dgvZauzimanjeTerena.Location = new System.Drawing.Point(6, 72);
            this.dgvZauzimanjeTerena.Name = "dgvZauzimanjeTerena";
            this.dgvZauzimanjeTerena.ReadOnly = true;
            this.dgvZauzimanjeTerena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZauzimanjeTerena.Size = new System.Drawing.Size(557, 229);
            this.dgvZauzimanjeTerena.TabIndex = 0;
            this.dgvZauzimanjeTerena.SelectionChanged += new System.EventHandler(this.dgvZauzimanjeTerena_SelectionChanged);
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Šifra";
            this.clSifra.Name = "clSifra";
            this.clSifra.ReadOnly = true;
            // 
            // clTim
            // 
            this.clTim.HeaderText = "Tim";
            this.clTim.Name = "clTim";
            this.clTim.ReadOnly = true;
            // 
            // clTeren
            // 
            this.clTeren.HeaderText = "Teren";
            this.clTeren.Name = "clTeren";
            this.clTeren.ReadOnly = true;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Status";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            // 
            // clDatumZauzimanja
            // 
            this.clDatumZauzimanja.HeaderText = "Datum zauzimanja";
            this.clDatumZauzimanja.Name = "clDatumZauzimanja";
            this.clDatumZauzimanja.ReadOnly = true;
            // 
            // clDatumOslobadanja
            // 
            this.clDatumOslobadanja.HeaderText = "Datum oslobađanja";
            this.clDatumOslobadanja.Name = "clDatumOslobadanja";
            this.clDatumOslobadanja.ReadOnly = true;
            // 
            // clNamena
            // 
            this.clNamena.HeaderText = "Namena korišćenja";
            this.clNamena.Name = "clNamena";
            this.clNamena.ReadOnly = true;
            // 
            // clPrimedbe
            // 
            this.clPrimedbe.HeaderText = "Primedbe na zauzimanje";
            this.clPrimedbe.Name = "clPrimedbe";
            this.clPrimedbe.ReadOnly = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // ZauzimanjeTerena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbZauzimanjeTerena);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ZauzimanjeTerena";
            this.Size = new System.Drawing.Size(575, 310);
            this.Load += new System.EventHandler(this.ZauzimanjeTerena_Load);
            this.gbZauzimanjeTerena.ResumeLayout(false);
            this.gbZauzimanjeTerena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZauzimanjeTerena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZauzimanjeTerena;
        private System.Windows.Forms.DataGridView dgvZauzimanjeTerena;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.CheckBox cbZauzimanje;
        private System.Windows.Forms.CheckBox cbOslobadanje;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.Label lblValueOfRezultat;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTeren;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDatumZauzimanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDatumOslobadanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrimedbe;
    }
}
