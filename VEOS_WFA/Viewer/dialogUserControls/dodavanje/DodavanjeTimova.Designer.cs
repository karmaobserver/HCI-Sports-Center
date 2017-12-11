namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    partial class DodavanjeTimova
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
            this.lblSport = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSportisti = new System.Windows.Forms.Label();
            this.cbSportisti = new System.Windows.Forms.CheckedListBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.cbSportovi = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(76, 43);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(39, 15);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(52, 224);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(63, 15);
            this.lblKomentar.TabIndex = 3;
            this.lblKomentar.Text = "Komentar:";
            // 
            // tbKomentar
            // 
            this.tbKomentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKomentar.Location = new System.Drawing.Point(121, 221);
            this.tbKomentar.Multiline = true;
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(222, 104);
            this.tbKomentar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbKomentar, "Unesite komentar");
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPotvrda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrda.Image = global::VEOS_WFA.Properties.Resources.potvrda2;
            this.btnPotvrda.Location = new System.Drawing.Point(3, 3);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(104, 46);
            this.btnPotvrda.TabIndex = 5;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPotvrda, "Tim će biti dodat");
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
            this.btnOdustanak.TabIndex = 6;
            this.btnOdustanak.Text = "Odustanak";
            this.btnOdustanak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOdustanak, "Tim neće biti dodat");
            this.btnOdustanak.UseVisualStyleBackColor = true;
            this.btnOdustanak.Click += new System.EventHandler(this.btnOdustanak_Click);
            this.btnOdustanak.MouseEnter += new System.EventHandler(this.btnOdustanak_MouseEnter);
            this.btnOdustanak.MouseLeave += new System.EventHandler(this.btnOdustanak_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 54);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::VEOS_WFA.Properties.Resources.home_screen_2_jpg;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblSportisti);
            this.panel1.Controls.Add(this.cbSportisti);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.cbSportovi);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tbKomentar);
            this.panel1.Controls.Add(this.lblSport);
            this.panel1.Controls.Add(this.lblKomentar);
            this.helpProvider1.SetHelpKeyword(this.panel1, "Dodavanje timova");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(385, 409);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(-1, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 18);
            this.panel2.TabIndex = 21;
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
            // lblSportisti
            // 
            this.lblSportisti.AutoSize = true;
            this.lblSportisti.Location = new System.Drawing.Point(60, 69);
            this.lblSportisti.Name = "lblSportisti";
            this.lblSportisti.Size = new System.Drawing.Size(55, 15);
            this.lblSportisti.TabIndex = 15;
            this.lblSportisti.Text = "Sportisti:";
            // 
            // cbSportisti
            // 
            this.cbSportisti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbSportisti.FormattingEnabled = true;
            this.cbSportisti.Location = new System.Drawing.Point(121, 69);
            this.cbSportisti.Name = "cbSportisti";
            this.cbSportisti.Size = new System.Drawing.Size(222, 146);
            this.cbSportisti.TabIndex = 3;
            this.cbSportisti.SelectedIndexChanged += new System.EventHandler(this.cbSportisti_SelectedIndexChanged);
            this.cbSportisti.MouseHover += new System.EventHandler(this.cbSportisti_MouseHover);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(85, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime:";
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIme.Location = new System.Drawing.Point(121, 11);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(222, 23);
            this.tbIme.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbIme, "Unesite ime tima");
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.Validated += new System.EventHandler(this.tbIme_Validated);
            // 
            // cbSportovi
            // 
            this.cbSportovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSportovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSportovi.FormattingEnabled = true;
            this.cbSportovi.Location = new System.Drawing.Point(121, 40);
            this.cbSportovi.Name = "cbSportovi";
            this.cbSportovi.Size = new System.Drawing.Size(222, 23);
            this.cbSportovi.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbSportovi, "Izaberite  jedan od ponuđenih sportova");
            this.cbSportovi.SelectedValueChanged += new System.EventHandler(this.cbSportovi_SelectedValueChanged);
            this.cbSportovi.Validated += new System.EventHandler(this.cbSportovi_Validated);
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
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 0;
            this.toolTip2.ReshowDelay = 100;
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 5000;
            this.toolTip3.InitialDelay = 0;
            this.toolTip3.ReshowDelay = 100;
            // 
            // DodavanjeTimova
            // 
            this.AcceptButton = this.btnPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustanak;
            this.ClientSize = new System.Drawing.Size(385, 409);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeTimova";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "x";
            this.Load += new System.EventHandler(this.DodavanjeTimova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DodavanjeTimova_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox cbSportovi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblSportisti;
        private System.Windows.Forms.CheckedListBox cbSportisti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}