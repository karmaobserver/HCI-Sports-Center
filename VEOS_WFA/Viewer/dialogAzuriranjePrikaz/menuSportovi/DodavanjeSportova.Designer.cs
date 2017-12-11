namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuSportovi
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
            this.lblSifraSporta = new System.Windows.Forms.Label();
            this.lblPrefixSporta = new System.Windows.Forms.Label();
            this.lblImeSporta = new System.Windows.Forms.Label();
            this.lblBeleskeSporta = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbBeleske = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSifraSporta
            // 
            this.lblSifraSporta.AutoSize = true;
            this.lblSifraSporta.Location = new System.Drawing.Point(64, 28);
            this.lblSifraSporta.Name = "lblSifraSporta";
            this.lblSifraSporta.Size = new System.Drawing.Size(36, 15);
            this.lblSifraSporta.TabIndex = 0;
            this.lblSifraSporta.Text = "Sifra:";
            // 
            // lblPrefixSporta
            // 
            this.lblPrefixSporta.AutoSize = true;
            this.lblPrefixSporta.Location = new System.Drawing.Point(58, 58);
            this.lblPrefixSporta.Name = "lblPrefixSporta";
            this.lblPrefixSporta.Size = new System.Drawing.Size(41, 15);
            this.lblPrefixSporta.TabIndex = 1;
            this.lblPrefixSporta.Text = "Prefix:";
            // 
            // lblImeSporta
            // 
            this.lblImeSporta.AutoSize = true;
            this.lblImeSporta.Location = new System.Drawing.Point(68, 88);
            this.lblImeSporta.Name = "lblImeSporta";
            this.lblImeSporta.Size = new System.Drawing.Size(30, 15);
            this.lblImeSporta.TabIndex = 2;
            this.lblImeSporta.Text = "Ime:";
            // 
            // lblBeleskeSporta
            // 
            this.lblBeleskeSporta.AutoSize = true;
            this.lblBeleskeSporta.Location = new System.Drawing.Point(44, 200);
            this.lblBeleskeSporta.Name = "lblBeleskeSporta";
            this.lblBeleskeSporta.Size = new System.Drawing.Size(51, 15);
            this.lblBeleskeSporta.TabIndex = 3;
            this.lblBeleskeSporta.Text = "Beleske:";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(107, 20);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(222, 23);
            this.tbSifra.TabIndex = 4;
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(107, 50);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(222, 23);
            this.tbPrefix.TabIndex = 5;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(107, 80);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(222, 23);
            this.tbIme.TabIndex = 6;
            // 
            // tbBeleske
            // 
            this.tbBeleske.Location = new System.Drawing.Point(107, 110);
            this.tbBeleske.Multiline = true;
            this.tbBeleske.Name = "tbBeleske";
            this.tbBeleske.Size = new System.Drawing.Size(222, 104);
            this.tbBeleske.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 54);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(3, 3);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(104, 46);
            this.btnPotvrda.TabIndex = 12;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // btnOdustanak
            // 
            this.btnOdustanak.Location = new System.Drawing.Point(113, 3);
            this.btnOdustanak.Name = "btnOdustanak";
            this.btnOdustanak.Size = new System.Drawing.Size(104, 46);
            this.btnOdustanak.TabIndex = 13;
            this.btnOdustanak.Text = "Odustanak";
            this.btnOdustanak.UseVisualStyleBackColor = true;
            this.btnOdustanak.Click += new System.EventHandler(this.btnOdustanak_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSifra);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblSifraSporta);
            this.panel1.Controls.Add(this.tbBeleske);
            this.panel1.Controls.Add(this.lblPrefixSporta);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.lblImeSporta);
            this.panel1.Controls.Add(this.tbPrefix);
            this.panel1.Controls.Add(this.lblBeleskeSporta);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 284);
            this.panel1.TabIndex = 17;
            // 
            // DodavanjeSportova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 284);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodavanjeSportova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodavanjeSportova";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSifraSporta;
        private System.Windows.Forms.Label lblPrefixSporta;
        private System.Windows.Forms.Label lblImeSporta;
        private System.Windows.Forms.Label lblBeleskeSporta;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbBeleske;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.Panel panel1;
    }
}