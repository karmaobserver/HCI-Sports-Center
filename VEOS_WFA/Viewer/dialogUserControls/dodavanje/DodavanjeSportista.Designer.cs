namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    partial class DodavanjeSportista
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKlasa = new System.Windows.Forms.Label();
            this.lblGodinaUpisa = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.tbGodinaUpisa = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbKlasa = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 319);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 54);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.BackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrda.Image = global::VEOS_WFA.Properties.Resources.potvrda2;
            this.btnPotvrda.Location = new System.Drawing.Point(3, 3);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(104, 46);
            this.btnPotvrda.TabIndex = 7;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPotvrda, "Sportista će biti dodat");
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            this.btnPotvrda.MouseEnter += new System.EventHandler(this.btnPotvrda_MouseEnter);
            this.btnPotvrda.MouseLeave += new System.EventHandler(this.btnPotvrda_MouseLeave);
            // 
            // btnOdustanak
            // 
            this.btnOdustanak.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustanak.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustanak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOdustanak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOdustanak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustanak.Image = global::VEOS_WFA.Properties.Resources.odustanak21;
            this.btnOdustanak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustanak.Location = new System.Drawing.Point(113, 3);
            this.btnOdustanak.Name = "btnOdustanak";
            this.btnOdustanak.Size = new System.Drawing.Size(104, 46);
            this.btnOdustanak.TabIndex = 8;
            this.btnOdustanak.Text = "Odustanak";
            this.btnOdustanak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOdustanak, "Sportista neće biti dodat");
            this.btnOdustanak.UseVisualStyleBackColor = true;
            this.btnOdustanak.Click += new System.EventHandler(this.btnOdustanak_Click);
            this.btnOdustanak.MouseEnter += new System.EventHandler(this.btnOdustanak_MouseEnter);
            this.btnOdustanak.MouseLeave += new System.EventHandler(this.btnOdustanak_MouseLeave);
            // 
            // tbJmbg
            // 
            this.tbJmbg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJmbg.Location = new System.Drawing.Point(121, 70);
            this.tbJmbg.MaxLength = 13;
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(97, 23);
            this.tbJmbg.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbJmbg, "Samo cifre su dozvoljene za unos");
            this.tbJmbg.TextChanged += new System.EventHandler(this.tbJmbg_TextChanged);
            this.tbJmbg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJmbg_KeyPress);
            this.tbJmbg.Validated += new System.EventHandler(this.tbJmbg_Validated);
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIme.Location = new System.Drawing.Point(121, 40);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(222, 23);
            this.tbIme.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbIme, "Unesite ime sportiste");
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.Validated += new System.EventHandler(this.tbIme_Validated);
            // 
            // tbPrezime
            // 
            this.tbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrezime.Location = new System.Drawing.Point(121, 11);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(222, 23);
            this.tbPrezime.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbPrezime, "Unesite prezime sportiste");
            this.tbPrezime.TextChanged += new System.EventHandler(this.tbPrezime_TextChanged);
            this.tbPrezime.Validated += new System.EventHandler(this.tbPrezime_Validated);
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(75, 73);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(40, 15);
            this.lblJmbg.TabIndex = 14;
            this.lblJmbg.Text = "JMBG:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(85, 43);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(62, 14);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(53, 15);
            this.lblPrezime.TabIndex = 12;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblKlasa
            // 
            this.lblKlasa.AutoSize = true;
            this.lblKlasa.Location = new System.Drawing.Point(74, 103);
            this.lblKlasa.Name = "lblKlasa";
            this.lblKlasa.Size = new System.Drawing.Size(41, 15);
            this.lblKlasa.TabIndex = 20;
            this.lblKlasa.Text = "Klasa:";
            // 
            // lblGodinaUpisa
            // 
            this.lblGodinaUpisa.AutoSize = true;
            this.lblGodinaUpisa.Location = new System.Drawing.Point(30, 164);
            this.lblGodinaUpisa.Name = "lblGodinaUpisa";
            this.lblGodinaUpisa.Size = new System.Drawing.Size(85, 15);
            this.lblGodinaUpisa.TabIndex = 22;
            this.lblGodinaUpisa.Text = "Godina Upisa:";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(76, 133);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(39, 15);
            this.lblSport.TabIndex = 24;
            this.lblSport.Text = "Sport:";
            // 
            // cmbSport
            // 
            this.cmbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.ItemHeight = 15;
            this.cmbSport.Location = new System.Drawing.Point(121, 130);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(222, 23);
            this.cmbSport.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmbSport, "Izberite jedan od ponuđenih sportova");
            this.cmbSport.SelectedValueChanged += new System.EventHandler(this.cmbSport_SelectedValueChanged);
            this.cmbSport.MouseHover += new System.EventHandler(this.cmbSport_MouseHover);
            this.cmbSport.Validated += new System.EventHandler(this.cmbSport_Validated);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(121, 191);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(222, 121);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlika.TabIndex = 26;
            this.pbSlika.TabStop = false;
            this.toolTip1.SetToolTip(this.pbSlika, "Kliknite na kvadratić da bi ste dodali ili izmenili sliku");
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            this.pbSlika.Validated += new System.EventHandler(this.pbSlika_Validated);
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(78, 191);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(37, 15);
            this.lblSlika.TabIndex = 28;
            this.lblSlika.Text = "Slika:";
            // 
            // tbGodinaUpisa
            // 
            this.tbGodinaUpisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGodinaUpisa.Location = new System.Drawing.Point(121, 161);
            this.tbGodinaUpisa.MaxLength = 4;
            this.tbGodinaUpisa.Name = "tbGodinaUpisa";
            this.tbGodinaUpisa.Size = new System.Drawing.Size(34, 23);
            this.tbGodinaUpisa.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbGodinaUpisa, "Samo cifre su dozvoljene za unos");
            this.tbGodinaUpisa.TextChanged += new System.EventHandler(this.tbGodinaUpisa_TextChanged);
            this.tbGodinaUpisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGodinaUpisa_KeyPress);
            this.tbGodinaUpisa.Validated += new System.EventHandler(this.tbGodinaUpisa_Validated);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            this.openFileDialog.Title = "Otvorite sliku";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::VEOS_WFA.Properties.Resources.home_screen_2_jpg;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbKlasa);
            this.panel1.Controls.Add(this.tbGodinaUpisa);
            this.panel1.Controls.Add(this.lblSlika);
            this.panel1.Controls.Add(this.lblPrezime);
            this.panel1.Controls.Add(this.pbSlika);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.cmbSport);
            this.panel1.Controls.Add(this.lblJmbg);
            this.panel1.Controls.Add(this.lblSport);
            this.panel1.Controls.Add(this.tbPrezime);
            this.panel1.Controls.Add(this.lblGodinaUpisa);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.tbJmbg);
            this.panel1.Controls.Add(this.lblKlasa);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.helpProvider1.SetHelpKeyword(this.panel1, "Dodavanje sportista");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(385, 397);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(-1, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 18);
            this.panel2.TabIndex = 31;
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
            // cbKlasa
            // 
            this.cbKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKlasa.FormattingEnabled = true;
            this.cbKlasa.Location = new System.Drawing.Point(121, 99);
            this.cbKlasa.Name = "cbKlasa";
            this.cbKlasa.Size = new System.Drawing.Size(222, 23);
            this.cbKlasa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbKlasa, "Izberite jednu od ponuđenih klasa");
            this.cbKlasa.SelectedValueChanged += new System.EventHandler(this.cbKlasa_SelectedValueChanged);
            this.cbKlasa.Validated += new System.EventHandler(this.cbKlasa_Validated);
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
            // DodavanjeSportista
            // 
            this.AcceptButton = this.btnPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustanak;
            this.ClientSize = new System.Drawing.Size(385, 397);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeSportista";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodavanjeSportista";
            this.Load += new System.EventHandler(this.DodavanjeSportista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DodavanjeSportista_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKlasa;
        private System.Windows.Forms.Label lblGodinaUpisa;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.TextBox tbGodinaUpisa;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox cbKlasa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}