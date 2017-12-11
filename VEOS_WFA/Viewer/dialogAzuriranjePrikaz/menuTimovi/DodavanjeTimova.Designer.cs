namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz.menuTimovi
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
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblBrSportista = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbBrojSportista = new System.Windows.Forms.TextBox();
            this.tbSport = new System.Windows.Forms.TextBox();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnOdustanak = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(63, 19);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(32, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "SIfra:";
            // 
            // lblBrSportista
            // 
            this.lblBrSportista.AutoSize = true;
            this.lblBrSportista.Location = new System.Drawing.Point(26, 45);
            this.lblBrSportista.Name = "lblBrSportista";
            this.lblBrSportista.Size = new System.Drawing.Size(72, 13);
            this.lblBrSportista.TabIndex = 1;
            this.lblBrSportista.Text = "Broj Sportista:";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(63, 71);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(35, 13);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(43, 168);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 3;
            this.lblKomentar.Text = "Komentar:";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(104, 12);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(191, 20);
            this.tbSifra.TabIndex = 4;
            // 
            // tbBrojSportista
            // 
            this.tbBrojSportista.Location = new System.Drawing.Point(104, 38);
            this.tbBrojSportista.Name = "tbBrojSportista";
            this.tbBrojSportista.Size = new System.Drawing.Size(191, 20);
            this.tbBrojSportista.TabIndex = 5;
            // 
            // tbSport
            // 
            this.tbSport.Location = new System.Drawing.Point(104, 64);
            this.tbSport.Name = "tbSport";
            this.tbSport.Size = new System.Drawing.Size(191, 20);
            this.tbSport.TabIndex = 6;
            // 
            // tbKomentar
            // 
            this.tbKomentar.Location = new System.Drawing.Point(104, 90);
            this.tbKomentar.Multiline = true;
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(191, 91);
            this.tbKomentar.TabIndex = 7;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(3, 3);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(89, 40);
            this.btnPotvrda.TabIndex = 8;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // btnOdustanak
            // 
            this.btnOdustanak.Location = new System.Drawing.Point(98, 3);
            this.btnOdustanak.Name = "btnOdustanak";
            this.btnOdustanak.Size = new System.Drawing.Size(89, 40);
            this.btnOdustanak.TabIndex = 9;
            this.btnOdustanak.Text = "Odkustanak";
            this.btnOdustanak.UseVisualStyleBackColor = true;
            this.btnOdustanak.Click += new System.EventHandler(this.btnOdustanak_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPotvrda);
            this.flowLayoutPanel1.Controls.Add(this.btnOdustanak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 187);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 47);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // DodavanjeTimova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 246);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.tbSport);
            this.Controls.Add(this.tbBrojSportista);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.lblBrSportista);
            this.Controls.Add(this.lblSifra);
            this.Name = "DodavanjeTimova";
            this.Text = "DodavanjeTimova";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblBrSportista;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbBrojSportista;
        private System.Windows.Forms.TextBox tbSport;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnOdustanak;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}