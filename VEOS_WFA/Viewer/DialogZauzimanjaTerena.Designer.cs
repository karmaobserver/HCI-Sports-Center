namespace VEOS_WFA.Viewer
{
    partial class DialogZauzimanjaTerena
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
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNamena = new System.Windows.Forms.ComboBox();
            this.tbSifraTima = new System.Windows.Forms.TextBox();
            this.tbPrimedbe = new System.Windows.Forms.TextBox();
            this.lblSifraTima = new System.Windows.Forms.Label();
            this.dtpZauzimanjeTerena = new System.Windows.Forms.DateTimePicker();
            this.lblSifraTerena = new System.Windows.Forms.Label();
            this.lblPrimedbe = new System.Windows.Forms.Label();
            this.lblZauzimanjeTerena = new System.Windows.Forms.Label();
            this.dtpOslobadanjeTerena = new System.Windows.Forms.DateTimePicker();
            this.lblOslobadanjeTerena = new System.Windows.Forms.Label();
            this.tbSifraTerena = new System.Windows.Forms.TextBox();
            this.lblNamenaKoriscenja = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
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
            this.panel1.Controls.Add(this.cbNamena);
            this.panel1.Controls.Add(this.tbSifraTima);
            this.panel1.Controls.Add(this.tbPrimedbe);
            this.panel1.Controls.Add(this.lblSifraTima);
            this.panel1.Controls.Add(this.dtpZauzimanjeTerena);
            this.panel1.Controls.Add(this.lblSifraTerena);
            this.panel1.Controls.Add(this.lblPrimedbe);
            this.panel1.Controls.Add(this.lblZauzimanjeTerena);
            this.panel1.Controls.Add(this.dtpOslobadanjeTerena);
            this.panel1.Controls.Add(this.lblOslobadanjeTerena);
            this.panel1.Controls.Add(this.tbSifraTerena);
            this.panel1.Controls.Add(this.lblNamenaKoriscenja);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.helpProvider1.SetHelpKeyword(this.panel1, "");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(469, 385);
            this.panel1.TabIndex = 49;
            this.panel1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.panel1_HelpRequested);
            // 
            // cbNamena
            // 
            this.cbNamena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNamena.FormattingEnabled = true;
            this.cbNamena.Location = new System.Drawing.Point(217, 131);
            this.cbNamena.Name = "cbNamena";
            this.cbNamena.Size = new System.Drawing.Size(222, 23);
            this.cbNamena.TabIndex = 3;
            this.cbNamena.Validated += new System.EventHandler(this.cbNamena_Validated);
            // 
            // tbSifraTima
            // 
            this.tbSifraTima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSifraTima.Enabled = false;
            this.tbSifraTima.Location = new System.Drawing.Point(217, 12);
            this.tbSifraTima.Name = "tbSifraTima";
            this.tbSifraTima.Size = new System.Drawing.Size(222, 23);
            this.tbSifraTima.TabIndex = 10;
            // 
            // tbPrimedbe
            // 
            this.tbPrimedbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrimedbe.Location = new System.Drawing.Point(217, 162);
            this.tbPrimedbe.Multiline = true;
            this.tbPrimedbe.Name = "tbPrimedbe";
            this.tbPrimedbe.Size = new System.Drawing.Size(222, 149);
            this.tbPrimedbe.TabIndex = 4;
            // 
            // lblSifraTima
            // 
            this.lblSifraTima.AutoSize = true;
            this.lblSifraTima.Location = new System.Drawing.Point(148, 15);
            this.lblSifraTima.Name = "lblSifraTima";
            this.lblSifraTima.Size = new System.Drawing.Size(63, 15);
            this.lblSifraTima.TabIndex = 29;
            this.lblSifraTima.Text = "Šifra tima:";
            // 
            // dtpZauzimanjeTerena
            // 
            this.dtpZauzimanjeTerena.Location = new System.Drawing.Point(217, 72);
            this.dtpZauzimanjeTerena.Name = "dtpZauzimanjeTerena";
            this.dtpZauzimanjeTerena.Size = new System.Drawing.Size(222, 23);
            this.dtpZauzimanjeTerena.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtpZauzimanjeTerena, "Kliknite na strelicu pored da bi ste modifikovali datum");
            // 
            // lblSifraTerena
            // 
            this.lblSifraTerena.AutoSize = true;
            this.lblSifraTerena.Location = new System.Drawing.Point(136, 45);
            this.lblSifraTerena.Name = "lblSifraTerena";
            this.lblSifraTerena.Size = new System.Drawing.Size(74, 15);
            this.lblSifraTerena.TabIndex = 30;
            this.lblSifraTerena.Text = "Šifra terena:";
            // 
            // lblPrimedbe
            // 
            this.lblPrimedbe.AutoSize = true;
            this.lblPrimedbe.Location = new System.Drawing.Point(29, 165);
            this.lblPrimedbe.Name = "lblPrimedbe";
            this.lblPrimedbe.Size = new System.Drawing.Size(182, 15);
            this.lblPrimedbe.TabIndex = 42;
            this.lblPrimedbe.Text = "Primedbe na zauzimanje terena:";
            // 
            // lblZauzimanjeTerena
            // 
            this.lblZauzimanjeTerena.AutoSize = true;
            this.lblZauzimanjeTerena.Location = new System.Drawing.Point(19, 78);
            this.lblZauzimanjeTerena.Name = "lblZauzimanjeTerena";
            this.lblZauzimanjeTerena.Size = new System.Drawing.Size(192, 15);
            this.lblZauzimanjeTerena.TabIndex = 31;
            this.lblZauzimanjeTerena.Text = "Datum i vreme zauzimanje terena:";
            // 
            // dtpOslobadanjeTerena
            // 
            this.dtpOslobadanjeTerena.Location = new System.Drawing.Point(217, 102);
            this.dtpOslobadanjeTerena.Name = "dtpOslobadanjeTerena";
            this.dtpOslobadanjeTerena.Size = new System.Drawing.Size(222, 23);
            this.dtpOslobadanjeTerena.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpOslobadanjeTerena, "Kliknite na strelicu pored da bi ste modifikovali datum");
            // 
            // lblOslobadanjeTerena
            // 
            this.lblOslobadanjeTerena.AutoSize = true;
            this.lblOslobadanjeTerena.Location = new System.Drawing.Point(11, 108);
            this.lblOslobadanjeTerena.Name = "lblOslobadanjeTerena";
            this.lblOslobadanjeTerena.Size = new System.Drawing.Size(200, 15);
            this.lblOslobadanjeTerena.TabIndex = 32;
            this.lblOslobadanjeTerena.Text = "Datum i vreme oslobadanja terena:";
            // 
            // tbSifraTerena
            // 
            this.tbSifraTerena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSifraTerena.Enabled = false;
            this.tbSifraTerena.Location = new System.Drawing.Point(217, 42);
            this.tbSifraTerena.Name = "tbSifraTerena";
            this.tbSifraTerena.Size = new System.Drawing.Size(222, 23);
            this.tbSifraTerena.TabIndex = 11;
            // 
            // lblNamenaKoriscenja
            // 
            this.lblNamenaKoriscenja.AutoSize = true;
            this.lblNamenaKoriscenja.Location = new System.Drawing.Point(57, 135);
            this.lblNamenaKoriscenja.Name = "lblNamenaKoriscenja";
            this.lblNamenaKoriscenja.Size = new System.Drawing.Size(154, 15);
            this.lblNamenaKoriscenja.TabIndex = 38;
            this.lblNamenaKoriscenja.Text = "Namena korišćenja terena:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(217, 319);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 54);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DialogZauzimanjaTerena
            // 
            this.AcceptButton = this.btnPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustanak;
            this.ClientSize = new System.Drawing.Size(469, 385);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogZauzimanjaTerena";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogZauzimanjaTerena";
            this.Load += new System.EventHandler(this.DialogZauzimanjaTerena_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogZauzimanjaTerena_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrimedbe;
        private System.Windows.Forms.DateTimePicker dtpOslobadanjeTerena;
        private System.Windows.Forms.Label lblNamenaKoriscenja;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.TextBox tbSifraTerena;
        private System.Windows.Forms.TextBox tbSifraTima;
        private System.Windows.Forms.Label lblOslobadanjeTerena;
        private System.Windows.Forms.Label lblZauzimanjeTerena;
        private System.Windows.Forms.Label lblSifraTerena;
        private System.Windows.Forms.Label lblSifraTima;
        private System.Windows.Forms.DateTimePicker dtpZauzimanjeTerena;
        private System.Windows.Forms.TextBox tbPrimedbe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox cbNamena;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}