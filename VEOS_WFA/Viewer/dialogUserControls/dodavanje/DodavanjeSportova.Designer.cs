namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    partial class DodavanjeSportova
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
            this.lblPrefixSporta = new System.Windows.Forms.Label();
            this.lblImeSporta = new System.Windows.Forms.Label();
            this.lblBeleskeSporta = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbBeleske = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrefixSporta
            // 
            this.lblPrefixSporta.AutoSize = true;
            this.lblPrefixSporta.Location = new System.Drawing.Point(54, 14);
            this.lblPrefixSporta.Name = "lblPrefixSporta";
            this.lblPrefixSporta.Size = new System.Drawing.Size(47, 15);
            this.lblPrefixSporta.TabIndex = 1;
            this.lblPrefixSporta.Text = "Prefiks:";
            // 
            // lblImeSporta
            // 
            this.lblImeSporta.AutoSize = true;
            this.lblImeSporta.Location = new System.Drawing.Point(71, 43);
            this.lblImeSporta.Name = "lblImeSporta";
            this.lblImeSporta.Size = new System.Drawing.Size(30, 15);
            this.lblImeSporta.TabIndex = 2;
            this.lblImeSporta.Text = "Ime:";
            // 
            // lblBeleskeSporta
            // 
            this.lblBeleskeSporta.AutoSize = true;
            this.lblBeleskeSporta.Location = new System.Drawing.Point(50, 73);
            this.lblBeleskeSporta.Name = "lblBeleskeSporta";
            this.lblBeleskeSporta.Size = new System.Drawing.Size(51, 15);
            this.lblBeleskeSporta.TabIndex = 3;
            this.lblBeleskeSporta.Text = "Beleške:";
            // 
            // tbPrefix
            // 
            this.tbPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrefix.Location = new System.Drawing.Point(107, 11);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(107, 23);
            this.tbPrefix.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbPrefix, "Unesite prefiks sporta");
            this.tbPrefix.TextChanged += new System.EventHandler(this.tbPrefix_TextChanged);
            this.tbPrefix.Validated += new System.EventHandler(this.tbPrefix_Validated);
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIme.Location = new System.Drawing.Point(107, 40);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(222, 23);
            this.tbIme.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbIme, "Unesite ime sporta");
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            this.tbIme.Validated += new System.EventHandler(this.tbIme_Validated);
            // 
            // tbBeleske
            // 
            this.tbBeleske.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBeleske.Location = new System.Drawing.Point(107, 70);
            this.tbBeleske.Multiline = true;
            this.tbBeleske.Name = "tbBeleske";
            this.tbBeleske.Size = new System.Drawing.Size(222, 104);
            this.tbBeleske.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbBeleske, "Unesite beleske o sportu");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 54);
            this.flowLayoutPanel1.TabIndex = 16;
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
            this.toolTip1.SetToolTip(this.btnPotvrda, "Sport će biti dodat");
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
            this.toolTip1.SetToolTip(this.btnOdustanak, "Sport neće biti dodat");
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
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tbBeleske);
            this.panel1.Controls.Add(this.lblPrefixSporta);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.lblImeSporta);
            this.panel1.Controls.Add(this.tbPrefix);
            this.panel1.Controls.Add(this.lblBeleskeSporta);
            this.helpProvider1.SetHelpKeyword(this.panel1, "Dodavanje sportova");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(374, 258);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Location = new System.Drawing.Point(-1, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 18);
            this.panel2.TabIndex = 32;
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
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DodavanjeSportova
            // 
            this.AcceptButton = this.btnPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustanak;
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeSportova";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodavanjeSportova";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DodavanjeSportova_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrefixSporta;
        private System.Windows.Forms.Label lblImeSporta;
        private System.Windows.Forms.Label lblBeleskeSporta;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbBeleske;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}