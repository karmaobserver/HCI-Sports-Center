namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    partial class DodavanjeTerena
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
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbZatvoren = new System.Windows.Forms.RadioButton();
            this.rbOtvoren = new System.Windows.Forms.RadioButton();
            this.cbLokacija = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.cbSportovi = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.tbKommentar = new System.Windows.Forms.TextBox();
            this.lblGodOpr = new System.Windows.Forms.Label();
            this.tbKapacitet = new System.Windows.Forms.TextBox();
            this.lblSportovi = new System.Windows.Forms.Label();
            this.tbGodOpr = new System.Windows.Forms.TextBox();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrda.Image = global::VEOS_WFA.Properties.Resources.potvrda2;
            this.btnPotvrda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotvrda.Location = new System.Drawing.Point(3, 3);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(104, 46);
            this.btnPotvrda.TabIndex = 9;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPotvrda, "Teren će biti dodat");
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            this.btnPotvrda.MouseEnter += new System.EventHandler(this.btnPotvrda_MouseEnter);
            this.btnPotvrda.MouseLeave += new System.EventHandler(this.btnPotvrda_MouseLeave);
            // 
            // btnOdustanak
            // 
            this.btnOdustanak.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustanak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOdustanak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOdustanak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustanak.Image = global::VEOS_WFA.Properties.Resources.odustanak21;
            this.btnOdustanak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustanak.Location = new System.Drawing.Point(113, 3);
            this.btnOdustanak.Name = "btnOdustanak";
            this.btnOdustanak.Size = new System.Drawing.Size(104, 46);
            this.btnOdustanak.TabIndex = 10;
            this.btnOdustanak.Text = "Odustanak";
            this.btnOdustanak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOdustanak, "Teren neće biti dodat");
            this.btnOdustanak.UseVisualStyleBackColor = true;
            this.btnOdustanak.Click += new System.EventHandler(this.btnOdustanak_Click);
            this.btnOdustanak.MouseEnter += new System.EventHandler(this.btnOdustanak_MouseEnter);
            this.btnOdustanak.MouseLeave += new System.EventHandler(this.btnOdustanak_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::VEOS_WFA.Properties.Resources.home_screen_2_jpg;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rbZatvoren);
            this.panel1.Controls.Add(this.rbOtvoren);
            this.panel1.Controls.Add(this.cbLokacija);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.cbSportovi);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblLokacija);
            this.panel1.Controls.Add(this.tbKommentar);
            this.panel1.Controls.Add(this.lblGodOpr);
            this.panel1.Controls.Add(this.tbKapacitet);
            this.panel1.Controls.Add(this.lblSportovi);
            this.panel1.Controls.Add(this.tbGodOpr);
            this.panel1.Controls.Add(this.lblKapacitet);
            this.panel1.Controls.Add(this.lblKommentar);
            this.helpProvider1.SetHelpKeyword(this.panel1, "Dodavanje terena");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(385, 395);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(-1, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 18);
            this.panel2.TabIndex = 20;
            this.panel2.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 15);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Ready...";
            // 
            // rbZatvoren
            // 
            this.rbZatvoren.AutoSize = true;
            this.rbZatvoren.Location = new System.Drawing.Point(252, 292);
            this.rbZatvoren.Name = "rbZatvoren";
            this.rbZatvoren.Size = new System.Drawing.Size(73, 19);
            this.rbZatvoren.TabIndex = 8;
            this.rbZatvoren.Text = "Zatvoren";
            this.toolTip1.SetToolTip(this.rbZatvoren, "Teren će biti zatvoren");
            this.rbZatvoren.UseVisualStyleBackColor = true;
            // 
            // rbOtvoren
            // 
            this.rbOtvoren.AutoSize = true;
            this.rbOtvoren.Checked = true;
            this.rbOtvoren.Location = new System.Drawing.Point(139, 292);
            this.rbOtvoren.Name = "rbOtvoren";
            this.rbOtvoren.Size = new System.Drawing.Size(69, 19);
            this.rbOtvoren.TabIndex = 7;
            this.rbOtvoren.TabStop = true;
            this.rbOtvoren.Text = "Otvoren";
            this.toolTip1.SetToolTip(this.rbOtvoren, "Teren će biti otvoren");
            this.rbOtvoren.UseVisualStyleBackColor = true;
            // 
            // cbLokacija
            // 
            this.cbLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLokacija.FormattingEnabled = true;
            this.cbLokacija.Location = new System.Drawing.Point(139, 40);
            this.cbLokacija.Name = "cbLokacija";
            this.cbLokacija.Size = new System.Drawing.Size(222, 23);
            this.cbLokacija.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbLokacija, "Izaberite jednu od ponuđenih lokacija");
            this.cbLokacija.SelectedValueChanged += new System.EventHandler(this.cbLokacija_SelectedValueChanged);
            this.cbLokacija.Validated += new System.EventHandler(this.cbLokacija_Validated);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(103, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 18;
            this.lblIme.Text = "Ime:";
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIme.Location = new System.Drawing.Point(139, 11);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(222, 23);
            this.tbIme.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbIme, "Unesite ime terena");
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.Validated += new System.EventHandler(this.tbIme_Validated);
            // 
            // cbSportovi
            // 
            this.cbSportovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbSportovi.FormattingEnabled = true;
            this.cbSportovi.Location = new System.Drawing.Point(139, 128);
            this.cbSportovi.Name = "cbSportovi";
            this.cbSportovi.Size = new System.Drawing.Size(222, 92);
            this.cbSportovi.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbSportovi, "čekirajte sport ili više sportova");
            this.cbSportovi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbSportovi_ItemCheck);
            this.cbSportovi.SelectedIndexChanged += new System.EventHandler(this.cbSportovi_SelectedIndexChanged);
            this.cbSportovi.MouseHover += new System.EventHandler(this.cbSportovi_MouseHover);
            this.cbSportovi.Validated += new System.EventHandler(this.cbSportovi_Validated);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 317);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 54);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(77, 43);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(56, 15);
            this.lblLokacija.TabIndex = 1;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // tbKommentar
            // 
            this.tbKommentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKommentar.Location = new System.Drawing.Point(139, 228);
            this.tbKommentar.Multiline = true;
            this.tbKommentar.Name = "tbKommentar";
            this.tbKommentar.Size = new System.Drawing.Size(222, 58);
            this.tbKommentar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbKommentar, "Unesite komentar");
            // 
            // lblGodOpr
            // 
            this.lblGodOpr.AutoSize = true;
            this.lblGodOpr.Location = new System.Drawing.Point(13, 73);
            this.lblGodOpr.Name = "lblGodOpr";
            this.lblGodOpr.Size = new System.Drawing.Size(120, 15);
            this.lblGodOpr.TabIndex = 2;
            this.lblGodOpr.Text = "Godina opremljenja:";
            // 
            // tbKapacitet
            // 
            this.tbKapacitet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKapacitet.Location = new System.Drawing.Point(139, 99);
            this.tbKapacitet.Name = "tbKapacitet";
            this.tbKapacitet.Size = new System.Drawing.Size(69, 23);
            this.tbKapacitet.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbKapacitet, "Samo cifre su dozvoljene za unos");
            this.tbKapacitet.TextChanged += new System.EventHandler(this.tbKapacitet_TextChanged);
            this.tbKapacitet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKapacitet_KeyPress);
            this.tbKapacitet.Validated += new System.EventHandler(this.tbKapacitet_Validated);
            // 
            // lblSportovi
            // 
            this.lblSportovi.AutoSize = true;
            this.lblSportovi.Location = new System.Drawing.Point(77, 128);
            this.lblSportovi.Name = "lblSportovi";
            this.lblSportovi.Size = new System.Drawing.Size(56, 15);
            this.lblSportovi.TabIndex = 3;
            this.lblSportovi.Text = "Sportovi:";
            // 
            // tbGodOpr
            // 
            this.tbGodOpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGodOpr.Location = new System.Drawing.Point(139, 70);
            this.tbGodOpr.MaxLength = 4;
            this.tbGodOpr.Name = "tbGodOpr";
            this.tbGodOpr.Size = new System.Drawing.Size(35, 23);
            this.tbGodOpr.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbGodOpr, "Samo cifre su dozvoljene za unos");
            this.tbGodOpr.TextChanged += new System.EventHandler(this.tbGodOpr_TextChanged);
            this.tbGodOpr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGodOpr_KeyPress);
            this.tbGodOpr.Validated += new System.EventHandler(this.tbGodOpr_Validated);
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(71, 102);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(62, 15);
            this.lblKapacitet.TabIndex = 4;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Location = new System.Drawing.Point(60, 231);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(73, 15);
            this.lblKommentar.TabIndex = 5;
            this.lblKommentar.Text = "Kommentar:";
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
            // DodavanjeTerena
            // 
            this.AcceptButton = this.btnPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustanak;
            this.ClientSize = new System.Drawing.Size(385, 395);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeTerena";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodavanjeTerena";
            this.Load += new System.EventHandler(this.DodavanjeTerena_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DodavanjeTerena_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblGodOpr;
        private System.Windows.Forms.Label lblSportovi;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.TextBox tbGodOpr;
        private System.Windows.Forms.TextBox tbKapacitet;
        private System.Windows.Forms.TextBox tbKommentar;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox cbSportovi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.ComboBox cbLokacija;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RadioButton rbZatvoren;
        private System.Windows.Forms.RadioButton rbOtvoren;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}